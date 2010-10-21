namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferedOutputStream()
		{
			InitJNI();
		}
		protected BufferedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write18692;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedOutputStream._write18692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._write18692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18693;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedOutputStream._write18693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._write18693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush18694;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedOutputStream._flush18694);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._flush18694);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedOutputStream18695;
		public BufferedOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._BufferedOutputStream18695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedOutputStream18696;
		public BufferedOutputStream(java.io.OutputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._BufferedOutputStream18696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedOutputStream"));
			global::java.io.BufferedOutputStream._write18692 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "write", "(I)V");
			global::java.io.BufferedOutputStream._write18693 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "write", "([BII)V");
			global::java.io.BufferedOutputStream._flush18694 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "flush", "()V");
			global::java.io.BufferedOutputStream._BufferedOutputStream18695 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.io.BufferedOutputStream._BufferedOutputStream18696 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
		}
	}
}
