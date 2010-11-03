namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipInputStream : java.util.zip.InflaterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipInputStream.staticClass, "close", "()V", ref global::java.util.zip.ZipInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipInputStream.staticClass, "read", "([BII)I", ref global::java.util.zip.ZipInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipInputStream.staticClass, "skip", "(J)J", ref global::java.util.zip.ZipInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipInputStream.staticClass, "available", "()I", ref global::java.util.zip.ZipInputStream._m3);
		}
		public new global::java.util.zip.ZipEntry NextEntry
		{
			get
			{
				return getNextEntry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.zip.ZipEntry getNextEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;", ref global::java.util.zip.ZipInputStream._m4) as java.util.zip.ZipEntry;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", ref global::java.util.zip.ZipInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.zip.ZipEntry;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void closeEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipInputStream.staticClass, "closeEntry", "()V", ref global::java.util.zip.ZipInputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ZipInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipInputStream._m7.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipInputStream._m7 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ZipInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipInputStream"));
		}
	}
}
