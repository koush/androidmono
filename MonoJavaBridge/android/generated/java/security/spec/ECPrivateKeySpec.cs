namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECPrivateKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECPrivateKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.security.spec.ECParameterSpec Params
		{
			get
			{
				return getParams();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.spec.ECParameterSpec getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECPrivateKeySpec.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;", ref global::java.security.spec.ECPrivateKeySpec._m0) as java.security.spec.ECParameterSpec;
		}
		public new global::java.math.BigInteger S
		{
			get
			{
				return getS();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.math.BigInteger getS()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECPrivateKeySpec.staticClass, "getS", "()Ljava/math/BigInteger;", ref global::java.security.spec.ECPrivateKeySpec._m1) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ECPrivateKeySpec(java.math.BigInteger arg0, java.security.spec.ECParameterSpec arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECPrivateKeySpec._m2.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECPrivateKeySpec._m2 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPrivateKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECPrivateKeySpec.staticClass, global::java.security.spec.ECPrivateKeySpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ECPrivateKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECPrivateKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECPrivateKeySpec"));
		}
	}
}
