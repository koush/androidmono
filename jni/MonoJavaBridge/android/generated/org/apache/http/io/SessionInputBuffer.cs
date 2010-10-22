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
	public sealed partial class SessionInputBuffer_ : java.lang.Object, SessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SessionInputBuffer_()
		{
			InitJNI();
		}
		internal SessionInputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine33352;
		 int org.apache.http.io.SessionInputBuffer.readLine(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_._readLine33352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_.staticClass, global::org.apache.http.io.SessionInputBuffer_._readLine33352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLine33353;
		 global::java.lang.String org.apache.http.io.SessionInputBuffer.readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_._readLine33353)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_.staticClass, global::org.apache.http.io.SessionInputBuffer_._readLine33353)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read33354;
		 int org.apache.http.io.SessionInputBuffer.read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_._read33354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_.staticClass, global::org.apache.http.io.SessionInputBuffer_._read33354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33355;
		 int org.apache.http.io.SessionInputBuffer.read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_._read33355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_.staticClass, global::org.apache.http.io.SessionInputBuffer_._read33355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read33356;
		 int org.apache.http.io.SessionInputBuffer.read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_._read33356);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_.staticClass, global::org.apache.http.io.SessionInputBuffer_._read33356);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33357;
		 global::org.apache.http.io.HttpTransportMetrics org.apache.http.io.SessionInputBuffer.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_._getMetrics33357)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_.staticClass, global::org.apache.http.io.SessionInputBuffer_._getMetrics33357)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33358;
		 bool org.apache.http.io.SessionInputBuffer.isDataAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_._isDataAvailable33358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.io.SessionInputBuffer_.staticClass, global::org.apache.http.io.SessionInputBuffer_._isDataAvailable33358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.SessionInputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/SessionInputBuffer"));
			global::org.apache.http.io.SessionInputBuffer_._readLine33352 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionInputBuffer_.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I");
			global::org.apache.http.io.SessionInputBuffer_._readLine33353 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionInputBuffer_.staticClass, "readLine", "()Ljava/lang/String;");
			global::org.apache.http.io.SessionInputBuffer_._read33354 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "([BII)I");
			global::org.apache.http.io.SessionInputBuffer_._read33355 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "([B)I");
			global::org.apache.http.io.SessionInputBuffer_._read33356 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionInputBuffer_.staticClass, "read", "()I");
			global::org.apache.http.io.SessionInputBuffer_._getMetrics33357 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionInputBuffer_.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.io.SessionInputBuffer_._isDataAvailable33358 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionInputBuffer_.staticClass, "isDataAvailable", "(I)Z");
		}
	}
}
