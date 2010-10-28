namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ProviderInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProviderInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4007;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._toString4007)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._toString4007)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4008;
		public sealed override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._writeToParcel4008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._writeToParcel4008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4009;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._describeContents4009);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._describeContents4009);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderInfo4010;
		public ProviderInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._ProviderInfo4010);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderInfo4011;
		public ProviderInfo(android.content.pm.ProviderInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._ProviderInfo4011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority4012;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority4012)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _readPermission4013;
		public global::java.lang.String readPermission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _readPermission4013)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _writePermission4014;
		public global::java.lang.String writePermission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _writePermission4014)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _grantUriPermissions4015;
		public bool grantUriPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _grantUriPermissions4015);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _uriPermissionPatterns4016;
		public global::android.os.PatternMatcher[] uriPermissionPatterns
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.PatternMatcher>(@__env.GetObjectField(this.JvmHandle, _uriPermissionPatterns4016)) as android.os.PatternMatcher[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _pathPermissions4017;
		public global::android.content.pm.PathPermission[] pathPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PathPermission>(@__env.GetObjectField(this.JvmHandle, _pathPermissions4017)) as android.content.pm.PathPermission[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _multiprocess4018;
		public bool multiprocess
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _multiprocess4018);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initOrder4019;
		public int initOrder
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initOrder4019);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isSyncable4020;
		public bool isSyncable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isSyncable4020);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4021;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ProviderInfo.staticClass, _CREATOR4021)) as android.os.Parcelable_Creator;
			}
		}
		static ProviderInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ProviderInfo"));
			global::android.content.pm.ProviderInfo._toString4007 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._writeToParcel4008 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ProviderInfo._describeContents4009 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ProviderInfo._ProviderInfo4010 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ProviderInfo._ProviderInfo4011 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "(Landroid/content/pm/ProviderInfo;)V");
			global::android.content.pm.ProviderInfo._authority4012 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._readPermission4013 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "readPermission", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._writePermission4014 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "writePermission", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._grantUriPermissions4015 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "grantUriPermissions", "Z");
			global::android.content.pm.ProviderInfo._uriPermissionPatterns4016 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "uriPermissionPatterns", "[Landroid/os/PatternMatcher;");
			global::android.content.pm.ProviderInfo._pathPermissions4017 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "pathPermissions", "[Landroid/content/pm/PathPermission;");
			global::android.content.pm.ProviderInfo._multiprocess4018 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "multiprocess", "Z");
			global::android.content.pm.ProviderInfo._initOrder4019 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "initOrder", "I");
			global::android.content.pm.ProviderInfo._isSyncable4020 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "isSyncable", "Z");
			global::android.content.pm.ProviderInfo._CREATOR4021 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
