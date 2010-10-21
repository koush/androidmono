namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchMethodException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchMethodException()
		{
			InitJNI();
		}
		protected NoSuchMethodException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchMethodException20232;
		public NoSuchMethodException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodException.staticClass, global::java.lang.NoSuchMethodException._NoSuchMethodException20232);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchMethodException20233;
		public NoSuchMethodException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodException.staticClass, global::java.lang.NoSuchMethodException._NoSuchMethodException20233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchMethodException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchMethodException"));
			global::java.lang.NoSuchMethodException._NoSuchMethodException20232 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodException.staticClass, "<init>", "()V");
			global::java.lang.NoSuchMethodException._NoSuchMethodException20233 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
