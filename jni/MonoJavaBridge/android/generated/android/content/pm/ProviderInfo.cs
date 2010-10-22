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
		internal static global::MonoJavaBridge.MethodId _toString3990;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._toString3990)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._toString3990)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3991;
		public sealed override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._writeToParcel3991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._writeToParcel3991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3992;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ProviderInfo._describeContents3992);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._describeContents3992);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderInfo3993;
		public ProviderInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._ProviderInfo3993);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderInfo3994;
		public ProviderInfo(android.content.pm.ProviderInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ProviderInfo.staticClass, global::android.content.pm.ProviderInfo._ProviderInfo3994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority3995;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority3995)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _readPermission3996;
		public global::java.lang.String readPermission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _readPermission3996)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _writePermission3997;
		public global::java.lang.String writePermission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _writePermission3997)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _grantUriPermissions3998;
		public bool grantUriPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _grantUriPermissions3998);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _uriPermissionPatterns3999;
		public global::android.os.PatternMatcher[] uriPermissionPatterns
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.PatternMatcher>(@__env.GetObjectField(this.JvmHandle, _uriPermissionPatterns3999)) as android.os.PatternMatcher[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _pathPermissions4000;
		public global::android.content.pm.PathPermission[] pathPermissions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PathPermission>(@__env.GetObjectField(this.JvmHandle, _pathPermissions4000)) as android.content.pm.PathPermission[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _multiprocess4001;
		public bool multiprocess
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _multiprocess4001);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initOrder4002;
		public int initOrder
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initOrder4002);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isSyncable4003;
		public bool isSyncable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isSyncable4003);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4004;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ProviderInfo.staticClass, _CREATOR4004)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ProviderInfo"));
			global::android.content.pm.ProviderInfo._toString3990 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._writeToParcel3991 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ProviderInfo._describeContents3992 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ProviderInfo._ProviderInfo3993 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ProviderInfo._ProviderInfo3994 = @__env.GetMethodIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "<init>", "(Landroid/content/pm/ProviderInfo;)V");
			global::android.content.pm.ProviderInfo._authority3995 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._readPermission3996 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "readPermission", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._writePermission3997 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "writePermission", "Ljava/lang/String;");
			global::android.content.pm.ProviderInfo._grantUriPermissions3998 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "grantUriPermissions", "Z");
			global::android.content.pm.ProviderInfo._uriPermissionPatterns3999 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "uriPermissionPatterns", "[Landroid/os/PatternMatcher;");
			global::android.content.pm.ProviderInfo._pathPermissions4000 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "pathPermissions", "[Landroid/content/pm/PathPermission;");
			global::android.content.pm.ProviderInfo._multiprocess4001 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "multiprocess", "Z");
			global::android.content.pm.ProviderInfo._initOrder4002 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "initOrder", "I");
			global::android.content.pm.ProviderInfo._isSyncable4003 = @__env.GetFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "isSyncable", "Z");
			global::android.content.pm.ProviderInfo._CREATOR4004 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ProviderInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
