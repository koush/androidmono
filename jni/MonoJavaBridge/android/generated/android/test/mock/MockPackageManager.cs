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
		internal static global::MonoJavaBridge.MethodId _checkPermission7990;
		public override int checkPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._checkPermission7990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkPermission7990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackageInfo7991;
		public override global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackageInfo7991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageInfo7991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo7992;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationInfo7992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationInfo7992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getText7993;
		public override global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getText7993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getText7993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity7994;
		public override global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._resolveActivity7994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveActivity7994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable7995;
		public override global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getDrawable7995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getDrawable7995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getXml7996;
		public override global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getXml7996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getXml7996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _currentToCanonicalPackageNames7997;
		public override global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames7997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames7997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _canonicalToCurrentPackageNames7998;
		public override global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames7998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames7998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getLaunchIntentForPackage7999;
		public override global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getLaunchIntentForPackage7999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getLaunchIntentForPackage7999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageGids8000;
		public override int[] getPackageGids(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackageGids8000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageGids8000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionInfo8001;
		public override global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPermissionInfo8001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPermissionInfo8001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryPermissionsByGroup8002;
		public override global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryPermissionsByGroup8002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryPermissionsByGroup8002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionGroupInfo8003;
		public override global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPermissionGroupInfo8003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPermissionGroupInfo8003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAllPermissionGroups8004;
		public override global::java.util.List getAllPermissionGroups(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getAllPermissionGroups8004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getAllPermissionGroups8004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityInfo8005;
		public override global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getActivityInfo8005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityInfo8005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getReceiverInfo8006;
		public override global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getReceiverInfo8006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getReceiverInfo8006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo8007;
		public override global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getServiceInfo8007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getServiceInfo8007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledPackages8008;
		public override global::java.util.List getInstalledPackages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstalledPackages8008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstalledPackages8008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPermission8009;
		public override bool addPermission(android.content.pm.PermissionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPermission8009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPermission8009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPermissionAsync8010;
		public override bool addPermissionAsync(android.content.pm.PermissionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPermissionAsync8010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPermissionAsync8010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission8011;
		public override void removePermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._removePermission8011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._removePermission8011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures8012;
		public override int checkSignatures(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._checkSignatures8012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkSignatures8012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures8013;
		public override int checkSignatures(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._checkSignatures8013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkSignatures8013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackagesForUid8014;
		public override global::java.lang.String[] getPackagesForUid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackagesForUid8014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackagesForUid8014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getNameForUid8015;
		public override global::java.lang.String getNameForUid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getNameForUid8015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getNameForUid8015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledApplications8016;
		public override global::java.util.List getInstalledApplications(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstalledApplications8016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstalledApplications8016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		public new global::java.lang.String[] SystemSharedLibraryNames
		{
			get
			{
				return getSystemSharedLibraryNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemSharedLibraryNames8017;
		public override global::java.lang.String[] getSystemSharedLibraryNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames8017)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames8017)) as java.lang.String[];
		}
		public new global::android.content.pm.FeatureInfo[] SystemAvailableFeatures
		{
			get
			{
				return getSystemAvailableFeatures();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemAvailableFeatures8018;
		public override global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getSystemAvailableFeatures8018)) as android.content.pm.FeatureInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getSystemAvailableFeatures8018)) as android.content.pm.FeatureInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _hasSystemFeature8019;
		public override bool hasSystemFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._hasSystemFeature8019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._hasSystemFeature8019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivities8020;
		public override global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryIntentActivities8020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentActivities8020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivityOptions8021;
		public override global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryIntentActivityOptions8021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentActivityOptions8021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryBroadcastReceivers8022;
		public override global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryBroadcastReceivers8022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryBroadcastReceivers8022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveService8023;
		public override global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._resolveService8023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveService8023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentServices8024;
		public override global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryIntentServices8024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentServices8024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveContentProvider8025;
		public override global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._resolveContentProvider8025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveContentProvider8025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryContentProviders8026;
		public override global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryContentProviders8026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryContentProviders8026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getInstrumentationInfo8027;
		public override global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstrumentationInfo8027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstrumentationInfo8027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryInstrumentation8028;
		public override global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._queryInstrumentation8028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryInstrumentation8028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon8029;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getActivityIcon8029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityIcon8029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon8030;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getActivityIcon8030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityIcon8030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable DefaultActivityIcon
		{
			get
			{
				return getDefaultActivityIcon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultActivityIcon8031;
		public override global::android.graphics.drawable.Drawable getDefaultActivityIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getDefaultActivityIcon8031)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getDefaultActivityIcon8031)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon8032;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationIcon8032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationIcon8032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon8033;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationIcon8033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationIcon8033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationLabel8034;
		public override global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationLabel8034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationLabel8034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForActivity8035;
		public override global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getResourcesForActivity8035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForActivity8035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication8036;
		public override global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getResourcesForApplication8036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForApplication8036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication8037;
		public override global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getResourcesForApplication8037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForApplication8037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageArchiveInfo8038;
		public override global::android.content.pm.PackageInfo getPackageArchiveInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPackageArchiveInfo8038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageArchiveInfo8038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstallerPackageName8039;
		public override global::java.lang.String getInstallerPackageName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getInstallerPackageName8039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstallerPackageName8039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addPackageToPreferred8040;
		public override void addPackageToPreferred(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPackageToPreferred8040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPackageToPreferred8040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePackageFromPreferred8041;
		public override void removePackageFromPreferred(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._removePackageFromPreferred8041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._removePackageFromPreferred8041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredPackages8042;
		public override global::java.util.List getPreferredPackages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPreferredPackages8042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPreferredPackages8042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPreferredActivity8043;
		public override void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._addPreferredActivity8043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPreferredActivity8043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clearPackagePreferredActivities8044;
		public override void clearPackagePreferredActivities(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._clearPackagePreferredActivities8044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._clearPackagePreferredActivities8044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredActivities8045;
		public override int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getPreferredActivities8045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPreferredActivities8045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setComponentEnabledSetting8046;
		public override void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._setComponentEnabledSetting8046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._setComponentEnabledSetting8046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getComponentEnabledSetting8047;
		public override int getComponentEnabledSetting(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getComponentEnabledSetting8047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getComponentEnabledSetting8047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setApplicationEnabledSetting8048;
		public override void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._setApplicationEnabledSetting8048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._setApplicationEnabledSetting8048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationEnabledSetting8049;
		public override int getApplicationEnabledSetting(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._getApplicationEnabledSetting8049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationEnabledSetting8049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSafeMode8050;
		public override bool isSafeMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager._isSafeMode8050);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._isSafeMode8050);
		}
		internal static global::MonoJavaBridge.MethodId _MockPackageManager8051;
		public MockPackageManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._MockPackageManager8051);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockPackageManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockPackageManager"));
			global::android.test.mock.MockPackageManager._checkPermission7990 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._getPackageInfo7991 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.test.mock.MockPackageManager._getApplicationInfo7992 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;");
			global::android.test.mock.MockPackageManager._getText7993 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockPackageManager._resolveActivity7994 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.test.mock.MockPackageManager._getDrawable7995 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getXml7996 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames7997 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames7998 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getLaunchIntentForPackage7999 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.test.mock.MockPackageManager._getPackageGids8000 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageGids", "(Ljava/lang/String;)[I");
			global::android.test.mock.MockPackageManager._getPermissionInfo8001 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;");
			global::android.test.mock.MockPackageManager._queryPermissionsByGroup8002 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getPermissionGroupInfo8003 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;");
			global::android.test.mock.MockPackageManager._getAllPermissionGroups8004 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getActivityInfo8005 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.test.mock.MockPackageManager._getReceiverInfo8006 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.test.mock.MockPackageManager._getServiceInfo8007 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;");
			global::android.test.mock.MockPackageManager._getInstalledPackages8008 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstalledPackages", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._addPermission8009 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.test.mock.MockPackageManager._addPermissionAsync8010 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.test.mock.MockPackageManager._removePermission8011 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "removePermission", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._checkSignatures8012 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkSignatures", "(II)I");
			global::android.test.mock.MockPackageManager._checkSignatures8013 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._getPackagesForUid8014 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getNameForUid8015 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getNameForUid", "(I)Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getInstalledApplications8016 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstalledApplications", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames8017 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getSystemAvailableFeatures8018 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;");
			global::android.test.mock.MockPackageManager._hasSystemFeature8019 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z");
			global::android.test.mock.MockPackageManager._queryIntentActivities8020 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._queryIntentActivityOptions8021 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._queryBroadcastReceivers8022 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._resolveService8023 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.test.mock.MockPackageManager._queryIntentServices8024 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._resolveContentProvider8025 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;");
			global::android.test.mock.MockPackageManager._queryContentProviders8026 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getInstrumentationInfo8027 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;");
			global::android.test.mock.MockPackageManager._queryInstrumentation8028 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getActivityIcon8029 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getActivityIcon8030 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getDefaultActivityIcon8031 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationIcon8032 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationIcon8033 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationLabel8034 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockPackageManager._getResourcesForActivity8035 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getResourcesForApplication8036 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getResourcesForApplication8037 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getPackageArchiveInfo8038 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.test.mock.MockPackageManager._getInstallerPackageName8039 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._addPackageToPreferred8040 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._removePackageFromPreferred8041 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._getPreferredPackages8042 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPreferredPackages", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._addPreferredActivity8043 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V");
			global::android.test.mock.MockPackageManager._clearPackagePreferredActivities8044 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._getPreferredActivities8045 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._setComponentEnabledSetting8046 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V");
			global::android.test.mock.MockPackageManager._getComponentEnabledSetting8047 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I");
			global::android.test.mock.MockPackageManager._setApplicationEnabledSetting8048 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V");
			global::android.test.mock.MockPackageManager._getApplicationEnabledSetting8049 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._isSafeMode8050 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "isSafeMode", "()Z");
			global::android.test.mock.MockPackageManager._MockPackageManager8051 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "<init>", "()V");
		}
	}
}
