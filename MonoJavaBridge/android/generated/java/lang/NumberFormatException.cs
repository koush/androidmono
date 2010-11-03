namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NumberFormatException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NumberFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NumberFormatException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NumberFormatException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.NumberFormatException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.NumberFormatException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NumberFormatException.staticClass, global::java.lang.NumberFormatException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NumberFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NumberFormatException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.NumberFormatException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.NumberFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NumberFormatException.staticClass, global::java.lang.NumberFormatException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NumberFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NumberFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NumberFormatException"));
		}
	}
}
