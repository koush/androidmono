namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchProviderException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchProviderException()
		{
			InitJNI();
		}
		protected NoSuchProviderException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchProviderException17482;
		public NoSuchProviderException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchProviderException.staticClass, global::java.security.NoSuchProviderException._NoSuchProviderException17482);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchProviderException17483;
		public NoSuchProviderException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchProviderException.staticClass, global::java.security.NoSuchProviderException._NoSuchProviderException17483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.NoSuchProviderException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/NoSuchProviderException"));
			global::java.security.NoSuchProviderException._NoSuchProviderException17482 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchProviderException.staticClass, "<init>", "()V");
			global::java.security.NoSuchProviderException._NoSuchProviderException17483 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchProviderException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
