namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertSelector_))]
	public partial interface CertSelector : java.lang.Cloneable
	{
		global::java.lang.Object clone();
		bool match(java.security.cert.Certificate arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertSelector))]
	internal sealed partial class CertSelector_ : java.lang.Object, CertSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertSelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23532;
		global::java.lang.Object java.security.cert.CertSelector.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertSelector_._clone23532.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertSelector_._clone23532 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertSelector_.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertSelector_._clone23532)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _match23533;
		bool java.security.cert.CertSelector.match(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertSelector_._match23533.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertSelector_._match23533 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertSelector_.staticClass, "match", "(Ljava/security/cert/Certificate;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.CertSelector_._match23533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CertSelector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertSelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertSelector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
