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
		internal static global::MonoJavaBridge.MethodId _reset26702;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._reset26702);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._reset26702);
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
		internal static global::MonoJavaBridge.MethodId _getBytesTransferred26703;
		public virtual long getBytesTransferred() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._getBytesTransferred26703);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._getBytesTransferred26703);
		}
		internal static global::MonoJavaBridge.MethodId _setBytesTransferred26704;
		public virtual void setBytesTransferred(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._setBytesTransferred26704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._setBytesTransferred26704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementBytesTransferred26705;
		public virtual void incrementBytesTransferred(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl._incrementBytesTransferred26705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._incrementBytesTransferred26705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpTransportMetricsImpl26706;
		public HttpTransportMetricsImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, global::org.apache.http.impl.io.HttpTransportMetricsImpl._HttpTransportMetricsImpl26706);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpTransportMetricsImpl"));
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._reset26702 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "reset", "()V");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._getBytesTransferred26703 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "getBytesTransferred", "()J");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._setBytesTransferred26704 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "setBytesTransferred", "(J)V");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._incrementBytesTransferred26705 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "incrementBytesTransferred", "(J)V");
			global::org.apache.http.impl.io.HttpTransportMetricsImpl._HttpTransportMetricsImpl26706 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpTransportMetricsImpl.staticClass, "<init>", "()V");
		}
	}
}
