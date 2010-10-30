namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstantiationError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InstantiationError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InstantiationError20191;
		public InstantiationError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.InstantiationError._InstantiationError20191.native == global::System.IntPtr.Zero)
				global::java.lang.InstantiationError._InstantiationError20191 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationError.staticClass, global::java.lang.InstantiationError._InstantiationError20191);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstantiationError20192;
		public InstantiationError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.InstantiationError._InstantiationError20192.native == global::System.IntPtr.Zero)
				global::java.lang.InstantiationError._InstantiationError20192 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationError.staticClass, global::java.lang.InstantiationError._InstantiationError20192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InstantiationError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InstantiationError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InstantiationError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
