namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileReader : java.io.InputStreamReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileReader()
		{
			InitJNI();
		}
		protected FileReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FileReader18931;
		public FileReader(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader18931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileReader18932;
		public FileReader(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader18932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileReader18933;
		public FileReader(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader18933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileReader"));
			global::java.io.FileReader._FileReader18931 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileReader._FileReader18932 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileReader._FileReader18933 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
