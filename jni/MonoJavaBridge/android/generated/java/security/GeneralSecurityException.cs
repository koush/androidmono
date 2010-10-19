namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GeneralSecurityException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GeneralSecurityException()
		{
			InitJNI();
		}
		protected GeneralSecurityException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException17236;
		public GeneralSecurityException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException17236);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException17237;
		public GeneralSecurityException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException17237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException17238;
		public GeneralSecurityException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException17238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException17239;
		public GeneralSecurityException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException17239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.GeneralSecurityException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/GeneralSecurityException"));
			global::java.security.GeneralSecurityException._GeneralSecurityException17236 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "()V");
			global::java.security.GeneralSecurityException._GeneralSecurityException17237 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.GeneralSecurityException._GeneralSecurityException17238 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.GeneralSecurityException._GeneralSecurityException17239 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
