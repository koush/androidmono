namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchAlgorithmException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchAlgorithmException()
		{
			InitJNI();
		}
		protected NoSuchAlgorithmException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException23196;
		public NoSuchAlgorithmException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23196);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException23197;
		public NoSuchAlgorithmException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException23198;
		public NoSuchAlgorithmException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException23199;
		public NoSuchAlgorithmException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.NoSuchAlgorithmException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/NoSuchAlgorithmException"));
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23196 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "()V");
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23197 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23198 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException23199 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
