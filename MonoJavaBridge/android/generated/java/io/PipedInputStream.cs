namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedInputStream.staticClass, "close", "()V", ref global::java.io.PipedInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedInputStream.staticClass, "read", "()I", ref global::java.io.PipedInputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedInputStream.staticClass, "read", "([BII)I", ref global::java.io.PipedInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedInputStream.staticClass, "available", "()I", ref global::java.io.PipedInputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void connect(java.io.PipedOutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedInputStream.staticClass, "connect", "(Ljava/io/PipedOutputStream;)V", ref global::java.io.PipedInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void receive(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedInputStream.staticClass, "receive", "(I)V", ref global::java.io.PipedInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PipedInputStream(java.io.PipedOutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._m6.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._m6 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PipedInputStream(java.io.PipedOutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._m7.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._m7 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public PipedInputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._m8.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._m8 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._m8);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public PipedInputStream(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._m9.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._m9 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PipedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedInputStream"));
		}
	}
}
