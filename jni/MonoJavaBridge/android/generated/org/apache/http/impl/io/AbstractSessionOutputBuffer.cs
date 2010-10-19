namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.io.AbstractSessionOutputBuffer_))]
	public abstract partial class AbstractSessionOutputBuffer : java.lang.Object, org.apache.http.io.SessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSessionOutputBuffer()
		{
			InitJNI();
		}
		protected AbstractSessionOutputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write26655;
		public virtual void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write26656;
		public virtual void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write26657;
		public virtual void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init26658;
		protected virtual void init(java.io.OutputStream arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._init26658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._init26658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush26659;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flush26659);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flush26659);
		}
		internal static global::MonoJavaBridge.MethodId _flushBuffer26660;
		protected virtual void flushBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flushBuffer26660);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flushBuffer26660);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics26661;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._getMetrics26661)) as org.apache.http.io.HttpTransportMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpTransportMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._getMetrics26661)) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _writeLine26662;
		public virtual void writeLine(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine26662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine26662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLine26663;
		public virtual void writeLine(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine26663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine26663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSessionOutputBuffer26664;
		public AbstractSessionOutputBuffer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._AbstractSessionOutputBuffer26664);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionOutputBuffer"));
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26655 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "([B)V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26656 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "([BII)V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write26657 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "(I)V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._init26658 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "init", "(Ljava/io/OutputStream;ILorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flush26659 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "flush", "()V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flushBuffer26660 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "flushBuffer", "()V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._getMetrics26661 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine26662 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine26663 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "writeLine", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer._AbstractSessionOutputBuffer26664 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.io.AbstractSessionOutputBuffer))]
	public sealed partial class AbstractSessionOutputBuffer_ : org.apache.http.impl.io.AbstractSessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSessionOutputBuffer_()
		{
			InitJNI();
		}
		internal AbstractSessionOutputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionOutputBuffer"));
		}
	}
}
