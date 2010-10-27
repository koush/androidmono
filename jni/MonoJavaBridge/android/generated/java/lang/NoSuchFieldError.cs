namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchFieldError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchFieldError()
		{
			InitJNI();
		}
		protected NoSuchFieldError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchFieldError20344;
		public NoSuchFieldError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldError.staticClass, global::java.lang.NoSuchFieldError._NoSuchFieldError20344);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchFieldError20345;
		public NoSuchFieldError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldError.staticClass, global::java.lang.NoSuchFieldError._NoSuchFieldError20345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchFieldError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchFieldError"));
			global::java.lang.NoSuchFieldError._NoSuchFieldError20344 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldError.staticClass, "<init>", "()V");
			global::java.lang.NoSuchFieldError._NoSuchFieldError20345 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
