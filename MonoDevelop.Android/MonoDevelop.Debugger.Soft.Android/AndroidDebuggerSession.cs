// 
// IPhoneDebuggerSession.cs
//  
// Author:
//       Michael Hutchinson <mhutchinson@novell.com>
// 
// Copyright (c) 2009 Novell, Inc. (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

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
		
		protected override string AppName {
			get { return appName; }
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
			string adbShellArgs = String.Format ("shell 'MONO_PATH=/data/data/com.koushikdutta.mono HOME=/data/local/bin /data/data/com.koushikdutta.mono/mono --debugger-agent=transport=dt_socket,address={0}:{1} /data/local/bin/{2} | /data/data/com.koushikdutta.mono/fwdstdin {0} {3}'", debuggerStartInfo.Address, debuggerStartInfo.DebugPort, outputFile, debuggerStartInfo.OutputPort);
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
			: base (address, debugPort, outputPort)
		{
			ExecutionCommand = cmd;
		}
	}
}