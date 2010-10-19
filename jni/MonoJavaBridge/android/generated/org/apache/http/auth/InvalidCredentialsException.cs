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
		internal static global::MonoJavaBridge.MethodId _InvalidCredentialsException25165;
		public InvalidCredentialsException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.InvalidCredentialsException.staticClass, global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException25165);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidCredentialsException25166;
		public InvalidCredentialsException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.InvalidCredentialsException.staticClass, global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException25166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidCredentialsException25167;
		public InvalidCredentialsException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.InvalidCredentialsException.staticClass, global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException25167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.InvalidCredentialsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/InvalidCredentialsException"));
			global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException25165 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.InvalidCredentialsException.staticClass, "<init>", "()V");
			global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException25166 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.InvalidCredentialsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.InvalidCredentialsException._InvalidCredentialsException25167 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.InvalidCredentialsException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
