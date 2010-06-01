using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MonoDevelop.Android
{
    [Flags]
    public enum GenerationFlags : int
    {
        None = 0,
        KeepIntermediateFiles = 1
    }
    
    public class MonoReflector
    {
        private string mOutputPath;
        private static string mTemplate = new StreamReader(typeof(MonoReflector).Assembly.GetManifestResourceStream("JavaClassTemplate.java")).ReadToEnd();

        /*
        public MonoReflector(params string[] files)
        {
            foreach (string assem in files)
                assems.Add(Assembly.LoadFile(assem));
        }

        public MonoReflector(params Assembly[] files)
        {
            assems.AddRange(assems);
        }
        */
        
        public MonoReflector()
        {
        }
        
        public MonoReflector(string outputPath)
        {
            mOutputPath = outputPath;
        }
        
        public string[] Generate(GenerationFlags flags, string assemblyFile)
        {
            return Generate(flags, Assembly.LoadFile(assemblyFile));
        }

        private string[] Generate(GenerationFlags flags, params Assembly[] assemblies)
        {
            List<string> ret = new List<string>();
            foreach (Assembly a in assemblies)
            {
                ret.AddRange(Generate(flags, a));
            }
            return ret.ToArray();
        }

        public string[] Generate(GenerationFlags flags, Assembly assembly)
        {
            List<string> ret = new List<string>();
            foreach (Type t in assembly.GetTypes())
            {
                if (!t.IsInterface)
                {
                    Dictionary<MethodInfo, MethodInfo> methods = new Dictionary<MethodInfo, MethodInfo>();
                    HashSet<Type> interfaces = new HashSet<Type>();
                    bool isBaseClass = false;
                    foreach (MethodInfo subm in t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.IsVirtual))
                    {
                        if ((subm.MemberType & MemberTypes.Property) == MemberTypes.Property || (subm.MemberType & MemberTypes.Method) == MemberTypes.Method)
                        {
                            MethodInfo androidMethod = FindBaseForMethod(subm, null);
                            if (androidMethod != null)
                            {
                                isBaseClass |= true;
                                methods.Add(subm, androidMethod);
                            }
                            else//must be implementing an interface
                            {
                                androidMethod = FindInterfaceForMethod(subm);
                                if (androidMethod != null)
                                {
                                    if (!interfaces.Contains(androidMethod.DeclaringType))
                                        interfaces.Add(androidMethod.DeclaringType);
                                    methods.Add(subm, androidMethod);
                                }
                            }
                        }
                    }
                    if (methods.Count > 0)
                    {
                        StringBuilder linkMethods = new StringBuilder(), natives = new StringBuilder();
                        //get the link methods

                        KeyValuePair<MethodInfo, MethodInfo>? first = null;
                        foreach (KeyValuePair<MethodInfo, MethodInfo> pair in methods)
                        {
                            if (first == null)
                                first = pair;
                            StringBuilder args = new StringBuilder(), jniArgs = new StringBuilder();
                            ParameterInfo[] paramInfo = null;
                            foreach (ParameterInfo p in paramInfo = pair.Key.GetParameters())
                                jniArgs.Append(GetJType(p.ParameterType, true, true));
                            for (int i = 0; i < paramInfo.Length; i++)
                            {
                                args.Append(paramInfo[i].ParameterType.FullName);
                                if (i < paramInfo.Length - 1)
                                    args.Append(",");
                            }
                            linkMethods.AppendLine(string.Format("\t\tMonoBridge.link({0}.class, \"{1}\", \"({2}){3}\", \"{4}\");",
                                t.Name, pair.Key.Name, jniArgs, GetJType(pair.Key.ReturnType, true, true), args));
                            args = new StringBuilder();//reuse var

                            for (int i = 0; i < paramInfo.Length; i++)
                            {
                                args.AppendFormat("{0} {1}", paramInfo[i].ParameterType.FullName, paramInfo[i].Name);
                                if (i < paramInfo.Length - 1)
                                    args.Append(",");
                            }
                            natives.AppendLine("\t@Override");
                            natives.AppendLine(string.Format("\t{0} native {1} {2}({3});",
                                pair.Key.IsPublic ? "public" : "protected", GetJLangType(pair.Value.ReturnType), pair.Key.Name, args));
                        }
                        string basePath = mOutputPath ?? Path.GetDirectoryName(t.Assembly.Location);
                        basePath = Path.Combine(basePath, t.Namespace.Replace('.', Path.DirectorySeparatorChar));
                        Directory.CreateDirectory(basePath);
                        string outputFile = Path.Combine(basePath, t.Name + ".java");
                        ret.Add(outputFile);
                        StringBuilder interfacesText = new StringBuilder();
                        if (interfaces.Count > 0)
                        {
                            foreach (var iface in interfaces)
                            {
                                interfacesText.AppendFormat(", {0}", iface.FullName);
                            }
                        }
                        File.WriteAllText(outputFile,
                            string.Format(mTemplate, t.Namespace, t.Name, isBaseClass ? " extends " : string.Empty, isBaseClass ? first.Value.Value.DeclaringType.FullName : string.Empty, linkMethods, natives, interfacesText.ToString()));
                    }
                }
            }
            return ret.ToArray();
        }

        private MethodInfo FindBaseForMethod(MethodInfo sub, Type currentSuper)
        {
            if (currentSuper == null)
                return FindBaseForMethod(sub, sub.DeclaringType.BaseType);
            MethodInfo sup = currentSuper.GetMethod(sub.Name, BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public,
                null, sub.GetParameters().Select(x => x.ParameterType).ToArray(), null);
            if (sup != null)
            {
                foreach (var attrib in currentSuper.GetCustomAttributes(false))
                {
                    if (attrib.GetType().FullName == "net.sf.jni4net.attributes.JavaClassAttribute")
                        return sup;
                }
            }
            return currentSuper.BaseType != null ? FindBaseForMethod(sub, currentSuper.BaseType) : null;
        }

        private MethodInfo FindInterfaceForMethod(MethodInfo sub)
        {
            foreach (Type t in sub.DeclaringType.GetInterfaces())
            {
                MethodInfo sup = t.GetMethod(sub.Name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public,
                    null, sub.GetParameters().Select(x => x.ParameterType).ToArray(), null);
                if (sup != null)
                {
                    foreach (var attrib in t.GetCustomAttributes(false))
                    {
                        if (attrib.GetType().FullName == "net.sf.jni4net.attributes.JavaInterfaceAttribute")
                        {
                            Console.WriteLine("Match: {0}", sup);
                            return sup;
                        }
                    }
                }
            }
            return null;
        }

        private string GetJType(Type type, bool replace, bool jniClasses)
        {
            string value = string.Empty;
            if (type == typeof(bool))
                value = "Z";
            else if (type == typeof(byte))
                value = "B";
            else if (type == typeof(char))
                value = "C";
            else if (type == typeof(short))
                value = "S";
            else if (type == typeof(int))
                value = "I";
            else if (type == typeof(long))
                value = "J";
            else if (type == typeof(float))
                value = "F";
            else if (type == typeof(double))
                value = "D";
            else if (type == typeof(void))
                value = "V";
            else
                value = jniClasses ? "L" + type.FullName + ";" : type.FullName;
            if (type.IsArray)
                value = "[" + value;
            return replace ? value.Replace('.', '/') : value;
        }

        private string GetJLangType(Type type)
        {
            switch (type.FullName)
            {
                case "System.Boolean":
                    return "bool";
                case "System.Byte":
                    return "byte";
                case "System.Char":
                    return "char";
                case "System.Int16":
                    return "short";
                case "System.Int32":
                    return "int";
                case "System.Int64":
                    return "long";
                case "System.Single":
                    return "float";
                case "System.Double":
                    return "double";
                case "System.Void":
                    return "void";
                default:
                    return type.FullName;
            }
        }
    }
}
