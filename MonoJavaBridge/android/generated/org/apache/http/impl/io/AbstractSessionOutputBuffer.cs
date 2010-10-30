namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.io.AbstractSessionOutputBuffer_))]
	public abstract partial class AbstractSessionOutputBuffer : java.lang.Object, org.apache.http.io.SessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSessionOutputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "([B)V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "([BII)V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "(I)V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void init(java.io.OutputStream arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "init", "(Ljava/io/OutputStream;ILorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "flush", "()V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void flushBuffer()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "flushBuffer", "()V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m6) as org.apache.http.io.HttpTransportMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void writeLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void writeLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "writeLine", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AbstractSessionOutputBuffer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._m9);
			Init(@__env, handle);
		}
		static AbstractSessionOutputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionOutputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.io.AbstractSessionOutputBuffer))]
	internal sealed partial class AbstractSessionOutputBuffer_ : org.apache.http.impl.io.AbstractSessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSessionOutputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbstractSessionOutputBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionOutputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
