namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidParameterSpecException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidParameterSpecException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InvalidParameterSpecException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.InvalidParameterSpecException._m0.native == global::System.IntPtr.Zero)
				global::java.security.spec.InvalidParameterSpecException._m0 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidParameterSpecException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidParameterSpecException.staticClass, global::java.security.spec.InvalidParameterSpecException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InvalidParameterSpecException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.InvalidParameterSpecException._m1.native == global::System.IntPtr.Zero)
				global::java.security.spec.InvalidParameterSpecException._m1 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidParameterSpecException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidParameterSpecException.staticClass, global::java.security.spec.InvalidParameterSpecException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidParameterSpecException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.InvalidParameterSpecException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/InvalidParameterSpecException"));
		}
	}
}
