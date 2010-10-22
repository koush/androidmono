namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PackageInfo()
		{
			InitJNI();
		}
		protected PackageInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3736;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageInfo._toString3736)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._toString3736)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3737;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageInfo._writeToParcel3737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._writeToParcel3737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3738;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageInfo._describeContents3738);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._describeContents3738);
		}
		internal static global::MonoJavaBridge.MethodId _PackageInfo3739;
		public PackageInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._PackageInfo3739);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName3740;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName3740)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionCode3741;
		public int versionCode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _versionCode3741);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionName3742;
		public global::java.lang.String versionName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _versionName3742)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserId3743;
		public global::java.lang.String sharedUserId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sharedUserId3743)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserLabel3744;
		public int sharedUserLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _sharedUserLabel3744);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo3745;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _applicationInfo3745)) as android.content.pm.ApplicationInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gids3746;
		public int[] gids
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _gids3746)) as int[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _activities3747;
		public global::android.content.pm.ActivityInfo[] activities
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ActivityInfo>(@__env.GetObjectField(this.JvmHandle, _activities3747)) as android.content.pm.ActivityInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _receivers3748;
		public global::android.content.pm.ActivityInfo[] receivers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ActivityInfo>(@__env.GetObjectField(this.JvmHandle, _receivers3748)) as android.content.pm.ActivityInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _services3749;
		public global::android.content.pm.ServiceInfo[] services
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ServiceInfo>(@__env.GetObjectField(this.JvmHandle, _services3749)) as android.content.pm.ServiceInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _providers3750;
		public global::android.content.pm.ProviderInfo[] providers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ProviderInfo>(@__env.GetObjectField(this.JvmHandle, _providers3750)) as android.content.pm.ProviderInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _instrumentation3751;
		public global::android.content.pm.InstrumentationInfo[] instrumentation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.InstrumentationInfo>(@__env.GetObjectField(this.JvmHandle, _instrumentation3751)) as android.content.pm.InstrumentationInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permissions3752;
		public global::android.content.pm.PermissionInfo[] permissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PermissionInfo>(@__env.GetObjectField(this.JvmHandle, _permissions3752)) as android.content.pm.PermissionInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _requestedPermissions3753;
		public global::java.lang.String[] requestedPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _requestedPermissions3753)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _signatures3754;
		public global::android.content.pm.Signature[] signatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.Signature>(@__env.GetObjectField(this.JvmHandle, _signatures3754)) as android.content.pm.Signature[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _configPreferences3755;
		public global::android.content.pm.ConfigurationInfo[] configPreferences
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.ConfigurationInfo>(@__env.GetObjectField(this.JvmHandle, _configPreferences3755)) as android.content.pm.ConfigurationInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqFeatures3756;
		public global::android.content.pm.FeatureInfo[] reqFeatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.GetObjectField(this.JvmHandle, _reqFeatures3756)) as android.content.pm.FeatureInfo[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3757;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PackageInfo.staticClass, _CREATOR3757)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageInfo"));
			global::android.content.pm.PackageInfo._toString3736 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PackageInfo._writeToParcel3737 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageInfo._describeContents3738 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PackageInfo._PackageInfo3739 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PackageInfo._packageName3740 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._versionCode3741 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "versionCode", "I");
			global::android.content.pm.PackageInfo._versionName3742 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "versionName", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._sharedUserId3743 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "sharedUserId", "Ljava/lang/String;");
			global::android.content.pm.PackageInfo._sharedUserLabel3744 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "sharedUserLabel", "I");
			global::android.content.pm.PackageInfo._applicationInfo3745 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "applicationInfo", "Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.PackageInfo._gids3746 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "gids", "[I");
			global::android.content.pm.PackageInfo._activities3747 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "activities", "[Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageInfo._receivers3748 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "receivers", "[Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageInfo._services3749 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "services", "[Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.PackageInfo._providers3750 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "providers", "[Landroid/content/pm/ProviderInfo;");
			global::android.content.pm.PackageInfo._instrumentation3751 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "instrumentation", "[Landroid/content/pm/InstrumentationInfo;");
			global::android.content.pm.PackageInfo._permissions3752 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "permissions", "[Landroid/content/pm/PermissionInfo;");
			global::android.content.pm.PackageInfo._requestedPermissions3753 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "requestedPermissions", "[Ljava/lang/String;");
			global::android.content.pm.PackageInfo._signatures3754 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "signatures", "[Landroid/content/pm/Signature;");
			global::android.content.pm.PackageInfo._configPreferences3755 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "configPreferences", "[Landroid/content/pm/ConfigurationInfo;");
			global::android.content.pm.PackageInfo._reqFeatures3756 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "reqFeatures", "[Landroid/content/pm/FeatureInfo;");
			global::android.content.pm.PackageInfo._CREATOR3757 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
