namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.Key_))]
	public partial interface Key : java.io.Serializable
	{
		byte[] getEncoded();
		global::java.lang.String getAlgorithm();
		global::java.lang.String getFormat();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Key))]
	internal sealed partial class Key_ : java.lang.Object, Key
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Key_()
		{
			InitJNI();
		}
		internal Key_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23005;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Key_._getEncoded23005)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Key_.staticClass, global::java.security.Key_._getEncoded23005)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23006;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Key_._getAlgorithm23006)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Key_.staticClass, global::java.security.Key_._getAlgorithm23006)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23007;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Key_._getFormat23007)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Key_.staticClass, global::java.security.Key_._getFormat23007)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Key_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Key"));
			global::java.security.Key_._getEncoded23005 = @__env.GetMethodIDNoThrow(global::java.security.Key_.staticClass, "getEncoded", "()[B");
			global::java.security.Key_._getAlgorithm23006 = @__env.GetMethodIDNoThrow(global::java.security.Key_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.Key_._getFormat23007 = @__env.GetMethodIDNoThrow(global::java.security.Key_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
