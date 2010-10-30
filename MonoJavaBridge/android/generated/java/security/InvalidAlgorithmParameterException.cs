namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidAlgorithmParameterException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidAlgorithmParameterException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22996;
		public InvalidAlgorithmParameterException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22996.native == global::System.IntPtr.Zero)
				global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22996 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22996);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22997;
		public InvalidAlgorithmParameterException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22997.native == global::System.IntPtr.Zero)
				global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22997 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22998;
		public InvalidAlgorithmParameterException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22998.native == global::System.IntPtr.Zero)
				global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22998 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidAlgorithmParameterException22999;
		public InvalidAlgorithmParameterException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22999.native == global::System.IntPtr.Zero)
				global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22999 = @__env.GetMethodIDNoThrow(global::java.security.InvalidAlgorithmParameterException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidAlgorithmParameterException.staticClass, global::java.security.InvalidAlgorithmParameterException._InvalidAlgorithmParameterException22999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidAlgorithmParameterException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.InvalidAlgorithmParameterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/InvalidAlgorithmParameterException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
