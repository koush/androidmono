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
            
            var manifest = Path.Combine(Path.Combine(BaseDirectory, "Android"), "AndroidManifest.xml");
            if (null == GetProjectFile(manifest))
                return;
            
            var javaProjDir = Path.Combine(BaseDirectory, "Android");
            var thisAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var iconPath = Path.Combine(javaProjDir, "res/drawable/icon.png");
            var iconFile = GetProjectFile(iconPath);
            if (iconFile == null)
            {
                var projectFile = AddFile(iconPath);
                using (var istream = thisAssembly.GetManifestResourceStream("icon.png"))
                {
                    using (var ostream = new FileStream(iconPath, FileMode.Create))
                    {
                        var bytes = new byte[istream.Length];
                        istream.Read(bytes, 0, bytes.Length);
                        ostream.Write(bytes, 0, bytes.Length);
                    }
                }
            }
            
            var monoActivityPath = Path.Combine(javaProjDir, "src");
            monoActivityPath = Path.Combine(monoActivityPath, DefaultNamespace.Replace('.', Path.DirectorySeparatorChar));
            Directory.CreateDirectory(monoActivityPath);
            monoActivityPath = Path.Combine(monoActivityPath, "MonoActivity.java");
            if (iconFile == null)
            {
                var projectFile = AddFile(monoActivityPath);
                using (var istream = new StreamReader(thisAssembly.GetManifestResourceStream("MonoActivity.java")))
                {
                    
                    File.WriteAllText(monoActivityPath, string.Format(istream.ReadToEnd(), DefaultNamespace));
                }
            }
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
            var javaProjectPath = Path.Combine(BaseDirectory, "Android");
            var manifest = Path.Combine(javaProjectPath, "AndroidManifest.xml");
            var isApk = null != GetProjectFile(manifest);
            return new AndroidExecutionCommand (TargetRuntime, TargetFramework, configuration.CompiledOutputName.FileName, configuration.OutputDirectory,
                                               configuration.DebugMode, isApk, javaProjectPath, DefaultNamespace);
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
