namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECPrivateKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECPrivateKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getParams23887;
		public virtual global::java.security.spec.ECParameterSpec getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECPrivateKeySpec._getParams23887)) as java.security.spec.ECParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECPrivateKeySpec.staticClass, global::java.security.spec.ECPrivateKeySpec._getParams23887)) as java.security.spec.ECParameterSpec;
		}
		public new global::java.math.BigInteger S
		{
			get
			{
				return getS();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getS23888;
		public virtual global::java.math.BigInteger getS() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECPrivateKeySpec._getS23888)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECPrivateKeySpec.staticClass, global::java.security.spec.ECPrivateKeySpec._getS23888)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _ECPrivateKeySpec23889;
		public ECPrivateKeySpec(java.math.BigInteger arg0, java.security.spec.ECParameterSpec arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECPrivateKeySpec.staticClass, global::java.security.spec.ECPrivateKeySpec._ECPrivateKeySpec23889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECPrivateKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECPrivateKeySpec"));
			global::java.security.spec.ECPrivateKeySpec._getParams23887 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPrivateKeySpec.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
			global::java.security.spec.ECPrivateKeySpec._getS23888 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPrivateKeySpec.staticClass, "getS", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECPrivateKeySpec._ECPrivateKeySpec23889 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPrivateKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V");
		}
	}
}
