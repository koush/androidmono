namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalArgumentException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalArgumentException()
		{
			InitJNI();
		}
		protected IllegalArgumentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException14549;
		public IllegalArgumentException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException14549);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException14550;
		public IllegalArgumentException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException14550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException14551;
		public IllegalArgumentException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException14551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException14552;
		public IllegalArgumentException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException14552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalArgumentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalArgumentException"));
			global::java.lang.IllegalArgumentException._IllegalArgumentException14549 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "()V");
			global::java.lang.IllegalArgumentException._IllegalArgumentException14550 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.IllegalArgumentException._IllegalArgumentException14551 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.IllegalArgumentException._IllegalArgumentException14552 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
