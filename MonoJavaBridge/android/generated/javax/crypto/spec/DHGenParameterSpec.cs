namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHGenParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DHGenParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int ExponentSize
		{
			get
			{
				return getExponentSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExponentSize28767;
		public virtual int getExponentSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.DHGenParameterSpec.staticClass, global::javax.crypto.spec.DHGenParameterSpec._getExponentSize28767);
		}
		public new int PrimeSize
		{
			get
			{
				return getPrimeSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeSize28768;
		public virtual int getPrimeSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.DHGenParameterSpec.staticClass, global::javax.crypto.spec.DHGenParameterSpec._getPrimeSize28768);
		}
		internal static global::MonoJavaBridge.MethodId _DHGenParameterSpec28769;
		public DHGenParameterSpec(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHGenParameterSpec.staticClass, global::javax.crypto.spec.DHGenParameterSpec._DHGenParameterSpec28769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DHGenParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHGenParameterSpec"));
			global::javax.crypto.spec.DHGenParameterSpec._getExponentSize28767 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHGenParameterSpec.staticClass, "getExponentSize", "()I");
			global::javax.crypto.spec.DHGenParameterSpec._getPrimeSize28768 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHGenParameterSpec.staticClass, "getPrimeSize", "()I");
			global::javax.crypto.spec.DHGenParameterSpec._DHGenParameterSpec28769 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHGenParameterSpec.staticClass, "<init>", "(II)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
