namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpTransportMetricsImpl : java.lang.Object, org.apache.http.io.HttpTransportMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpTransportMetricsImpl()
		{
			InitJNI();
		}
		protected HttpTransportMetricsImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset33447;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._reset33447);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._reset33447);
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
		internal static global::MonoJavaBridge.MethodId _getBytesTransferred33448;
		public virtual long getBytesTransferred() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._getBytesTransferred33448);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._getBytesTransferred33448);
		}
		internal static global::MonoJavaBridge.MethodId _setBytesTransferred33449;
		public virtual void setBytesTransferred(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._setBytesTransferred33449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._setBytesTransferred33449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementBytesTransferred33450;
		public virtual void incrementBytesTransferred(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._incrementBytesTransferred33450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._incrementBytesTransferred33450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpTransportMetricsImpl33451;
		public HttpTransportMetricsImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._HttpTransportMetricsImpl33451);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpTransportMetricsImpl"));
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._reset33447 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "reset", "()V");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._getBytesTransferred33448 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "getBytesTransferred", "()J");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._setBytesTransferred33449 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "setBytesTransferred", "(J)V");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._incrementBytesTransferred33450 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "incrementBytesTransferred", "(J)V");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._HttpTransportMetricsImpl33451 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "<init>", "()V");
		}
	}
}
