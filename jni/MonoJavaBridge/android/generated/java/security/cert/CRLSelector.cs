namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CRLSelector_))]
	public interface CRLSelector : java.lang.Cloneable
	{
		global::java.lang.Object clone();
		bool match(java.security.cert.CRL arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CRLSelector))]
	public sealed partial class CRLSelector_ : java.lang.Object, CRLSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CRLSelector_()
		{
			InitJNI();
		}
		internal CRLSelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23358;
		 global::java.lang.Object java.security.cert.CRLSelector.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CRLSelector_._clone23358)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CRLSelector_.staticClass, global::java.security.cert.CRLSelector_._clone23358)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _match23359;
		 bool java.security.cert.CRLSelector.match(java.security.cert.CRL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.CRLSelector_._match23359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.CRLSelector_.staticClass, global::java.security.cert.CRLSelector_._match23359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRLSelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRLSelector"));
			global::java.security.cert.CRLSelector_._clone23358 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLSelector_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.CRLSelector_._match23359 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLSelector_.staticClass, "match", "(Ljava/security/cert/CRL;)Z");
		}
	}
}
