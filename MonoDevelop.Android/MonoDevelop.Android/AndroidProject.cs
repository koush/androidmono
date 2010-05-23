using System;
using System.Xml;
using MonoDevelop.Core;
using MonoDevelop.Core.Serialization;
using MonoDevelop.Projects;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using MonoDevelop.Core.ProgressMonitoring;
using MonoDevelop.Core.Execution;

namespace MonoDevelop.Android
{

	public class AndroidProject : DotNetProject
	{
		public AndroidProject ()
		{
            Console.WriteLine("AndroidProject");
		}

		public AndroidProject (string languageName)
			: base (languageName)
		{
		}
        
        protected override void OnEndLoad ()
        {
            base.OnEndLoad ();
            
            var iconPath = Path.Combine(BaseDirectory, "Android/res/drawable/icon.png");
            var iconFile = GetProjectFile(iconPath);
            if (iconFile == null)
            {
                var projectFile = AddFile(iconPath);
                var a = System.Reflection.Assembly.GetExecutingAssembly();
                using (var istream = a.GetManifestResourceStream("icon.png"))
                {
                    using (var ostream = new FileStream(iconPath, FileMode.Create))
                    {
                        var bytes = new byte[istream.Length];
                        istream.Read(bytes, 0, bytes.Length);
                        ostream.Write(bytes, 0, bytes.Length);
                    }
                }
            }
            
            Directory.CreateDirectory(Path.Combine(BaseDirectory, "Android/src"));
        }
        
		
		public override string ProjectType {
			get { return "Android"; }
		}
		
		public AndroidProject (string languageName, ProjectCreateInformation info, XmlElement projectOptions)
			: base (languageName, info, projectOptions)
		{
		}
                
        protected override void OnBeginLoad ()
        {
            base.OnBeginLoad ();
        }
        
		
		protected override ExecutionCommand CreateExecutionCommand (ConfigurationSelector configSel, DotNetProjectConfiguration configuration)
		{
            bool isApk = false;
            foreach (var reference in References)
            {
                if (reference.Reference.StartsWith("android"))
                {
                    isApk = true;
                    break;
                }
            }
            
			return new AndroidExecutionCommand (TargetRuntime, TargetFramework, configuration.CompiledOutputName.FileName, configuration.OutputDirectory,
			                                   configuration.DebugMode, isApk);
		}
        
        public override SolutionItemConfiguration CreateConfiguration (string name)
        {
            var conf = new AndroidProjectConfiguration (name);
            
            var dir = new FilePath ("bin");
            if (!String.IsNullOrEmpty (conf.Platform))
                dir.Combine (conf.Platform);
            dir.Combine (conf.Name);
            
            conf.OutputDirectory = BaseDirectory.IsNullOrEmpty? dir : BaseDirectory.Combine (dir);
            conf.OutputAssembly = Name;
            
            if (LanguageBinding != null)
                conf.CompilationParameters = LanguageBinding.CreateCompilationParameters (null);
            return conf;
        }
        
	}
}
