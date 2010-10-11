namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpConnectionMetrics_))]
	public interface HttpConnectionMetrics  : global::MonoJavaBridge.IJavaObject 
	{
		void reset();
		long getRequestCount();
		long getResponseCount();
		long getSentBytesCount();
		long getReceivedBytesCount();
		global::java.lang.Object getMetric(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpConnectionMetrics))]
	public sealed partial class HttpConnectionMetrics_ : java.lang.Object, HttpConnectionMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpConnectionMetrics_()
		{
			InitJNI();
		}
		internal HttpConnectionMetrics_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset16140;
		 void org.apache.http.HttpConnectionMetrics.reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._reset16140);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._reset16140);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestCount16141;
		 long org.apache.http.HttpConnectionMetrics.getRequestCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getRequestCount16141);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getRequestCount16141);
		}
		internal static global::MonoJavaBridge.MethodId _getResponseCount16142;
		 long org.apache.http.HttpConnectionMetrics.getResponseCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getResponseCount16142);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getResponseCount16142);
		}
		internal static global::MonoJavaBridge.MethodId _getSentBytesCount16143;
		 long org.apache.http.HttpConnectionMetrics.getSentBytesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount16143);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount16143);
		}
		internal static global::MonoJavaBridge.MethodId _getReceivedBytesCount16144;
		 long org.apache.http.HttpConnectionMetrics.getReceivedBytesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount16144);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount16144);
		}
		internal static global::MonoJavaBridge.MethodId _getMetric16145;
		 global::java.lang.Object org.apache.http.HttpConnectionMetrics.getMetric(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getMetric16145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getMetric16145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpConnectionMetrics_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpConnectionMetrics"));
			global::org.apache.http.HttpConnectionMetrics_._reset16140 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "reset", "()V");
			global::org.apache.http.HttpConnectionMetrics_._getRequestCount16141 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getRequestCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getResponseCount16142 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getResponseCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount16143 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getSentBytesCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount16144 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getReceivedBytesCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getMetric16145 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getMetric", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
