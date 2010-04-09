
using System;
using System.IO;

namespace MonoDroid
{
	public class NetProxyGenerator : CodeGenerator
	{
		public NetProxyGenerator (DirectoryInfo workingDirectory)
			: base(workingDirectory)
		{
		}
		
		static readonly string[] myKeywords = new string[] {
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
		
		protected override void Prepare (ObjectModel model)
		{
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
						method.Return = EscapeName(method.Return, false);
				}
				if (type.Parent != null)
					type.Parent = EscapeName(type.Parent);
				for (int i = 0; i < type.Interfaces.Count; i++)
				{
					type.Interfaces[i] = EscapeName(type.Interfaces[i]);
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

		protected override void BeginNamespace (string name)
		{
			WriteLine("namespace {0}", name);
			WriteLine("{");
		}
		
		protected override string GetFilePath (Type type)
		{
			return Path.Combine(type.Namespace.Replace('.', Path.DirectorySeparatorChar), type.SimpleName + ".cs");
		}		
		
		protected override void BeginType (Type type)
		{
			Write(type.Scope);
			if (type.IsNew)
				Write("new");
			if (type.Abstract && !type.IsInterface)
				Write("abstract");
			if (type.IsSealed)
				Write("sealed");
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
		}

		protected override void EmitMethod (Method method)
		{
			if (method.IsSynthetic)
				return;
			
			if (!method.Type.IsInterface)
			{
				WriteLine("[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]");
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
					Write("extern");
				}
			}
			if (method.IsNew)
				Write("new");
			if (method.Return != null)
				Write(method.Return);
			Write(method.Name, false);
			Write("(", false);
			WriteDelimited(method.Parameters, (v, i) => string.Format("{0} arg{1}", v, i), ",");
			WriteLine(");");
		}
	}
}
