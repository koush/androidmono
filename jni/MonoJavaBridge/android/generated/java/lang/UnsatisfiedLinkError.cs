namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsatisfiedLinkError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsatisfiedLinkError()
		{
			InitJNI();
		}
		protected UnsatisfiedLinkError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsatisfiedLinkError20806;
		public UnsatisfiedLinkError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsatisfiedLinkError.staticClass, global::java.lang.UnsatisfiedLinkError._UnsatisfiedLinkError20806);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsatisfiedLinkError20807;
		public UnsatisfiedLinkError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsatisfiedLinkError.staticClass, global::java.lang.UnsatisfiedLinkError._UnsatisfiedLinkError20807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnsatisfiedLinkError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnsatisfiedLinkError"));
			global::java.lang.UnsatisfiedLinkError._UnsatisfiedLinkError20806 = @__env.GetMethodIDNoThrow(global::java.lang.UnsatisfiedLinkError.staticClass, "<init>", "()V");
			global::java.lang.UnsatisfiedLinkError._UnsatisfiedLinkError20807 = @__env.GetMethodIDNoThrow(global::java.lang.UnsatisfiedLinkError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
