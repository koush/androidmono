namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalAccessException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalAccessException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalAccessException20171;
		public IllegalAccessException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessException.staticClass, global::java.lang.IllegalAccessException._IllegalAccessException20171);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalAccessException20172;
		public IllegalAccessException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessException.staticClass, global::java.lang.IllegalAccessException._IllegalAccessException20172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalAccessException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalAccessException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalAccessException"));
			global::java.lang.IllegalAccessException._IllegalAccessException20171 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessException.staticClass, "<init>", "()V");
			global::java.lang.IllegalAccessException._IllegalAccessException20172 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}