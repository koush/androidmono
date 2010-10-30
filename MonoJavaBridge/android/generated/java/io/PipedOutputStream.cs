namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19379;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "write", "(I)V", ref global::java.io.PipedOutputStream._write19379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19380;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "write", "([BII)V", ref global::java.io.PipedOutputStream._write19380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19381;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "flush", "()V", ref global::java.io.PipedOutputStream._flush19381);
		}
		internal static global::MonoJavaBridge.MethodId _close19382;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "close", "()V", ref global::java.io.PipedOutputStream._close19382);
		}
		internal static global::MonoJavaBridge.MethodId _connect19383;
		public virtual void connect(java.io.PipedInputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "connect", "(Ljava/io/PipedInputStream;)V", ref global::java.io.PipedOutputStream._connect19383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedOutputStream19384;
		public PipedOutputStream(java.io.PipedInputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedOutputStream._PipedOutputStream19384.native == global::System.IntPtr.Zero)
				global::java.io.PipedOutputStream._PipedOutputStream19384 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "<init>", "(Ljava/io/PipedInputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._PipedOutputStream19384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedOutputStream19385;
		public PipedOutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedOutputStream._PipedOutputStream19385.native == global::System.IntPtr.Zero)
				global::java.io.PipedOutputStream._PipedOutputStream19385 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._PipedOutputStream19385);
			Init(@__env, handle);
		}
		static PipedOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
