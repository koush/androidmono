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
		internal static global::MonoJavaBridge.MethodId _getW18197;
		 global::java.security.spec.ECPoint java.security.interfaces.ECPublicKey.getW() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getW18197)) as java.security.spec.ECPoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getW18197)) as java.security.spec.ECPoint;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18198;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getEncoded18198)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getEncoded18198)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm18199;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getAlgorithm18199)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getAlgorithm18199)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat18200;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getFormat18200)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getFormat18200)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParams18201;
		 global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getParams18201)) as java.security.spec.ECParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_.staticClass, global::java.security.interfaces.ECPublicKey_._getParams18201)) as java.security.spec.ECParameterSpec;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPublicKey"));
			global::java.security.interfaces.ECPublicKey_._getW18197 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getW", "()Ljava/security/spec/ECPoint;");
			global::java.security.interfaces.ECPublicKey_._getEncoded18198 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.ECPublicKey_._getAlgorithm18199 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPublicKey_._getFormat18200 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPublicKey_._getParams18201 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
		}
	}
}
