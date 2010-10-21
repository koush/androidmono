namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthenticationException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthenticationException()
		{
			InitJNI();
		}
		protected AuthenticationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticationException31699;
		public AuthenticationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthenticationException.staticClass, global::org.apache.http.auth.AuthenticationException._AuthenticationException31699);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticationException31700;
		public AuthenticationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthenticationException.staticClass, global::org.apache.http.auth.AuthenticationException._AuthenticationException31700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticationException31701;
		public AuthenticationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthenticationException.staticClass, global::org.apache.http.auth.AuthenticationException._AuthenticationException31701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthenticationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthenticationException"));
			global::org.apache.http.auth.AuthenticationException._AuthenticationException31699 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthenticationException.staticClass, "<init>", "()V");
			global::org.apache.http.auth.AuthenticationException._AuthenticationException31700 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthenticationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.AuthenticationException._AuthenticationException31701 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthenticationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
