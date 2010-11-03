namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, "write", "(I)V", ref global::java.io.BufferedWriter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, "write", "([CII)V", ref global::java.io.BufferedWriter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.BufferedWriter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void newLine()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, "newLine", "()V", ref global::java.io.BufferedWriter._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, "flush", "()V", ref global::java.io.BufferedWriter._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, "close", "()V", ref global::java.io.BufferedWriter._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public BufferedWriter(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._m6.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._m6 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public BufferedWriter(java.io.Writer arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._m7.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._m7 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "<init>", "(Ljava/io/Writer;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BufferedWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedWriter"));
		}
	}
}
