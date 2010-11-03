namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarException : java.util.zip.ZipException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public JarException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarException._m0.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarException._m0 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarException.staticClass, global::java.util.jar.JarException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public JarException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarException._m1.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarException._m1 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarException.staticClass, global::java.util.jar.JarException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarException"));
		}
	}
}
