namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DestroyFailedException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DestroyFailedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DestroyFailedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.DestroyFailedException._m0.native == global::System.IntPtr.Zero)
				global::javax.security.auth.DestroyFailedException._m0 = @__env.GetMethodIDNoThrow(global::javax.security.auth.DestroyFailedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.DestroyFailedException.staticClass, global::javax.security.auth.DestroyFailedException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DestroyFailedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.DestroyFailedException._m1.native == global::System.IntPtr.Zero)
				global::javax.security.auth.DestroyFailedException._m1 = @__env.GetMethodIDNoThrow(global::javax.security.auth.DestroyFailedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.DestroyFailedException.staticClass, global::javax.security.auth.DestroyFailedException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DestroyFailedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.DestroyFailedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/DestroyFailedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
