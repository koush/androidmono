namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LoggingSessionInputBuffer : java.lang.Object, org.apache.http.io.SessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LoggingSessionInputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine33054;
		public virtual int readLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", ref global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLine33055;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "readLine", "()Ljava/lang/String;", ref global::org.apache.http.impl.conn.LoggingSessionInputBuffer._readLine33055) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read33056;
		public virtual int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "([B)I", ref global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read33057;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "([BII)I", ref global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33058;
		public virtual int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "read", "()I", ref global::org.apache.http.impl.conn.LoggingSessionInputBuffer._read33058);
		}
		public new global::org.apache.http.io.HttpTransportMetrics Metrics
		{
			get
			{
				return getMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33059;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.impl.conn.LoggingSessionInputBuffer._getMetrics33059) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33060;
		public virtual bool isDataAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "isDataAvailable", "(I)Z", ref global::org.apache.http.impl.conn.LoggingSessionInputBuffer._isDataAvailable33060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LoggingSessionInputBuffer33061;
		public LoggingSessionInputBuffer(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.impl.conn.Wire arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.LoggingSessionInputBuffer._LoggingSessionInputBuffer33061.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.LoggingSessionInputBuffer._LoggingSessionInputBuffer33061 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/impl/conn/Wire;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionInputBuffer._LoggingSessionInputBuffer33061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LoggingSessionInputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.LoggingSessionInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/LoggingSessionInputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
