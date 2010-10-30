namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.io.AbstractSessionInputBuffer_))]
	public abstract partial class AbstractSessionInputBuffer : java.lang.Object, org.apache.http.io.SessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSessionInputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33389;
		public abstract bool isDataAvailable(int arg0);
		internal static global::MonoJavaBridge.MethodId _init33390;
		protected virtual void init(java.io.InputStream arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "init", "(Ljava/io/InputStream;ILorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._init33390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLine33391;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "()Ljava/lang/String;", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33391) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readLine33392;
		public virtual int readLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read33393;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([BII)I", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33394;
		public virtual int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "()I", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33394);
		}
		internal static global::MonoJavaBridge.MethodId _read33395;
		public virtual int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([B)I", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33396;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics33396) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _fillBuffer33397;
		protected virtual int fillBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "fillBuffer", "()I", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer33397);
		}
		internal static global::MonoJavaBridge.MethodId _hasBufferedData33398;
		protected virtual bool hasBufferedData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "hasBufferedData", "()Z", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData33398);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSessionInputBuffer33399;
		public AbstractSessionInputBuffer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer33399.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer33399 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer33399);
			Init(@__env, handle);
		}
		static AbstractSessionInputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.io.AbstractSessionInputBuffer))]
	internal sealed partial class AbstractSessionInputBuffer_ : org.apache.http.impl.io.AbstractSessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSessionInputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33400;
		public override bool isDataAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass, "isDataAvailable", "(I)Z", ref global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable33400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbstractSessionInputBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
