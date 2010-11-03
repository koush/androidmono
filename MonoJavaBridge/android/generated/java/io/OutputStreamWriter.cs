namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OutputStreamWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OutputStreamWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "write", "([CII)V", ref global::java.io.OutputStreamWriter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.OutputStreamWriter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "write", "(I)V", ref global::java.io.OutputStreamWriter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "flush", "()V", ref global::java.io.OutputStreamWriter._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "close", "()V", ref global::java.io.OutputStreamWriter._m4);
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.OutputStreamWriter.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::java.io.OutputStreamWriter._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public OutputStreamWriter(java.io.OutputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._m6.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._m6 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public OutputStreamWriter(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._m7.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._m7 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.Charset arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._m8.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._m8 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.CharsetEncoder arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._m9.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._m9 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/CharsetEncoder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static OutputStreamWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStreamWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStreamWriter"));
		}
	}
}
