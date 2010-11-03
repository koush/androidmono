namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedWriter.staticClass, "write", "(I)V", ref global::java.io.PipedWriter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedWriter.staticClass, "write", "([CII)V", ref global::java.io.PipedWriter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedWriter.staticClass, "flush", "()V", ref global::java.io.PipedWriter._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedWriter.staticClass, "close", "()V", ref global::java.io.PipedWriter._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void connect(java.io.PipedReader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedWriter.staticClass, "connect", "(Ljava/io/PipedReader;)V", ref global::java.io.PipedWriter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PipedWriter(java.io.PipedReader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedWriter._m5.native == global::System.IntPtr.Zero)
				global::java.io.PipedWriter._m5 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "<init>", "(Ljava/io/PipedReader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedWriter.staticClass, global::java.io.PipedWriter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PipedWriter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedWriter._m6.native == global::System.IntPtr.Zero)
				global::java.io.PipedWriter._m6 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedWriter.staticClass, global::java.io.PipedWriter._m6);
			Init(@__env, handle);
		}
		static PipedWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedWriter"));
		}
	}
}
