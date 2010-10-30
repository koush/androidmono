namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close18800;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._close18800.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._close18800 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._close18800);
		}
		internal static global::MonoJavaBridge.MethodId _mark18801;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._mark18801.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._mark18801 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "mark", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._mark18801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18802;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._reset18802.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._reset18802 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "reset", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._reset18802);
		}
		internal static global::MonoJavaBridge.MethodId _read18803;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._read18803.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._read18803 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read18803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18804;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._read18804.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._read18804 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read18804);
		}
		internal static global::MonoJavaBridge.MethodId _skip18805;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._skip18805.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._skip18805 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "skip", "(J)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._skip18805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18806;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._available18806.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._available18806 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "available", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._available18806);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18807;
		public override bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._markSupported18807.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._markSupported18807 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "markSupported", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._markSupported18807);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream18808;
		public BufferedInputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._BufferedInputStream18808.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._BufferedInputStream18808 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream18808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream18809;
		public BufferedInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._BufferedInputStream18809.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._BufferedInputStream18809 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream18809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BufferedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
