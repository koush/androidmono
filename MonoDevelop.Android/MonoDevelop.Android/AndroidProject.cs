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
		}

		public AndroidProject (string languageName)
			: base (languageName)
		{
		}
		
		public override string ProjectType {
			get { return "Android"; }
		}
		
		public AndroidProject (string languageName, ProjectCreateInformation info, XmlElement projectOptions)
			: base (languageName, info, projectOptions)
		{
		}

		
		protected override ExecutionCommand CreateExecutionCommand (ConfigurationSelector configSel, DotNetProjectConfiguration configuration)
		{
			return new AndroidExecutionCommand (TargetRuntime, TargetFramework, configuration.CompiledOutputName.FileName, configuration.OutputDirectory,
			                                   configuration.DebugMode);
		}
	}
}
