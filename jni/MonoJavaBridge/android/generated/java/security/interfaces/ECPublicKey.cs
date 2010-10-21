namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.ECPublicKey_))]
	public interface ECPublicKey : PublicKey, ECKey
	{
		global::java.security.spec.ECPoint getW();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.ECPublicKey))]
	public sealed partial class ECPublicKey_ : java.lang.Object, ECPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECPublicKey_()
		{
			InitJNI();
		}
		internal ECPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getW23801;
		 global::java.security.spec.ECPoint java.security.interfaces.ECPublicKey.getW() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getW23801)) as java.security.spec.ECPoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getW23801)) as java.security.spec.ECPoint;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23802;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getEncoded23802)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getEncoded23802)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23803;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getAlgorithm23803)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getAlgorithm23803)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23804;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getFormat23804)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getFormat23804)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23805;
		 global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getParams23805)) as java.security.spec.ECParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getParams23805)) as java.security.spec.ECParameterSpec;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPublicKey"));
			global::java.security.interfaces.ECPublicKey_._getW23801 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getW", "()Ljava/security/spec/ECPoint;");
			global::java.security.interfaces.ECPublicKey_._getEncoded23802 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.ECPublicKey_._getAlgorithm23803 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPublicKey_._getFormat23804 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPublicKey_._getParams23805 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
		}
	}
}
