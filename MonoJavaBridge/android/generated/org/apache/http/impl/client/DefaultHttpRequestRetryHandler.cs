namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpRequestRetryHandler : java.lang.Object, org.apache.http.client.HttpRequestRetryHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpRequestRetryHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _retryRequest32903;
		public virtual bool retryRequest(java.io.IOException arg0, int arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._retryRequest32903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._retryRequest32903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isRequestSentRetryEnabled32904;
		public virtual bool isRequestSentRetryEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._isRequestSentRetryEnabled32904);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._isRequestSentRetryEnabled32904);
		}
		public new int RetryCount
		{
			get
			{
				return getRetryCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRetryCount32905;
		public virtual int getRetryCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._getRetryCount32905);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._getRetryCount32905);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpRequestRetryHandler32906;
		public DefaultHttpRequestRetryHandler(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._DefaultHttpRequestRetryHandler32906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpRequestRetryHandler32907;
		public DefaultHttpRequestRetryHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._DefaultHttpRequestRetryHandler32907);
			Init(@__env, handle);
		}
		static DefaultHttpRequestRetryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultHttpRequestRetryHandler"));
			global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._retryRequest32903 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "retryRequest", "(Ljava/io/IOException;ILorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._isRequestSentRetryEnabled32904 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "isRequestSentRetryEnabled", "()Z");
			global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._getRetryCount32905 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "getRetryCount", "()I");
			global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._DefaultHttpRequestRetryHandler32906 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "<init>", "(IZ)V");
			global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler._DefaultHttpRequestRetryHandler32907 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpRequestRetryHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}