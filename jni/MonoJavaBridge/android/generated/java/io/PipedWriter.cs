namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PipedWriter()
		{
			InitJNI();
		}
		protected PipedWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write13775;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._write13775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._write13775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13776;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._write13776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._write13776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush13777;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._flush13777);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._flush13777);
		}
		internal static global::MonoJavaBridge.MethodId _close13778;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._close13778);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._close13778);
		}
		internal static global::MonoJavaBridge.MethodId _connect13779;
		public virtual void connect(java.io.PipedReader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._connect13779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._connect13779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedWriter13780;
		public PipedWriter(java.io.PipedReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedWriter.staticClass, global::java.io.PipedWriter._PipedWriter13780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedWriter13781;
		public PipedWriter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedWriter.staticClass, global::java.io.PipedWriter._PipedWriter13781);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedWriter"));
			global::java.io.PipedWriter._write13775 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "write", "(I)V");
			global::java.io.PipedWriter._write13776 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "write", "([CII)V");
			global::java.io.PipedWriter._flush13777 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "flush", "()V");
			global::java.io.PipedWriter._close13778 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "close", "()V");
			global::java.io.PipedWriter._connect13779 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "connect", "(Ljava/io/PipedReader;)V");
			global::java.io.PipedWriter._PipedWriter13780 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "<init>", "(Ljava/io/PipedReader;)V");
			global::java.io.PipedWriter._PipedWriter13781 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "<init>", "()V");
		}
	}
}
