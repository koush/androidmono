namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OutputStreamWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OutputStreamWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19359;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "write", "([CII)V", ref global::java.io.OutputStreamWriter._write19359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19360;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.OutputStreamWriter._write19360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19361;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "write", "(I)V", ref global::java.io.OutputStreamWriter._write19361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19362;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "flush", "()V", ref global::java.io.OutputStreamWriter._flush19362);
		}
		internal static global::MonoJavaBridge.MethodId _close19363;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.OutputStreamWriter.staticClass, "close", "()V", ref global::java.io.OutputStreamWriter._close19363);
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding19364;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.OutputStreamWriter.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::java.io.OutputStreamWriter._getEncoding19364) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19365;
		public OutputStreamWriter(java.io.OutputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._OutputStreamWriter19365.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._OutputStreamWriter19365 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19366;
		public OutputStreamWriter(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._OutputStreamWriter19366.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._OutputStreamWriter19366 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19367;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.Charset arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._OutputStreamWriter19367.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._OutputStreamWriter19367 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19368;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.CharsetEncoder arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.OutputStreamWriter._OutputStreamWriter19368.native == global::System.IntPtr.Zero)
				global::java.io.OutputStreamWriter._OutputStreamWriter19368 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/CharsetEncoder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static OutputStreamWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStreamWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStreamWriter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
