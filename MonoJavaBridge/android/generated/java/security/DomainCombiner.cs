namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.DomainCombiner_))]
	public partial interface DomainCombiner  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.security.ProtectionDomain[] combine(java.security.ProtectionDomain[] arg0, java.security.ProtectionDomain[] arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.DomainCombiner))]
	internal sealed partial class DomainCombiner_ : java.lang.Object, DomainCombiner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DomainCombiner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _combine22952;
		global::java.security.ProtectionDomain[] java.security.DomainCombiner.combine(java.security.ProtectionDomain[] arg0, java.security.ProtectionDomain[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.ProtectionDomain>(this, global::java.security.DomainCombiner_.staticClass, "combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;", ref global::java.security.DomainCombiner_._combine22952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.ProtectionDomain[];
		}
		static DomainCombiner_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.DomainCombiner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/DomainCombiner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
