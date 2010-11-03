namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidMarkException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidMarkException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InvalidMarkException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.InvalidMarkException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.InvalidMarkException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.InvalidMarkException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.InvalidMarkException.staticClass, global::java.nio.InvalidMarkException._m0);
			Init(@__env, handle);
		}
		static InvalidMarkException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.InvalidMarkException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/InvalidMarkException"));
		}
	}
}
