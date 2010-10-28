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
		internal static global::MonoJavaBridge.MethodId _reset32653;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._reset32653);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._reset32653);
		}
		public new long RequestCount
		{
			get
			{
				return getRequestCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestCount32654;
		public virtual long getRequestCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getRequestCount32654);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getRequestCount32654);
		}
		public new long ResponseCount
		{
			get
			{
				return getResponseCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResponseCount32655;
		public virtual long getResponseCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getResponseCount32655);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getResponseCount32655);
		}
		public new long SentBytesCount
		{
			get
			{
				return getSentBytesCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSentBytesCount32656;
		public virtual long getSentBytesCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getSentBytesCount32656);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getSentBytesCount32656);
		}
		public new long ReceivedBytesCount
		{
			get
			{
				return getReceivedBytesCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceivedBytesCount32657;
		public virtual long getReceivedBytesCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getReceivedBytesCount32657);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getReceivedBytesCount32657);
		}
		internal static global::MonoJavaBridge.MethodId _getMetric32658;
		public virtual global::java.lang.Object getMetric(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._getMetric32658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._getMetric32658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _incrementRequestCount32659;
		public virtual void incrementRequestCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementRequestCount32659);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementRequestCount32659);
		}
		internal static global::MonoJavaBridge.MethodId _incrementResponseCount32660;
		public virtual void incrementResponseCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementResponseCount32660);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementResponseCount32660);
		}
		internal static global::MonoJavaBridge.MethodId _setMetric32661;
		public virtual void setMetric(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl._setMetric32661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._setMetric32661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _HttpConnectionMetricsImpl32662;
		public HttpConnectionMetricsImpl(org.apache.http.io.HttpTransportMetrics arg0, org.apache.http.io.HttpTransportMetrics arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, global::org.apache.http.impl.HttpConnectionMetricsImpl._HttpConnectionMetricsImpl32662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::org.apache.http.impl.HttpConnectionMetricsImpl._reset32653 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "reset", "()V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getRequestCount32654 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getRequestCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getResponseCount32655 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getResponseCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getSentBytesCount32656 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getSentBytesCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getReceivedBytesCount32657 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getReceivedBytesCount", "()J");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._getMetric32658 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "getMetric", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementRequestCount32659 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "incrementRequestCount", "()V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._incrementResponseCount32660 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "incrementResponseCount", "()V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._setMetric32661 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "setMetric", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.impl.HttpConnectionMetricsImpl._HttpConnectionMetricsImpl32662 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.HttpConnectionMetricsImpl.staticClass, "<init>", "(Lorg/apache/http/io/HttpTransportMetrics;Lorg/apache/http/io/HttpTransportMetrics;)V");
		}
	}
}
