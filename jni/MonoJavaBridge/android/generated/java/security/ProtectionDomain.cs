namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtectionDomain : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProtectionDomain()
		{
			InitJNI();
		}
		protected ProtectionDomain(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23252;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain._toString23252)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._toString23252)) as java.lang.String;
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader23253;
		public virtual global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain._getClassLoader23253)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getClassLoader23253)) as java.lang.ClassLoader;
		}
		public new global::java.security.CodeSource CodeSource
		{
			get
			{
				return getCodeSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCodeSource23254;
		public virtual global::java.security.CodeSource getCodeSource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain._getCodeSource23254)) as java.security.CodeSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getCodeSource23254)) as java.security.CodeSource;
		}
		public new global::java.security.Principal[] Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals23255;
		public virtual global::java.security.Principal[] getPrincipals() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain._getPrincipals23255)) as java.security.Principal[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getPrincipals23255)) as java.security.Principal[];
		}
		public new global::java.security.PermissionCollection Permissions
		{
			get
			{
				return getPermissions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23256;
		public virtual global::java.security.PermissionCollection getPermissions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain._getPermissions23256)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getPermissions23256)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _implies23257;
		public virtual bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.ProtectionDomain._implies23257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._implies23257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ProtectionDomain23258;
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._ProtectionDomain23258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProtectionDomain23259;
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1, java.lang.ClassLoader arg2, java.security.Principal[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._ProtectionDomain23259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.ProtectionDomain.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/ProtectionDomain"));
			global::java.security.ProtectionDomain._toString23252 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.ProtectionDomain._getClassLoader23253 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.security.ProtectionDomain._getCodeSource23254 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "getCodeSource", "()Ljava/security/CodeSource;");
			global::java.security.ProtectionDomain._getPrincipals23255 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "getPrincipals", "()[Ljava/security/Principal;");
			global::java.security.ProtectionDomain._getPermissions23256 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "getPermissions", "()Ljava/security/PermissionCollection;");
			global::java.security.ProtectionDomain._implies23257 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.ProtectionDomain._ProtectionDomain23258 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V");
			global::java.security.ProtectionDomain._ProtectionDomain23259 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLoader;[Ljava/security/Principal;)V");
		}
	}
}
