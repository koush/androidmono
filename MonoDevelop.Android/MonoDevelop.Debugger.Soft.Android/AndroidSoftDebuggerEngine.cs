using System;
using System.Collections.Generic;
using System.IO;
using MonoDevelop.Debugger;
using MonoDevelop.Core;
using MonoDevelop.Core.Execution;
using MonoDevelop.Android;
using Mono.Debugging.Client;
using MonoDevelop.Debugger.Soft;
using System.Net;

namespace MonoDevelop.Debugger.Soft.Android
{
	public class AndroidSoftDebuggerEngine: IDebuggerEngine
	{
		public bool CanDebugCommand (ExecutionCommand command)
		{
			var cmd = command as AndroidExecutionCommand;
			return cmd != null && cmd.DebugMode;
		}
		
		public DebuggerStartInfo CreateDebuggerStartInfo (ExecutionCommand command)
		{
			var cmd = (AndroidExecutionCommand) command;
			var startInfo = new AndroidDebuggerStartInfo (AndroidBuildExtension.DebuggerIP,
								     AndroidBuildExtension.DebuggerPort,
								     AndroidBuildExtension.DebuggerOutputPort, cmd);
			return startInfo;
		}

		public DebuggerSession CreateSession ()
		{
			return new AndroidDebuggerSession ();
		}
		
		public ProcessInfo[] GetAttachableProcesses ()
		{
			return new ProcessInfo[0];
		}
	}
}
