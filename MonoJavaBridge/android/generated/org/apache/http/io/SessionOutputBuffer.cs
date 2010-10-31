namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.SessionOutputBuffer_))]
	public partial interface SessionOutputBuffer  : global::MonoJavaBridge.IJavaObject 
	{
		void write(byte[] arg0, int arg1, int arg2);
		void write(byte[] arg0);
		void write(int arg0);
		void flush();
		global::org.apache.http.io.HttpTransportMetrics getMetrics();
		void writeLine(java.lang.String arg0);
		void writeLine(org.apache.http.util.CharArrayBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.SessionOutputBuffer))]
	internal sealed partial class SessionOutputBuffer_ : java.lang.Object, SessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SessionOutputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.io.SessionOutputBuffer.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "([BII)V", ref global::org.apache.http.io.SessionOutputBuffer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.io.SessionOutputBuffer.write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "([B)V", ref global::org.apache.http.io.SessionOutputBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.io.SessionOutputBuffer.write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "(I)V", ref global::org.apache.http.io.SessionOutputBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.http.io.SessionOutputBuffer.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "flush", "()V", ref global::org.apache.http.io.SessionOutputBuffer_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.io.HttpTransportMetrics org.apache.http.io.SessionOutputBuffer.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.io.SessionOutputBuffer_._m4) as org.apache.http.io.HttpTransportMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.io.SessionOutputBuffer.writeLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "writeLine", "(Ljava/lang/String;)V", ref global::org.apache.http.io.SessionOutputBuffer_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.io.SessionOutputBuffer.writeLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", ref global::org.apache.http.io.SessionOutputBuffer_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SessionOutputBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.SessionOutputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/SessionOutputBuffer"));
		}
	}
}
