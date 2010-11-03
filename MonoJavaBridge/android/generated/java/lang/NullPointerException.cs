namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NullPointerException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NullPointerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NullPointerException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NullPointerException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.NullPointerException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.NullPointerException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NullPointerException.staticClass, global::java.lang.NullPointerException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NullPointerException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NullPointerException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.NullPointerException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.NullPointerException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NullPointerException.staticClass, global::java.lang.NullPointerException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NullPointerException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NullPointerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NullPointerException"));
		}
	}
}
