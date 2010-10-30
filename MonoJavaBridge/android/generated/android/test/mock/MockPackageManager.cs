namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockPackageManager : android.content.pm.PackageManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MockPackageManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission12526;
		public override int checkPermission(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkPermission12526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackageInfo12527;
		public override global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageInfo12527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo12528;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationInfo12528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getText12529;
		public override global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getText12529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity12530;
		public override global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveActivity12530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable12531;
		public override global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getDrawable12531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getXml12532;
		public override global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getXml12532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _currentToCanonicalPackageNames12533;
		public override global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames12533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _canonicalToCurrentPackageNames12534;
		public override global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames12534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getLaunchIntentForPackage12535;
		public override global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getLaunchIntentForPackage12535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageGids12536;
		public override int[] getPackageGids(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageGids12536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionInfo12537;
		public override global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPermissionInfo12537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryPermissionsByGroup12538;
		public override global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryPermissionsByGroup12538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionGroupInfo12539;
		public override global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPermissionGroupInfo12539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAllPermissionGroups12540;
		public override global::java.util.List getAllPermissionGroups(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getAllPermissionGroups12540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityInfo12541;
		public override global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityInfo12541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getReceiverInfo12542;
		public override global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getReceiverInfo12542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo12543;
		public override global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getServiceInfo12543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledPackages12544;
		public override global::java.util.List getInstalledPackages(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstalledPackages12544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPermission12545;
		public override bool addPermission(android.content.pm.PermissionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPermission12545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPermissionAsync12546;
		public override bool addPermissionAsync(android.content.pm.PermissionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPermissionAsync12546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission12547;
		public override void removePermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._removePermission12547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures12548;
		public override int checkSignatures(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkSignatures12548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures12549;
		public override int checkSignatures(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._checkSignatures12549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackagesForUid12550;
		public override global::java.lang.String[] getPackagesForUid(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackagesForUid12550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getNameForUid12551;
		public override global::java.lang.String getNameForUid(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getNameForUid12551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledApplications12552;
		public override global::java.util.List getInstalledApplications(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstalledApplications12552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		public new global::java.lang.String[] SystemSharedLibraryNames
		{
			get
			{
				return getSystemSharedLibraryNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemSharedLibraryNames12553;
		public override global::java.lang.String[] getSystemSharedLibraryNames()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames12553)) as java.lang.String[];
		}
		public new global::android.content.pm.FeatureInfo[] SystemAvailableFeatures
		{
			get
			{
				return getSystemAvailableFeatures();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemAvailableFeatures12554;
		public override global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getSystemAvailableFeatures12554)) as android.content.pm.FeatureInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _hasSystemFeature12555;
		public override bool hasSystemFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._hasSystemFeature12555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivities12556;
		public override global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentActivities12556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivityOptions12557;
		public override global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentActivityOptions12557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryBroadcastReceivers12558;
		public override global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryBroadcastReceivers12558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveService12559;
		public override global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveService12559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentServices12560;
		public override global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryIntentServices12560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveContentProvider12561;
		public override global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.pm.ProviderInfo>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._resolveContentProvider12561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryContentProviders12562;
		public override global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryContentProviders12562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getInstrumentationInfo12563;
		public override global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstrumentationInfo12563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryInstrumentation12564;
		public override global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._queryInstrumentation12564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon12565;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityIcon12565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon12566;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getActivityIcon12566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable DefaultActivityIcon
		{
			get
			{
				return getDefaultActivityIcon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultActivityIcon12567;
		public override global::android.graphics.drawable.Drawable getDefaultActivityIcon()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getDefaultActivityIcon12567)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon12568;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationIcon12568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon12569;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationIcon12569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationLabel12570;
		public override global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationLabel12570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForActivity12571;
		public override global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForActivity12571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication12572;
		public override global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForApplication12572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication12573;
		public override global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getResourcesForApplication12573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageArchiveInfo12574;
		public override global::android.content.pm.PackageInfo getPackageArchiveInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPackageArchiveInfo12574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstallerPackageName12575;
		public override global::java.lang.String getInstallerPackageName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getInstallerPackageName12575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addPackageToPreferred12576;
		public override void addPackageToPreferred(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPackageToPreferred12576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePackageFromPreferred12577;
		public override void removePackageFromPreferred(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._removePackageFromPreferred12577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredPackages12578;
		public override global::java.util.List getPreferredPackages(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPreferredPackages12578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPreferredActivity12579;
		public override void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._addPreferredActivity12579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clearPackagePreferredActivities12580;
		public override void clearPackagePreferredActivities(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._clearPackagePreferredActivities12580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredActivities12581;
		public override int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getPreferredActivities12581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setComponentEnabledSetting12582;
		public override void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._setComponentEnabledSetting12582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getComponentEnabledSetting12583;
		public override int getComponentEnabledSetting(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getComponentEnabledSetting12583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setApplicationEnabledSetting12584;
		public override void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._setApplicationEnabledSetting12584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationEnabledSetting12585;
		public override int getApplicationEnabledSetting(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._getApplicationEnabledSetting12585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSafeMode12586;
		public override bool isSafeMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._isSafeMode12586);
		}
		internal static global::MonoJavaBridge.MethodId _MockPackageManager12587;
		public MockPackageManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockPackageManager.staticClass, global::android.test.mock.MockPackageManager._MockPackageManager12587);
			Init(@__env, handle);
		}
		static MockPackageManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockPackageManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockPackageManager"));
			global::android.test.mock.MockPackageManager._checkPermission12526 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._getPackageInfo12527 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.test.mock.MockPackageManager._getApplicationInfo12528 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;");
			global::android.test.mock.MockPackageManager._getText12529 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockPackageManager._resolveActivity12530 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.test.mock.MockPackageManager._getDrawable12531 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getXml12532 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockPackageManager._currentToCanonicalPackageNames12533 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._canonicalToCurrentPackageNames12534 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getLaunchIntentForPackage12535 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.test.mock.MockPackageManager._getPackageGids12536 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageGids", "(Ljava/lang/String;)[I");
			global::android.test.mock.MockPackageManager._getPermissionInfo12537 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;");
			global::android.test.mock.MockPackageManager._queryPermissionsByGroup12538 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getPermissionGroupInfo12539 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;");
			global::android.test.mock.MockPackageManager._getAllPermissionGroups12540 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getActivityInfo12541 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.test.mock.MockPackageManager._getReceiverInfo12542 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.test.mock.MockPackageManager._getServiceInfo12543 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;");
			global::android.test.mock.MockPackageManager._getInstalledPackages12544 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstalledPackages", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._addPermission12545 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.test.mock.MockPackageManager._addPermissionAsync12546 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.test.mock.MockPackageManager._removePermission12547 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "removePermission", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._checkSignatures12548 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkSignatures", "(II)I");
			global::android.test.mock.MockPackageManager._checkSignatures12549 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._getPackagesForUid12550 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getNameForUid12551 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getNameForUid", "(I)Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getInstalledApplications12552 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstalledApplications", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getSystemSharedLibraryNames12553 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._getSystemAvailableFeatures12554 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;");
			global::android.test.mock.MockPackageManager._hasSystemFeature12555 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z");
			global::android.test.mock.MockPackageManager._queryIntentActivities12556 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._queryIntentActivityOptions12557 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._queryBroadcastReceivers12558 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._resolveService12559 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.test.mock.MockPackageManager._queryIntentServices12560 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._resolveContentProvider12561 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;");
			global::android.test.mock.MockPackageManager._queryContentProviders12562 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getInstrumentationInfo12563 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;");
			global::android.test.mock.MockPackageManager._queryInstrumentation12564 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._getActivityIcon12565 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getActivityIcon12566 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getDefaultActivityIcon12567 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationIcon12568 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationIcon12569 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockPackageManager._getApplicationLabel12570 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockPackageManager._getResourcesForActivity12571 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getResourcesForApplication12572 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getResourcesForApplication12573 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;");
			global::android.test.mock.MockPackageManager._getPackageArchiveInfo12574 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.test.mock.MockPackageManager._getInstallerPackageName12575 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.test.mock.MockPackageManager._addPackageToPreferred12576 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._removePackageFromPreferred12577 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._getPreferredPackages12578 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPreferredPackages", "(I)Ljava/util/List;");
			global::android.test.mock.MockPackageManager._addPreferredActivity12579 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V");
			global::android.test.mock.MockPackageManager._clearPackagePreferredActivities12580 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V");
			global::android.test.mock.MockPackageManager._getPreferredActivities12581 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._setComponentEnabledSetting12582 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V");
			global::android.test.mock.MockPackageManager._getComponentEnabledSetting12583 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I");
			global::android.test.mock.MockPackageManager._setApplicationEnabledSetting12584 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V");
			global::android.test.mock.MockPackageManager._getApplicationEnabledSetting12585 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I");
			global::android.test.mock.MockPackageManager._isSafeMode12586 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "isSafeMode", "()Z");
			global::android.test.mock.MockPackageManager._MockPackageManager12587 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockPackageManager.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
