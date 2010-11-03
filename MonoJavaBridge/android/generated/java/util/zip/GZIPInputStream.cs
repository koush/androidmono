namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GZIPInputStream : java.util.zip.InflaterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GZIPInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.GZIPInputStream.staticClass, "close", "()V", ref global::java.util.zip.GZIPInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.GZIPInputStream.staticClass, "read", "([BII)I", ref global::java.util.zip.GZIPInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public GZIPInputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.GZIPInputStream._m2.native == global::System.IntPtr.Zero)
				global::java.util.zip.GZIPInputStream._m2 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPInputStream.staticClass, global::java.util.zip.GZIPInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public GZIPInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.GZIPInputStream._m3.native == global::System.IntPtr.Zero)
				global::java.util.zip.GZIPInputStream._m3 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPInputStream.staticClass, global::java.util.zip.GZIPInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int GZIP_MAGIC
		{
			get
			{
				return 35615;
			}
		}
		static GZIPInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.GZIPInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/GZIPInputStream"));
		}
	}
}
