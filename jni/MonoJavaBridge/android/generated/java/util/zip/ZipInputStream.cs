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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._close28470);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._close28470);
		}
		internal static global::MonoJavaBridge.MethodId _read28471;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._read28471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._read28471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip28472;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._skip28472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._skip28472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28473;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._available28473);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._available28473);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._getNextEntry28474)) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._getNextEntry28474)) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createZipEntry28475;
		protected virtual global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._createZipEntry28475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._createZipEntry28475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _closeEntry28476;
		public virtual void closeEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._closeEntry28476);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._closeEntry28476);
		}
		internal static global::MonoJavaBridge.MethodId _ZipInputStream28477;
		public ZipInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._ZipInputStream28477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ZipInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipInputStream"));
			global::java.util.zip.ZipInputStream._close28470 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "close", "()V");
			global::java.util.zip.ZipInputStream._read28471 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.ZipInputStream._skip28472 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "skip", "(J)J");
			global::java.util.zip.ZipInputStream._available28473 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "available", "()I");
			global::java.util.zip.ZipInputStream._getNextEntry28474 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipInputStream._createZipEntry28475 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipInputStream._closeEntry28476 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "closeEntry", "()V");
			global::java.util.zip.ZipInputStream._ZipInputStream28477 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
