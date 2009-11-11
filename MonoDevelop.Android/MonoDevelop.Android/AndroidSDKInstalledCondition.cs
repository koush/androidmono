using System;
using System.IO;
using System.Collections.Generic;
using MonoDevelop.Core.Assemblies;
using MonoDevelop.Core;
using Mono.Addins;
using MonoDevelop.Core.Gui;


namespace MonoDevelop.Android
{

	public class AndroidSDKInstalledCondition : ConditionType
	{
		public static readonly string ANDROID_SDK = Environment.GetEnvironmentVariable("ANDROID_SDK") ?? "/Developer/android-sdk";
		public static Boolean IsInstalled
		{
			get
			{
			return Directory.Exists(ANDROID_SDK);	
			}
		}
		
		public override bool Evaluate (NodeElement conditionNode)
		{
			return IsInstalled;
		}
	}
}
