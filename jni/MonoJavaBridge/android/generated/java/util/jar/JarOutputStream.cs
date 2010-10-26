namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarOutputStream : java.util.zip.ZipOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JarOutputStream()
		{
			InitJNI();
		}
		protected JarOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _putNextEntry27882;
		public override void putNextEntry(java.util.zip.ZipEntry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.JarOutputStream._putNextEntry27882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.JarOutputStream.staticClass, global::java.util.jar.JarOutputStream._putNextEntry27882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _JarOutputStream27883;
		public JarOutputStream(java.io.OutputStream arg0, java.util.jar.Manifest arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarOutputStream.staticClass, global::java.util.jar.JarOutputStream._JarOutputStream27883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarOutputStream27884;
		public JarOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarOutputStream.staticClass, global::java.util.jar.JarOutputStream._JarOutputStream27884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarOutputStream"));
			global::java.util.jar.JarOutputStream._putNextEntry27882 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarOutputStream.staticClass, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V");
			global::java.util.jar.JarOutputStream._JarOutputStream27883 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/jar/Manifest;)V");
			global::java.util.jar.JarOutputStream._JarOutputStream27884 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
