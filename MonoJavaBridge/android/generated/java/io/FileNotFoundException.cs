namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileNotFoundException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FileNotFoundException19029;
		public FileNotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileNotFoundException._FileNotFoundException19029.native == global::System.IntPtr.Zero)
				global::java.io.FileNotFoundException._FileNotFoundException19029 = @__env.GetMethodIDNoThrow(global::java.io.FileNotFoundException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileNotFoundException.staticClass, global::java.io.FileNotFoundException._FileNotFoundException19029);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileNotFoundException19030;
		public FileNotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileNotFoundException._FileNotFoundException19030.native == global::System.IntPtr.Zero)
				global::java.io.FileNotFoundException._FileNotFoundException19030 = @__env.GetMethodIDNoThrow(global::java.io.FileNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileNotFoundException.staticClass, global::java.io.FileNotFoundException._FileNotFoundException19030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FileNotFoundException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileNotFoundException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
