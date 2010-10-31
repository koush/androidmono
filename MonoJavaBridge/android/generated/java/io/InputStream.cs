namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.InputStream_))]
	public abstract partial class InputStream : java.lang.Object, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, "close", "()V", ref global::java.io.InputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, "mark", "(I)V", ref global::java.io.InputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStream.staticClass, "reset", "()V", ref global::java.io.InputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, "read", "([BII)I", ref global::java.io.InputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, "read", "([B)I", ref global::java.io.InputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int read();
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.InputStream.staticClass, "skip", "(J)J", ref global::java.io.InputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream.staticClass, "available", "()I", ref global::java.io.InputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.InputStream.staticClass, "markSupported", "()Z", ref global::java.io.InputStream._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public InputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStream._m9.native == global::System.IntPtr.Zero)
				global::java.io.InputStream._m9 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStream.staticClass, global::java.io.InputStream._m9);
			Init(@__env, handle);
		}
		static InputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.InputStream))]
	internal sealed partial class InputStream_ : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputStream_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStream_.staticClass, "read", "()I", ref global::java.io.InputStream_._m0);
		}
		static InputStream_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
		}
	}
}
