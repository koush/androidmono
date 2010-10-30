namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write18810;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedOutputStream._write18810.native == global::System.IntPtr.Zero)
				global::java.io.BufferedOutputStream._write18810 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._write18810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18811;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedOutputStream._write18811.native == global::System.IntPtr.Zero)
				global::java.io.BufferedOutputStream._write18811 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "write", "([BII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._write18811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush18812;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedOutputStream._flush18812.native == global::System.IntPtr.Zero)
				global::java.io.BufferedOutputStream._flush18812 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "flush", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._flush18812);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedOutputStream18813;
		public BufferedOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedOutputStream._BufferedOutputStream18813.native == global::System.IntPtr.Zero)
				global::java.io.BufferedOutputStream._BufferedOutputStream18813 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._BufferedOutputStream18813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedOutputStream18814;
		public BufferedOutputStream(java.io.OutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedOutputStream._BufferedOutputStream18814.native == global::System.IntPtr.Zero)
				global::java.io.BufferedOutputStream._BufferedOutputStream18814 = @__env.GetMethodIDNoThrow(global::java.io.BufferedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedOutputStream.staticClass, global::java.io.BufferedOutputStream._BufferedOutputStream18814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BufferedOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
