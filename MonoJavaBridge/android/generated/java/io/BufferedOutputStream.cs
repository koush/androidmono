namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedOutputStream.staticClass, "write", "(I)V", ref global::java.io.BufferedOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedOutputStream.staticClass, "write", "([BII)V", ref global::java.io.BufferedOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedOutputStream.staticClass, "flush", "()V", ref global::java.io.BufferedOutputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public BufferedOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedOutputStream._m3.native == global::System.IntPtr.Zero)
				global::java.io.BufferedOutputStream._m3 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public BufferedOutputStream(java.io.OutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedOutputStream._m4.native == global::System.IntPtr.Zero)
				global::java.io.BufferedOutputStream._m4 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BufferedOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedOutputStream"));
		}
	}
}
