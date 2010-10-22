namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockPackageManager : android.content.pm.PackageManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MockPackageManager()
		{
			InitJNI();
		}
		protected MockPackageManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission12468;
		public override int checkPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._checkPermission12468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkPermission12468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackageInfo12469;
		public override global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackageInfo12469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageInfo12469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo12470;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationInfo12470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationInfo12470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getText12471;
		public override global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getText12471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getText12471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity12472;
		public override global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._resolveActivity12472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveActivity12472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable12473;
		public override global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getDrawable12473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getDrawable12473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getXml12474;
		public override global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getXml12474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getXml12474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _currentToCanonicalPackageNames12475;
		public override global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames12475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames12475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _canonicalToCurrentPackageNames12476;
		public override global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames12476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames12476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getLaunchIntentForPackage12477;
		public override global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getLaunchIntentForPackage12477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getLaunchIntentForPackage12477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageGids12478;
		public override int[] getPackageGids(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackageGids12478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageGids12478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionInfo12479;
		public override global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPermissionInfo12479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPermissionInfo12479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryPermissionsByGroup12480;
		public override global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryPermissionsByGroup12480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryPermissionsByGroup12480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionGroupInfo12481;
		public override global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPermissionGroupInfo12481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPermissionGroupInfo12481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAllPermissionGroups12482;
		public override global::java.util.List getAllPermissionGroups(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getAllPermissionGroups12482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getAllPermissionGroups12482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityInfo12483;
		public override global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getActivityInfo12483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityInfo12483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getReceiverInfo12484;
		public override global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getReceiverInfo12484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getReceiverInfo12484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo12485;
		public override global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getServiceInfo12485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getServiceInfo12485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledPackages12486;
		public override global::java.util.List getInstalledPackages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstalledPackages12486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstalledPackages12486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPermission12487;
		public override bool addPermission(android.content.pm.PermissionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPermission12487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPermission12487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPermissionAsync12488;
		public override bool addPermissionAsync(android.content.pm.PermissionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPermissionAsync12488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPermissionAsync12488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission12489;
		public override void removePermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._removePermission12489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._removePermission12489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures12490;
		public override int checkSignatures(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._checkSignatures12490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkSignatures12490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures12491;
		public override int checkSignatures(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._checkSignatures12491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkSignatures12491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackagesForUid12492;
		public override global::java.lang.String[] getPackagesForUid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackagesForUid12492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackagesForUid12492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getNameForUid12493;
		public override global::java.lang.String getNameForUid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getNameForUid12493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getNameForUid12493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledApplications12494;
		public override global::java.util.List getInstalledApplications(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstalledApplications12494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstalledApplications12494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		public new global::java.lang.String[] SystemSharedLibraryNames
		{
			get
			{
				return getSystemSharedLibraryNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemSharedLibraryNames12495;
		public override global::java.lang.String[] getSystemSharedLibraryNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames12495)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames12495)) as java.lang.String[];
		}
		public new global::android.content.pm.FeatureInfo[] SystemAvailableFeatures
		{
			get
			{
				return getSystemAvailableFeatures();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemAvailableFeatures12496;
		public override global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getSystemAvailableFeatures12496)) as android.content.pm.FeatureInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getSystemAvailableFeatures12496)) as android.content.pm.FeatureInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _hasSystemFeature12497;
		public override bool hasSystemFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._hasSystemFeature12497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._hasSystemFeature12497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivities12498;
		public override global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryIntentActivities12498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentActivities12498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivityOptions12499;
		public override global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryIntentActivityOptions12499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentActivityOptions12499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryBroadcastReceivers12500;
		public override global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryBroadcastReceivers12500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryBroadcastReceivers12500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveService12501;
		public override global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._resolveService12501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveService12501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentServices12502;
		public override global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryIntentServices12502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentServices12502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveContentProvider12503;
		public override global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.pm.ProviderInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._resolveContentProvider12503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.pm.ProviderInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveContentProvider12503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryContentProviders12504;
		public override global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryContentProviders12504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryContentProviders12504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getInstrumentationInfo12505;
		public override global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstrumentationInfo12505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstrumentationInfo12505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryInstrumentation12506;
		public override global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryInstrumentation12506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryInstrumentation12506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon12507;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getActivityIcon12507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityIcon12507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon12508;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getActivityIcon12508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityIcon12508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable DefaultActivityIcon
		{
			get
			{
				return getDefaultActivityIcon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultActivityIcon12509;
		public override global::android.graphics.drawable.Drawable getDefaultActivityIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getDefaultActivityIcon12509)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getDefaultActivityIcon12509)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon12510;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationIcon12510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationIcon12510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon12511;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationIcon12511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationIcon12511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationLabel12512;
		public override global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationLabel12512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationLabel12512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForActivity12513;
		public override global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getResourcesForActivity12513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForActivity12513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication12514;
		public override global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getResourcesForApplication12514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForApplication12514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication12515;
		public override global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getResourcesForApplication12515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForApplication12515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageArchiveInfo12516;
		public override global::android.content.pm.PackageInfo getPackageArchiveInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackageArchiveInfo12516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageArchiveInfo12516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstallerPackageName12517;
		public override global::java.lang.String getInstallerPackageName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstallerPackageName12517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstallerPackageName12517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addPackageToPreferred12518;
		public override void addPackageToPreferred(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPackageToPreferred12518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPackageToPreferred12518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePackageFromPreferred12519;
		public override void removePackageFromPreferred(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._removePackageFromPreferred12519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._removePackageFromPreferred12519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredPackages12520;
		public override global::java.util.List getPreferredPackages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPreferredPackages12520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPreferredPackages12520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPreferredActivity12521;
		public override void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPreferredActivity12521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPreferredActivity12521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clearPackagePreferredActivities12522;
		public override void clearPackagePreferredActivities(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._clearPackagePreferredActivities12522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._clearPackagePreferredActivities12522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredActivities12523;
		public override int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPreferredActivities12523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPreferredActivities12523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setComponentEnabledSetting12524;
		public override void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._setComponentEnabledSetting12524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._setComponentEnabledSetting12524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getComponentEnabledSetting12525;
		public override int getComponentEnabledSetting(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getComponentEnabledSetting12525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getComponentEnabledSetting12525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setApplicationEnabledSetting12526;
		public override void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._setApplicationEnabledSetting12526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._setApplicationEnabledSetting12526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationEnabledSetting12527;
		public override int getApplicationEnabledSetting(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationEnabledSetting12527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationEnabledSetting12527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSafeMode12528;
		public override bool isSafeMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._isSafeMode12528);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._isSafeMode12528);
		}
		internal static global::MonoJavaBridge.MethodId _MockPackageManager12529;
		public MockPackageManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._MockPackageManager12529);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockPackageManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockPackageManager"));
			global::android.test.mock.MockPackageManager._checkPermission12468 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._getPackageInfo12469 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.test.mock.MockPackageManager._getApplicationInfo12470 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;");
			global::android.test.mock.MockPackageManager._getText12471 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockPackageManager._resolveActivity12472 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.test.mock.MockPackageManager._getDrawable12473 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getXml12474 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames12475 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames12476 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getLaunchIntentForPackage12477 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.test.mock.MockPackageManager._getPackageGids12478 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageGids", "(Ljava/lang/String;)[I");
			global::android.test.mock.MockPackageManager._getPermissionInfo12479 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;");
			global::android.test.mock.MockPackageManager._queryPermissionsByGroup12480 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getPermissionGroupInfo12481 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;");
			global::android.test.mock.MockPackageManager._getAllPermissionGroups12482 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getActivityInfo12483 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.test.mock.MockPackageManager._getReceiverInfo12484 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.test.mock.MockPackageManager._getServiceInfo12485 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;");
			global::android.test.mock.MockPackageManager._getInstalledPackages12486 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstalledPackages", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._addPermission12487 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.test.mock.MockPackageManager._addPermissionAsync12488 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.test.mock.MockPackageManager._removePermission12489 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "removePermission", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._checkSignatures12490 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkSignatures", "(II)I");
			global::android.test.mock.MockPackageManager._checkSignatures12491 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._getPackagesForUid12492 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getNameForUid12493 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getNameForUid", "(I)Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getInstalledApplications12494 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstalledApplications", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames12495 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getSystemAvailableFeatures12496 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;");
			global::android.test.mock.MockPackageManager._hasSystemFeature12497 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z");
			global::android.test.mock.MockPackageManager._queryIntentActivities12498 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._queryIntentActivityOptions12499 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._queryBroadcastReceivers12500 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._resolveService12501 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.test.mock.MockPackageManager._queryIntentServices12502 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._resolveContentProvider12503 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;");
			global::android.test.mock.MockPackageManager._queryContentProviders12504 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getInstrumentationInfo12505 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;");
			global::android.test.mock.MockPackageManager._queryInstrumentation12506 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getActivityIcon12507 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getActivityIcon12508 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getDefaultActivityIcon12509 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationIcon12510 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationIcon12511 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationLabel12512 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockPackageManager._getResourcesForActivity12513 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getResourcesForApplication12514 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getResourcesForApplication12515 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getPackageArchiveInfo12516 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.test.mock.MockPackageManager._getInstallerPackageName12517 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._addPackageToPreferred12518 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._removePackageFromPreferred12519 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._getPreferredPackages12520 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPreferredPackages", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._addPreferredActivity12521 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V");
			global::android.test.mock.MockPackageManager._clearPackagePreferredActivities12522 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._getPreferredActivities12523 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._setComponentEnabledSetting12524 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V");
			global::android.test.mock.MockPackageManager._getComponentEnabledSetting12525 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I");
			global::android.test.mock.MockPackageManager._setApplicationEnabledSetting12526 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V");
			global::android.test.mock.MockPackageManager._getApplicationEnabledSetting12527 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._isSafeMode12528 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "isSafeMode", "()Z");
			global::android.test.mock.MockPackageManager._MockPackageManager12529 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "<init>", "()V");
		}
	}
}
