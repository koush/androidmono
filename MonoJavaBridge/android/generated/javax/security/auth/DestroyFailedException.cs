namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DestroyFailedException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DestroyFailedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DestroyFailedException30165;
		public DestroyFailedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.DestroyFailedException.staticClass, global::javax.security.auth.DestroyFailedException._DestroyFailedException30165);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DestroyFailedException30166;
		public DestroyFailedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.DestroyFailedException.staticClass, global::javax.security.auth.DestroyFailedException._DestroyFailedException30166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DestroyFailedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.DestroyFailedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/DestroyFailedException"));
			global::javax.security.auth.DestroyFailedException._DestroyFailedException30165 = @__env.GetMethodIDNoThrow(global::javax.security.auth.DestroyFailedException.staticClass, "<init>", "()V");
			global::javax.security.auth.DestroyFailedException._DestroyFailedException30166 = @__env.GetMethodIDNoThrow(global::javax.security.auth.DestroyFailedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
