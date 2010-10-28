namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoHttpResponseException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoHttpResponseException()
		{
			InitJNI();
		}
		protected NoHttpResponseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoHttpResponseException31740;
		public NoHttpResponseException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.NoHttpResponseException.staticClass, global::org.apache.http.NoHttpResponseException._NoHttpResponseException31740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.NoHttpResponseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/NoHttpResponseException"));
			global::org.apache.http.NoHttpResponseException._NoHttpResponseException31740 = @__env.GetMethodIDNoThrow(global::org.apache.http.NoHttpResponseException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
