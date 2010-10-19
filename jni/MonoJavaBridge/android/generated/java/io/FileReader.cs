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
		internal static global::MonoJavaBridge.MethodId _FileReader13456;
		public FileReader(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader13456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileReader13457;
		public FileReader(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader13457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileReader13458;
		public FileReader(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileReader.staticClass, global::java.io.FileReader._FileReader13458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileReader"));
			global::java.io.FileReader._FileReader13456 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileReader._FileReader13457 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileReader._FileReader13458 = @__env.GetMethodIDNoThrow(global::java.io.FileReader.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
