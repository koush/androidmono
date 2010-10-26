namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoClassDefFoundError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoClassDefFoundError()
		{
			InitJNI();
		}
		protected NoClassDefFoundError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoClassDefFoundError20342;
		public NoClassDefFoundError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError._NoClassDefFoundError20342);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoClassDefFoundError20343;
		public NoClassDefFoundError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError._NoClassDefFoundError20343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoClassDefFoundError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoClassDefFoundError"));
			global::java.lang.NoClassDefFoundError._NoClassDefFoundError20342 = @__env.GetMethodIDNoThrow(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "()V");
			global::java.lang.NoClassDefFoundError._NoClassDefFoundError20343 = @__env.GetMethodIDNoThrow(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
