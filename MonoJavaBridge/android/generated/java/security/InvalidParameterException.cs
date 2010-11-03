namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidParameterException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidParameterException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InvalidParameterException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.InvalidParameterException._m0.native == global::System.IntPtr.Zero)
				global::java.security.InvalidParameterException._m0 = @__env.GetMethodIDNoThrow(global::java.security.InvalidParameterException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidParameterException.staticClass, global::java.security.InvalidParameterException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InvalidParameterException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.InvalidParameterException._m1.native == global::System.IntPtr.Zero)
				global::java.security.InvalidParameterException._m1 = @__env.GetMethodIDNoThrow(global::java.security.InvalidParameterException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidParameterException.staticClass, global::java.security.InvalidParameterException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidParameterException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.InvalidParameterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/InvalidParameterException"));
		}
	}
}
