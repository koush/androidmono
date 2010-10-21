namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NullPointerException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NullPointerException()
		{
			InitJNI();
		}
		protected NullPointerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NullPointerException20234;
		public NullPointerException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NullPointerException.staticClass, global::java.lang.NullPointerException._NullPointerException20234);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NullPointerException20235;
		public NullPointerException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NullPointerException.staticClass, global::java.lang.NullPointerException._NullPointerException20235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NullPointerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NullPointerException"));
			global::java.lang.NullPointerException._NullPointerException20234 = @__env.GetMethodIDNoThrow(global::java.lang.NullPointerException.staticClass, "<init>", "()V");
			global::java.lang.NullPointerException._NullPointerException20235 = @__env.GetMethodIDNoThrow(global::java.lang.NullPointerException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
