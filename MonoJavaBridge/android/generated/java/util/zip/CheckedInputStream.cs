namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.CheckedInputStream.staticClass, "read", "()I", ref global::java.util.zip.CheckedInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.CheckedInputStream.staticClass, "read", "([BII)I", ref global::java.util.zip.CheckedInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.CheckedInputStream.staticClass, "skip", "(J)J", ref global::java.util.zip.CheckedInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.zip.Checksum Checksum
		{
			get
			{
				return getChecksum();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.zip.Checksum getChecksum()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.zip.Checksum>(this, global::java.util.zip.CheckedInputStream.staticClass, "getChecksum", "()Ljava/util/zip/Checksum;", ref global::java.util.zip.CheckedInputStream._m3) as java.util.zip.Checksum;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public CheckedInputStream(java.io.InputStream arg0, java.util.zip.Checksum arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.CheckedInputStream._m4.native == global::System.IntPtr.Zero)
				global::java.util.zip.CheckedInputStream._m4 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Checksum;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CheckedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CheckedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CheckedInputStream"));
		}
	}
}
