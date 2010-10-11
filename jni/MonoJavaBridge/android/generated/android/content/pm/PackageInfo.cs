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
		internal static global::MonoJavaBridge.MethodId _toString1940;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageInfo._toString1940)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._toString1940)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1941;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageInfo._writeToParcel1941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._writeToParcel1941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1942;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageInfo._describeContents1942);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._describeContents1942);
		}
		internal static global::MonoJavaBridge.MethodId _PackageInfo1943;
		public PackageInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._PackageInfo1943);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName1944;
		public global::java.lang.String packageName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionCode1945;
		public int versionCode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _versionName1946;
		public global::java.lang.String versionName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserId1947;
		public global::java.lang.String sharedUserId
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedUserLabel1948;
		public int sharedUserLabel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo1949;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				return default(global::android.content.pm.ApplicationInfo);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gids1950;
		public int[] gids
		{
			get
			{
				return default(int[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _activities1951;
		public global::android.content.pm.ActivityInfo[] activities
		{
			get
			{
				return default(global::android.content.pm.ActivityInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _receivers1952;
		public global::android.content.pm.ActivityInfo[] receivers
		{
			get
			{
				return default(global::android.content.pm.ActivityInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _services1953;
		public global::android.content.pm.ServiceInfo[] services
		{
			get
			{
				return default(global::android.content.pm.ServiceInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _providers1954;
		public global::android.content.pm.ProviderInfo[] providers
		{
			get
			{
				return default(global::android.content.pm.ProviderInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _instrumentation1955;
		public global::android.content.pm.InstrumentationInfo[] instrumentation
		{
			get
			{
				return default(global::android.content.pm.InstrumentationInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permissions1956;
		public global::android.content.pm.PermissionInfo[] permissions
		{
			get
			{
				return default(global::android.content.pm.PermissionInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _requestedPermissions1957;
		public global::java.lang.String[] requestedPermissions
		{
			get
			{
				return default(global::java.lang.String[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _signatures1958;
		public global::android.content.pm.Signature[] signatures
		{
			get
			{
				return default(global::android.content.pm.Signature[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _configPreferences1959;
		public global::android.content.pm.ConfigurationInfo[] configPreferences
		{
			get
			{
				return default(global::android.content.pm.ConfigurationInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqFeatures1960;
		public global::android.content.pm.FeatureInfo[] reqFeatures
		{
			get
			{
				return default(global::android.content.pm.FeatureInfo[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1961;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageInfo"));
			global::android.content.pm.PackageInfo._toString1940 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PackageInfo._writeToParcel1941 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageInfo._describeContents1942 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PackageInfo._PackageInfo1943 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageInfo.staticClass, "<init>", "()V");
		}
	}
}
