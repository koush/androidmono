namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.InputStream_))]
	public abstract partial class InputStream : java.lang.Object, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19094;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._close19094.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._close19094 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._close19094);
		}
		internal static global::MonoJavaBridge.MethodId _mark19095;
		public virtual void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._mark19095.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._mark19095 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "mark", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._mark19095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19096;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._reset19096.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._reset19096 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "reset", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._reset19096);
		}
		internal static global::MonoJavaBridge.MethodId _read19097;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._read19097.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._read19097 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._read19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19098;
		public virtual int read(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._read19098.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._read19098 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([B)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._read19098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19099;
		public abstract int read();
		internal static global::MonoJavaBridge.MethodId _skip19100;
		public virtual long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._skip19100.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._skip19100 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "skip", "(J)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._skip19100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19101;
		public virtual int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._available19101.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._available19101 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "available", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._available19101);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19102;
		public virtual bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._markSupported19102.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._markSupported19102 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "markSupported", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.InputStream.staticClass, global::java.io.InputStream._markSupported19102);
		}
		internal static global::MonoJavaBridge.MethodId _InputStream19103;
		public InputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._InputStream19103.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._InputStream19103 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStream.staticClass, global::java.io.InputStream._InputStream19103);
			Init(@__env, handle);
		}
		static InputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.InputStream))]
	internal sealed partial class InputStream_ : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputStream_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read19104;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream_._read19104.native == global::System.IntPtr.Zero)
				global::java.io.InputStream_._read19104 = @__env.GetMethodIDNoThrow(global::java.io.InputStream_.staticClass, "read", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream_._read19104);
		}
		static InputStream_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
