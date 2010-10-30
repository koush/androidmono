namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchProviderException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchProviderException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchProviderException23200;
		public NoSuchProviderException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.NoSuchProviderException._NoSuchProviderException23200.native == global::System.IntPtr.Zero)
				global::java.security.NoSuchProviderException._NoSuchProviderException23200 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchProviderException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchProviderException.staticClass, global::java.security.NoSuchProviderException._NoSuchProviderException23200);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchProviderException23201;
		public NoSuchProviderException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.NoSuchProviderException._NoSuchProviderException23201.native == global::System.IntPtr.Zero)
				global::java.security.NoSuchProviderException._NoSuchProviderException23201 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchProviderException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchProviderException.staticClass, global::java.security.NoSuchProviderException._NoSuchProviderException23201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchProviderException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.NoSuchProviderException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/NoSuchProviderException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
