namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.io.AbstractSessionInputBuffer_))]
	public abstract partial class AbstractSessionInputBuffer : java.lang.Object, org.apache.http.io.SessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSessionInputBuffer()
		{
			InitJNI();
		}
		protected AbstractSessionInputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33270;
		public abstract bool isDataAvailable(int arg0);
		internal static global::MonoJavaBridge.MethodId _init33271;
		protected virtual void init(java.io.InputStream arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._init33271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._init33271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLine33272;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33272)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readLine33273;
		public virtual int readLine(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read33274;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33275;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33275);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33275);
		}
		internal static global::MonoJavaBridge.MethodId _read33276;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33277;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics33277)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics33277)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _fillBuffer33278;
		protected virtual int fillBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer33278);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer33278);
		}
		internal static global::MonoJavaBridge.MethodId _hasBufferedData33279;
		protected virtual bool hasBufferedData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData33279);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData33279);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSessionInputBuffer33280;
		public AbstractSessionInputBuffer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer33280);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._isDataAvailable33270 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "isDataAvailable", "(I)Z");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._init33271 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "init", "(Ljava/io/InputStream;ILorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33272 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "()Ljava/lang/String;");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine33273 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33274 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33275 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "()I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read33276 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([B)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics33277 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer33278 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "fillBuffer", "()I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData33279 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "hasBufferedData", "()Z");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer33280 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.io.AbstractSessionInputBuffer))]
	public sealed partial class AbstractSessionInputBuffer_ : org.apache.http.impl.io.AbstractSessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSessionInputBuffer_()
		{
			InitJNI();
		}
		internal AbstractSessionInputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33281;
		public override bool isDataAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable33281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable33281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
			global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable33281 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass, "isDataAvailable", "(I)Z");
		}
	}
}
