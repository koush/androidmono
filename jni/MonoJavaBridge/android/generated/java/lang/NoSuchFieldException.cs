namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchFieldException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchFieldException()
		{
			InitJNI();
		}
		protected NoSuchFieldException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchFieldException14714;
		public NoSuchFieldException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException._NoSuchFieldException14714);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchFieldException14715;
		public NoSuchFieldException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException._NoSuchFieldException14715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchFieldException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchFieldException"));
			global::java.lang.NoSuchFieldException._NoSuchFieldException14714 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldException.staticClass, "<init>", "()V");
			global::java.lang.NoSuchFieldException._NoSuchFieldException14715 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
