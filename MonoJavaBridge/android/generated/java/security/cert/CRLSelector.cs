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
		internal static global::MonoJavaBridge.MethodId _clone23477;
		global::java.lang.Object java.security.cert.CRLSelector.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CRLSelector_._clone23477)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _match23478;
		bool java.security.cert.CRLSelector.match(java.security.cert.CRL arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.CRLSelector_._match23478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CRLSelector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRLSelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRLSelector"));
			global::java.security.cert.CRLSelector_._clone23477 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLSelector_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.CRLSelector_._match23478 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLSelector_.staticClass, "match", "(Ljava/security/cert/CRL;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
