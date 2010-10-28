namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IncompatibleClassChangeError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IncompatibleClassChangeError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IncompatibleClassChangeError20185;
		public IncompatibleClassChangeError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IncompatibleClassChangeError.staticClass, global::java.lang.IncompatibleClassChangeError._IncompatibleClassChangeError20185);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IncompatibleClassChangeError20186;
		public IncompatibleClassChangeError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IncompatibleClassChangeError.staticClass, global::java.lang.IncompatibleClassChangeError._IncompatibleClassChangeError20186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IncompatibleClassChangeError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IncompatibleClassChangeError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IncompatibleClassChangeError"));
			global::java.lang.IncompatibleClassChangeError._IncompatibleClassChangeError20185 = @__env.GetMethodIDNoThrow(global::java.lang.IncompatibleClassChangeError.staticClass, "<init>", "()V");
			global::java.lang.IncompatibleClassChangeError._IncompatibleClassChangeError20186 = @__env.GetMethodIDNoThrow(global::java.lang.IncompatibleClassChangeError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
