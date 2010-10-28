namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidParameterSpecException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidParameterSpecException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterSpecException24028;
		public InvalidParameterSpecException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidParameterSpecException.staticClass, global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException24028);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterSpecException24029;
		public InvalidParameterSpecException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidParameterSpecException.staticClass, global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException24029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidParameterSpecException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.InvalidParameterSpecException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/InvalidParameterSpecException"));
			global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException24028 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidParameterSpecException.staticClass, "<init>", "()V");
			global::java.security.spec.InvalidParameterSpecException._InvalidParameterSpecException24029 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidParameterSpecException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
