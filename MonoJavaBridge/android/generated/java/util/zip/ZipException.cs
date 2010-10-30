namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ZipException28456;
		public ZipException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipException._ZipException28456.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipException._ZipException28456 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipException.staticClass, global::java.util.zip.ZipException._ZipException28456);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipException28457;
		public ZipException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipException._ZipException28457.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipException._ZipException28457 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipException.staticClass, global::java.util.zip.ZipException._ZipException28457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ZipException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
