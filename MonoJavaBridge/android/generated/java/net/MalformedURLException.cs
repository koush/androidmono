namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedURLException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MalformedURLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public MalformedURLException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MalformedURLException._m0.native == global::System.IntPtr.Zero)
				global::java.net.MalformedURLException._m0 = @__env.GetMethodIDNoThrow(global::java.net.MalformedURLException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MalformedURLException.staticClass, global::java.net.MalformedURLException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public MalformedURLException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MalformedURLException._m1.native == global::System.IntPtr.Zero)
				global::java.net.MalformedURLException._m1 = @__env.GetMethodIDNoThrow(global::java.net.MalformedURLException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MalformedURLException.staticClass, global::java.net.MalformedURLException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MalformedURLException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.MalformedURLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/MalformedURLException"));
		}
	}
}
