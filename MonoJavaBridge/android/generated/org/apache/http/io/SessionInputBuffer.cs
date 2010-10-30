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
		internal static global::MonoJavaBridge.MethodId _readLine33471;
		int org.apache.http.io.SessionInputBuffer.readLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", ref global::org.apache.http.io.SessionInputBuffer_._readLine33471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLine33472;
		global::java.lang.String org.apache.http.io.SessionInputBuffer.readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "readLine", "()Ljava/lang/String;", ref global::org.apache.http.io.SessionInputBuffer_._readLine33472) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read33473;
		int org.apache.http.io.SessionInputBuffer.read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "([BII)I", ref global::org.apache.http.io.SessionInputBuffer_._read33473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33474;
		int org.apache.http.io.SessionInputBuffer.read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "([B)I", ref global::org.apache.http.io.SessionInputBuffer_._read33474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read33475;
		int org.apache.http.io.SessionInputBuffer.read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "()I", ref global::org.apache.http.io.SessionInputBuffer_._read33475);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33476;
		global::org.apache.http.io.HttpTransportMetrics org.apache.http.io.SessionInputBuffer.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.io.SessionInputBuffer_._getMetrics33476) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33477;
		bool org.apache.http.io.SessionInputBuffer.isDataAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.io.SessionInputBuffer_.staticClass, "isDataAvailable", "(I)Z", ref global::org.apache.http.io.SessionInputBuffer_._isDataAvailable33477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
