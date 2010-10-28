namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TooManyListenersException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TooManyListenersException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TooManyListenersException26879;
		public TooManyListenersException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TooManyListenersException.staticClass, global::java.util.TooManyListenersException._TooManyListenersException26879);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TooManyListenersException26880;
		public TooManyListenersException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TooManyListenersException.staticClass, global::java.util.TooManyListenersException._TooManyListenersException26880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TooManyListenersException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TooManyListenersException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TooManyListenersException"));
			global::java.util.TooManyListenersException._TooManyListenersException26879 = @__env.GetMethodIDNoThrow(global::java.util.TooManyListenersException.staticClass, "<init>", "()V");
			global::java.util.TooManyListenersException._TooManyListenersException26880 = @__env.GetMethodIDNoThrow(global::java.util.TooManyListenersException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
