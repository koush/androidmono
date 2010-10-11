namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RuntimeException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RuntimeException()
		{
			InitJNI();
		}
		protected RuntimeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException13107;
		public RuntimeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException13107);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException13108;
		public RuntimeException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException13108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException13109;
		public RuntimeException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException13109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException13110;
		public RuntimeException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException13110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.RuntimeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/RuntimeException"));
			global::java.lang.RuntimeException._RuntimeException13107 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "()V");
			global::java.lang.RuntimeException._RuntimeException13108 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.RuntimeException._RuntimeException13109 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.RuntimeException._RuntimeException13110 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
