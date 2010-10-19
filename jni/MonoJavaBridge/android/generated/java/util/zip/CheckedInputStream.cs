namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CheckedInputStream()
		{
			InitJNI();
		}
		protected CheckedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read22346;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream._read22346);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._read22346);
		}
		internal static global::MonoJavaBridge.MethodId _read22347;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream._read22347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._read22347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip22348;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream._skip22348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._skip22348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.zip.Checksum Checksum
		{
			get
			{
				return getChecksum();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChecksum22349;
		public virtual global::java.util.zip.Checksum getChecksum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.zip.Checksum>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream._getChecksum22349)) as java.util.zip.Checksum;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.zip.Checksum>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._getChecksum22349)) as java.util.zip.Checksum;
		}
		internal static global::MonoJavaBridge.MethodId _CheckedInputStream22350;
		public CheckedInputStream(java.io.InputStream arg0, java.util.zip.Checksum arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._CheckedInputStream22350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CheckedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CheckedInputStream"));
			global::java.util.zip.CheckedInputStream._read22346 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "read", "()I");
			global::java.util.zip.CheckedInputStream._read22347 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.CheckedInputStream._skip22348 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "skip", "(J)J");
			global::java.util.zip.CheckedInputStream._getChecksum22349 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "getChecksum", "()Ljava/util/zip/Checksum;");
			global::java.util.zip.CheckedInputStream._CheckedInputStream22350 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Checksum;)V");
		}
	}
}
