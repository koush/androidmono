namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileReader : java.io.InputStreamReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FileReader19049;
		public FileReader(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileReader._FileReader19049.native == global::System.IntPtr.Zero)
				global::java.io.FileReader._FileReader19049 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader19049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileReader19050;
		public FileReader(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileReader._FileReader19050.native == global::System.IntPtr.Zero)
				global::java.io.FileReader._FileReader19050 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader19050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileReader19051;
		public FileReader(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileReader._FileReader19051.native == global::System.IntPtr.Zero)
				global::java.io.FileReader._FileReader19051 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader19051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FileReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
