namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PrivateCredentialPermission : java.security.Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrivateCredentialPermission()
		{
			InitJNI();
		}
		internal PrivateCredentialPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30168;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission._equals30168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._equals30168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30169;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission._hashCode30169);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._hashCode30169);
		}
		public new global::java.lang.String[][] Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30170;
		public global::java.lang.String[][] getPrincipals() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission._getPrincipals30170)) as java.lang.String[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._getPrincipals30170)) as java.lang.String[][];
		}
		internal static global::MonoJavaBridge.MethodId _implies30171;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission._implies30171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._implies30171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions30172;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission._getActions30172)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._getActions30172)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection30173;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission._newPermissionCollection30173)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._newPermissionCollection30173)) as java.security.PermissionCollection;
		}
		public new global::java.lang.String CredentialClass
		{
			get
			{
				return getCredentialClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCredentialClass30174;
		public global::java.lang.String getCredentialClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission._getCredentialClass30174)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._getCredentialClass30174)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PrivateCredentialPermission30175;
		public PrivateCredentialPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.PrivateCredentialPermission.staticClass, global::javax.security.auth.PrivateCredentialPermission._PrivateCredentialPermission30175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.PrivateCredentialPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/PrivateCredentialPermission"));
			global::javax.security.auth.PrivateCredentialPermission._equals30168 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.auth.PrivateCredentialPermission._hashCode30169 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "hashCode", "()I");
			global::javax.security.auth.PrivateCredentialPermission._getPrincipals30170 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "getPrincipals", "()[[Ljava/lang/String;");
			global::javax.security.auth.PrivateCredentialPermission._implies30171 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::javax.security.auth.PrivateCredentialPermission._getActions30172 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::javax.security.auth.PrivateCredentialPermission._newPermissionCollection30173 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::javax.security.auth.PrivateCredentialPermission._getCredentialClass30174 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "getCredentialClass", "()Ljava/lang/String;");
			global::javax.security.auth.PrivateCredentialPermission._PrivateCredentialPermission30175 = @__env.GetMethodIDNoThrow(global::javax.security.auth.PrivateCredentialPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
