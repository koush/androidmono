namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PermissionGroupInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PermissionGroupInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PermissionGroupInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.PermissionGroupInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PermissionGroupInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.PermissionGroupInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PermissionGroupInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.PermissionGroupInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.PermissionGroupInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.PermissionGroupInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PermissionGroupInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionGroupInfo._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionGroupInfo._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PermissionGroupInfo(android.content.pm.PermissionGroupInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionGroupInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionGroupInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionGroupInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes2091;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes2091);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedDescription2092;
		public global::java.lang.CharSequence nonLocalizedDescription
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedDescription2092)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2093;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PermissionGroupInfo.staticClass, _CREATOR2093)) as android.os.Parcelable_Creator;
			}
		}
		static PermissionGroupInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PermissionGroupInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PermissionGroupInfo"));
			global::android.content.pm.PermissionGroupInfo._descriptionRes2091 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.PermissionGroupInfo._nonLocalizedDescription2092 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "nonLocalizedDescription", "Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionGroupInfo._CREATOR2093 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
