namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpTransportMetricsImpl : java.lang.Object, org.apache.http.io.HttpTransportMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpTransportMetricsImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset33448;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "reset", "()V", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._reset33448);
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
		internal static global::MonoJavaBridge.MethodId _getBytesTransferred33449;
		public virtual long getBytesTransferred()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "getBytesTransferred", "()J", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._getBytesTransferred33449);
		}
		internal static global::MonoJavaBridge.MethodId _setBytesTransferred33450;
		public virtual void setBytesTransferred(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "setBytesTransferred", "(J)V", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._setBytesTransferred33450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementBytesTransferred33451;
		public virtual void incrementBytesTransferred(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "incrementBytesTransferred", "(J)V", ref global::org.apache.http.impl.io.HttpTransportMetricsImpl._incrementBytesTransferred33451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpTransportMetricsImpl33452;
		public HttpTransportMetricsImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.HttpTransportMetricsImpl._HttpTransportMetricsImpl33452.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.HttpTransportMetricsImpl._HttpTransportMetricsImpl33452 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._HttpTransportMetricsImpl33452);
			Init(@__env, handle);
		}
		static HttpTransportMetricsImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpTransportMetricsImpl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
