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
        static readonly string[] myKeywords = new string[] {
            "namespace",
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
        protected override void Prepare (ObjectModel model)
        {
            myModel = model;

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
        
        protected override void BeginNamespace (Type type)
        {
            WriteLine("namespace {0}", type.Namespace);
            WriteLine("{");
        }
        
        protected override string GetFilePath (Type type)
        {
            var file = Path.Combine(type.Namespace.Replace('.', Path.DirectorySeparatorChar), type.SimpleName + ".cs").Replace("@", string.Empty);
            return Path.Combine("generated", file);
        }        

        protected override bool BeginType (Type type)
        {
            myInitJni.Clear();
            
            if (type.WrappedInterface == null)
            {
                if (type.IsInterface)
                {
                    WriteLine("[global::MonoJavaBridge.JavaInterface(typeof(global::{0}_))]", type.Name);
                }
                else if (type.Abstract)
                {
                    WriteLine("[global::MonoJavaBridge.JavaClass(typeof(global::{0}_))]", type.Name);
                }
                else
                {
                    WriteLine("[global::MonoJavaBridge.JavaClass()]");
                }
            }
            else
            {
                WriteLine("[global::MonoJavaBridge.JavaProxy(typeof(global::{0}))]", type.Name.Substring(0, type.Name.Length - 1));
            }
            
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
                Write("partial class {0}", type.SimpleName);
            
            if (type.Parent != null || type.Interfaces.Count > 0)
                Write(":");
            if (type.IsInterface && type.Interfaces.Count == 0)
                Write(" : global::MonoJavaBridge.IJavaObject");
            
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
                WriteLine("internal {0}static global::MonoJavaBridge.JniGlobalHandle staticClass;", type.Parent == null ? "" : "new ");

                /*
                if (!type.HasEmptyConstructor)
                {
                    WriteLine("public {0}(){{}}", type.SimpleName);
                }
                */
                
                WriteLine("static {0}()", type.SimpleName);
                WriteLine("{");
                myIndent++;
                WriteLine("InitJNI();");
                myIndent--;
                WriteLine("}");

                WriteLine("{1} {0}(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)", type.SimpleName, type.IsSealed ? "internal" : "protected");
                WriteLine("{");
                WriteLine("}");
                
                myIndent--;
            }

            return true;
        }
        
        void AddAllInterfaces(Type interfaceType, HashSet<Type> interfaces)
        {
            if (!interfaces.Contains(interfaceType))
                interfaces.Add(interfaceType);
            foreach (var i in interfaceType.InterfaceTypes)
            {
                AddAllInterfaces(i, interfaces);
            }
        }
        
        void GenerateInterfaceStubs(Type interfaceType)
        {
            WriteLine();
            
            Type wrapperType = new Type();
            wrapperType.WrappedInterface = interfaceType.Name;
            wrapperType.WrappedInterfaceType = interfaceType;
            wrapperType.Name = interfaceType.Name + "_";
            wrapperType.Scope = interfaceType.Scope;
            wrapperType.IsSealed = true;
            if (interfaceType.IsInterface)
            {
                wrapperType.Parent = "java.lang.Object";
                wrapperType.ParentType = myModel.FindType("java.lang.Object");
                wrapperType.Interfaces.Add(interfaceType.Name);
                wrapperType.InterfaceTypes.Add(interfaceType);

                var h = new HashSet<Type>();
                AddAllInterfaces(interfaceType, h);
                foreach (var i in h)
                {
                    foreach (var m in i.Methods)
                    {
                        var mc = new Method();
                        mc.Type = wrapperType;
                        mc.Name = i.Name + "." + m.Name;
                        mc.Parameters.AddRange(m.Parameters);
                        mc.ParameterTypes.AddRange(m.ParameterTypes);
                        mc.Return = m.Return;
                        mc.ReturnType = m.ReturnType;
                        if (!wrapperType.Methods.Contains(mc))
                            wrapperType.Methods.Add(mc);
                    }
                }
            }
            else
            {
                wrapperType.Parent = interfaceType.Name;
                wrapperType.ParentType = interfaceType;

                var curType = interfaceType;
                var allImplementedMethods = new Methods();
                while (curType != null)
                {
                    foreach (var m in curType.Methods)
                    {
                        if (!m.Abstract)
                        {
                            if (!allImplementedMethods.Contains(m))
                                allImplementedMethods.Add(m);
                            continue;
                        }
                        if (allImplementedMethods.Contains(m))
                            continue;
                        var mc = new Method();
                        mc.Type = wrapperType;
                        mc.Name = m.Name;
                        mc.Scope = m.Scope;
                        mc.IsOverride = true;
                        mc.Parameters.AddRange(m.Parameters);
                        mc.ParameterTypes.AddRange(m.ParameterTypes);
                        mc.Return = m.Return;
                        mc.ReturnType = m.ReturnType;
                        if (!wrapperType.Methods.Contains(mc))
                            wrapperType.Methods.Add(mc);
                    }
                    curType = curType.ParentType;
                }
            }
            
            myIndent--;
            GenerateType(wrapperType);
            myIndent++;
        }
        
        protected override void EndType (Type type)
        {
            if (type.IsInterface || type.Static)
            {
                myInitJni.Clear();
                base.EndType(type);
                
                if (type.IsInterface)
                    GenerateInterfaceStubs(type);

                return;
            }

            myIndent++;
            WriteLine("private static void InitJNI()");
            WriteLine("{");
            myIndent++;
            WriteLine("global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;");
            if (type.WrappedInterface == null)
                WriteLine("global::{0}.staticClass = @__env.NewGlobalRef(@__env.FindClass(\"{1}\"));", type.Name, GetJavaName(type).Replace('.', '/'));
            else
                WriteLine("global::{0}.staticClass = @__env.NewGlobalRef(@__env.FindClass(\"{1}\"));", type.Name, GetJavaName(type.WrappedInterfaceType).Replace('.', '/'));
            foreach (var initJni in myInitJni)
            {
                WriteLine(initJni);
            }
            myIndent--;
            WriteLine("}");
            myIndent--;

            myInitJni.Clear();
            base.EndType(type);
            if (type.Abstract)
                GenerateInterfaceStubs(type);
        }
        
        public static string GetFieldStatement(string typeName, Type type)
        {
            if (typeName == "void")
                return "@__env.Call{0}VoidMethod({1});";
            
            switch (typeName)
            {
                case "bool":
                    return "return @__env.Get{0}BooleanField({1});";
                case "int":
                    return "return @__env.Get{0}IntField({1});";
                case "double":
                    return "return @__env.Get{0}DoubleField({1});";
                case "float":
                    return "return @__env.Get{0}FloatField({1});";
                case "short":
                    return "return @__env.Get{0}ShortField({1});";
                case "long":
                    return "return @__env.Get{0}LongField({1});";
                case "char":
                    return "return @__env.Get{0}CharField({1});";
                case "byte":
                    return "return @__env.Get{0}ByteField({1});";
            }
            
            StringBuilder ret = new StringBuilder();
            if (typeName.EndsWith("[]"))
                ret.AppendFormat("return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<{0}>", typeName.Substring(0, typeName.Length - 2));
            else if (type.IsInterface)
                ret.AppendFormat("return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::{0}>", typeName);
            else
                ret.Append("return global::MonoJavaBridge.JavaBridge.WrapJavaObject");
            ret.Append("(@__env.Get{0}ObjectField({1}))");
            ret.AppendFormat(" as {0};", typeName);
            
            return ret.ToString();
        }
        

        List<string> myInitJni = new List<string>();
        int myMemberCounter = 0;
        protected override void EmitField (Field field)
        {
            if (field.Scope == "protected")
                return;
            
            bool hasValue = !string.IsNullOrEmpty(field.Value);
            
            var containingType = field.ContainingType;
            if (containingType.Static)
                containingType = FindType(containingType.Name.Substring(0, containingType.Name.Length - "Constants".Length).Replace("@", string.Empty));

            var fieldId = string.Format("_{0}{1}", field.Name.Replace("@",""), myMemberCounter++);
            var signature = GetSignature(field.FieldType, field.Type);
            string initJni = string.Format("global::{0}.{1} = @__env.Get{4}FieldIDNoThrow(global::{0}.staticClass, \"{2}\", \"{3}\");", containingType.Name, fieldId, field.Name, signature, field.Static ? "Static" : string.Empty);
            if (!hasValue)
            {
                WriteLine("internal static global::MonoJavaBridge.FieldId {0};", fieldId);
                myInitJni.Add(initJni);
            }
            
            Write(field.Scope);
            if (field.Static)
                Write("static");
            Write("{0}{1}", ObjectModel.IsSystemType(field.Type) ? string.Empty : "global::", field.Type);
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
                
                WriteLine("global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;");
                string fieldStatement = GetFieldStatement(field.Type, field.FieldType);
                if (field.Static)
                {
                    var contents = string.Format("global::{0}{2}.staticClass, {1}", containingType.Name, fieldId, containingType.IsInterface ? "_" : string.Empty);
                    WriteLine(fieldStatement, "Static", contents);
                }
                else
                {
                    var contents = string.Format("this.JvmHandle, {0}", fieldId);
                    WriteLine(fieldStatement, string.Empty, contents);
                }
                
                //WriteLine("return default({0}{1});", ObjectModel.IsSystemType(field.Type) ? string.Empty : "global::", field.Type);
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
                return "global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject({1});";

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
            if (method.Return == null)
                Console.WriteLine(method.ToString() + "::" + method.Type);
            if (method.Return.EndsWith("[]"))
                ret.AppendFormat("return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<{0}>", method.Return.Substring(0, method.Return.Length - 2));
            else if (method.ReturnType.IsInterface)
                ret.AppendFormat("return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::{0}>", method.Return);
            else
                ret.Append("return global::MonoJavaBridge.JavaBridge.WrapJavaObject");
            //ret.AppendFormat("(typeof({0}), ", method.Return);            
            ret.Append("(@__env.Call{0}ObjectMethod({1}))");
            ret.AppendFormat(" as {0};", method.Return);
            
            return ret.ToString();
        }
        
        public string GetParameterStatement(Type parameterType, string parameter) 
        {
            return "ConvertToValue({0})";
        }

        protected override void EmitMethod (Method method)
        {
            if (method.IsSynthetic)
                return;
            
            if (method.IsOverride && !method.IsConstructor && !method.Abstract && !method.Static)
            {
                Type parent = method.Type.ParentType;
                while (parent != null)
                {
                    parent = parent.ParentType;
                }
            }
            
            if (method.PropertyType.HasValue && method.Name.StartsWith("get"))
            {
                var propertyType = method.PropertyType.Value;
                Write(method.Scope);
                    if (method.Static)
                    {
                        Write("static");
                    }
                    else
                    {
                        Write("new");
                    }
                bool isCharSequence = method.Return == "java.lang.CharSequence";
                if (!isCharSequence)
                    Write("{0}{1}", ObjectModel.IsSystemType(method.Return) ? string.Empty : "global::", method.Return);
                else
                    Write("string");
                WriteLine(method.Name.Substring(3), false);
                WriteLine("{");
                myIndent++;
                WriteLine("get");
                WriteLine("{");
                myIndent++;
                if (!isCharSequence)
                    WriteLine("return get{0}();", method.Name.Substring(3));
                else
                    WriteLine("return get{0}().toString();", method.Name.Substring(3));
                myIndent--;
                WriteLine("}");
                if (propertyType == PropertyType.ReadWrite)
                {
                    WriteLine("set");
                    WriteLine("{");
                    myIndent++;
                    if (!isCharSequence)
                        WriteLine("set{0}(value);", method.Name.Substring(3));
                    else
                        WriteLine("set{0}((global::java.lang.CharSequence)(global::java.lang.String)value);", method.Name.Substring(3));
                    myIndent--;
                    WriteLine("}");
                }
                myIndent--;
                WriteLine("}");
            }
            
            string methodId = null;
            if (!method.Type.IsInterface)
            {
                string signature = GetMethodSignature(method);
                if (method.Name.LastIndexOf('.') == -1)
                    methodId = method.Name;
                else
                    methodId = method.Name.Substring(method.Name.LastIndexOf('.') + 1);
                string methodIdLookup = methodId;
                methodId = string.Format("_{0}{1}", methodId.Replace("@",""), myMemberCounter++);
                string initJni = string.Format("global::{0}.{1} = @__env.Get{4}MethodIDNoThrow(global::{0}.staticClass, \"{2}\", \"{3}\");", method.Type.Name, methodId, method.IsConstructor ? "<init>" : methodIdLookup, signature, method.Static ? "Static" : string.Empty);
                myInitJni.Add(initJni);
                WriteLine("internal static global::MonoJavaBridge.MethodId {0};", methodId);
                
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
                }
            }
            if (method.Return != null)
                Write("{0}{1}", ObjectModel.IsSystemType(method.Return) ? string.Empty : "global::", method.Return);
            Write(method.Name, false);
            Write("(", false);
            WriteDelimited(method.Parameters, (v, i) => string.Format("{0} arg{1}", v, i), ",");
            if (method.Type.IsInterface || method.Abstract || method.Scope == "internal")
            {
                WriteLine(");");
            }
            else
            {
                Write(")");
                if (method.IsConstructor)
                    Write(" : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)");
                WriteLine();
                WriteLine("{");
                myIndent++;
                WriteLine("global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;");
                var statement = GetMethodStatement(method);
                StringBuilder parBuilder = new StringBuilder();
                if (method.Static || method.IsConstructor)
                    parBuilder.AppendFormat("{0}.staticClass, ", method.Type.Name);
                else
                    parBuilder.Append("this.JvmHandle, ");
                parBuilder.AppendFormat("global::{0}.{1}", method.Type.Name, methodId);
                //if (method.IsConstructor)
                //    parBuilder.Append(", this");
                bool hasCharSequenceArgument = false;
                for (int i = 0; i < method.Parameters.Count; i++)
                {
                    parBuilder.Append(", ");
                    var parType = method.ParameterTypes[i];
                    var par = method.Parameters[i];
                    if (par == "java.lang.CharSequence")
                        hasCharSequenceArgument = true;
                    parBuilder.Append("global::MonoJavaBridge.JavaBridge.");
                    parBuilder.Append(string.Format(GetParameterStatement(parType, par), "arg" + i));
                }
                if (method.Static || method.IsConstructor)
                {
                    WriteLine(statement, method.Static ? "Static" : string.Empty, parBuilder);
                    if (method.IsConstructor)
                        WriteLine("Init(@__env, handle);");
                }
                else
                {
                    WriteLine("if (!IsClrObject)", method.Type.Name);
                    myIndent++;
                    WriteLine(statement, string.Empty, parBuilder);
                    myIndent--;
                    WriteLine("else");
                    myIndent++;
                    WriteLine(statement, "NonVirtual", string.Format(parBuilder.ToString().Replace("this.JvmHandle, ", "this.JvmHandle, global::{0}.staticClass, "), method.Type.Name));
                    myIndent--;
                }
                myIndent--;
                WriteLine("}");
                
                if (hasCharSequenceArgument && !method.IsConstructor && method.Scope == "public" && !method.Static)
                {
                    var em = method;
                    //myExtensionMethods.Add(method);
                    Write("public {0} {1}(", false, em.Return, em.Name);
                    //Write("this global::{0} __this", false, em.Type.Name);
                    WriteDelimited(em.Parameters, (v, i) => string.Format("{0} arg{1}", v == "java.lang.CharSequence" ? "string" : v, i), ",");
                    WriteLine(")");
                    WriteLine("{");
                    myIndent++;
                    if (em.Return != "void")
                        Write("return");
                    
                    Write("{0}(", false, em.Name);
                    WriteDelimited(em.Parameters, (v, i) => string.Format("{0}arg{1}", v == "java.lang.CharSequence" ? "(global::java.lang.CharSequence)(global::java.lang.String)" : string.Empty, i), ",");
                    WriteLine(");");
                    myIndent--;
                    WriteLine("}");

                }
            }
        }
    }
}
