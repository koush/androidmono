namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnrecoverableKeyException : java.security.UnrecoverableEntryException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnrecoverableKeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnrecoverableKeyException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.UnrecoverableKeyException._m0.native == global::System.IntPtr.Zero)
				global::java.security.UnrecoverableKeyException._m0 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableKeyException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableKeyException.staticClass, global::java.security.UnrecoverableKeyException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnrecoverableKeyException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.UnrecoverableKeyException._m1.native == global::System.IntPtr.Zero)
				global::java.security.UnrecoverableKeyException._m1 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableKeyException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableKeyException.staticClass, global::java.security.UnrecoverableKeyException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnrecoverableKeyException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnrecoverableKeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnrecoverableKeyException"));
		}
	}
}
