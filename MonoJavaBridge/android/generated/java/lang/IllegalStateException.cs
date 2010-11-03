namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalStateException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalStateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public IllegalStateException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public IllegalStateException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public IllegalStateException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public IllegalStateException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._m3.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._m3 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalStateException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalStateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalStateException"));
		}
	}
}
