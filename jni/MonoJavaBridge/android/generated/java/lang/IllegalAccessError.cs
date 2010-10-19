namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalAccessError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalAccessError()
		{
			InitJNI();
		}
		protected IllegalAccessError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalAccessError14545;
		public IllegalAccessError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessError.staticClass, global::java.lang.IllegalAccessError._IllegalAccessError14545);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalAccessError14546;
		public IllegalAccessError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessError.staticClass, global::java.lang.IllegalAccessError._IllegalAccessError14546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalAccessError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalAccessError"));
			global::java.lang.IllegalAccessError._IllegalAccessError14545 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessError.staticClass, "<init>", "()V");
			global::java.lang.IllegalAccessError._IllegalAccessError14546 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
