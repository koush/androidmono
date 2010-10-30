namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Error : java.lang.Throwable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Error(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _Error20129;
		public Error() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Error._Error20129.native == global::System.IntPtr.Zero)
				global::java.lang.Error._Error20129 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20129);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error20130;
		public Error(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Error._Error20130.native == global::System.IntPtr.Zero)
				global::java.lang.Error._Error20130 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error20131;
		public Error(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Error._Error20131.native == global::System.IntPtr.Zero)
				global::java.lang.Error._Error20131 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error20132;
		public Error(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Error._Error20132.native == global::System.IntPtr.Zero)
				global::java.lang.Error._Error20132 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Error()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Error.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Error"));
		}
		internal static void InitJNI()
		{
		}
	}
}
