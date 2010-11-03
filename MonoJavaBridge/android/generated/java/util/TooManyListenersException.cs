namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TooManyListenersException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TooManyListenersException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public TooManyListenersException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TooManyListenersException._m0.native == global::System.IntPtr.Zero)
				global::java.util.TooManyListenersException._m0 = @__env.GetMethodIDNoThrow(global::java.util.TooManyListenersException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TooManyListenersException.staticClass, global::java.util.TooManyListenersException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public TooManyListenersException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TooManyListenersException._m1.native == global::System.IntPtr.Zero)
				global::java.util.TooManyListenersException._m1 = @__env.GetMethodIDNoThrow(global::java.util.TooManyListenersException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TooManyListenersException.staticClass, global::java.util.TooManyListenersException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TooManyListenersException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TooManyListenersException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TooManyListenersException"));
		}
	}
}
