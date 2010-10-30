namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExemptionMechanismException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExemptionMechanismException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ExemptionMechanismException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismException._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismException._m0 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanismException.staticClass, global::javax.crypto.ExemptionMechanismException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ExemptionMechanismException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismException._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismException._m1 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanismException.staticClass, global::javax.crypto.ExemptionMechanismException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ExemptionMechanismException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
