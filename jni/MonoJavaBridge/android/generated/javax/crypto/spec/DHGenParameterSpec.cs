namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHGenParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DHGenParameterSpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getExponentSize22746;
		public virtual int getExponentSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.DHGenParameterSpec._getExponentSize22746);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.DHGenParameterSpec.staticClass, global::javax.crypto.spec.DHGenParameterSpec._getExponentSize22746);
		}
		public new int PrimeSize
		{
			get
			{
				return getPrimeSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeSize22747;
		public virtual int getPrimeSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.DHGenParameterSpec._getPrimeSize22747);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.DHGenParameterSpec.staticClass, global::javax.crypto.spec.DHGenParameterSpec._getPrimeSize22747);
		}
		internal static global::MonoJavaBridge.MethodId _DHGenParameterSpec22748;
		public DHGenParameterSpec(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHGenParameterSpec.staticClass, global::javax.crypto.spec.DHGenParameterSpec._DHGenParameterSpec22748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHGenParameterSpec"));
			global::javax.crypto.spec.DHGenParameterSpec._getExponentSize22746 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHGenParameterSpec.staticClass, "getExponentSize", "()I");
			global::javax.crypto.spec.DHGenParameterSpec._getPrimeSize22747 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHGenParameterSpec.staticClass, "getPrimeSize", "()I");
			global::javax.crypto.spec.DHGenParameterSpec._DHGenParameterSpec22748 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHGenParameterSpec.staticClass, "<init>", "(II)V");
		}
	}
}
