namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CRLSelector_))]
	public partial interface CRLSelector : java.lang.Cloneable
	{
		global::java.lang.Object clone();
		bool match(java.security.cert.CRL arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CRLSelector))]
	internal sealed partial class CRLSelector_ : java.lang.Object, CRLSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CRLSelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.security.cert.CRLSelector.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CRLSelector_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.CRLSelector_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.security.cert.CRLSelector.match(java.security.cert.CRL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.CRLSelector_.staticClass, "match", "(Ljava/security/cert/CRL;)Z", ref global::java.security.cert.CRLSelector_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CRLSelector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRLSelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRLSelector"));
		}
	}
}
