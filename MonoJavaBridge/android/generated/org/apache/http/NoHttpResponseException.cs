namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoHttpResponseException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoHttpResponseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoHttpResponseException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.NoHttpResponseException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.NoHttpResponseException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.NoHttpResponseException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.NoHttpResponseException.staticClass, global::org.apache.http.NoHttpResponseException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoHttpResponseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.NoHttpResponseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/NoHttpResponseException"));
		}
	}
}
