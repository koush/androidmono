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
		internal X509Extension_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.security.cert.X509Extension.hasUnsupportedCriticalExtension()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509Extension_.staticClass, "hasUnsupportedCriticalExtension", "()Z", ref global::java.security.cert.X509Extension_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.util.Set java.security.cert.X509Extension.getCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509Extension_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509Extension_._m1) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.util.Set java.security.cert.X509Extension.getNonCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509Extension_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509Extension_._m2) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		byte[] java.security.cert.X509Extension.getExtensionValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Extension_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B", ref global::java.security.cert.X509Extension_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		static X509Extension_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Extension_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Extension"));
		}
	}
}
