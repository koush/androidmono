using System;
using System.Xml.Serialization;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;

namespace MonoDroid
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var types = ObjectModel.Load("androidsdk.xml");
			//var thing = types.FindType("android.widget.LinearLayout.LayoutParams");
			var iface = (from type in types.Types where type.IsInterface && type.Interfaces.Count > 0 select type).First();
			NetProxyGenerator net = new NetProxyGenerator(Directory.CreateDirectory("net"));
			net.Generate(types);
			Console.WriteLine("Done!");
		}
	}
}
