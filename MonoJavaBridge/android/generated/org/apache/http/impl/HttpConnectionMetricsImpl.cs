namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpConnectionMetricsImpl : java.lang.Object, HttpConnectionMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpConnectionMetricsImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "reset", "()V", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m0);
		}
		public new long RequestCount
		{
			get
			{
				return getRequestCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual long getRequestCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getRequestCount", "()J", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m1);
		}
		public new long ResponseCount
		{
			get
			{
				return getResponseCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long getResponseCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getResponseCount", "()J", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m2);
		}
		public new long SentBytesCount
		{
			get
			{
				return getSentBytesCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual long getSentBytesCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getSentBytesCount", "()J", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m3);
		}
		public new long ReceivedBytesCount
		{
			get
			{
				return getReceivedBytesCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long getReceivedBytesCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getReceivedBytesCount", "()J", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object getMetric(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getMetric", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void incrementRequestCount()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "incrementRequestCount", "()V", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void incrementResponseCount()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "incrementResponseCount", "()V", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setMetric(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "setMetric", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.apache.http.impl.HttpConnectionMetricsImpl._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public HttpConnectionMetricsImpl(org.apache.http.io.HttpTransportMetrics arg0, org.apache.http.io.HttpTransportMetrics arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.HttpConnectionMetricsImpl._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.HttpConnectionMetricsImpl._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "<init>", "(Lorg/apache/http/io/HttpTransportMetrics;Lorg/apache/http/io/HttpTransportMetrics;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String REQUEST_COUNT
		{
			get
			{
				return "http.request-count";
			}
		}
		public static global::java.lang.String RESPONSE_COUNT
		{
			get
			{
				return "http.response-count";
			}
		}
		public static global::java.lang.String SENT_BYTES_COUNT
		{
			get
			{
				return "http.sent-bytes-count";
			}
		}
		public static global::java.lang.String RECEIVED_BYTES_COUNT
		{
			get
			{
				return "http.received-bytes-count";
			}
		}
		static HttpConnectionMetricsImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/HttpConnectionMetricsImpl"));
		}
	}
}
