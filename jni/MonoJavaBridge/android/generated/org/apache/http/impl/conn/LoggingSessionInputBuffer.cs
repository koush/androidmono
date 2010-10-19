namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LoggingSessionInputBuffer : java.lang.Object, org.apache.http.io.SessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LoggingSessionInputBuffer()
		{
			InitJNI();
		}
		protected LoggingSessionInputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine26312;
		public virtual int readLine(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine26312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine26312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLine26313;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine26313)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine26313)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read26314;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read26315;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read26316;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26316);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26316);
		}
		public new global::org.apache.http.io.HttpTransportMetrics Metrics
		{
			get
			{
				return getMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics26317;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._getMetrics26317)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._getMetrics26317)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable26318;
		public virtual bool isDataAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._isDataAvailable26318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._isDataAvailable26318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LoggingSessionInputBuffer26319;
		public LoggingSessionInputBuffer(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.impl.conn.Wire arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._LoggingSessionInputBuffer26319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/LoggingSessionInputBuffer"));
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine26312 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine26313 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "readLine", "()Ljava/lang/String;");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26314 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "([B)I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26315 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read26316 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "()I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._getMetrics26317 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._isDataAvailable26318 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "isDataAvailable", "(I)Z");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._LoggingSessionInputBuffer26319 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/impl/conn/Wire;)V");
		}
	}
}
