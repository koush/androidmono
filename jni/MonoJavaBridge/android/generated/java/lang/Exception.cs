namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Exception : java.lang.Throwable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Exception()
		{
			InitJNI();
		}
		protected Exception(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _Exception14509;
		public Exception()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception14509);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Exception14510;
		public Exception(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception14510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Exception14511;
		public Exception(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception14511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Exception14512;
		public Exception(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Exception.staticClass, global::java.lang.Exception._Exception14512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Exception.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Exception"));
			global::java.lang.Exception._Exception14509 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "()V");
			global::java.lang.Exception._Exception14510 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Exception._Exception14511 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.Exception._Exception14512 = @__env.GetMethodIDNoThrow(global::java.lang.Exception.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
