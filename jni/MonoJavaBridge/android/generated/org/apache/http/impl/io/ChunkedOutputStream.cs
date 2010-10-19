namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChunkedOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ChunkedOutputStream()
		{
			InitJNI();
		}
		protected ChunkedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write26671;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._write26671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._write26671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write26672;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._write26672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._write26672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write26673;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._write26673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._write26673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush26674;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._flush26674);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._flush26674);
		}
		internal static global::MonoJavaBridge.MethodId _close26675;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._close26675);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._close26675);
		}
		internal static global::MonoJavaBridge.MethodId _finish26676;
		public virtual void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._finish26676);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._finish26676);
		}
		internal static global::MonoJavaBridge.MethodId _flushCache26677;
		protected virtual void flushCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._flushCache26677);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._flushCache26677);
		}
		internal static global::MonoJavaBridge.MethodId _flushCacheWithAppend26678;
		protected virtual void flushCacheWithAppend(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._flushCacheWithAppend26678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._flushCacheWithAppend26678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeClosingChunk26679;
		protected virtual void writeClosingChunk() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream._writeClosingChunk26679);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._writeClosingChunk26679);
		}
		internal static global::MonoJavaBridge.MethodId _ChunkedOutputStream26680;
		public ChunkedOutputStream(org.apache.http.io.SessionOutputBuffer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream26680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ChunkedOutputStream26681;
		public ChunkedOutputStream(org.apache.http.io.SessionOutputBuffer arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream26681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ChunkedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ChunkedOutputStream"));
			global::org.apache.http.impl.io.ChunkedOutputStream._write26671 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "(I)V");
			global::org.apache.http.impl.io.ChunkedOutputStream._write26672 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "([BII)V");
			global::org.apache.http.impl.io.ChunkedOutputStream._write26673 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "([B)V");
			global::org.apache.http.impl.io.ChunkedOutputStream._flush26674 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flush", "()V");
			global::org.apache.http.impl.io.ChunkedOutputStream._close26675 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.ChunkedOutputStream._finish26676 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "finish", "()V");
			global::org.apache.http.impl.io.ChunkedOutputStream._flushCache26677 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flushCache", "()V");
			global::org.apache.http.impl.io.ChunkedOutputStream._flushCacheWithAppend26678 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flushCacheWithAppend", "([BII)V");
			global::org.apache.http.impl.io.ChunkedOutputStream._writeClosingChunk26679 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "writeClosingChunk", "()V");
			global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream26680 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V");
			global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream26681 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;I)V");
		}
	}
}
