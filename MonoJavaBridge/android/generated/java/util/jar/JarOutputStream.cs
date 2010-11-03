namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarOutputStream : java.util.zip.ZipOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void putNextEntry(java.util.zip.ZipEntry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.JarOutputStream.staticClass, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V", ref global::java.util.jar.JarOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public JarOutputStream(java.io.OutputStream arg0, java.util.jar.Manifest arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarOutputStream._m1.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarOutputStream._m1 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/jar/Manifest;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarOutputStream.staticClass, global::java.util.jar.JarOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public JarOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarOutputStream._m2.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarOutputStream._m2 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarOutputStream.staticClass, global::java.util.jar.JarOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarOutputStream"));
		}
	}
}
