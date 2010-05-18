using System;
using System.Xml.Serialization;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MonoDroid
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var types = ObjectModel.Load("../androidsdk.xml");
			NetProxyGenerator net = new NetProxyGenerator(Directory.CreateDirectory("net"));
			net.Generate(types);
			Console.WriteLine("Done!");
		}
	}
}
