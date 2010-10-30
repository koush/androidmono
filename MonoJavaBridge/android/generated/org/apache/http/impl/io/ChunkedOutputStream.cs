namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChunkedOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ChunkedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "(I)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "([BII)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "write", "([B)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flush", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "close", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "finish", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void flushCache()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flushCache", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void flushCacheWithAppend(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "flushCacheWithAppend", "([BII)V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void writeClosingChunk()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "writeClosingChunk", "()V", ref global::org.apache.http.impl.io.ChunkedOutputStream._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ChunkedOutputStream(org.apache.http.io.SessionOutputBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ChunkedOutputStream._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ChunkedOutputStream._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ChunkedOutputStream(org.apache.http.io.SessionOutputBuffer arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ChunkedOutputStream._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ChunkedOutputStream._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedOutputStream.staticClass, global::org.apache.http.impl.io.ChunkedOutputStream._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
