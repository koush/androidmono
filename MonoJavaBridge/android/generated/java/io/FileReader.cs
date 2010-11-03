namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileReader : java.io.InputStreamReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public FileReader(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileReader._m0.native == global::System.IntPtr.Zero)
				global::java.io.FileReader._m0 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public FileReader(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileReader._m1.native == global::System.IntPtr.Zero)
				global::java.io.FileReader._m1 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public FileReader(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileReader._m2.native == global::System.IntPtr.Zero)
				global::java.io.FileReader._m2 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FileReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileReader"));
		}
	}
}
