namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileWriter : java.io.OutputStreamWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public FileWriter(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileWriter._m0.native == global::System.IntPtr.Zero)
				global::java.io.FileWriter._m0 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public FileWriter(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileWriter._m1.native == global::System.IntPtr.Zero)
				global::java.io.FileWriter._m1 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public FileWriter(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileWriter._m2.native == global::System.IntPtr.Zero)
				global::java.io.FileWriter._m2 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public FileWriter(java.io.File arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileWriter._m3.native == global::System.IntPtr.Zero)
				global::java.io.FileWriter._m3 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public FileWriter(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileWriter._m4.native == global::System.IntPtr.Zero)
				global::java.io.FileWriter._m4 = @__env.GetMethodIDNoThrow(global::java.io.FileWriter.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileWriter.staticClass, global::java.io.FileWriter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FileWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileWriter"));
		}
	}
}
