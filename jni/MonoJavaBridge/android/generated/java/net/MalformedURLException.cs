namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedURLException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MalformedURLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MalformedURLException21608;
		public MalformedURLException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MalformedURLException.staticClass, global::java.net.MalformedURLException._MalformedURLException21608);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedURLException21609;
		public MalformedURLException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MalformedURLException.staticClass, global::java.net.MalformedURLException._MalformedURLException21609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MalformedURLException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.MalformedURLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/MalformedURLException"));
			global::java.net.MalformedURLException._MalformedURLException21608 = @__env.GetMethodIDNoThrow(global::java.net.MalformedURLException.staticClass, "<init>", "()V");
			global::java.net.MalformedURLException._MalformedURLException21609 = @__env.GetMethodIDNoThrow(global::java.net.MalformedURLException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
