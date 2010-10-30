namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChunkedOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ChunkedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33417;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "(I)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._write33417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33418;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "([BII)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._write33418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33419;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "([B)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._write33419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush33420;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flush", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._flush33420);
		}
		internal static global::MonoJavaBridge.MethodId _close33421;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "close", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._close33421);
		}
		internal static global::MonoJavaBridge.MethodId _finish33422;
		public virtual void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "finish", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._finish33422);
		}
		internal static global::MonoJavaBridge.MethodId _flushCache33423;
		protected virtual void flushCache()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flushCache", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._flushCache33423);
		}
		internal static global::MonoJavaBridge.MethodId _flushCacheWithAppend33424;
		protected virtual void flushCacheWithAppend(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flushCacheWithAppend", "([BII)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._flushCacheWithAppend33424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeClosingChunk33425;
		protected virtual void writeClosingChunk()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "writeClosingChunk", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._writeClosingChunk33425);
		}
		internal static global::MonoJavaBridge.MethodId _ChunkedOutputStream33426;
		public ChunkedOutputStream(org.apache.http.io.SessionOutputBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream33426.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream33426 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream33426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ChunkedOutputStream33427;
		public ChunkedOutputStream(org.apache.http.io.SessionOutputBuffer arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream33427.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream33427 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._ChunkedOutputStream33427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ChunkedOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ChunkedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ChunkedOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
