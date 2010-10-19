namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidParameterException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidParameterException()
		{
			InitJNI();
		}
		protected InvalidParameterException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterException17287;
		public InvalidParameterException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidParameterException.staticClass, global::java.security.InvalidParameterException._InvalidParameterException17287);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidParameterException17288;
		public InvalidParameterException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidParameterException.staticClass, global::java.security.InvalidParameterException._InvalidParameterException17288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.InvalidParameterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/InvalidParameterException"));
			global::java.security.InvalidParameterException._InvalidParameterException17287 = @__env.GetMethodIDNoThrow(global::java.security.InvalidParameterException.staticClass, "<init>", "()V");
			global::java.security.InvalidParameterException._InvalidParameterException17288 = @__env.GetMethodIDNoThrow(global::java.security.InvalidParameterException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
