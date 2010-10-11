namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ProviderInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProviderInfo()
		{
			InitJNI();
		}
		internal ProviderInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2141;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._toString2141)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._toString2141)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2142;
		public sealed override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._writeToParcel2142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._writeToParcel2142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2143;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._describeContents2143);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._describeContents2143);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderInfo2144;
		public ProviderInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._ProviderInfo2144);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderInfo2145;
		public ProviderInfo(android.content.pm.ProviderInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._ProviderInfo2145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority2146;
		public global::java.lang.String authority
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _readPermission2147;
		public global::java.lang.String readPermission
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _writePermission2148;
		public global::java.lang.String writePermission
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _grantUriPermissions2149;
		public bool grantUriPermissions
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _uriPermissionPatterns2150;
		public global::android.os.PatternMatcher[] uriPermissionPatterns
		{
			get
			{
				return default(global::android.os.PatternMatcher[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _pathPermissions2151;
		public global::android.content.pm.PathPermission[] pathPermissions
		{
			get
			{
				return default(global::android.content.pm.PathPermission[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _multiprocess2152;
		public bool multiprocess
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initOrder2153;
		public int initOrder
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isSyncable2154;
		public bool isSyncable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2155;
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
			global::android.content.pm.ProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ProviderInfo"));
			global::android.content.pm.ProviderInfo._toString2141 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._writeToParcel2142 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ProviderInfo._describeContents2143 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ProviderInfo._ProviderInfo2144 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ProviderInfo._ProviderInfo2145 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "(Landroid/content/pm/ProviderInfo;)V");
		}
	}
}
