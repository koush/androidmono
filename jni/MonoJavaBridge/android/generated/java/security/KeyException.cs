namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _KeyException23010;
		public KeyException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException23010);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyException23011;
		public KeyException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException23011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyException23012;
		public KeyException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException23012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyException23013;
		public KeyException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyException.staticClass, global::java.security.KeyException._KeyException23013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static KeyException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyException"));
			global::java.security.KeyException._KeyException23010 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "()V");
			global::java.security.KeyException._KeyException23011 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.KeyException._KeyException23012 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.KeyException._KeyException23013 = @__env.GetMethodIDNoThrow(global::java.security.KeyException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
