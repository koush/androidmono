namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GZIPInputStream : java.util.zip.InflaterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GZIPInputStream()
		{
			InitJNI();
		}
		protected GZIPInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close22391;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.GZIPInputStream._close22391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.GZIPInputStream.staticClass, global::java.util.zip.GZIPInputStream._close22391);
		}
		internal static global::MonoJavaBridge.MethodId _read22392;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.GZIPInputStream._read22392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.GZIPInputStream.staticClass, global::java.util.zip.GZIPInputStream._read22392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _GZIPInputStream22393;
		public GZIPInputStream(java.io.InputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPInputStream.staticClass, global::java.util.zip.GZIPInputStream._GZIPInputStream22393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GZIPInputStream22394;
		public GZIPInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPInputStream.staticClass, global::java.util.zip.GZIPInputStream._GZIPInputStream22394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int GZIP_MAGIC
		{
			get
			{
				return 35615;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.GZIPInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/GZIPInputStream"));
			global::java.util.zip.GZIPInputStream._close22391 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPInputStream.staticClass, "close", "()V");
			global::java.util.zip.GZIPInputStream._read22392 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.GZIPInputStream._GZIPInputStream22393 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::java.util.zip.GZIPInputStream._GZIPInputStream22394 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
