namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.FilterWriter_))]
	public abstract partial class FilterWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19083;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterWriter._write19083.native == global::System.IntPtr.Zero)
				global::java.io.FilterWriter._write19083 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._write19083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19084;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterWriter._write19084.native == global::System.IntPtr.Zero)
				global::java.io.FilterWriter._write19084 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "write", "([CII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._write19084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19085;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterWriter._write19085.native == global::System.IntPtr.Zero)
				global::java.io.FilterWriter._write19085 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._write19085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19086;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterWriter._flush19086.native == global::System.IntPtr.Zero)
				global::java.io.FilterWriter._flush19086 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "flush", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._flush19086);
		}
		internal static global::MonoJavaBridge.MethodId _close19087;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterWriter._close19087.native == global::System.IntPtr.Zero)
				global::java.io.FilterWriter._close19087 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._close19087);
		}
		internal static global::MonoJavaBridge.MethodId _FilterWriter19088;
		protected FilterWriter(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterWriter._FilterWriter19088.native == global::System.IntPtr.Zero)
				global::java.io.FilterWriter._FilterWriter19088 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterWriter.staticClass, global::java.io.FilterWriter._FilterWriter19088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FilterWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterWriter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FilterWriter))]
	internal sealed partial class FilterWriter_ : java.io.FilterWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FilterWriter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static FilterWriter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterWriter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterWriter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
