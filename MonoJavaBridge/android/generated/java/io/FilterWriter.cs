namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.FilterWriter_))]
	public abstract partial class FilterWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, "write", "(I)V", ref global::java.io.FilterWriter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, "write", "([CII)V", ref global::java.io.FilterWriter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.FilterWriter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, "flush", "()V", ref global::java.io.FilterWriter._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterWriter.staticClass, "close", "()V", ref global::java.io.FilterWriter._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected FilterWriter(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterWriter._m5.native == global::System.IntPtr.Zero)
				global::java.io.FilterWriter._m5 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterWriter.staticClass, global::java.io.FilterWriter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FilterWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterWriter"));
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
	}
}
