namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchMethodError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchMethodError()
		{
			InitJNI();
		}
		protected NoSuchMethodError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchMethodError20230;
		public NoSuchMethodError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodError.staticClass, global::java.lang.NoSuchMethodError._NoSuchMethodError20230);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchMethodError20231;
		public NoSuchMethodError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodError.staticClass, global::java.lang.NoSuchMethodError._NoSuchMethodError20231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchMethodError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchMethodError"));
			global::java.lang.NoSuchMethodError._NoSuchMethodError20230 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodError.staticClass, "<init>", "()V");
			global::java.lang.NoSuchMethodError._NoSuchMethodError20231 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
