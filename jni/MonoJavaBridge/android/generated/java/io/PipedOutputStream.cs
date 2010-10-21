namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PipedOutputStream()
		{
			InitJNI();
		}
		protected PipedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19261;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream._write19261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._write19261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19262;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream._write19262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._write19262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19263;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream._flush19263);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._flush19263);
		}
		internal static global::MonoJavaBridge.MethodId _close19264;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream._close19264);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._close19264);
		}
		internal static global::MonoJavaBridge.MethodId _connect19265;
		public virtual void connect(java.io.PipedInputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream._connect19265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._connect19265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedOutputStream19266;
		public PipedOutputStream(java.io.PipedInputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._PipedOutputStream19266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedOutputStream19267;
		public PipedOutputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedOutputStream.staticClass, global::java.io.PipedOutputStream._PipedOutputStream19267);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedOutputStream"));
			global::java.io.PipedOutputStream._write19261 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "write", "(I)V");
			global::java.io.PipedOutputStream._write19262 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "write", "([BII)V");
			global::java.io.PipedOutputStream._flush19263 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "flush", "()V");
			global::java.io.PipedOutputStream._close19264 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "close", "()V");
			global::java.io.PipedOutputStream._connect19265 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "connect", "(Ljava/io/PipedInputStream;)V");
			global::java.io.PipedOutputStream._PipedOutputStream19266 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "<init>", "(Ljava/io/PipedInputStream;)V");
			global::java.io.PipedOutputStream._PipedOutputStream19267 = @__env.GetMethodIDNoThrow(global::java.io.PipedOutputStream.staticClass, "<init>", "()V");
		}
	}
}
