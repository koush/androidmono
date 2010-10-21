namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidKeySpecException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidKeySpecException()
		{
			InitJNI();
		}
		protected InvalidKeySpecException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException23905;
		public InvalidKeySpecException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23905);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException23906;
		public InvalidKeySpecException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException23907;
		public InvalidKeySpecException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException23908;
		public InvalidKeySpecException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.InvalidKeySpecException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/InvalidKeySpecException"));
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23905 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "()V");
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23906 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23907 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException23908 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
