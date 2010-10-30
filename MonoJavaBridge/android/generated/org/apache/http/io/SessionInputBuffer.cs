namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.SessionInputBuffer_))]
	public partial interface SessionInputBuffer  : global::MonoJavaBridge.IJavaObject 
	{
		int readLine(org.apache.http.util.CharArrayBuffer arg0);
		global::java.lang.String readLine();
		int read(byte[] arg0, int arg1, int arg2);
		int read(byte[] arg0);
		int read();
		global::org.apache.http.io.HttpTransportMetrics getMetrics();
		bool isDataAvailable(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.SessionInputBuffer))]
	internal sealed partial class SessionInputBuffer_ : java.lang.Object, SessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SessionInputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.apache.http.io.SessionInputBuffer.readLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", ref global::org.apache.http.io.SessionInputBuffer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.apache.http.io.SessionInputBuffer.readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "readLine", "()Ljava/lang/String;", ref global::org.apache.http.io.SessionInputBuffer_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int org.apache.http.io.SessionInputBuffer.read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "([BII)I", ref global::org.apache.http.io.SessionInputBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int org.apache.http.io.SessionInputBuffer.read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "([B)I", ref global::org.apache.http.io.SessionInputBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int org.apache.http.io.SessionInputBuffer.read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "()I", ref global::org.apache.http.io.SessionInputBuffer_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.apache.http.io.HttpTransportMetrics org.apache.http.io.SessionInputBuffer.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.io.SessionInputBuffer_._m5) as org.apache.http.io.HttpTransportMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool org.apache.http.io.SessionInputBuffer.isDataAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "isDataAvailable", "(I)Z", ref global::org.apache.http.io.SessionInputBuffer_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SessionInputBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.SessionInputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/SessionInputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
