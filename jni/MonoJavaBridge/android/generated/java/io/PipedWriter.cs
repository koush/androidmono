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
		internal static global::MonoJavaBridge.MethodId _write19277;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._write19277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._write19277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19278;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._write19278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._write19278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19279;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._flush19279);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._flush19279);
		}
		internal static global::MonoJavaBridge.MethodId _close19280;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._close19280);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._close19280);
		}
		internal static global::MonoJavaBridge.MethodId _connect19281;
		public virtual void connect(java.io.PipedReader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedWriter._connect19281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedWriter.staticClass, global::java.io.PipedWriter._connect19281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedWriter19282;
		public PipedWriter(java.io.PipedReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedWriter.staticClass, global::java.io.PipedWriter._PipedWriter19282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedWriter19283;
		public PipedWriter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedWriter.staticClass, global::java.io.PipedWriter._PipedWriter19283);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedWriter"));
			global::java.io.PipedWriter._write19277 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "write", "(I)V");
			global::java.io.PipedWriter._write19278 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "write", "([CII)V");
			global::java.io.PipedWriter._flush19279 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "flush", "()V");
			global::java.io.PipedWriter._close19280 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "close", "()V");
			global::java.io.PipedWriter._connect19281 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "connect", "(Ljava/io/PipedReader;)V");
			global::java.io.PipedWriter._PipedWriter19282 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "<init>", "(Ljava/io/PipedReader;)V");
			global::java.io.PipedWriter._PipedWriter19283 = @__env.GetMethodIDNoThrow(global::java.io.PipedWriter.staticClass, "<init>", "()V");
		}
	}
}
