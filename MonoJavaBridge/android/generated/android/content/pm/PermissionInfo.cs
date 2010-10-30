namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PermissionInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PermissionInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PermissionInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.PermissionInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PermissionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.PermissionInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PermissionInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.PermissionInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.PermissionInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.PermissionInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PermissionInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PermissionInfo(android.content.pm.PermissionInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int PROTECTION_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int PROTECTION_DANGEROUS
		{
			get
			{
				return 1;
			}
		}
		public static int PROTECTION_SIGNATURE
		{
			get
			{
				return 2;
			}
		}
		public static int PROTECTION_SIGNATURE_OR_SYSTEM
		{
			get
			{
				return 3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _group2098;
		public global::java.lang.String group
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _group2098)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes2099;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes2099);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedDescription2100;
		public global::java.lang.CharSequence nonLocalizedDescription
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedDescription2100)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _protectionLevel2101;
		public int protectionLevel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _protectionLevel2101);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2102;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PermissionInfo.staticClass, _CREATOR2102)) as android.os.Parcelable_Creator;
			}
		}
		static PermissionInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PermissionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PermissionInfo"));
			global::android.content.pm.PermissionInfo._group2098 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "group", "Ljava/lang/String;");
			global::android.content.pm.PermissionInfo._descriptionRes2099 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.PermissionInfo._nonLocalizedDescription2100 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "nonLocalizedDescription", "Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionInfo._protectionLevel2101 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "protectionLevel", "I");
			global::android.content.pm.PermissionInfo._CREATOR2102 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
