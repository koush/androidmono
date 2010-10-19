namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpResponseException : org.apache.http.client.ClientProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpResponseException()
		{
			InitJNI();
		}
		protected HttpResponseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int StatusCode
		{
			get
			{
				return getStatusCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusCode25228;
		public virtual int getStatusCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.client.HttpResponseException._getStatusCode25228);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.client.HttpResponseException.staticClass, global::org.apache.http.client.HttpResponseException._getStatusCode25228);
		}
		internal static global::MonoJavaBridge.MethodId _HttpResponseException25229;
		public HttpResponseException(int arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.HttpResponseException.staticClass, global::org.apache.http.client.HttpResponseException._HttpResponseException25229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.HttpResponseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/HttpResponseException"));
			global::org.apache.http.client.HttpResponseException._getStatusCode25228 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.HttpResponseException.staticClass, "getStatusCode", "()I");
			global::org.apache.http.client.HttpResponseException._HttpResponseException25229 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.HttpResponseException.staticClass, "<init>", "(ILjava/lang/String;)V");
		}
	}
}
