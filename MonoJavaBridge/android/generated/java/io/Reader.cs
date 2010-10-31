namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.Reader_))]
	public abstract partial class Reader : java.lang.Object, java.lang.Readable, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Reader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void close();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Reader.staticClass, "mark", "(I)V", ref global::java.io.Reader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Reader.staticClass, "reset", "()V", ref global::java.io.Reader._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int read(char[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader.staticClass, "read", "()I", ref global::java.io.Reader._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int read(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader.staticClass, "read", "([C)I", ref global::java.io.Reader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int read(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader.staticClass, "read", "(Ljava/nio/CharBuffer;)I", ref global::java.io.Reader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.Reader.staticClass, "skip", "(J)J", ref global::java.io.Reader._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.Reader.staticClass, "markSupported", "()Z", ref global::java.io.Reader._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.Reader.staticClass, "ready", "()Z", ref global::java.io.Reader._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected Reader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.Reader._m10.native == global::System.IntPtr.Zero)
				global::java.io.Reader._m10 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._m10);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected Reader(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.Reader._m11.native == global::System.IntPtr.Zero)
				global::java.io.Reader._m11 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Reader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Reader))]
	internal sealed partial class Reader_ : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Reader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Reader_.staticClass, "close", "()V", ref global::java.io.Reader_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader_.staticClass, "read", "([CII)I", ref global::java.io.Reader_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static Reader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
		}
	}
}
