namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ProviderInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProviderInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ProviderInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.ProviderInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.ProviderInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ProviderInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.ProviderInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ProviderInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ProviderInfo._m3.native == global::System.IntPtr.Zero)
				global::android.content.pm.ProviderInfo._m3 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._m3);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ProviderInfo(android.content.pm.ProviderInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ProviderInfo._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.ProviderInfo._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "(Landroid/content/pm/ProviderInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority2103;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority2103)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _readPermission2104;
		public global::java.lang.String readPermission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _readPermission2104)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _writePermission2105;
		public global::java.lang.String writePermission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _writePermission2105)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _grantUriPermissions2106;
		public bool grantUriPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _grantUriPermissions2106);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _uriPermissionPatterns2107;
		public global::android.os.PatternMatcher[] uriPermissionPatterns
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.PatternMatcher>(@__env.GetObjectField(this.JvmHandle, _uriPermissionPatterns2107)) as android.os.PatternMatcher[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _pathPermissions2108;
		public global::android.content.pm.PathPermission[] pathPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PathPermission>(@__env.GetObjectField(this.JvmHandle, _pathPermissions2108)) as android.content.pm.PathPermission[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _multiprocess2109;
		public bool multiprocess
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _multiprocess2109);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initOrder2110;
		public int initOrder
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initOrder2110);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isSyncable2111;
		public bool isSyncable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isSyncable2111);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2112;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ProviderInfo.staticClass, _CREATOR2112)) as android.os.Parcelable_Creator;
			}
		}
		static ProviderInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ProviderInfo"));
			global::android.content.pm.ProviderInfo._authority2103 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._readPermission2104 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "readPermission", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._writePermission2105 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "writePermission", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._grantUriPermissions2106 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "grantUriPermissions", "Z");
			global::android.content.pm.ProviderInfo._uriPermissionPatterns2107 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "uriPermissionPatterns", "[Landroid/os/PatternMatcher;");
			global::android.content.pm.ProviderInfo._pathPermissions2108 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "pathPermissions", "[Landroid/content/pm/PathPermission;");
			global::android.content.pm.ProviderInfo._multiprocess2109 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "multiprocess", "Z");
			global::android.content.pm.ProviderInfo._initOrder2110 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "initOrder", "I");
			global::android.content.pm.ProviderInfo._isSyncable2111 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "isSyncable", "Z");
			global::android.content.pm.ProviderInfo._CREATOR2112 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
