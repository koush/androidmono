namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedReader.staticClass, "close", "()V", ref global::java.io.PipedReader._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedReader.staticClass, "read", "()I", ref global::java.io.PipedReader._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedReader.staticClass, "read", "([CII)I", ref global::java.io.PipedReader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void connect(java.io.PipedWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedReader.staticClass, "connect", "(Ljava/io/PipedWriter;)V", ref global::java.io.PipedReader._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.PipedReader.staticClass, "ready", "()Z", ref global::java.io.PipedReader._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PipedReader(java.io.PipedWriter arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._m5.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._m5 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PipedReader(java.io.PipedWriter arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._m6.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._m6 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PipedReader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._m7.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._m7 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._m7);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public PipedReader(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._m8.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._m8 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PipedReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedReader"));
		}
	}
}
