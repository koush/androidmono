namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipInputStream : java.util.zip.InflaterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28470;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipInputStream.staticClass, "close", "()V", ref global::java.util.zip.ZipInputStream._close28470);
		}
		internal static global::MonoJavaBridge.MethodId _read28471;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipInputStream.staticClass, "read", "([BII)I", ref global::java.util.zip.ZipInputStream._read28471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip28472;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipInputStream.staticClass, "skip", "(J)J", ref global::java.util.zip.ZipInputStream._skip28472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28473;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipInputStream.staticClass, "available", "()I", ref global::java.util.zip.ZipInputStream._available28473);
		}
		public new global::java.util.zip.ZipEntry NextEntry
		{
			get
			{
				return getNextEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextEntry28474;
		public virtual global::java.util.zip.ZipEntry getNextEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;", ref global::java.util.zip.ZipInputStream._getNextEntry28474) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createZipEntry28475;
		protected virtual global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", ref global::java.util.zip.ZipInputStream._createZipEntry28475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _closeEntry28476;
		public virtual void closeEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipInputStream.staticClass, "closeEntry", "()V", ref global::java.util.zip.ZipInputStream._closeEntry28476);
		}
		internal static global::MonoJavaBridge.MethodId _ZipInputStream28477;
		public ZipInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipInputStream._ZipInputStream28477.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipInputStream._ZipInputStream28477 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._ZipInputStream28477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ZipInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
