
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;


namespace MonoDroid
{
    public class NetProxyGenerator : CodeGenerator
    {
        static Dictionary<string, System.Type> myJniTypes = new Dictionary<string, System.Type>();
        
        public NetProxyGenerator (DirectoryInfo workingDirectory)
            : base(workingDirectory)
        {
        }
        
        static readonly string[] myKeywords = new string[] {
            "in",
            "out",
            "checked",
            "params",
            "lock",
            "ref",
            "internal",
            "out",
            "object",
            "string",
            "bool"
        };
        static readonly int myTypeCount = 3;
        static string[] myReplaceKeyword = new string[myKeywords.Length];
        static string[] myStartKeywords = new string[myKeywords.Length];
        static string[] myStartReplaceKeywords = new string[myKeywords.Length];
        static string[] myEndKeywords = new string[myKeywords.Length];
        static string[] myEndReplaceKeywords = new string[myKeywords.Length];
        static string[] myContainKeywords = new string[myKeywords.Length];
        static string[] myContainReplaceKeywords = new string[myKeywords.Length];

        static string EscapeName(string name)
        {
            return EscapeName(name, true);
        }

        static string EscapeName(string name, bool doExactMatchOnTypes)
        {
            for (int i = 0; i < myKeywords.Length; i++)
            {
                var keyword = myStartKeywords[i];
                if (!name.StartsWith(keyword))
                    continue;
                name = myStartReplaceKeywords[i] + name.Substring(keyword.Length);
                break;
            }
            for (int i = 0; i < myKeywords.Length; i++)
            {
                var keyword = myEndKeywords[i];
                if (!name.EndsWith(keyword))
                    continue;
                name = name.Substring(0, name.Length - keyword.Length) + myEndReplaceKeywords[i];
                break;
            }
            for (int i = 0; i < myKeywords.Length; i++)
            {
                var keyword = myContainKeywords[i];
                if (!name.Contains(keyword))
                    continue;
                name = name.Replace(keyword, myContainReplaceKeywords[i]);
            }
            for (int i = 0; i < (doExactMatchOnTypes ? myKeywords.Length : myKeywords.Length - myTypeCount); i++)
            {
                if (name != myKeywords[i])
                    continue;
                name = myReplaceKeyword[i];
            }
            return name;
        }
        
        public Type FindType(string typeName)
        {
            if (typeName == null)
                return null;
            typeName = typeName.TrimEnd(']', '[');
            return myModel.FindType(typeName);
        }
        
        public void AddAllTypes(ObjectModel model, HashSet<Type> hash, Type type)
        {
            if (type == null)
                return;
            if (hash.Contains(type))
                return;
            
            hash.Add(type);
            
            AddAllTypes(model, hash, type.ParentType);
            foreach (var iface in type.InterfaceTypes)
            {
                AddAllTypes(model, hash, iface);
            }

            foreach (var field in type.Fields)
            {
                AddAllTypes(model, hash, FindType(field.Type));
            }
            
            foreach (var method in type.Methods)
            {
                AddAllTypes(model, hash, method.ReturnType ?? FindType(method.Return));
                foreach (var par in method.Parameters)
                    AddAllTypes(model, hash, FindType(par));
            }
        }
        
