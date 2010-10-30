namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PermissionInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PermissionInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3992;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._toString3992.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._toString3992 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._toString3992) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3993;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._writeToParcel3993.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._writeToParcel3993 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._writeToParcel3993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3994;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._describeContents3994.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._describeContents3994 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._describeContents3994);
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription3995;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._loadDescription3995.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._loadDescription3995 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._loadDescription3995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _PermissionInfo3996;
		public PermissionInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._PermissionInfo3996.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._PermissionInfo3996 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._PermissionInfo3996);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionInfo3997;
		public PermissionInfo(android.content.pm.PermissionInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionInfo._PermissionInfo3997.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionInfo._PermissionInfo3997 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._PermissionInfo3997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _group4002;
		public global::java.lang.String group
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _group4002)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes4003;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes4003);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedDescription4004;
		public global::java.lang.CharSequence nonLocalizedDescription
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedDescription4004)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _protectionLevel4005;
		public int protectionLevel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _protectionLevel4005);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4006;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PermissionInfo.staticClass, _CREATOR4006)) as android.os.Parcelable_Creator;
			}
		}
		static PermissionInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PermissionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PermissionInfo"));
			global::android.content.pm.PermissionInfo._group4002 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "group", "Ljava/lang/String;");
			global::android.content.pm.PermissionInfo._descriptionRes4003 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.PermissionInfo._nonLocalizedDescription4004 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "nonLocalizedDescription", "Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionInfo._protectionLevel4005 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "protectionLevel", "I");
			global::android.content.pm.PermissionInfo._CREATOR4006 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
