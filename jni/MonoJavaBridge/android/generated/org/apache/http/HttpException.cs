namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpException()
		{
			InitJNI();
		}
		protected HttpException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _HttpException24964;
		public HttpException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpException.staticClass, global::org.apache.http.HttpException._HttpException24964);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpException24965;
		public HttpException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpException.staticClass, global::org.apache.http.HttpException._HttpException24965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpException24966;
		public HttpException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpException.staticClass, global::org.apache.http.HttpException._HttpException24966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpException"));
			global::org.apache.http.HttpException._HttpException24964 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpException.staticClass, "<init>", "()V");
			global::org.apache.http.HttpException._HttpException24965 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpException._HttpException24966 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
