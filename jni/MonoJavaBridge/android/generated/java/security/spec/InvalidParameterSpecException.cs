namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidParameterSpecException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidParameterSpecException()
		{
			InitJNI();
		}
		protected InvalidParameterSpecException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterSpecException18300;
		public InvalidParameterSpecException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidParameterSpecException.staticClass, global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException18300);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterSpecException18301;
		public InvalidParameterSpecException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidParameterSpecException.staticClass, global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException18301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.InvalidParameterSpecException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/InvalidParameterSpecException"));
			global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException18300 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidParameterSpecException.staticClass, "<init>", "()V");
			global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException18301 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidParameterSpecException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
