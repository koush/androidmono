namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write18826;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._write18826.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._write18826 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._write18826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18827;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._write18827.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._write18827 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "write", "([CII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._write18827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18828;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._write18828.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._write18828 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._write18828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _newLine18829;
		public virtual void newLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._newLine18829.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._newLine18829 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "newLine", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._newLine18829);
		}
		internal static global::MonoJavaBridge.MethodId _flush18830;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._flush18830.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._flush18830 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "flush", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._flush18830);
		}
		internal static global::MonoJavaBridge.MethodId _close18831;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._close18831.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._close18831 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._close18831);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedWriter18832;
		public BufferedWriter(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._BufferedWriter18832.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._BufferedWriter18832 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._BufferedWriter18832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedWriter18833;
		public BufferedWriter(java.io.Writer arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedWriter._BufferedWriter18833.native == global::System.IntPtr.Zero)
				global::java.io.BufferedWriter._BufferedWriter18833 = @__env.GetMethodIDNoThrow(global::java.io.BufferedWriter.staticClass, "<init>", "(Ljava/io/Writer;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedWriter.staticClass, global::java.io.BufferedWriter._BufferedWriter18833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BufferedWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedWriter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
