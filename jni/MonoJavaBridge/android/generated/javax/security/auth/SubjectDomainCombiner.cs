namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SubjectDomainCombiner : java.lang.Object, java.security.DomainCombiner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SubjectDomainCombiner()
		{
			InitJNI();
		}
		protected SubjectDomainCombiner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _combine30195;
		public virtual global::java.security.ProtectionDomain[] combine(java.security.ProtectionDomain[] arg0, java.security.ProtectionDomain[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.ProtectionDomain>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.SubjectDomainCombiner._combine30195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.ProtectionDomain[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.ProtectionDomain>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.SubjectDomainCombiner.staticClass, global::javax.security.auth.SubjectDomainCombiner._combine30195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.ProtectionDomain[];
		}
		public new global::javax.security.auth.Subject Subject
		{
			get
			{
				return getSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubject30196;
		public virtual global::javax.security.auth.Subject getSubject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.Subject>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.SubjectDomainCombiner._getSubject30196)) as javax.security.auth.Subject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.Subject>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.SubjectDomainCombiner.staticClass, global::javax.security.auth.SubjectDomainCombiner._getSubject30196)) as javax.security.auth.Subject;
		}
		internal static global::MonoJavaBridge.MethodId _SubjectDomainCombiner30197;
		public SubjectDomainCombiner(javax.security.auth.Subject arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.SubjectDomainCombiner.staticClass, global::javax.security.auth.SubjectDomainCombiner._SubjectDomainCombiner30197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.SubjectDomainCombiner.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/SubjectDomainCombiner"));
			global::javax.security.auth.SubjectDomainCombiner._combine30195 = @__env.GetMethodIDNoThrow(global::javax.security.auth.SubjectDomainCombiner.staticClass, "combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;");
			global::javax.security.auth.SubjectDomainCombiner._getSubject30196 = @__env.GetMethodIDNoThrow(global::javax.security.auth.SubjectDomainCombiner.staticClass, "getSubject", "()Ljavax/security/auth/Subject;");
			global::javax.security.auth.SubjectDomainCombiner._SubjectDomainCombiner30197 = @__env.GetMethodIDNoThrow(global::javax.security.auth.SubjectDomainCombiner.staticClass, "<init>", "(Ljavax/security/auth/Subject;)V");
		}
	}
}
