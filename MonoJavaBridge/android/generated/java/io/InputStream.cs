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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, "close", "()V", ref global::java.io.InputStream._close19094);
		}
		internal static global::MonoJavaBridge.MethodId _mark19095;
		public virtual void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, "mark", "(I)V", ref global::java.io.InputStream._mark19095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19096;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, "reset", "()V", ref global::java.io.InputStream._reset19096);
		}
		internal static global::MonoJavaBridge.MethodId _read19097;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, "read", "([BII)I", ref global::java.io.InputStream._read19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19098;
		public virtual int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, "read", "([B)I", ref global::java.io.InputStream._read19098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19099;
		public abstract int read();
		internal static global::MonoJavaBridge.MethodId _skip19100;
		public virtual long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.InputStream.staticClass, "skip", "(J)J", ref global::java.io.InputStream._skip19100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19101;
		public virtual int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, "available", "()I", ref global::java.io.InputStream._available19101);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19102;
		public virtual bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.InputStream.staticClass, "markSupported", "()Z", ref global::java.io.InputStream._markSupported19102);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream_.staticClass, "read", "()I", ref global::java.io.InputStream_._read19104);
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
