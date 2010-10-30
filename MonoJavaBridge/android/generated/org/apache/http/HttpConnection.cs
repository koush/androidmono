namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpConnection_))]
	public partial interface HttpConnection  : global::MonoJavaBridge.IJavaObject 
	{
		void shutdown();
		void close();
		bool isOpen();
		global::org.apache.http.HttpConnectionMetrics getMetrics();
		bool isStale();
		void setSocketTimeout(int arg0);
		int getSocketTimeout();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpConnection))]
	internal sealed partial class HttpConnection_ : java.lang.Object, HttpConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31529;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.HttpConnection_._shutdown31529);
		}
		internal static global::MonoJavaBridge.MethodId _close31530;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpConnection_.staticClass, "close", "()V", ref global::org.apache.http.HttpConnection_._close31530);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen31531;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.HttpConnection_._isOpen31531);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics31532;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.HttpConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.HttpConnection_._getMetrics31532) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale31533;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.HttpConnection_._isStale31533);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout31534;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.HttpConnection_._setSocketTimeout31534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout31535;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.HttpConnection_._getSocketTimeout31535);
		}
		static HttpConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
