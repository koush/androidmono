
using System;
using MonoDevelop.Core;
using MonoDevelop.Core.Execution;
using MonoDevelop.Core.Assemblies;

namespace MonoDevelop.Android
{

    public class AndroidExecutionCommand : ExecutionCommand
    {

        public AndroidExecutionCommand (TargetRuntime runtime, TargetFramework framework, string outputAssembly,
                                       FilePath logDirectory, bool debugMode, bool isApk, string javaProjectPath, string defaultNamespace)
        {
            LogDirectory = logDirectory;
            Framework = framework;
            Runtime = runtime;
            DebugMode = debugMode;
            OutputAssembly = outputAssembly;
            IsAPK = isApk;
            JavaProjectPath = javaProjectPath;
            DefaultNamespace = defaultNamespace;
        }
            
        public FilePath LogDirectory { get; private set; }
        public bool DebugMode { get; private set; }
        public TargetRuntime Runtime { get; private set; }
        public TargetFramework Framework { get; private set; }
        public string OutputAssembly { get; set; }
        public bool IsAPK { get; set; }
        public string JavaProjectPath { get; set; }
        public string DefaultNamespace { get; set; }
        
        public override string CommandString {
            get { return "[android]"; }
        }
    }
}
