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
		internal static global::MonoJavaBridge.MethodId _readLine33053;
		public virtual int readLine(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLine33054;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33054)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33054)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read33055;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read33056;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33057;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33057);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33057);
		}
		public new global::org.apache.http.io.HttpTransportMetrics Metrics
		{
			get
			{
				return getMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33058;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._getMetrics33058)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._getMetrics33058)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33059;
		public virtual bool isDataAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._isDataAvailable33059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._isDataAvailable33059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LoggingSessionInputBuffer33060;
		public LoggingSessionInputBuffer(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.impl.conn.Wire arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._LoggingSessionInputBuffer33060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/LoggingSessionInputBuffer"));
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33053 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33054 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "readLine", "()Ljava/lang/String;");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33055 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "([B)I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33056 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33057 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "()I");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._getMetrics33058 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._isDataAvailable33059 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "isDataAvailable", "(I)Z");
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer._LoggingSessionInputBuffer33060 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/impl/conn/Wire;)V");
		}
	}
}