        ObjectModel myModel;
        HashSet<Type> myTypesOfInterest = new HashSet<Type>();
        protected override void Prepare (ObjectModel model)
        {
            myModel = model;

            var androidTypes = from type in myModel.Types where type.Name.StartsWith("android.") && !type.Name.StartsWith("android.test.") select type;
            foreach (var type in androidTypes)
            {
                AddAllTypes(myModel, myTypesOfInterest, type);
            }
            
            foreach (var type in model.Types)
            {
                type.Name = EscapeName(type.Name);
                foreach (var method in type.Methods)
                {
                    method.Name = EscapeName(method.Name);
                    for (int i = 0; i < method.Parameters.Count; i++)
                    {
                        method.Parameters[i] = EscapeName(method.Parameters[i], false);
                    }
                    if (method.Return != null)
                    {
                        method.Return = EscapeName(method.Return, false);
                    }
                    // jni4net exposes java.util.List.listIterator with a return type of Iterator, and not ListIterator...
                    // massage this so it works.
                    if ((type.Name == "java.util.AbstractList" || type.Name == "java.util.concurrent.CopyOnWriteArrayList") && method.Name == "listIterator")
                        method.Return = "java.util.Iterator";
                }
                if (type.Parent != null)
                    type.Parent = EscapeName(type.Parent);
                for (int i = 0; i < type.Interfaces.Count; i++)
                {
                    type.Interfaces[i] = EscapeName(type.Interfaces[i]);
                }
                for (int i = 0; i < type.Fields.Count; i++)
                {
                    type.Fields[i].Name = EscapeName(type.Fields[i].Name);
                    type.Fields[i].Type = EscapeName(type.Fields[i].Type, false);
                }
            }
        }

        
        static NetProxyGenerator()
        {
            Assembly jniAssembly = typeof(net.sf.jni4net.Bridge).Assembly;
            foreach (var type in jniAssembly.GetTypes())
            {
                myJniTypes.Add(type.FullName, type);
            }            

            for (int i = 0; i < myKeywords.Length; i++)
            {
                string keyword = myKeywords[i];
                myReplaceKeyword[i] = '@' + keyword;
                myStartKeywords[i] = keyword + '.';
                myStartReplaceKeywords[i] = '@' + keyword + '.';
                myEndKeywords[i] = '.' + keyword;
                myEndReplaceKeywords[i] = ".@" + keyword;
                myContainKeywords[i] = '.' + keyword + '.';
                myContainReplaceKeywords[i] = ".@" + keyword + '.';
            }
        }

        protected override void BeginNamespace (string name)
        {
            WriteLine("namespace {0}", name);
            WriteLine("{");
        }
        
        protected override string GetFilePath (Type type)
        {
            return Path.Combine(type.Namespace.Replace('.', Path.DirectorySeparatorChar), type.SimpleName + ".cs");
        }        
        
        protected override bool BeginType (Type type)
        {
            myInitJni.Clear();
            
            if (myJniTypes.ContainsKey(type.Name) || !myTypesOfInterest.Contains(type))
                return false;
            
            if (type.IsInterface)
                WriteLine("[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]");
            else
                WriteLine("[global::net.sf.jni4net.attributes.JavaClassAttribute()]");
            
            Write(type.Scope);
            if (type.IsNew)
                Write("new");
            if (type.Abstract && !type.IsInterface)
                Write("abstract");
            if (type.IsSealed)
                Write("sealed");
            if (type.Static)
                Write("static");
            if (type.IsInterface)
                Write("interface {0}", type.SimpleName);
            else
                Write("class {0}", type.SimpleName);
            
            if (type.Parent != null || type.Interfaces.Count > 0)
                Write(":");
            
            if (type.Parent != null)
                Write(type.Parent, false);
            
            if (!type.IsInterface && type.Interfaces.Count > 0)
            {
                Write(",");
            }
            WriteDelimited(type.InterfaceTypes, (v, i) => type.Qualifier.StartsWith(v.Qualifier) ? v.SimpleName : v.Name, ",");
            WriteLine();
            WriteLine("{");
            
            if (!type.IsInterface && !type.Static)
            {
                myIndent++;
                WriteLine("internal {0}static global::java.lang.Class staticClass;", type.Parent == null || myJniTypes.ContainsKey(type.Parent) ? "" : "new ");
                WriteLine("static {0}()", type.SimpleName);
                WriteLine("{");
                myIndent++;
                WriteLine("global::net.sf.jni4net.utils.Registry.RegisterType(typeof({0}), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);", type.Name);
                myIndent--;
                WriteLine("}");
                
                if (!type.Abstract)
                {
                    WriteLine("private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper", myJniTypes.ContainsKey(type.Parent) ? string.Empty : "new ");
                    WriteLine("{");
                    myIndent++;
                    WriteLine("public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)");
                    WriteLine("{");
                    myIndent++;
                    WriteLine("return new global::{0}(@__env);", type.Name);
                    myIndent--;
                    WriteLine("}");
                    myIndent--;
                    WriteLine("}");
                }

                WriteLine("{1} {0}(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)", type.SimpleName, type.IsSealed ? "internal" : "protected");
                WriteLine("{");
                WriteLine("}");
                
                myIndent--;
            }

            return true;
        }
        
