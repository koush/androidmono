namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PackageInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3753;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageInfo._toString3753.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageInfo._toString3753 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._toString3753) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3754;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageInfo._writeToParcel3754.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageInfo._writeToParcel3754 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._writeToParcel3754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3755;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageInfo._describeContents3755.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageInfo._describeContents3755 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._describeContents3755);
		}
		internal static global::MonoJavaBridge.MethodId _PackageInfo3756;
		public PackageInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageInfo._PackageInfo3756.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageInfo._PackageInfo3756 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._PackageInfo3756);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName3757;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName3757)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionCode3758;
		public int versionCode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _versionCode3758);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionName3759;
		public global::java.lang.String versionName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _versionName3759)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserId3760;
		public global::java.lang.String sharedUserId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sharedUserId3760)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserLabel3761;
		public int sharedUserLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _sharedUserLabel3761);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo3762;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _applicationInfo3762)) as android.content.pm.ApplicationInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gids3763;
		public int[] gids
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _gids3763)) as int[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _activities3764;
		public global::android.content.pm.ActivityInfo[] activities
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ActivityInfo>(@__env.GetObjectField(this.JvmHandle, _activities3764)) as android.content.pm.ActivityInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _receivers3765;
		public global::android.content.pm.ActivityInfo[] receivers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ActivityInfo>(@__env.GetObjectField(this.JvmHandle, _receivers3765)) as android.content.pm.ActivityInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _services3766;
		public global::android.content.pm.ServiceInfo[] services
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ServiceInfo>(@__env.GetObjectField(this.JvmHandle, _services3766)) as android.content.pm.ServiceInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _providers3767;
		public global::android.content.pm.ProviderInfo[] providers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ProviderInfo>(@__env.GetObjectField(this.JvmHandle, _providers3767)) as android.content.pm.ProviderInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _instrumentation3768;
		public global::android.content.pm.InstrumentationInfo[] instrumentation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.InstrumentationInfo>(@__env.GetObjectField(this.JvmHandle, _instrumentation3768)) as android.content.pm.InstrumentationInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permissions3769;
		public global::android.content.pm.PermissionInfo[] permissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PermissionInfo>(@__env.GetObjectField(this.JvmHandle, _permissions3769)) as android.content.pm.PermissionInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _requestedPermissions3770;
		public global::java.lang.String[] requestedPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _requestedPermissions3770)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _signatures3771;
		public global::android.content.pm.Signature[] signatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.Signature>(@__env.GetObjectField(this.JvmHandle, _signatures3771)) as android.content.pm.Signature[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _configPreferences3772;
		public global::android.content.pm.ConfigurationInfo[] configPreferences
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ConfigurationInfo>(@__env.GetObjectField(this.JvmHandle, _configPreferences3772)) as android.content.pm.ConfigurationInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqFeatures3773;
		public global::android.content.pm.FeatureInfo[] reqFeatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.GetObjectField(this.JvmHandle, _reqFeatures3773)) as android.content.pm.FeatureInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3774;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PackageInfo.staticClass, _CREATOR3774)) as android.os.Parcelable_Creator;
			}
		}
		static PackageInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageInfo"));
			global::android.content.pm.PackageInfo._packageName3757 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._versionCode3758 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "versionCode", "I");
			global::android.content.pm.PackageInfo._versionName3759 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "versionName", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._sharedUserId3760 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "sharedUserId", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._sharedUserLabel3761 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "sharedUserLabel", "I");
			global::android.content.pm.PackageInfo._applicationInfo3762 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "applicationInfo", "Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.PackageInfo._gids3763 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "gids", "[I");
			global::android.content.pm.PackageInfo._activities3764 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "activities", "[Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageInfo._receivers3765 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "receivers", "[Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageInfo._services3766 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "services", "[Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.PackageInfo._providers3767 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "providers", "[Landroid/content/pm/ProviderInfo;");
			global::android.content.pm.PackageInfo._instrumentation3768 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "instrumentation", "[Landroid/content/pm/InstrumentationInfo;");
			global::android.content.pm.PackageInfo._permissions3769 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "permissions", "[Landroid/content/pm/PermissionInfo;");
			global::android.content.pm.PackageInfo._requestedPermissions3770 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "requestedPermissions", "[Ljava/lang/String;");
			global::android.content.pm.PackageInfo._signatures3771 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "signatures", "[Landroid/content/pm/Signature;");
			global::android.content.pm.PackageInfo._configPreferences3772 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "configPreferences", "[Landroid/content/pm/ConfigurationInfo;");
			global::android.content.pm.PackageInfo._reqFeatures3773 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "reqFeatures", "[Landroid/content/pm/FeatureInfo;");
			global::android.content.pm.PackageInfo._CREATOR3774 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
