namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownHostException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnknownHostException()
		{
			InitJNI();
		}
		protected UnknownHostException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnknownHostException21872;
		public UnknownHostException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownHostException.staticClass, global::java.net.UnknownHostException._UnknownHostException21872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnknownHostException21873;
		public UnknownHostException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownHostException.staticClass, global::java.net.UnknownHostException._UnknownHostException21873);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.UnknownHostException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/UnknownHostException"));
			global::java.net.UnknownHostException._UnknownHostException21872 = @__env.GetMethodIDNoThrow(global::java.net.UnknownHostException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.UnknownHostException._UnknownHostException21873 = @__env.GetMethodIDNoThrow(global::java.net.UnknownHostException.staticClass, "<init>", "()V");
		}
	}
}
