namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeflaterOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DeflaterOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "write", "([BII)V", ref global::java.util.zip.DeflaterOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "write", "(I)V", ref global::java.util.zip.DeflaterOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "close", "()V", ref global::java.util.zip.DeflaterOutputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "finish", "()V", ref global::java.util.zip.DeflaterOutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void deflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "deflate", "()V", ref global::java.util.zip.DeflaterOutputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DeflaterOutputStream._m5.native == global::System.IntPtr.Zero)
				global::java.util.zip.DeflaterOutputStream._m5 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DeflaterOutputStream._m6.native == global::System.IntPtr.Zero)
				global::java.util.zip.DeflaterOutputStream._m6 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public DeflaterOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DeflaterOutputStream._m7.native == global::System.IntPtr.Zero)
				global::java.util.zip.DeflaterOutputStream._m7 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DeflaterOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.DeflaterOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/DeflaterOutputStream"));
		}
	}
}
