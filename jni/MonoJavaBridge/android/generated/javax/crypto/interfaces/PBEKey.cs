namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.PBEKey_))]
	public interface PBEKey : SecretKey
	{
		char[] getPassword();
		int getIterationCount();
		byte[] getSalt();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.PBEKey))]
	public sealed partial class PBEKey_ : java.lang.Object, PBEKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PBEKey_()
		{
			InitJNI();
		}
		internal PBEKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPassword22731;
		 char[] javax.crypto.interfaces.PBEKey.getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getPassword22731)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getPassword22731)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getIterationCount22732;
		 int javax.crypto.interfaces.PBEKey.getIterationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getIterationCount22732);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getIterationCount22732);
		}
		internal static global::MonoJavaBridge.MethodId _getSalt22733;
		 byte[] javax.crypto.interfaces.PBEKey.getSalt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getSalt22733)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getSalt22733)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded22734;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getEncoded22734)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getEncoded22734)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22735;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getAlgorithm22735)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getAlgorithm22735)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat22736;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getFormat22736)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getFormat22736)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.PBEKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/PBEKey"));
			global::javax.crypto.interfaces.PBEKey_._getPassword22731 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getPassword", "()[C");
			global::javax.crypto.interfaces.PBEKey_._getIterationCount22732 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getIterationCount", "()I");
			global::javax.crypto.interfaces.PBEKey_._getSalt22733 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getSalt", "()[B");
			global::javax.crypto.interfaces.PBEKey_._getEncoded22734 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getEncoded", "()[B");
			global::javax.crypto.interfaces.PBEKey_._getAlgorithm22735 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.interfaces.PBEKey_._getFormat22736 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
