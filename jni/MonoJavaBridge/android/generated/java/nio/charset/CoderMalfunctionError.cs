namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CoderMalfunctionError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CoderMalfunctionError()
		{
			InitJNI();
		}
		protected CoderMalfunctionError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CoderMalfunctionError22795;
		public CoderMalfunctionError(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CoderMalfunctionError.staticClass, global::java.nio.charset.CoderMalfunctionError._CoderMalfunctionError22795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CoderMalfunctionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CoderMalfunctionError"));
			global::java.nio.charset.CoderMalfunctionError._CoderMalfunctionError22795 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderMalfunctionError.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
