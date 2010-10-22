namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpStatus_))]
	public partial interface HttpStatus  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpStatus))]
	public sealed partial class HttpStatus_ : java.lang.Object, HttpStatus
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpStatus_()
		{
			InitJNI();
		}
		internal HttpStatus_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpStatus_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpStatus"));
		}
	}
}
