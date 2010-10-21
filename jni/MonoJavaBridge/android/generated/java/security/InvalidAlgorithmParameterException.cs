namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidAlgorithmParameterException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidAlgorithmParameterException()
		{
			InitJNI();
		}
		protected InvalidAlgorithmParameterException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22877;
		public InvalidAlgorithmParameterException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22877);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22878;
		public InvalidAlgorithmParameterException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22879;
		public InvalidAlgorithmParameterException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22880;
		public InvalidAlgorithmParameterException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.InvalidAlgorithmParameterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/InvalidAlgorithmParameterException"));
			global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22877 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "()V");
			global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22878 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22879 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22880 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
