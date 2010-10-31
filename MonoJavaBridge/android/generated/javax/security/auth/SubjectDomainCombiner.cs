namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SubjectDomainCombiner : java.lang.Object, java.security.DomainCombiner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SubjectDomainCombiner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.ProtectionDomain[] combine(java.security.ProtectionDomain[] arg0, java.security.ProtectionDomain[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.ProtectionDomain>(this, global::javax.security.auth.SubjectDomainCombiner.staticClass, "combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;", ref global::javax.security.auth.SubjectDomainCombiner._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.ProtectionDomain[];
		}
		public new global::javax.security.auth.Subject Subject
		{
			get
			{
				return getSubject();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::javax.security.auth.Subject getSubject()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.Subject>(this, global::javax.security.auth.SubjectDomainCombiner.staticClass, "getSubject", "()Ljavax/security/auth/Subject;", ref global::javax.security.auth.SubjectDomainCombiner._m1) as javax.security.auth.Subject;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public SubjectDomainCombiner(javax.security.auth.Subject arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.SubjectDomainCombiner._m2.native == global::System.IntPtr.Zero)
				global::javax.security.auth.SubjectDomainCombiner._m2 = @__env.GetMethodIDNoThrow(global::javax.security.auth.SubjectDomainCombiner.staticClass, "<init>", "(Ljavax/security/auth/Subject;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.SubjectDomainCombiner.staticClass, global::javax.security.auth.SubjectDomainCombiner._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SubjectDomainCombiner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.SubjectDomainCombiner.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/SubjectDomainCombiner"));
		}
	}
}
