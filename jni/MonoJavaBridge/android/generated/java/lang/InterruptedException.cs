namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InterruptedException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InterruptedException()
		{
			InitJNI();
		}
		protected InterruptedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InterruptedException20238;
		public InterruptedException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InterruptedException.staticClass, global::java.lang.InterruptedException._InterruptedException20238);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InterruptedException20239;
		public InterruptedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InterruptedException.staticClass, global::java.lang.InterruptedException._InterruptedException20239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InterruptedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InterruptedException"));
			global::java.lang.InterruptedException._InterruptedException20238 = @__env.GetMethodIDNoThrow(global::java.lang.InterruptedException.staticClass, "<init>", "()V");
			global::java.lang.InterruptedException._InterruptedException20239 = @__env.GetMethodIDNoThrow(global::java.lang.InterruptedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
