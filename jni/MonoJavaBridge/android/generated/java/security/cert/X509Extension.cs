namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.X509Extension_))]
	public partial interface X509Extension  : global::MonoJavaBridge.IJavaObject 
	{
		bool hasUnsupportedCriticalExtension();
		global::java.util.Set getCriticalExtensionOIDs();
		global::java.util.Set getNonCriticalExtensionOIDs();
		byte[] getExtensionValue(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509Extension))]
	internal sealed partial class X509Extension_ : java.lang.Object, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509Extension_()
		{
			InitJNI();
		}
		internal X509Extension_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23890;
		bool java.security.cert.X509Extension.hasUnsupportedCriticalExtension()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509Extension_._hasUnsupportedCriticalExtension23890);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509Extension_.staticClass, global::java.security.cert.X509Extension_._hasUnsupportedCriticalExtension23890);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23891;
		global::java.util.Set java.security.cert.X509Extension.getCriticalExtensionOIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Extension_._getCriticalExtensionOIDs23891)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Extension_.staticClass, global::java.security.cert.X509Extension_._getCriticalExtensionOIDs23891)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23892;
		global::java.util.Set java.security.cert.X509Extension.getNonCriticalExtensionOIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Extension_._getNonCriticalExtensionOIDs23892)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Extension_.staticClass, global::java.security.cert.X509Extension_._getNonCriticalExtensionOIDs23892)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23893;
		byte[] java.security.cert.X509Extension.getExtensionValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Extension_._getExtensionValue23893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Extension_.staticClass, global::java.security.cert.X509Extension_._getExtensionValue23893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Extension_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Extension"));
			global::java.security.cert.X509Extension_._hasUnsupportedCriticalExtension23890 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Extension_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Extension_._getCriticalExtensionOIDs23891 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Extension_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Extension_._getNonCriticalExtensionOIDs23892 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Extension_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Extension_._getExtensionValue23893 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Extension_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
		}
	}
}
