namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PBEParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PBEParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int IterationCount
		{
			get
			{
				return getIterationCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getIterationCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.PBEParameterSpec.staticClass, "getIterationCount", "()I", ref global::javax.crypto.spec.PBEParameterSpec._m0);
		}
		public new byte[] Salt
		{
			get
			{
				return getSalt();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual byte[] getSalt()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.PBEParameterSpec.staticClass, "getSalt", "()[B", ref global::javax.crypto.spec.PBEParameterSpec._m1) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public PBEParameterSpec(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PBEParameterSpec._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PBEParameterSpec._m2 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEParameterSpec.staticClass, "<init>", "([BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEParameterSpec.staticClass, global::javax.crypto.spec.PBEParameterSpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PBEParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PBEParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PBEParameterSpec"));
		}
	}
}
