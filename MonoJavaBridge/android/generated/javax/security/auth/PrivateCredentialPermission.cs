namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PrivateCredentialPermission : java.security.Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PrivateCredentialPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30169;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.auth.PrivateCredentialPermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.security.auth.PrivateCredentialPermission._equals30169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30170;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.security.auth.PrivateCredentialPermission.staticClass, "hashCode", "()I", ref global::javax.security.auth.PrivateCredentialPermission._hashCode30170);
		}
		public new global::java.lang.String[][] Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30171;
		public global::java.lang.String[][] getPrincipals()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String[]>(this, global::javax.security.auth.PrivateCredentialPermission.staticClass, "getPrincipals", "()[[Ljava/lang/String;", ref global::javax.security.auth.PrivateCredentialPermission._getPrincipals30171) as java.lang.String[][];
		}
		internal static global::MonoJavaBridge.MethodId _implies30172;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.auth.PrivateCredentialPermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::javax.security.auth.PrivateCredentialPermission._implies30172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions30173;
		public sealed override global::java.lang.String getActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.PrivateCredentialPermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::javax.security.auth.PrivateCredentialPermission._getActions30173) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection30174;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.auth.PrivateCredentialPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::javax.security.auth.PrivateCredentialPermission._newPermissionCollection30174) as java.security.PermissionCollection;
		}
		public new global::java.lang.String CredentialClass
		{
			get
			{
				return getCredentialClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCredentialClass30175;
		public global::java.lang.String getCredentialClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.PrivateCredentialPermission.staticClass, "getCredentialClass", "()Ljava/lang/String;", ref global::javax.security.auth.PrivateCredentialPermission._getCredentialClass30175) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PrivateCredentialPermission30176;
		public PrivateCredentialPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.PrivateCredentialPermission._PrivateCredentialPermission30176.native == global::System.IntPtr.Zero)
				global::javax.security.auth.PrivateCredentialPermission._PrivateCredentialPermission30176 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._PrivateCredentialPermission30176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PrivateCredentialPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.PrivateCredentialPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/PrivateCredentialPermission"));
		}
		internal static void InitJNI()
		{
		}
	}
}
