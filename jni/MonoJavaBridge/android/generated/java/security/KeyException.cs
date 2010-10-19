namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyException()
		{
			InitJNI();
		}
		protected KeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _KeyException17292;
		public KeyException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException17292);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyException17293;
		public KeyException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException17293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyException17294;
		public KeyException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException17294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyException17295;
		public KeyException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException17295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyException"));
			global::java.security.KeyException._KeyException17292 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "()V");
			global::java.security.KeyException._KeyException17293 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.KeyException._KeyException17294 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.KeyException._KeyException17295 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
