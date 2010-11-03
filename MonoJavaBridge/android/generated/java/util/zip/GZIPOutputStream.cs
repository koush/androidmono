namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GZIPOutputStream : java.util.zip.DeflaterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GZIPOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.GZIPOutputStream.staticClass, "write", "([BII)V", ref global::java.util.zip.GZIPOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.GZIPOutputStream.staticClass, "finish", "()V", ref global::java.util.zip.GZIPOutputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public GZIPOutputStream(java.io.OutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.GZIPOutputStream._m2.native == global::System.IntPtr.Zero)
				global::java.util.zip.GZIPOutputStream._m2 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public GZIPOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.GZIPOutputStream._m3.native == global::System.IntPtr.Zero)
				global::java.util.zip.GZIPOutputStream._m3 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static GZIPOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.GZIPOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/GZIPOutputStream"));
		}
	}
}
