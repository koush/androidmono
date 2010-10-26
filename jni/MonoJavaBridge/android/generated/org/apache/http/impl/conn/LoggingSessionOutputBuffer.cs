namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LoggingSessionOutputBuffer : java.lang.Object, org.apache.http.io.SessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LoggingSessionOutputBuffer()
		{
			InitJNI();
		}
		protected LoggingSessionOutputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33061;
		public virtual void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33062;
		public virtual void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33063;
		public virtual void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush33064;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._flush33064);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._flush33064);
		}
		public new global::org.apache.http.io.HttpTransportMetrics Metrics
		{
			get
			{
				return getMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33065;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._getMetrics33065)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._getMetrics33065)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33066;
		public virtual void writeLine(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._writeLine33066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._writeLine33066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33067;
		public virtual void writeLine(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._writeLine33067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._writeLine33067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LoggingSessionOutputBuffer33068;
		public LoggingSessionOutputBuffer(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.impl.conn.Wire arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._LoggingSessionOutputBuffer33068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/LoggingSessionOutputBuffer"));
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33061 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "write", "([BII)V");
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33062 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "write", "(I)V");
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._write33063 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "write", "([B)V");
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._flush33064 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "flush", "()V");
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._getMetrics33065 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._writeLine33066 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V");
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._writeLine33067 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "writeLine", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.conn.LoggingSessionOutputBuffer._LoggingSessionOutputBuffer33068 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.LoggingSessionOutputBuffer.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/impl/conn/Wire;)V");
		}
	}
}
