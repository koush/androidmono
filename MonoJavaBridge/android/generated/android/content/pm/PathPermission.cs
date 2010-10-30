namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathPermission : android.os.PatternMatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PathPermission.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.PathPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String ReadPermission
		{
			get
			{
				return getReadPermission();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getReadPermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PathPermission.staticClass, "getReadPermission", "()Ljava/lang/String;", ref global::android.content.pm.PathPermission._m1) as java.lang.String;
		}
		public new global::java.lang.String WritePermission
		{
			get
			{
				return getWritePermission();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getWritePermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PathPermission.staticClass, "getWritePermission", "()Ljava/lang/String;", ref global::android.content.pm.PathPermission._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PathPermission(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PathPermission._m3.native == global::System.IntPtr.Zero)
				global::android.content.pm.PathPermission._m3 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PathPermission(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PathPermission._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.PathPermission._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2090;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PathPermission.staticClass, _CREATOR2090)) as android.os.Parcelable_Creator;
			}
		}
		static PathPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PathPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PathPermission"));
			global::android.content.pm.PathPermission._CREATOR2090 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PathPermission.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
