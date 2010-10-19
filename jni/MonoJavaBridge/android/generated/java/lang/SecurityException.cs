namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecurityException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecurityException()
		{
			InitJNI();
		}
		protected SecurityException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SecurityException14827;
		public SecurityException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._SecurityException14827);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecurityException14828;
		public SecurityException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._SecurityException14828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecurityException14829;
		public SecurityException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._SecurityException14829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecurityException14830;
		public SecurityException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._SecurityException14830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SecurityException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SecurityException"));
			global::java.lang.SecurityException._SecurityException14827 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "()V");
			global::java.lang.SecurityException._SecurityException14828 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.SecurityException._SecurityException14829 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.SecurityException._SecurityException14830 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