        protected override void EndType (Type type)
        {
            if (type.IsInterface || type.Static)
            {
                myInitJni.Clear();
                base.EndType(type);
                return;
            }
            myIndent++;
            WriteLine("private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)");
            WriteLine("{");
            myIndent++;
            WriteLine("global::{0}.staticClass = @__class;", type.Name);
            foreach (var initJni in myInitJni)
            {
                WriteLine(initJni);
            }
            myIndent--;
            WriteLine("}");
            myIndent--;
            myInitJni.Clear();
            base.EndType(type);
        }

        List<string> myInitJni = new List<string>();
        int myMemberCounter = 0;
        protected override void EmitField (Field field)
        {
            if (field.Scope == "protected")
                return;
            
            bool hasValue = !string.IsNullOrEmpty(field.Value);
            
            if (!hasValue)
                WriteLine("internal static global::net.sf.jni4net.jni.FieldId _{0}{1};", field.Name.Replace("@",""), myMemberCounter++);
            
            Write(field.Scope);
            if (field.Static)
                Write("static");
            Write(field.Type);
            Write(field.Name, false);
            WriteLine();
            WriteLine("{");
            myIndent++;
            WriteLine("get");
            WriteLine("{");
            if (hasValue)
            {
                myIndent++;
                string val = field.Value;
                val = val.Replace("\\" , "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n");
                
                if (field.Type == "java.lang.String")
                {
                    Write("return \"{0}\"", false, val);
                }
                else if (field.Type == "char")
                {
                    val = val.Replace("'", "\\'");
                    // there's a weird compile error happening here due to unicode chars or something...
                    if (field.Name == "HEX_INPUT" || field.Name == "PICKER_DIALOG_INPUT")
                        val = "0";
                    Write("return '{0}'", false, val);
                }
                else
                {
                    Write("return {0}", false, field.Value);
                }
                
                if (field.Type == "long")
                    Write("L", false);
                else if (field.Type == "float")
                    Write("f", false);
                WriteLine(";");
                myIndent--;
            }
            else
            {
                myIndent++;
                WriteLine("return default({0});", field.Type);
                myIndent--;
            }
            WriteLine("}");
            if (!field.IsReadOnly)
            {
                WriteLine("set");
                WriteLine("{");
                WriteLine("}");
            }
            myIndent--;
            WriteLine("}");
        }
        
        
        public static string GetMethodSignature(Method method)
        {
            StringBuilder ret = new StringBuilder();
            ret.Append('(');
            for (int i = 0; i < method.Parameters.Count; i++)
            {
                var typeName = method.Parameters[i];
                var type = method.ParameterTypes[i];
                ret.Append(GetSignature(type, typeName));
            }
            ret.Append(')');
            ret.Append(GetSignature(method.ReturnType, method.Return));
            return ret.ToString();
        }
        
        public static string GetJavaName(Type type)
        {
            string typeName = type.SimpleName;
            
            var root = type;
            while (root.NestingClass != null)
            {
                typeName = root.NestingClass.SimpleName + "$" + typeName;
                root = root.NestingClass;
            }
            typeName = root.Namespace + "." + typeName;
            return typeName;
        }
      
        public static string GetSignature(Type type, string typeName)
        {
            if (type == null && typeName == null)
                return "V";
            
            if (type != null)
                typeName = GetJavaName(type);
            
            typeName = typeName.Replace('_', '$');
            
            string low = typeName.ToLowerInvariant();
            int arr = low.LastIndexOf("[");
            string array = "";
            while (arr != -1)
            {
                array += "[";
                low = low.Substring(0, arr);
                arr = low.LastIndexOf("[");
            }
            switch (low)
            {
                case "bool":
                    return array + "Z";
                case "int":
                    return array + "I";
                case "double":
                    return array + "D";
                case "float":
                    return array + "F";
                case "short":
                    return array + "S";
                case "long":
                    return array + "J";
                case "char":
                    return array + "C";
                case "byte":
                    return array + "B";
                case "void":
                    return array + "V";
                default:
                    return array + "L" + typeName.Substring(0, low.Length).Replace('.', '/') + ";";
            }
        }
        
