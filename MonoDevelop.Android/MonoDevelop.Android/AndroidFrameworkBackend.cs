using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MonoDevelop.Core.Assemblies;
using MonoDevelop.Core;
using Mono.Addins;
using MonoDevelop.Ide;
using Gtk;
using MonoDevelop.Core.Serialization;


namespace MonoDevelop.Android
{
    public class AndroidFrameworkBackend : MonoFrameworkBackend
    {
        public override SystemPackageInfo GetFrameworkPackageInfo (string packageName)
        {
            SystemPackageInfo info = base.GetFrameworkPackageInfo ("mono-android");
            info.Name = "mono-android";
            return info;
        }
        
        public override bool IsInstalled {
            get { return true; }
        }
    }
}
