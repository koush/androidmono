namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyManagementException : java.security.KeyException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyManagementException()
		{
			InitJNI();
		}
		protected KeyManagementException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException22914;
		public KeyManagementException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException22914);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException22915;
		public KeyManagementException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException22915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException22916;
		public KeyManagementException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException22916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException22917;
		public KeyManagementException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException22917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyManagementException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyManagementException"));
			global::java.security.KeyManagementException._KeyManagementException22914 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "()V");
			global::java.security.KeyManagementException._KeyManagementException22915 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.KeyManagementException._KeyManagementException22916 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.KeyManagementException._KeyManagementException22917 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
