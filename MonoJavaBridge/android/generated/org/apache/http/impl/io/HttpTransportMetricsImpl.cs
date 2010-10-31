namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpTransportMetricsImpl : java.lang.Object, org.apache.http.io.HttpTransportMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpTransportMetricsImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "reset", "()V", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._m0);
		}
		public new long BytesTransferred
		{
			get
			{
				return getBytesTransferred();
			}
			set
			{
				setBytesTransferred(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual long getBytesTransferred()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "getBytesTransferred", "()J", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setBytesTransferred(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "setBytesTransferred", "(J)V", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void incrementBytesTransferred(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "incrementBytesTransferred", "(J)V", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public HttpTransportMetricsImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.HttpTransportMetricsImpl._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.HttpTransportMetricsImpl._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._m4);
			Init(@__env, handle);
		}
		static HttpTransportMetricsImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpTransportMetricsImpl"));
		}
	}
}
