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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._init33390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._init33390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLine33391;
		public virtual global::java.lang.String readLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33391)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33391)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readLine33392;
		public virtual int readLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read33393;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33394;
		public virtual int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33394);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33394);
		}
		internal static global::MonoJavaBridge.MethodId _read33395;
		public virtual int read(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33396;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics33396)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics33396)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _fillBuffer33397;
		protected virtual int fillBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer33397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer33397);
		}
		internal static global::MonoJavaBridge.MethodId _hasBufferedData33398;
		protected virtual bool hasBufferedData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData33398);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData33398);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSessionInputBuffer33399;
		public AbstractSessionInputBuffer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer33399);
			Init(@__env, handle);
		}
		static AbstractSessionInputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._isDataAvailable33389 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "isDataAvailable", "(I)Z");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._init33390 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "init", "(Ljava/io/InputStream;ILorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33391 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "()Ljava/lang/String;");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33392 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33393 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33394 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "()I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33395 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([B)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics33396 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer33397 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "fillBuffer", "()I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData33398 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "hasBufferedData", "()Z");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer33399 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "<init>", "()V");
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable33400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable33400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbstractSessionInputBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
			global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable33400 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass, "isDataAvailable", "(I)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
