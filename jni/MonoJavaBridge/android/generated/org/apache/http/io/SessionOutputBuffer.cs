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
		static SessionOutputBuffer_()
		{
			InitJNI();
		}
		internal SessionOutputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33477;
		void org.apache.http.io.SessionOutputBuffer.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_._write33477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_.staticClass, global::org.apache.http.io.SessionOutputBuffer_._write33477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33478;
		void org.apache.http.io.SessionOutputBuffer.write(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_._write33478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_.staticClass, global::org.apache.http.io.SessionOutputBuffer_._write33478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33479;
		void org.apache.http.io.SessionOutputBuffer.write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_._write33479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_.staticClass, global::org.apache.http.io.SessionOutputBuffer_._write33479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush33480;
		void org.apache.http.io.SessionOutputBuffer.flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_._flush33480);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_.staticClass, global::org.apache.http.io.SessionOutputBuffer_._flush33480);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33481;
		global::org.apache.http.io.HttpTransportMetrics org.apache.http.io.SessionOutputBuffer.getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_._getMetrics33481)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_.staticClass, global::org.apache.http.io.SessionOutputBuffer_._getMetrics33481)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33482;
		void org.apache.http.io.SessionOutputBuffer.writeLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_._writeLine33482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_.staticClass, global::org.apache.http.io.SessionOutputBuffer_._writeLine33482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33483;
		void org.apache.http.io.SessionOutputBuffer.writeLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_._writeLine33483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.SessionOutputBuffer_.staticClass, global::org.apache.http.io.SessionOutputBuffer_._writeLine33483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.SessionOutputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/SessionOutputBuffer"));
			global::org.apache.http.io.SessionOutputBuffer_._write33477 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "([BII)V");
			global::org.apache.http.io.SessionOutputBuffer_._write33478 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "([B)V");
			global::org.apache.http.io.SessionOutputBuffer_._write33479 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "(I)V");
			global::org.apache.http.io.SessionOutputBuffer_._flush33480 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionOutputBuffer_.staticClass, "flush", "()V");
			global::org.apache.http.io.SessionOutputBuffer_._getMetrics33481 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionOutputBuffer_.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.io.SessionOutputBuffer_._writeLine33482 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionOutputBuffer_.staticClass, "writeLine", "(Ljava/lang/String;)V");
			global::org.apache.http.io.SessionOutputBuffer_._writeLine33483 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.SessionOutputBuffer_.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V");
		}
	}
}
