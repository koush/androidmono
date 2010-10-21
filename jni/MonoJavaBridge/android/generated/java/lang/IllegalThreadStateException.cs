namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalThreadStateException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalThreadStateException()
		{
			InitJNI();
		}
		protected IllegalThreadStateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalThreadStateException20065;
		public IllegalThreadStateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalThreadStateException.staticClass, global::java.lang.IllegalThreadStateException._IllegalThreadStateException20065);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalThreadStateException20066;
		public IllegalThreadStateException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalThreadStateException.staticClass, global::java.lang.IllegalThreadStateException._IllegalThreadStateException20066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalThreadStateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalThreadStateException"));
			global::java.lang.IllegalThreadStateException._IllegalThreadStateException20065 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalThreadStateException.staticClass, "<init>", "()V");
			global::java.lang.IllegalThreadStateException._IllegalThreadStateException20066 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalThreadStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
