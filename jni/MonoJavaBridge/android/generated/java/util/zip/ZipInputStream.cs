namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipInputStream : java.util.zip.InflaterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZipInputStream()
		{
			InitJNI();
		}
		protected ZipInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28351;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._close28351);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._close28351);
		}
		internal static global::MonoJavaBridge.MethodId _read28352;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._read28352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._read28352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip28353;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._skip28353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._skip28353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28354;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._available28354);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._available28354);
		}
		public new global::java.util.zip.ZipEntry NextEntry
		{
			get
			{
				return getNextEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextEntry28355;
		public virtual global::java.util.zip.ZipEntry getNextEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._getNextEntry28355)) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._getNextEntry28355)) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createZipEntry28356;
		protected virtual global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._createZipEntry28356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._createZipEntry28356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _closeEntry28357;
		public virtual void closeEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._closeEntry28357);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._closeEntry28357);
		}
		internal static global::MonoJavaBridge.MethodId _ZipInputStream28358;
		public ZipInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._ZipInputStream28358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipInputStream"));
			global::java.util.zip.ZipInputStream._close28351 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "close", "()V");
			global::java.util.zip.ZipInputStream._read28352 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.ZipInputStream._skip28353 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "skip", "(J)J");
			global::java.util.zip.ZipInputStream._available28354 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "available", "()I");
			global::java.util.zip.ZipInputStream._getNextEntry28355 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipInputStream._createZipEntry28356 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipInputStream._closeEntry28357 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "closeEntry", "()V");
			global::java.util.zip.ZipInputStream._ZipInputStream28358 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
