namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstantiationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InstantiationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InstantiationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.InstantiationException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.InstantiationException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationException.staticClass, global::java.lang.InstantiationException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InstantiationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.InstantiationException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.InstantiationException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationException.staticClass, global::java.lang.InstantiationException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InstantiationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InstantiationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InstantiationException"));
		}
	}
}
