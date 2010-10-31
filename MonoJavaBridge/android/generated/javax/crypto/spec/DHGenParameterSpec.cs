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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getExponentSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.DHGenParameterSpec.staticClass, "getExponentSize", "()I", ref global::javax.crypto.spec.DHGenParameterSpec._m0);
		}
		public new int PrimeSize
		{
			get
			{
				return getPrimeSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getPrimeSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.DHGenParameterSpec.staticClass, "getPrimeSize", "()I", ref global::javax.crypto.spec.DHGenParameterSpec._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DHGenParameterSpec(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHGenParameterSpec._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHGenParameterSpec._m2 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHGenParameterSpec.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHGenParameterSpec.staticClass, global::javax.crypto.spec.DHGenParameterSpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DHGenParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHGenParameterSpec"));
		}
	}
}
