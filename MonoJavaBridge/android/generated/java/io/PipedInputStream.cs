namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19369;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._close19369.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._close19369 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._close19369);
		}
		internal static global::MonoJavaBridge.MethodId _read19370;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._read19370.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._read19370 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read19370);
		}
		internal static global::MonoJavaBridge.MethodId _read19371;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._read19371.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._read19371 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read19371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available19372;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._available19372.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._available19372 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "available", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._available19372);
		}
		internal static global::MonoJavaBridge.MethodId _connect19373;
		public virtual void connect(java.io.PipedOutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._connect19373.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._connect19373 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "connect", "(Ljava/io/PipedOutputStream;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._connect19373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receive19374;
		protected virtual void receive(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._receive19374.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._receive19374 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "receive", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._receive19374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19375;
		public PipedInputStream(java.io.PipedOutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._PipedInputStream19375.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._PipedInputStream19375 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19376;
		public PipedInputStream(java.io.PipedOutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._PipedInputStream19376.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._PipedInputStream19376 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19377;
		public PipedInputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._PipedInputStream19377.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._PipedInputStream19377 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19377);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19378;
		public PipedInputStream(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedInputStream._PipedInputStream19378.native == global::System.IntPtr.Zero)
				global::java.io.PipedInputStream._PipedInputStream19378 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PipedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
