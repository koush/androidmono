namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstantiationError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InstantiationError()
		{
			InitJNI();
		}
		protected InstantiationError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InstantiationError14567;
		public InstantiationError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationError.staticClass, global::java.lang.InstantiationError._InstantiationError14567);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstantiationError14568;
		public InstantiationError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationError.staticClass, global::java.lang.InstantiationError._InstantiationError14568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InstantiationError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InstantiationError"));
			global::java.lang.InstantiationError._InstantiationError14567 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationError.staticClass, "<init>", "()V");
			global::java.lang.InstantiationError._InstantiationError14568 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
