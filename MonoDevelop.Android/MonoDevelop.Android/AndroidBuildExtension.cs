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
		
        protected override BuildResult Build (IProgressMonitor monitor, SolutionEntityItem item, ConfigurationSelector configuration)
        {
            var proj = item as AndroidProject;
            if (proj == null)
                return base.Build (monitor, item, configuration);            //monitor.BeginTask("Generating Java files.", 0);
            
            var conf = proj.GetConfiguration(configuration) as AndroidProjectConfiguration;        
            Console.WriteLine("Output assembly: {0}", conf.OutputAssembly);
            Console.WriteLine("Compiled Output assembly: {0}", conf.CompiledOutputName);
            Console.WriteLine(File.Exists(conf.CompiledOutputName));
            
            //monitor.EndTask();
            var buildResult = base.Build (monitor, item, configuration);
            Console.WriteLine(File.Exists(conf.CompiledOutputName));
            if (buildResult.Errors.Count > 0)
                return buildResult;
            
            var mr = new MonoReflector(conf.CompiledOutputName);
            if (!mr.Generate(GenerationFlags.None))
                buildResult.AddError("Error while generating Java classes.");
            return buildResult;
        }
        
        protected override BuildResult Compile (IProgressMonitor monitor, SolutionEntityItem item, BuildData buildData)
        {
            Console.WriteLine("Compiling APK.");
            return base.Compile (monitor, item, buildData);
        }
        
        protected override void Clean (IProgressMonitor monitor, SolutionEntityItem item, ConfigurationSelector configuration)
        {
            Console.WriteLine("Cleaning APK.");
            base.Clean (monitor, item, configuration);
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