        public static string GetMethodStatement(Method method)
        {
            if (method.IsConstructor)
                return "@__env.NewObject({1});";

            var type = method.ReturnType;
            var typeName = method.Return;
            
            if (typeName == "void")
                return "@__env.Call{0}VoidMethod({1});";
            
            switch (typeName)
            {
                case "bool":
                    return "return @__env.Call{0}BooleanMethod({1});";
                case "int":
                    return "return @__env.Call{0}IntMethod({1});";
                case "double":
                    return "return @__env.Call{0}DoubleMethod({1});";
                case "float":
                    return "return @__env.Call{0}FloatMethod({1});";
                case "short":
                    return "return @__env.Call{0}ShortMethod({1});";
                case "long":
                    return "return @__env.Call{0}LongMethod({1});";
                case "char":
                    return "return @__env.Call{0}CharMethod({1});";
                case "byte":
                    return "return @__env.Call{0}ByteMethod({1});";
            }
            
            StringBuilder ret = new StringBuilder();
            if (typeName.EndsWith("[]"))
            {
                ret.Append("return null;//");
            }
            else
            {
                if (typeName == "java.lang.Object" || (type != null && type.IsInterface))
                {
                    ret.AppendFormat("return global::net.sf.jni4net.utils.Convertor.FullJ2C<{0}>", typeName);
                }
                else
                {
                    ret.AppendFormat("return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<{0}>", typeName);
                }
            }
            
            ret.Append("(@__env, @__env.Call{0}ObjectMethodPtr({1}));");
            
            return ret.ToString();
            
            //string ret  String.Format("return global::net.sf.jni4net.utils.Convertor.{0}<{1}, {2}>", converter);
            
            return null;
        }
        
        public string GetParameterStatement(Type parameterType, string parameter)
        {
            switch (parameter)
            {
                case "bool":
                case "int":
                case "double":
                case "float":
                case "short":
                case "long":
                case "char":
                case "byte":
                    return "ParPrimC2J({0})";
                //case "java.lang.CharSequence":
                //    return "ParPrimC2J((java.lang.String){0})";
                case "bool[]":
                case "int[]":
                case "double[]":
                case "float[]":
                case "short[]":
                case "long[]":
                case "char[]":
                case "byte[]":
                    return "ParArrayPrimC2J(@__env, {0})";
            }
            
            if (parameter.EndsWith("[][]"))
            {
                return "ParArrayStrongCp2J(@__env, {0})";
            }
            
            if (parameter.EndsWith("[]"))
            {
                var stripParameter = parameter.Substring(0, parameter.Length - "[]".Length);
                string element = stripParameter.Replace("@", "");
                if (element == "java.lang.Object" || myModel.FindType(element).IsInterface)
                    return string.Format("ParArrayFullC2J<{0}, {1}>", parameter, stripParameter) + "(@__env, {0})";
                return "ParArrayStrongCp2J(@__env, {0})";
            }
            
            if (parameter == "java.lang.Object" || parameterType.IsInterface)
                return "ParFullC2J(@__env, {0})";
            return "ParStrongCp2J({0})";
        }

