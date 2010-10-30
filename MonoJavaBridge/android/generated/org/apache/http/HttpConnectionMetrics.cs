namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpConnectionMetrics_))]
	public partial interface HttpConnectionMetrics  : global::MonoJavaBridge.IJavaObject 
	{
		void reset();
		long getRequestCount();
		long getResponseCount();
		long getSentBytesCount();
		long getReceivedBytesCount();
		global::java.lang.Object getMetric(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpConnectionMetrics))]
	internal sealed partial class HttpConnectionMetrics_ : java.lang.Object, HttpConnectionMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpConnectionMetrics_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.HttpConnectionMetrics.reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpConnectionMetrics_.staticClass, "reset", "()V", ref global::org.apache.http.HttpConnectionMetrics_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		long org.apache.http.HttpConnectionMetrics.getRequestCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.HttpConnectionMetrics_.staticClass, "getRequestCount", "()J", ref global::org.apache.http.HttpConnectionMetrics_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		long org.apache.http.HttpConnectionMetrics.getResponseCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.HttpConnectionMetrics_.staticClass, "getResponseCount", "()J", ref global::org.apache.http.HttpConnectionMetrics_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		long org.apache.http.HttpConnectionMetrics.getSentBytesCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.HttpConnectionMetrics_.staticClass, "getSentBytesCount", "()J", ref global::org.apache.http.HttpConnectionMetrics_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		long org.apache.http.HttpConnectionMetrics.getReceivedBytesCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.HttpConnectionMetrics_.staticClass, "getReceivedBytesCount", "()J", ref global::org.apache.http.HttpConnectionMetrics_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.Object org.apache.http.HttpConnectionMetrics.getMetric(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpConnectionMetrics_.staticClass, "getMetric", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.HttpConnectionMetrics_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static HttpConnectionMetrics_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpConnectionMetrics_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpConnectionMetrics"));
		}
		internal static void InitJNI()
		{
		}
	}
}
