namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write28344;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.CheckedOutputStream.staticClass, "write", "(I)V", ref global::java.util.zip.CheckedOutputStream._write28344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write28345;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.CheckedOutputStream.staticClass, "write", "([BII)V", ref global::java.util.zip.CheckedOutputStream._write28345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.zip.Checksum Checksum
		{
			get
			{
				return getChecksum();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChecksum28346;
		public virtual global::java.util.zip.Checksum getChecksum()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.zip.Checksum>(this, global::java.util.zip.CheckedOutputStream.staticClass, "getChecksum", "()Ljava/util/zip/Checksum;", ref global::java.util.zip.CheckedOutputStream._getChecksum28346) as java.util.zip.Checksum;
		}
		internal static global::MonoJavaBridge.MethodId _CheckedOutputStream28347;
		public CheckedOutputStream(java.io.OutputStream arg0, java.util.zip.Checksum arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.CheckedOutputStream._CheckedOutputStream28347.native == global::System.IntPtr.Zero)
				global::java.util.zip.CheckedOutputStream._CheckedOutputStream28347 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Checksum;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CheckedOutputStream.staticClass, global::java.util.zip.CheckedOutputStream._CheckedOutputStream28347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CheckedOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CheckedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CheckedOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
