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
		internal static global::MonoJavaBridge.MethodId _reset31536;
		void org.apache.http.HttpConnectionMetrics.reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpConnectionMetrics_._reset31536.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpConnectionMetrics_._reset31536 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "reset", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._reset31536);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestCount31537;
		long org.apache.http.HttpConnectionMetrics.getRequestCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpConnectionMetrics_._getRequestCount31537.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpConnectionMetrics_._getRequestCount31537 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getRequestCount", "()J");
			return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getRequestCount31537);
		}
		internal static global::MonoJavaBridge.MethodId _getResponseCount31538;
		long org.apache.http.HttpConnectionMetrics.getResponseCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpConnectionMetrics_._getResponseCount31538.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpConnectionMetrics_._getResponseCount31538 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getResponseCount", "()J");
			return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getResponseCount31538);
		}
		internal static global::MonoJavaBridge.MethodId _getSentBytesCount31539;
		long org.apache.http.HttpConnectionMetrics.getSentBytesCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount31539.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount31539 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getSentBytesCount", "()J");
			return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount31539);
		}
		internal static global::MonoJavaBridge.MethodId _getReceivedBytesCount31540;
		long org.apache.http.HttpConnectionMetrics.getReceivedBytesCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount31540.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount31540 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getReceivedBytesCount", "()J");
			return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount31540);
		}
		internal static global::MonoJavaBridge.MethodId _getMetric31541;
		global::java.lang.Object org.apache.http.HttpConnectionMetrics.getMetric(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpConnectionMetrics_._getMetric31541.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpConnectionMetrics_._getMetric31541 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getMetric", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getMetric31541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
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
