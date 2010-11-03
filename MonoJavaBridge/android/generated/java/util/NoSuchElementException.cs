namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchElementException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchElementException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoSuchElementException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.NoSuchElementException._m0.native == global::System.IntPtr.Zero)
				global::java.util.NoSuchElementException._m0 = @__env.GetMethodIDNoThrow(global::java.util.NoSuchElementException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.NoSuchElementException.staticClass, global::java.util.NoSuchElementException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoSuchElementException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.NoSuchElementException._m1.native == global::System.IntPtr.Zero)
				global::java.util.NoSuchElementException._m1 = @__env.GetMethodIDNoThrow(global::java.util.NoSuchElementException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.NoSuchElementException.staticClass, global::java.util.NoSuchElementException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchElementException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.NoSuchElementException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/NoSuchElementException"));
		}
	}
}
