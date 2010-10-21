namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpConnectionMetricsImpl : java.lang.Object, HttpConnectionMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpConnectionMetricsImpl()
		{
			InitJNI();
		}
		protected HttpConnectionMetricsImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset32534;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._reset32534);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._reset32534);
		}
		public new long RequestCount
		{
			get
			{
				return getRequestCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestCount32535;
		public virtual long getRequestCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getRequestCount32535);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getRequestCount32535);
		}
		public new long ResponseCount
		{
			get
			{
				return getResponseCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResponseCount32536;
		public virtual long getResponseCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getResponseCount32536);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getResponseCount32536);
		}
		public new long SentBytesCount
		{
			get
			{
				return getSentBytesCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSentBytesCount32537;
		public virtual long getSentBytesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getSentBytesCount32537);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getSentBytesCount32537);
		}
		public new long ReceivedBytesCount
		{
			get
			{
				return getReceivedBytesCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceivedBytesCount32538;
		public virtual long getReceivedBytesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getReceivedBytesCount32538);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getReceivedBytesCount32538);
		}
		internal static global::MonoJavaBridge.MethodId _getMetric32539;
		public virtual global::java.lang.Object getMetric(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getMetric32539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getMetric32539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _incrementRequestCount32540;
		public virtual void incrementRequestCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementRequestCount32540);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementRequestCount32540);
		}
		internal static global::MonoJavaBridge.MethodId _incrementResponseCount32541;
		public virtual void incrementResponseCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementResponseCount32541);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementResponseCount32541);
		}
		internal static global::MonoJavaBridge.MethodId _setMetric32542;
		public virtual void setMetric(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._setMetric32542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._setMetric32542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _HttpConnectionMetricsImpl32543;
		public HttpConnectionMetricsImpl(org.apache.http.io.HttpTransportMetrics arg0, org.apache.http.io.HttpTransportMetrics arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._HttpConnectionMetricsImpl32543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/HttpConnectionMetricsImpl"));
			global::org.apache.http.impl.HttpConnectionMetricsImpl._reset32534 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "reset", "()V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getRequestCount32535 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getRequestCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getResponseCount32536 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getResponseCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getSentBytesCount32537 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getSentBytesCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getReceivedBytesCount32538 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getReceivedBytesCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getMetric32539 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getMetric", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementRequestCount32540 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "incrementRequestCount", "()V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementResponseCount32541 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "incrementResponseCount", "()V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._setMetric32542 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "setMetric", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._HttpConnectionMetricsImpl32543 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "<init>", "(Lorg/apache/http/io/HttpTransportMetrics;Lorg/apache/http/io/HttpTransportMetrics;)V");
		}
	}
}
