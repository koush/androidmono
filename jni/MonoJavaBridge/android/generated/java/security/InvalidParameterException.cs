namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidParameterException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidParameterException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterException23004;
		public InvalidParameterException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidParameterException.staticClass, global::java.security.InvalidParameterException._InvalidParameterException23004);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterException23005;
		public InvalidParameterException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidParameterException.staticClass, global::java.security.InvalidParameterException._InvalidParameterException23005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidParameterException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.InvalidParameterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/InvalidParameterException"));
			global::java.security.InvalidParameterException._InvalidParameterException23004 = @__env.GetMethodIDNoThrow(global::java.security.InvalidParameterException.staticClass, "<init>", "()V");
			global::java.security.InvalidParameterException._InvalidParameterException23005 = @__env.GetMethodIDNoThrow(global::java.security.InvalidParameterException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
