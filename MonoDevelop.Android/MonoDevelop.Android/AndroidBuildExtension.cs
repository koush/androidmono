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
	}
}
