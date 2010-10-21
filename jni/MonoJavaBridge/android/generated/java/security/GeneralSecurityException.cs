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
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException22834;
		public GeneralSecurityException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException22834);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException22835;
		public GeneralSecurityException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException22835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException22836;
		public GeneralSecurityException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException22836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GeneralSecurityException22837;
		public GeneralSecurityException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._GeneralSecurityException22837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.GeneralSecurityException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/GeneralSecurityException"));
			global::java.security.GeneralSecurityException._GeneralSecurityException22834 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "()V");
			global::java.security.GeneralSecurityException._GeneralSecurityException22835 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.GeneralSecurityException._GeneralSecurityException22836 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.GeneralSecurityException._GeneralSecurityException22837 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
