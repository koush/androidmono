namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.OutputStream_))]
	public abstract partial class OutputStream : java.lang.Object, Closeable, Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19352;
		public abstract void write(int arg0);
		internal static global::MonoJavaBridge.MethodId _write19353;
		public virtual void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "write", "([B)V", ref global::java.io.OutputStream._write19353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19354;
		public virtual void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "write", "([BII)V", ref global::java.io.OutputStream._write19354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19355;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "flush", "()V", ref global::java.io.OutputStream._flush19355);
		}
		internal static global::MonoJavaBridge.MethodId _close19356;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream.staticClass, "close", "()V", ref global::java.io.OutputStream._close19356);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStream19357;
		public OutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStream._OutputStream19357.native == global::System.IntPtr.Zero)
				global::java.io.OutputStream._OutputStream19357 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStream.staticClass, global::java.io.OutputStream._OutputStream19357);
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
		internal static global::MonoJavaBridge.MethodId _write19358;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStream_.staticClass, "write", "(I)V", ref global::java.io.OutputStream_._write19358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
