namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.OutputStream_))]
	public abstract partial class OutputStream : java.lang.Object, Closeable, Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void write(int arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "write", "([B)V", ref global::java.io.OutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "write", "([BII)V", ref global::java.io.OutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "flush", "()V", ref global::java.io.OutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "close", "()V", ref global::java.io.OutputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public OutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStream._m5.native == global::System.IntPtr.Zero)
				global::java.io.OutputStream._m5 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStream.staticClass, global::java.io.OutputStream._m5);
			Init(@__env, handle);
		}
		static OutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.OutputStream))]
	internal sealed partial class OutputStream_ : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal OutputStream_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream_.staticClass, "write", "(I)V", ref global::java.io.OutputStream_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static OutputStream_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
