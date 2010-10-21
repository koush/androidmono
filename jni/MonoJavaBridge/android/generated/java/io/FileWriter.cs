namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileWriter : java.io.OutputStreamWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileWriter()
		{
			InitJNI();
		}
		protected FileWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FileWriter18934;
		public FileWriter(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._FileWriter18934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileWriter18935;
		public FileWriter(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._FileWriter18935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileWriter18936;
		public FileWriter(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._FileWriter18936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileWriter18937;
		public FileWriter(java.io.File arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._FileWriter18937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileWriter18938;
		public FileWriter(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._FileWriter18938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileWriter"));
			global::java.io.FileWriter._FileWriter18934 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileWriter._FileWriter18935 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.io.FileWriter._FileWriter18936 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileWriter._FileWriter18937 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::java.io.FileWriter._FileWriter18938 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
