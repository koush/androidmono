using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using MonoDevelop.Core;
using MonoDevelop.Projects;
using MonoDevelop.Core.ProgressMonitoring;
using System.Xml;
using System.Text;
using System.Diagnostics;
using System.CodeDom.Compiler;

namespace MonoDevelop.Android
{

	public class AndroidBuildExtension : ProjectServiceExtension
	{

		public AndroidBuildExtension ()
		{
		}
		
		
		public static System.Net.IPAddress DebuggerIP
		{
			get
			{
				var ipStr = MonoDevelop.Core.PropertyService.Get<string> ("Android.Debugger.HostIP", "");
				try {
					if (!string.IsNullOrEmpty (ipStr))
						return System.Net.IPAddress.Parse (ipStr);
				} catch (Exception e) {
					LoggingService.LogInfo ("Error parsing Debugger HostIP: {0}: {1}", ipStr, e);
				}
				
				return System.Net.Dns.GetHostEntry (System.Net.Dns.GetHostName ()).AddressList[0];
			}
		}
		
		public static int DebuggerPort {
			get {
				return MonoDevelop.Core.PropertyService.Get<int> ("Android.Debugger.Port", 10000);
			}
		}
		
		public static int DebuggerOutputPort {
			get {
				return MonoDevelop.Core.PropertyService.Get<int> ("Android.Debugger.OutputPort", 10001);
			}
		}
	}
}
