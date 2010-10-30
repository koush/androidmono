namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpRequestRetryHandler : java.lang.Object, org.apache.http.client.HttpRequestRetryHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpRequestRetryHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool retryRequest(java.io.IOException arg0, int arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "retryRequest", "(Ljava/io/IOException;ILorg/apache/http/protocol/HttpContext;)Z", ref global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isRequestSentRetryEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "isRequestSentRetryEnabled", "()Z", ref global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m1);
		}
		public new int RetryCount
		{
			get
			{
				return getRetryCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getRetryCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "getRetryCount", "()I", ref global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DefaultHttpRequestRetryHandler(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "<init>", "(IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DefaultHttpRequestRetryHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._m4);
			Init(@__env, handle);
		}
		static DefaultHttpRequestRetryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultHttpRequestRetryHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
