namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalAccessError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalAccessError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalAccessError20169;
		public IllegalAccessError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalAccessError._IllegalAccessError20169.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalAccessError._IllegalAccessError20169 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessError.staticClass, global::java.lang.IllegalAccessError._IllegalAccessError20169);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalAccessError20170;
		public IllegalAccessError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalAccessError._IllegalAccessError20170.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalAccessError._IllegalAccessError20170 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessError.staticClass, global::java.lang.IllegalAccessError._IllegalAccessError20170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalAccessError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalAccessError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalAccessError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
