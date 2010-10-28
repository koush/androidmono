namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarException : java.util.zip.ZipException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _JarException27863;
		public JarException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarException.staticClass, global::java.util.jar.JarException._JarException27863);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarException27864;
		public JarException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarException.staticClass, global::java.util.jar.JarException._JarException27864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarException"));
			global::java.util.jar.JarException._JarException27863 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarException.staticClass, "<init>", "()V");
			global::java.util.jar.JarException._JarException27864 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
