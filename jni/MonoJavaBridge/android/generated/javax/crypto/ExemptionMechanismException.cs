namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExemptionMechanismException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExemptionMechanismException()
		{
			InitJNI();
		}
		protected ExemptionMechanismException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ExemptionMechanismException28488;
		public ExemptionMechanismException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanismException.staticClass, global::javax.crypto.ExemptionMechanismException._ExemptionMechanismException28488);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExemptionMechanismException28489;
		public ExemptionMechanismException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanismException.staticClass, global::javax.crypto.ExemptionMechanismException._ExemptionMechanismException28489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismException"));
			global::javax.crypto.ExemptionMechanismException._ExemptionMechanismException28488 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismException.staticClass, "<init>", "()V");
			global::javax.crypto.ExemptionMechanismException._ExemptionMechanismException28489 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
