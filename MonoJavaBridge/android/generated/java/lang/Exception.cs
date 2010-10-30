namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Exception : java.lang.Throwable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Exception(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _Exception20133;
		public Exception() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Exception._Exception20133.native == global::System.IntPtr.Zero)
				global::java.lang.Exception._Exception20133 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception20133);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Exception20134;
		public Exception(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Exception._Exception20134.native == global::System.IntPtr.Zero)
				global::java.lang.Exception._Exception20134 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception20134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Exception20135;
		public Exception(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Exception._Exception20135.native == global::System.IntPtr.Zero)
				global::java.lang.Exception._Exception20135 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception20135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Exception20136;
		public Exception(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Exception._Exception20136.native == global::System.IntPtr.Zero)
				global::java.lang.Exception._Exception20136 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception20136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Exception()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Exception.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Exception"));
		}
		internal static void InitJNI()
		{
		}
	}
}
