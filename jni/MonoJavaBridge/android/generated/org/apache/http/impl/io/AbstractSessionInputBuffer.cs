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
		internal static global::MonoJavaBridge.MethodId _isDataAvailable26643;
		public abstract bool isDataAvailable(int arg0);
		internal static global::MonoJavaBridge.MethodId _init26644;
		protected virtual void init(java.io.InputStream arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._init26644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._init26644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLine26645;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine26645)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine26645)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readLine26646;
		public virtual int readLine(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine26646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine26646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read26647;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read26648;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26648);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26648);
		}
		internal static global::MonoJavaBridge.MethodId _read26649;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics26650;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics26650)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics26650)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _fillBuffer26651;
		protected virtual int fillBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer26651);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer26651);
		}
		internal static global::MonoJavaBridge.MethodId _hasBufferedData26652;
		protected virtual bool hasBufferedData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData26652);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData26652);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSessionInputBuffer26653;
		public AbstractSessionInputBuffer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer26653);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._isDataAvailable26643 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "isDataAvailable", "(I)Z");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._init26644 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "init", "(Ljava/io/InputStream;ILorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine26645 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "()Ljava/lang/String;");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._readLine26646 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26647 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26648 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "()I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._read26649 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "read", "([B)I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._getMetrics26650 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._fillBuffer26651 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "fillBuffer", "()I");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._hasBufferedData26652 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "hasBufferedData", "()Z");
			global::org.apache.http.impl.io.AbstractSessionInputBuffer._AbstractSessionInputBuffer26653 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _isDataAvailable26654;
		public override bool isDataAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable26654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass, global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable26654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionInputBuffer"));
			global::org.apache.http.impl.io.AbstractSessionInputBuffer_._isDataAvailable26654 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionInputBuffer_.staticClass, "isDataAvailable", "(I)Z");
		}
	}
}
