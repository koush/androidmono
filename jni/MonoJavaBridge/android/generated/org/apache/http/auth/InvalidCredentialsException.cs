namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidCredentialsException : org.apache.http.auth.AuthenticationException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidCredentialsException()
		{
			InitJNI();
		}
		protected InvalidCredentialsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidCredentialsException31709;
		public InvalidCredentialsException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.InvalidCredentialsException.staticClass, global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException31709);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidCredentialsException31710;
		public InvalidCredentialsException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.InvalidCredentialsException.staticClass, global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException31710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidCredentialsException31711;
		public InvalidCredentialsException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.InvalidCredentialsException.staticClass, global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException31711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.InvalidCredentialsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/InvalidCredentialsException"));
			global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException31709 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.InvalidCredentialsException.staticClass, "<init>", "()V");
			global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException31710 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.InvalidCredentialsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException31711 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.InvalidCredentialsException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
