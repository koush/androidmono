namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.PBEKey_))]
	public partial interface PBEKey : SecretKey
	{
		char[] getPassword();
		int getIterationCount();
		byte[] getSalt();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.PBEKey))]
	internal sealed partial class PBEKey_ : java.lang.Object, PBEKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PBEKey_()
		{
			InitJNI();
		}
		internal PBEKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPassword28748;
		 char[] javax.crypto.interfaces.PBEKey.getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getPassword28748)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getPassword28748)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getIterationCount28749;
		 int javax.crypto.interfaces.PBEKey.getIterationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getIterationCount28749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getIterationCount28749);
		}
		internal static global::MonoJavaBridge.MethodId _getSalt28750;
		 byte[] javax.crypto.interfaces.PBEKey.getSalt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getSalt28750)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getSalt28750)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28751;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getEncoded28751)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getEncoded28751)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28752;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getAlgorithm28752)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getAlgorithm28752)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28753;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_._getFormat28753)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.PBEKey_.staticClass, global::javax.crypto.interfaces.PBEKey_._getFormat28753)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.PBEKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/PBEKey"));
			global::javax.crypto.interfaces.PBEKey_._getPassword28748 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getPassword", "()[C");
			global::javax.crypto.interfaces.PBEKey_._getIterationCount28749 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getIterationCount", "()I");
			global::javax.crypto.interfaces.PBEKey_._getSalt28750 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getSalt", "()[B");
			global::javax.crypto.interfaces.PBEKey_._getEncoded28751 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getEncoded", "()[B");
			global::javax.crypto.interfaces.PBEKey_._getAlgorithm28752 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.interfaces.PBEKey_._getFormat28753 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.PBEKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
