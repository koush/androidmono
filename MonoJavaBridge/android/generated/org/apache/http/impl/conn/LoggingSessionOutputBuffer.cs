namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LoggingSessionOutputBuffer : java.lang.Object, org.apache.http.io.SessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LoggingSessionOutputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "write", "([BII)V", ref global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "write", "(I)V", ref global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "write", "([B)V", ref global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "flush", "()V", ref global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m3);
		}
		public new global::org.apache.http.io.HttpTransportMetrics Metrics
		{
			get
			{
				return getMetrics();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m4) as org.apache.http.io.HttpTransportMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void writeLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", ref global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void writeLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "writeLine", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public LoggingSessionOutputBuffer(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.impl.conn.Wire arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m7 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/impl/conn/Wire;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LoggingSessionOutputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/LoggingSessionOutputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
