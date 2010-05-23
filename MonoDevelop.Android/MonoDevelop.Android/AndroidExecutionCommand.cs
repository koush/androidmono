
using System;
using MonoDevelop.Core;
using MonoDevelop.Core.Execution;
using MonoDevelop.Core.Assemblies;

namespace MonoDevelop.Android
{

	public class AndroidExecutionCommand : ExecutionCommand
	{

		public AndroidExecutionCommand (TargetRuntime runtime, TargetFramework framework, string outputAssembly,
		                               FilePath logDirectory, bool debugMode, bool isApk)
		{
			this.LogDirectory = logDirectory;
			this.Framework = framework;
			this.Runtime = runtime;
			this.DebugMode = debugMode;
			this.OutputAssembly = outputAssembly;
            this.IsAPK = isApk;
		}
			
		public FilePath LogDirectory { get; private set; }
		public bool DebugMode { get; private set; }
		public TargetRuntime Runtime { get; private set; }
		public TargetFramework Framework { get; private set; }
		public string OutputAssembly { get; set; }
        public bool IsAPK { get; set; }
		
		public override string CommandString {
			get { return "[android]"; }
		}
	}
}
