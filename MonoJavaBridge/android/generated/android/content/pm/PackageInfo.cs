namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PackageInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PackageInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.PackageInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.PackageInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.PackageInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PackageInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageInfo._m3.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageInfo._m3 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._m3);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName2012;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName2012)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionCode2013;
		public int versionCode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _versionCode2013);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionName2014;
		public global::java.lang.String versionName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _versionName2014)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserId2015;
		public global::java.lang.String sharedUserId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sharedUserId2015)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserLabel2016;
		public int sharedUserLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _sharedUserLabel2016);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo2017;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _applicationInfo2017)) as android.content.pm.ApplicationInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gids2018;
		public int[] gids
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _gids2018)) as int[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _activities2019;
		public global::android.content.pm.ActivityInfo[] activities
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ActivityInfo>(@__env.GetObjectField(this.JvmHandle, _activities2019)) as android.content.pm.ActivityInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _receivers2020;
		public global::android.content.pm.ActivityInfo[] receivers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ActivityInfo>(@__env.GetObjectField(this.JvmHandle, _receivers2020)) as android.content.pm.ActivityInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _services2021;
		public global::android.content.pm.ServiceInfo[] services
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ServiceInfo>(@__env.GetObjectField(this.JvmHandle, _services2021)) as android.content.pm.ServiceInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _providers2022;
		public global::android.content.pm.ProviderInfo[] providers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ProviderInfo>(@__env.GetObjectField(this.JvmHandle, _providers2022)) as android.content.pm.ProviderInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _instrumentation2023;
		public global::android.content.pm.InstrumentationInfo[] instrumentation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.InstrumentationInfo>(@__env.GetObjectField(this.JvmHandle, _instrumentation2023)) as android.content.pm.InstrumentationInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permissions2024;
		public global::android.content.pm.PermissionInfo[] permissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PermissionInfo>(@__env.GetObjectField(this.JvmHandle, _permissions2024)) as android.content.pm.PermissionInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _requestedPermissions2025;
		public global::java.lang.String[] requestedPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _requestedPermissions2025)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _signatures2026;
		public global::android.content.pm.Signature[] signatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.Signature>(@__env.GetObjectField(this.JvmHandle, _signatures2026)) as android.content.pm.Signature[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _configPreferences2027;
		public global::android.content.pm.ConfigurationInfo[] configPreferences
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ConfigurationInfo>(@__env.GetObjectField(this.JvmHandle, _configPreferences2027)) as android.content.pm.ConfigurationInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqFeatures2028;
		public global::android.content.pm.FeatureInfo[] reqFeatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.GetObjectField(this.JvmHandle, _reqFeatures2028)) as android.content.pm.FeatureInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2029;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PackageInfo.staticClass, _CREATOR2029)) as android.os.Parcelable_Creator;
			}
		}
		static PackageInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageInfo"));
			global::android.content.pm.PackageInfo._packageName2012 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._versionCode2013 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "versionCode", "I");
			global::android.content.pm.PackageInfo._versionName2014 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "versionName", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._sharedUserId2015 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "sharedUserId", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._sharedUserLabel2016 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "sharedUserLabel", "I");
			global::android.content.pm.PackageInfo._applicationInfo2017 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "applicationInfo", "Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.PackageInfo._gids2018 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "gids", "[I");
			global::android.content.pm.PackageInfo._activities2019 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "activities", "[Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageInfo._receivers2020 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "receivers", "[Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageInfo._services2021 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "services", "[Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.PackageInfo._providers2022 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "providers", "[Landroid/content/pm/ProviderInfo;");
			global::android.content.pm.PackageInfo._instrumentation2023 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "instrumentation", "[Landroid/content/pm/InstrumentationInfo;");
			global::android.content.pm.PackageInfo._permissions2024 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "permissions", "[Landroid/content/pm/PermissionInfo;");
			global::android.content.pm.PackageInfo._requestedPermissions2025 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "requestedPermissions", "[Ljava/lang/String;");
			global::android.content.pm.PackageInfo._signatures2026 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "signatures", "[Landroid/content/pm/Signature;");
			global::android.content.pm.PackageInfo._configPreferences2027 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "configPreferences", "[Landroid/content/pm/ConfigurationInfo;");
			global::android.content.pm.PackageInfo._reqFeatures2028 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "reqFeatures", "[Landroid/content/pm/FeatureInfo;");
			global::android.content.pm.PackageInfo._CREATOR2029 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
