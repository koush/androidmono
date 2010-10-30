namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FilterOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19068;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterOutputStream.staticClass, "write", "(I)V", ref global::java.io.FilterOutputStream._write19068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19069;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterOutputStream.staticClass, "write", "([B)V", ref global::java.io.FilterOutputStream._write19069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19070;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterOutputStream.staticClass, "write", "([BII)V", ref global::java.io.FilterOutputStream._write19070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19071;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterOutputStream.staticClass, "flush", "()V", ref global::java.io.FilterOutputStream._flush19071);
		}
		internal static global::MonoJavaBridge.MethodId _close19072;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterOutputStream.staticClass, "close", "()V", ref global::java.io.FilterOutputStream._close19072);
		}
		internal static global::MonoJavaBridge.MethodId _FilterOutputStream19073;
		public FilterOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterOutputStream._FilterOutputStream19073.native == global::System.IntPtr.Zero)
				global::java.io.FilterOutputStream._FilterOutputStream19073 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._FilterOutputStream19073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FilterOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
