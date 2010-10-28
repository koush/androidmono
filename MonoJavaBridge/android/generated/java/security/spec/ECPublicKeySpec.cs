namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECPublicKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECPublicKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.security.spec.ECParameterSpec Params
		{
			get
			{
				return getParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParams24009;
		public virtual global::java.security.spec.ECParameterSpec getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECPublicKeySpec._getParams24009)) as java.security.spec.ECParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECPublicKeySpec.staticClass, global::java.security.spec.ECPublicKeySpec._getParams24009)) as java.security.spec.ECParameterSpec;
		}
		public new global::java.security.spec.ECPoint W
		{
			get
			{
				return getW();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getW24010;
		public virtual global::java.security.spec.ECPoint getW()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECPublicKeySpec._getW24010)) as java.security.spec.ECPoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECPublicKeySpec.staticClass, global::java.security.spec.ECPublicKeySpec._getW24010)) as java.security.spec.ECPoint;
		}
		internal static global::MonoJavaBridge.MethodId _ECPublicKeySpec24011;
		public ECPublicKeySpec(java.security.spec.ECPoint arg0, java.security.spec.ECParameterSpec arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECPublicKeySpec.staticClass, global::java.security.spec.ECPublicKeySpec._ECPublicKeySpec24011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ECPublicKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECPublicKeySpec"));
			global::java.security.spec.ECPublicKeySpec._getParams24009 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPublicKeySpec.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
			global::java.security.spec.ECPublicKeySpec._getW24010 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPublicKeySpec.staticClass, "getW", "()Ljava/security/spec/ECPoint;");
			global::java.security.spec.ECPublicKeySpec._ECPublicKeySpec24011 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPublicKeySpec.staticClass, "<init>", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
