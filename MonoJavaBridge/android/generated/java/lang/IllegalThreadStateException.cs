namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalThreadStateException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalThreadStateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalThreadStateException20183;
		public IllegalThreadStateException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalThreadStateException._IllegalThreadStateException20183.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalThreadStateException._IllegalThreadStateException20183 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalThreadStateException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalThreadStateException.staticClass, global::java.lang.IllegalThreadStateException._IllegalThreadStateException20183);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalThreadStateException20184;
		public IllegalThreadStateException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalThreadStateException._IllegalThreadStateException20184.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalThreadStateException._IllegalThreadStateException20184 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalThreadStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalThreadStateException.staticClass, global::java.lang.IllegalThreadStateException._IllegalThreadStateException20184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalThreadStateException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalThreadStateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalThreadStateException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
