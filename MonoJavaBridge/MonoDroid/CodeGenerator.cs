using System;
using System.IO;
using System.Collections.Generic;

namespace MonoDroid
{
	public abstract class CodeGenerator
	{
		StreamWriter myWriter;

		public void Generate(ObjectModel objectModel)
		{
			objectModel.FinalizeModel();
			Prepare(objectModel);
			foreach (var type in objectModel.Types)
			{
				if (type.NestingClass != null)
					continue;
				
				var path = GetFilePath(type);
				string dir = Directory.GetParent(path).FullName;
				Directory.CreateDirectory(dir);
					
				using (myWriter = new StreamWriter(new FileStream(path, FileMode.Create)))
				{
					BeginNamespace(type);
					GenerateType(type);
					EndNamespace(type);
				}
			}
		}
				
		public void GenerateType(Type type)
		{
			if (type.IsSystemType)
				return;
			myIndent++;
			if (BeginType(type))
			{
				foreach(var subType in type.Types)
				{
					GenerateType(subType);
				}
                int index = 0;
				foreach(var method in type.Methods)
				{
					if (type.Signatures.Contains(method.ToSignatureString()))
					    continue;
                    method.Index = index++;
					type.Signatures.Add(method.ToSignatureString());
					myIndent++;
					EmitMethod(method);
					myIndent--;
				}
				foreach(var field in type.Fields)
				{
					myIndent++;
					EmitField(field);
					myIndent--;
				}
				EndType(type);
			}
			myIndent--;
		}
		
		protected int myIndent = 0;
		bool myIsNewLine = true;
		protected void Write(string format, params object[] args)
		{
			Write(format, true, args);
		}
		
		protected void Write(string format, bool whitespace, params object[] args)
		{
			if (myIsNewLine)
			{
				for (int i = 0; i < myIndent; i++)
					myWriter.Write('\t');
			}
			myIsNewLine = false;
			if (args.Length != 0)
				myWriter.Write(string.Format(format, args));
			else
				myWriter.Write(format);
			if (whitespace)
				myWriter.Write(" ");
		}
		
		protected void WriteLine(string format, params object[] args)
		{
			Write(format, false, args);
			myWriter.WriteLine();
			myIsNewLine = true;
		}
		
		protected void WriteLine()
		{
			myWriter.WriteLine();
			myIsNewLine = true;
		}
		
		protected abstract void BeginNamespace(Type type);
		protected virtual void EndNamespace(Type type)
		{
			WriteLine("}");
		}
		
		protected abstract bool BeginType(Type type);
		protected virtual void EndType(Type type)
		{
			WriteLine("}");
		}
		
		protected abstract void EmitMethod(Method method);
		protected abstract void EmitField(Field field);
		
		protected abstract string GetFilePath(Type type);
		protected void WriteDelimited<T>(ICollection<T> coll, Func<T, int, string> func, string delimiter)
		{
			bool first = true;
			int i = 0;
			foreach(T t in coll)
			{
				if (t == null)
					System.Diagnostics.Debugger.Break();
				if (!first)
					Write(delimiter);
				else
					first = false;
				Write(func(t, i++), false);
			}
		}
		
		protected virtual void Prepare(ObjectModel model)
		{
		}
	}
}
