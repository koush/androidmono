using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoDroid
{
	public class TypeList : SerializableDictionary<string, Type>
	{
		protected override string GetKey (Type value)
		{
			return value.Name;
		}
	}
	
	public class ObjectModel
	{
		public static bool IsSystemType(string type)
		{
            if (type.StartsWith("void")) return true;
            if (type.StartsWith("int")) return true;
            if (type.StartsWith("long")) return true;
            if (type.StartsWith("short")) return true;
            if (type.StartsWith("char")) return true;
            if (type.StartsWith("byte")) return true;
            if (type.StartsWith("float")) return true;
            if (type.StartsWith("double")) return true;
            if (type.StartsWith("bool")) return true;
            return false;
		}
		
		public static ObjectModel Load(string filename)
		{
			XmlSerializer ser = new XmlSerializer(typeof(ObjectModel));
			ObjectModel types = (ObjectModel)ser.Deserialize(new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read));
			return types;
		}
		
		public void AppendModel(string filename)
		{
			var other = ObjectModel.Load(filename);
			foreach(var type in other.Types)
			{
				Types.Add(type);
			}
		}
		
		TypeList myTypes = new TypeList();
    		[System.Xml.Serialization.XmlElementAttribute("Type", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]	
		public TypeList Types	
		{
			get
			{
				return myTypes;
			}
		}
		
		public void FinalizeModel()
		{
			// clear out cached info
			foreach (var type in myTypes)
			{
				type.Types.Clear();
			}
			
			// relink names to types
			foreach (var type in myTypes)
			{
				if (type.IsSystemType)
					continue;
				if (type.Parent != null)
					type.ParentType = FindType(type.Parent);
				int nestingClass = type.Name.LastIndexOf('.');
				if (nestingClass != -1)
				{
					string nestingClassName = type.Name.Substring(0, nestingClass);
					Type nesting;
					if (myTypes.Dictionary.TryGetValue(nestingClassName, out nesting))
					{
						nesting.Types.Add(type);
						type.NestingClass = nesting;
					}
				}
				
				type.InterfaceTypes.Clear();
				type.InterfaceTypes.AddRange(from itype in type.Interfaces select FindType(itype));
                
                foreach (var field in type.Fields)
                {
                    field.FieldType = FindType(field.Type);
                    field.ContainingType = type;
                }
                
                type.IsDelegate = type.IsInterface && type.Methods.Count == 1 && type.Interfaces.Count == 0 && type.Name.StartsWith("android.");
				
				foreach (var method in type.Methods)
				{
					method.Type = type;
					if (!method.IsConstructor)
						method.ReturnType = FindType(method.Return);
					method.ParameterTypes.Clear();
					method.ParameterTypes.AddRange(from p in method.Parameters select FindType(p));
                    /*
					if (method.Override != null)
					{
						Type otype = method.OverrideType = FindType(method.Override);
						//Console.WriteLine("{0} {1} {2} {3}", type, method, otype, method.IsSynthetic);
						//method.OverrideMethod = (from omethod in otype.Methods where omethod.Matches(method) select omethod).First();
						//Console.WriteLine("{0}", method.OverrideMethod);
					}
					*/
                    if (method.Type.IsInterface || method.Type.Abstract)
                        continue;
					if (method.PropertyType != null)
						continue;
                    if (method.IsConstructor)
                        continue;
					if ((!method.Name.StartsWith("get") && !method.Name.StartsWith("set")) || method.Name == "get" || method.Name == "set")
						continue;
                    var methodType = method.Name.Substring(0, 3);
                    var propertyName = method.Name.Substring(3);
                    if (FindType(method.Type.Name + "." + propertyName) != null)
                        continue;
                    if (propertyName == method.Type.SimpleName)
                        continue;
                    if (!char.IsLetter(propertyName[0]))
                        continue;
                    if ((from m in type.Methods where m.Name.Equals(propertyName, StringComparison.CurrentCultureIgnoreCase) select m).Count() != 0)
                        continue;
                    if (methodType == "get")
                    {
                        if (method.Parameters.Count != 0)
                            continue;
                        // don't try to make getters where there are multiple versions.
                        if ((from getter in type.Methods where getter.Name == method.Name && getter.Parameters.Count == 0 && getter.Return != "void" select getter).Count() != 1)
                            continue;
                        string setterName = "set" + propertyName;
                        var matchedSetter = (from setter in type.Methods where setter.Name == setterName && setter.Parameters.Count == 1 && setter.Return == "void" && setter.Parameters[0] == method.Return select setter).FirstOrDefault();
                        if (matchedSetter != null)
                        {
                            matchedSetter.PropertyType = method.PropertyType = PropertyType.ReadWrite;
                            matchedSetter.OtherPropertyAccessor = method;
                            method.OtherPropertyAccessor = matchedSetter;
                        }
                        else
                        {
                            method.PropertyType = PropertyType.ReadOnly;
                        }
                    }
                    else
                    {
                        if (method.Parameters.Count != 1)
                            continue;
                        // don't try to make setters where there are multiple versions.
                        if ((from setter in type.Methods where setter.Name == method.Name && setter.Parameters.Count == 1 select setter).Count() != 1)
                            continue;
                        string getterName = "get" + propertyName;
                        var matchedGetter = (from getter in type.Methods where getter.Name == getterName && getter.Parameters.Count == 0 && getter.Return == method.Parameters[0] select getter).FirstOrDefault();
                        if (matchedGetter != null)
                        {
                            matchedGetter.PropertyType = method.PropertyType = PropertyType.ReadWrite;
                            matchedGetter.OtherPropertyAccessor = method;
                            method.OtherPropertyAccessor = matchedGetter;
                        }
                        else
                        {
                            if ((from getter in type.Methods where getter.Name == "get" + propertyName && getter.Parameters.Count == 0 && getter.Return != "void" select getter).Count() != 0)
                                continue;
                            method.PropertyType = PropertyType.WriteOnly;
                        }
                    }
				}
			}
		}
		
		public Type FindType(string name)
		{
			Type ret = null;
			myTypes.Dictionary.TryGetValue(name, out ret);
			return ret;
		}
	}
	
	public class Accessible
	{
		public string Name
		{
			get;set;
		}

		public string Scope
		{
			get;set;
		}
                
        public bool Static
        {
            get;set;
        }

		public override string ToString ()
		{
			return string.Format("{0}{1}", Scope, " " + Name);
		}
	}
	
	public class Overridable : Accessible
	{
		public bool IsSealed
		{
			get;set;
		}
				
		public bool Abstract 
		{
			get;set;
		}
		
		public bool IsSynthetic
		{
			get;set;
		}

		public override string ToString ()
		{
			return string.Format("{0}{1}{2}{3}", Scope, Abstract ? " abstract" : string.Empty, IsSealed ? " sealed" : string.Empty, " " + Name);
		}
	}
	
	public class Field : Accessible
	{
        public Type ContainingType
        {
            get;set;
        }
        
        public Type FieldType
        {
            get;set;
        }
        
		public string Type
		{
			get;set;
		}
		
		public bool IsReadOnly
		{
			get;set;
		}
		
		public string Value
		{
			get;set;
		}

		public override string ToString ()
		{
			return string.Format("{0}{1}{2}{3}{4}", Scope, Static ? " static" : string.Empty, IsReadOnly ? " readonly" : string.Empty, " " + Name, Value != null ? " = " + Value : string.Empty);
		}
	}
	
	public class Type : Overridable
	{
        public bool NoAttributes
        {
            get;set;
        }
        
        public bool IsDelegate
        {
            get;set;
        }
        
        public bool HasEmptyConstructor
        {
            get;set;
        }
        
        public string WrappedInterface
        {
            get;set;
        }
        
        public Type WrappedInterfaceType
        {
            get;set;
        }
        
        public string NativeName
        {
            get;set;
        }
        
		HashSet<string> mySignatures = new HashSet<string>();
		public HashSet<string> Signatures
		{
			get
			{
				return mySignatures;
			}
		}
		
		public Boolean IsNew
		{
			get;set;
		}
		
		public bool IsSystemType
		{
			get;set;
		}
		
		public string Namespace
		{
			get
			{
				var root = this;
				while (root.NestingClass != null)
					root = root.NestingClass;
				return root.Name.Substring(0, root.Name.Length - root.SimpleName.Length - 1);
			}
		}
		
		public string Qualifier
		{
			get
			{
				int index = Name.LastIndexOf('.');
				if (index == -1)
					return string.Empty;
				return Name.Substring(0, index);
			}
		}
		
		public string SimpleName
		{
			get
			{
				int last = Name.LastIndexOf('.');
				if (last == -1)
					return Name;
				return Name.Substring(last + 1);
			}
		}
		
		public Type()
		{
		}

		public bool IsInterface
		{
			get;set;
		}
		
		public bool IsEnum
		{
			get;set;
		}
		
		public String Parent
		{
			get;set;
		}
		
		public Type ParentType
		{
			get;set;
		}
		
		List<string> myInterfaces = new List<string>();
		[System.Xml.Serialization.XmlArrayItemAttribute("Interface", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
		public List<string> Interfaces
		{
			get
			{
				return myInterfaces;
			}
		}
				
		List<Type> myTypes = new List<Type>();
		public List<Type> Types
		{
			get
			{
				return myTypes;
			}
		}
		
		List<Type> myInterfaceTypes = new List<Type>();
		public List<Type> InterfaceTypes
		{
			get
			{
				return myInterfaceTypes;
			}
		}
		
		public bool IsInnerClass
		{
			get;set;
		}
		
		public Type NestingClass
		{
			get;set;
		}
		
		Methods myMethods = new Methods();
		[System.Xml.Serialization.XmlArrayItemAttribute("Method", typeof(Method), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
		public Methods Methods	
		{
			get
			{
				return myMethods;
			}
		}
		
		List<Field> myFields = new List<Field>();
		[System.Xml.Serialization.XmlArrayItemAttribute("Field", typeof(Field), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
		public List<Field> Fields	
		{
			get
			{
				return myFields;
			}
		}
		
		public override string ToString ()
		{
			return string.Format("{0}{1}{2}{3}", Scope, IsInterface ? " interface" : Abstract ? " abstract" : string.Empty, IsSealed ? " sealed" : string.Empty, " " + Name);
		}
	}

	public enum PropertyType
	{
		ReadOnly,
		ReadWrite,
        WriteOnly,
	}
	
	public class Methods : SerializableDictionary<string, Method>
	{
		protected override string GetKey (Method value)
		{
			return value.ToSignatureString();
		}
	}
	
	public class Method : Overridable
	{
		public bool IsNew
		{
			get;set;
		}
		
		public bool Matches(Method other)
		{
			if (other.Return != Return)
				return false;
			if (other.Name != Name)
				return false;
			if (other.Parameters.Count != Parameters.Count)
				return false;
			for (int i = 0; i < Parameters.Count; i++)
			{
				if (other.Parameters[i] != Parameters[i])
					return false;
			}
			return true;
		}
			    
		public bool IsOverride
		{
			get;set;
		}
		
		public string Override
		{
			get;set;
		}
		
		public Type OverrideType
		{
			get;set;
		}
			
		public Method OverrideMethod
		{
			get;set;
		}
		
		public PropertyType? PropertyType
		{
			get;set;
		}
		
		public Method OtherPropertyAccessor
		{
			get;set;
		}
		
		public Type Type
		{
			get;	set;
		}
		
		public bool IsConstructor
		{
			get;set;
		}
		
		public string Return
		{
			get;set;
		}
		
		public Type ReturnType
		{
			get;set;
		}
		
		List<string> myParameters = new List<string>();
		[System.Xml.Serialization.XmlArrayItemAttribute("Parameter", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
		public List<string> Parameters	
		{
			get
			{
				return myParameters;
			}
		}
					
		List<Type> myParameterTypes = new List<Type>();
		public List<Type> ParameterTypes
		{
			get
			{
				return myParameterTypes;
			}
		}
		
		public string ToSignatureString ()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append('(');
			bool first = true;
			foreach(var param in Parameters)
			{
				if (!first)
					builder.Append(", ");
				builder.Append(param);
				first = false;
			}
			builder.Append(')');
			return string.Format("{0}{1}", Name, builder.ToString());
		}

		public override string ToString ()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append('(');
			bool first = true;
			foreach(var param in Parameters)
			{
				if (!first)
					builder.Append(", ");
				builder.Append(param);
				first = false;
			}
			builder.Append(')');
			return string.Format("{0}{1}{2}{3}{4}{5}{6}", Scope, Static ? " static" : string.Empty, Abstract ? " abstract" : string.Empty, IsSealed ? " sealed" : string.Empty, Return != null ? " " + Return : string.Empty, " " + Name, builder.ToString());
		}

	}
}
