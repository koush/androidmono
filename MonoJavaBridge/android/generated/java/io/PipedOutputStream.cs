namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "write", "(I)V", ref global::java.io.PipedOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "write", "([BII)V", ref global::java.io.PipedOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "flush", "()V", ref global::java.io.PipedOutputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "close", "()V", ref global::java.io.PipedOutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void connect(java.io.PipedInputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedOutputStream.staticClass, "connect", "(Ljava/io/PipedInputStream;)V", ref global::java.io.PipedOutputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PipedOutputStream(java.io.PipedInputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedOutputStream._m5.native == global::System.IntPtr.Zero)
				global::java.io.PipedOutputStream._m5 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "<init>", "(Ljava/io/PipedInputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PipedOutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedOutputStream._m6.native == global::System.IntPtr.Zero)
				global::java.io.PipedOutputStream._m6 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._m6);
			Init(@__env, handle);
		}
		static PipedOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedOutputStream"));
		}
	}
}