        protected override void EmitMethod (Method method)
        {
            if (method.IsSynthetic)
                return;
            
            if (method.IsOverride && !method.IsConstructor && !method.Abstract && !method.Static)
            {
                Type parent = method.Type.ParentType;
                string sig = method.ToSignatureString();
                while (parent != null)
                {
                    if (myJniTypes.ContainsKey(parent.Name) && parent.Methods.Dictionary.ContainsKey(sig))
                    {
                        var jniType = myJniTypes[parent.Name];
                        
                        // see if the method exists to override
                        try
                        {
                            if (jniType.GetMethod(method.Name) == null)
                                return;
                        }
                        catch (AmbiguousMatchException)
                        {
                        }
                    }
                    parent = parent.ParentType;
                }
            }
            
            //if (method.PropertyType != null && method.Name.StartsWith("set"))
            //    return;
            
            string methodId = null;
            if (!method.Type.IsInterface)
            {
                string signature = GetMethodSignature(method);
                if (method.Name.LastIndexOf('.') == -1)
                    methodId = method.Name;
                else
                    methodId = method.Name.Substring(method.Name.LastIndexOf('.') + 1);
                methodId = string.Format("_{0}{1}", methodId.Replace("@",""), myMemberCounter++);
                string initJni = string.Format("global::{0}.{1} = @__env.Get{4}MethodID(global::{0}.staticClass, \"{2}\", \"{3}\");", method.Type.Name, methodId, method.IsConstructor ? "<init>" : method.Name, signature, method.Static ? "Static" : string.Empty);
                myInitJni.Add(initJni);
                WriteLine("internal static global::net.sf.jni4net.jni.MethodId {0};", methodId);
                
                //WriteLine("[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]");
                Write(method.Scope);
                if (method.Abstract)
                    Write("abstract");
                else
                {
                    if (method.Static)
                    {
                        Write("static");
                    }
                    else if (!method.IsConstructor)
                    {
                        if (method.IsOverride)
                        {
                            if (method.IsSealed)
                                Write("sealed");
                            Write("override");
                        }
                        else if (!method.Type.IsSealed && method.Scope != string.Empty)
                            Write("virtual");
                    }
                    //Write("extern");
                }
            }
            // TODO: Reflect on the jni4net type, and see if the method exists or not.
            // This is a hack to prevent some compiler warnings.
            if (method.IsNew && (method.Name != "clone" || !myJniTypes.ContainsKey(method.Type.Parent)))
                Write("new");
            if (method.Return != null)
                Write(method.Return);
            //if (method.PropertyType == null)
            if (true)
            {
                Write(method.Name, false);
                Write("(", false);
                //WriteDelimited(method.Parameters, (v, i) => string.Format("{0} arg{1}", v == "java.lang.CharSequence" && !method.Abstract && !method.Type.IsInterface && ! method.Name.Contains('.') ? "string" : v, i), ",");
                WriteDelimited(method.Parameters, (v, i) => string.Format("{0} arg{1}", v, i), ",");
                if (method.Type.IsInterface || method.Abstract || method.Scope == "internal")
                {
                    WriteLine(");");
                }
                else
                {
                    Write(")");
                    if (method.IsConstructor)
                        Write(" : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv)");
                    WriteLine();
                    WriteLine("{");
                    myIndent++;
                    // TODO: Remove this if statement when object initializeation is properly supported.
                    if (method.Return == null || !method.Return.EndsWith("[]"))
                        WriteLine("global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;");
                    var statement = GetMethodStatement(method);
                    StringBuilder parBuilder = new StringBuilder();
                    if (method.Static || method.IsConstructor)
                        parBuilder.AppendFormat("{0}.staticClass, ", method.Type.Name);
                    else
                        parBuilder.Append("this, ");
                    parBuilder.Append(methodId);
                    if (method.IsConstructor)
                        parBuilder.Append(", this");
                    for (int i = 0; i < method.Parameters.Count; i++)
                    {
                        parBuilder.Append(", ");
                        var parType = method.ParameterTypes[i];
                        var par = method.Parameters[i];
                        parBuilder.Append("global::net.sf.jni4net.utils.Convertor.");
                        parBuilder.Append(string.Format(GetParameterStatement(parType, par), "arg" + i));
                    }
                    if (method.Static || method.IsConstructor)
                    {
                        WriteLine(statement, method.Static ? "Static" : string.Empty, parBuilder);
                    }
                    else
                    {
                        WriteLine("if (GetType() == typeof({0}))", method.Type.Name);
                        myIndent++;
                        WriteLine(statement, string.Empty, parBuilder);
                        myIndent--;
                        WriteLine("else");
                        myIndent++;
                        WriteLine(statement, "NonVirtual", string.Format(parBuilder.ToString().Replace("this, ", "this, {0}.staticClass, "), method.Type.Name));
                        myIndent--;
                    }
                    myIndent--;
                    WriteLine("}");
                }
            }
            else
            {
                WriteLine(method.Name.Substring(3), false);
                WriteLine("{");
                if (method.PropertyType == PropertyType.ReadOnly)
                    WriteLine("get;");
                else
                    WriteLine("get; set;");
                WriteLine("}");
            }
        }
    }
}
