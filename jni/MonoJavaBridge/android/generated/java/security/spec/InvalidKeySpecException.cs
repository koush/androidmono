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
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException18296;
		public InvalidKeySpecException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18296);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException18297;
		public InvalidKeySpecException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException18298;
		public InvalidKeySpecException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException18299;
		public InvalidKeySpecException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.InvalidKeySpecException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/InvalidKeySpecException"));
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18296 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "()V");
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18297 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18298 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException18299 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
