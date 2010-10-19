namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferedWriter()
		{
			InitJNI();
		}
		protected BufferedWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write13237;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedWriter._write13237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._write13237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13238;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedWriter._write13238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._write13238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13239;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedWriter._write13239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._write13239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _newLine13240;
		public virtual void newLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedWriter._newLine13240);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._newLine13240);
		}
		internal static global::MonoJavaBridge.MethodId _flush13241;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedWriter._flush13241);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._flush13241);
		}
		internal static global::MonoJavaBridge.MethodId _close13242;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedWriter._close13242);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._close13242);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedWriter13243;
		public BufferedWriter(java.io.Writer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._BufferedWriter13243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedWriter13244;
		public BufferedWriter(java.io.Writer arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._BufferedWriter13244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedWriter"));
			global::java.io.BufferedWriter._write13237 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "write", "(I)V");
			global::java.io.BufferedWriter._write13238 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "write", "([CII)V");
			global::java.io.BufferedWriter._write13239 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.BufferedWriter._newLine13240 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "newLine", "()V");
			global::java.io.BufferedWriter._flush13241 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "flush", "()V");
			global::java.io.BufferedWriter._close13242 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "close", "()V");
			global::java.io.BufferedWriter._BufferedWriter13243 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::java.io.BufferedWriter._BufferedWriter13244 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "<init>", "(Ljava/io/Writer;I)V");
		}
	}
}
