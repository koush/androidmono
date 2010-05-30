using System;
using Mono.Debugger;
using Mono.Debugging;
using Mono.Debugging.Client;
using System.Threading;
using System.Diagnostics;
using MonoDevelop.Android;
using System.IO;
using MonoDevelop.Core;
using System.Net.Sockets;
using System.Net;

namespace MonoDevelop.Debugger.Soft.Android
{
	public class AndroidDebuggerSession : RemoteSoftDebuggerSession
	{
		System.Diagnostics.Process simProcess;
		string appName;
		AndroidDebuggerStartInfo debuggerStartInfo;
		
		protected override void OnRun (DebuggerStartInfo startInfo)
		{
			var dsi = (AndroidDebuggerStartInfo) startInfo;
			debuggerStartInfo = dsi;
			appName = dsi.ExecutionCommand.OutputAssembly;
			
			var cmd = dsi.ExecutionCommand;
			StartSimulatorProcess (cmd);
			StartListening (dsi);
		}
		
		void TouchUploadMarker (FilePath markerFile)
		{
			if (File.Exists (markerFile))
				File.SetLastWriteTime (markerFile, DateTime.Now);
			else
				File.WriteAllText (markerFile, "This file is used to determine when the app was last uploaded to a device");
		}
		
		protected override string GetListenMessage (RemoteDebuggerStartInfo dsi)
		{
			string message = GettextCatalog.GetString ("Waiting for debugger to connect on {0}:{1}...", dsi.Address, dsi.DebugPort);
			return message;
		}
		
		protected override void EndSession ()
		{
			base.EndSession ();
			EndSimProcess ();
		}

		//FIXME: hook up the app's stdin and stdout
		void StartSimulatorProcess (AndroidExecutionCommand cmd)
		{
			string adbPath = Path.Combine(AndroidSDKInstalledCondition.ANDROID_SDK, "tools/adb");
			if (!File.Exists(adbPath))
				throw new InvalidOperationException ("Cannot execute Android application. adb tool is missing.");
			
			string adbPushArgs = string.Format("push {0}/ /data/local/bin", cmd.LogDirectory);
			System.Diagnostics.Process.Start(adbPath, adbPushArgs).WaitForExit();

			string outputFile = Path.GetFileName(cmd.OutputAssembly);
			string adbShellArgs = String.Format ("shell '/data/data/com.koushikdutta.mono/mono --debugger-agent=transport=dt_socket,address={0}:{1} /data/local/bin/{2} | /data/data/com.koushikdutta.mono/fwdstdin {0} {3}'", debuggerStartInfo.Address, debuggerStartInfo.DebugPort, outputFile, debuggerStartInfo.OutputPort);
			Console.WriteLine(adbShellArgs);
			var psi = new ProcessStartInfo () {
				FileName = adbPath,
				UseShellExecute = false,
				Arguments = adbShellArgs,
				RedirectStandardInput = true,
			};
			simProcess = System.Diagnostics.Process.Start (psi);
			
			simProcess.Exited += delegate {
				EndSession ();
				simProcess = null;
			};
			
			TargetExited += delegate {
				EndSimProcess ();
			};
		}
		
		void EndSimProcess ()
		{
			if (simProcess == null)
				return;
			if (!simProcess.HasExited) {
				try {
					simProcess.StandardInput.WriteLine ();
				} catch {}
			}
			GLib.Timeout.Add (10000, delegate {
				if (!simProcess.HasExited)
					simProcess.Kill ();
				return false;
			});
		}
		
		protected override void OnExit ()
		{
			base.OnExit ();
			EndSimProcess ();
		}
	}
	
	class AndroidDebuggerStartInfo : RemoteDebuggerStartInfo
	{
		public AndroidExecutionCommand ExecutionCommand { get; private set; }
		
		public AndroidDebuggerStartInfo (IPAddress address, int debugPort, int outputPort, AndroidExecutionCommand cmd)
			: base (null, address, debugPort, outputPort)
		{
			ExecutionCommand = cmd;
		}
	}
}
