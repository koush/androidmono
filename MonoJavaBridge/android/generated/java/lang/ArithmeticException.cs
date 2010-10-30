namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArithmeticException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ArithmeticException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ArithmeticException19710;
		public ArithmeticException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ArithmeticException._ArithmeticException19710.native == global::System.IntPtr.Zero)
				global::java.lang.ArithmeticException._ArithmeticException19710 = @__env.GetMethodIDNoThrow(global::java.lang.ArithmeticException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArithmeticException.staticClass, global::java.lang.ArithmeticException._ArithmeticException19710);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArithmeticException19711;
		public ArithmeticException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ArithmeticException._ArithmeticException19711.native == global::System.IntPtr.Zero)
				global::java.lang.ArithmeticException._ArithmeticException19711 = @__env.GetMethodIDNoThrow(global::java.lang.ArithmeticException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArithmeticException.staticClass, global::java.lang.ArithmeticException._ArithmeticException19711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ArithmeticException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ArithmeticException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ArithmeticException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
