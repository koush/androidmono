namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TooManyListenersException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TooManyListenersException()
		{
			InitJNI();
		}
		protected TooManyListenersException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TooManyListenersException26760;
		public TooManyListenersException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TooManyListenersException.staticClass, global::java.util.TooManyListenersException._TooManyListenersException26760);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TooManyListenersException26761;
		public TooManyListenersException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TooManyListenersException.staticClass, global::java.util.TooManyListenersException._TooManyListenersException26761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TooManyListenersException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TooManyListenersException"));
			global::java.util.TooManyListenersException._TooManyListenersException26760 = @__env.GetMethodIDNoThrow(global::java.util.TooManyListenersException.staticClass, "<init>", "()V");
			global::java.util.TooManyListenersException._TooManyListenersException26761 = @__env.GetMethodIDNoThrow(global::java.util.TooManyListenersException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
