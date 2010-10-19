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
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException17478;
		public NoSuchAlgorithmException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17478);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException17479;
		public NoSuchAlgorithmException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException17480;
		public NoSuchAlgorithmException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchAlgorithmException17481;
		public NoSuchAlgorithmException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.NoSuchAlgorithmException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/NoSuchAlgorithmException"));
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17478 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "()V");
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17479 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17480 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.NoSuchAlgorithmException._NoSuchAlgorithmException17481 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
