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
using System.Xml.Serialization;

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
                return base.Build (monitor, item, configuration);
            
            var manifest = Path.Combine(Path.Combine(proj.BaseDirectory, "Android"), "AndroidManifest.xml");
            if (null == proj.GetProjectFile(manifest))
            {
                Console.WriteLine("AndroidManifest.xml not found. Skipping APK build.");
                return base.Build (monitor, item, configuration);
            }
            
            var conf = proj.GetConfiguration(configuration) as AndroidProjectConfiguration;
            
            var buildResult = base.Build (monitor, item, configuration);
            if (buildResult.Errors.Count > 0)
                return buildResult;
            
            MonoReflectorContext ctx = new MonoReflectorContext();
            var javaProjDir = Path.Combine(proj.ItemDirectory.ToString(), "Android");
            var javaSrcDir = ctx.OutputDirectory = Path.Combine(javaProjDir, "src");
            ctx.AssemblyFile = conf.CompiledOutputName;
            monitor.BeginTask("Generating Java files.", 0);
            AppDomain other = AppDomain.CreateDomain("other");
            try   
            {
                other.Load(System.Reflection.Assembly.GetExecutingAssembly().GetName());
                other.DoCallBack(new CrossAppDomainDelegate(ctx.Callback));
            }
            finally
            {
                AppDomain.Unload(other);
            }
            monitor.EndTask();
            foreach (var outputFile in ctx.OutputFiles)
            {
                if (null == proj.GetProjectFile(outputFile))
                    proj.AddFile(outputFile);
            }
            
            var cfg = Config.Load();
            
            var androidPath = Path.Combine(cfg.AndroidSDK, "tools/android");
            var args = string.Format("update project -p {0}", javaProjDir);
            Process.Start(androidPath, args).WaitForExit();
            
            var assetsDir = Path.Combine(javaProjDir, "assets");
            var packagedAssembly = Path.Combine(assetsDir, Path.GetFileName(conf.CompiledOutputName));
            File.Copy(conf.CompiledOutputName, packagedAssembly, true);
            var mdb = conf.CompiledOutputName + ".mdb";
            var packagedMdb = Path.Combine(assetsDir, Path.GetFileName(mdb));
            File.Copy(mdb, packagedMdb, true);

            var androidmonoDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".androidmono");
            var monojavabridgejar = Path.Combine(androidmonoDir, "com.koushikdutta.monojavabridge.jar");
            var libsDir = Path.Combine(javaProjDir, "libs");
            Directory.CreateDirectory(libsDir);
            var localcopyjar = Path.Combine(libsDir, "com.koushikdutta.monojavabridge.jar");
            File.Copy(monojavabridgejar, localcopyjar, true);
            
            monitor.BeginTask("Building APK", 0);
            var ant = cfg.Ant ?? "ant";
            var antProcInfo = new ProcessStartInfo(ant, "debug");
            antProcInfo.WorkingDirectory = javaProjDir;
            antProcInfo.RedirectStandardOutput = true;
            antProcInfo.UseShellExecute = false;
            var antProc = Process.Start(antProcInfo);
            monitor.Log.Write(antProc.StandardOutput.ReadToEnd());
            monitor.EndTask();
            
            var genPath = Path.Combine(javaProjDir, "gen");
            var rPath = Path.Combine(genPath, proj.DefaultNamespace.Replace('.', Path.DirectorySeparatorChar));
            rPath = Path.Combine(rPath, "R.java");
            if (File.Exists(rPath))
            {
                var rText = File.ReadAllText(rPath);
                rText = rText.Replace("final class", "class").Replace("static final", "static readonly").Replace("class string", "class string_").Replace("class R ", "static class R ");
                var regex = new System.Text.RegularExpressions.Regex("package (.*?);");
                rText = regex.Replace(rText, "namespace $1\n{");
                rText += "\n}";
                
                rPath = Path.Combine(proj.BaseDirectory, "R.cs");
                File.WriteAllText(rPath, rText);
                if (proj.GetProjectFile(rPath) == null)
                    proj.AddFile(rPath);
            }
            
            return buildResult;
        }
        
        [Serializable]
        public class MonoReflectorContext : MarshalByRefObject
        {
            public string OutputDirectory;
            public string AssemblyFile;
            public List<string> OutputFiles = new List<string>();
            
            public void Callback()
            {
                var mr = new MonoReflector(OutputDirectory);
                OutputFiles.AddRange(mr.Generate(GenerationFlags.None, AssemblyFile));
            }
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
                Console.WriteLine("Android.Debugger.HostIP: {0}", ipStr);
				try {
					if (!string.IsNullOrEmpty (ipStr))
						return System.Net.IPAddress.Parse (ipStr);
				} catch (Exception e) {
					LoggingService.LogInfo ("Error parsing Debugger HostIP: {0}: {1}", ipStr, e);
				}
                
                var hostName = System.Net.Dns.GetHostName();
                Console.WriteLine("Host Name: {0}", hostName);
                var addresses = System.Net.Dns.GetHostAddresses(hostName);
                foreach (var addr in addresses)
                {
                    Console.WriteLine(addr);
                    if (addr.ToString().StartsWith("192.168.1"))
                        return addr;
                }
				
                return addresses[0];
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
