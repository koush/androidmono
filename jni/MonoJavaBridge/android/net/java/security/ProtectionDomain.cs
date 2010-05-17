namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ProtectionDomain : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ProtectionDomain() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.ProtectionDomain), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.ProtectionDomain(@__env); 
			} 
		} 
		protected ProtectionDomain(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11588; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11588)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.ProtectionDomain.staticClass, _toString11588)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader11589; 
		public virtual java.lang.ClassLoader getClassLoader() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, _getClassLoader11589)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.ProtectionDomain.staticClass, _getClassLoader11589)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCodeSource11590; 
		public virtual java.security.CodeSource getCodeSource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.CodeSource>(@__env, @__env.CallObjectMethodPtr(this, _getCodeSource11590)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.CodeSource>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.ProtectionDomain.staticClass, _getCodeSource11590)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrincipals11591; 
		public virtual java.security.Principal[] getPrincipals() 
		{ 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getPrincipals11591)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.ProtectionDomain.staticClass, _getPrincipals11591)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPermissions11592; 
		public virtual java.security.PermissionCollection getPermissions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallObjectMethodPtr(this, _getPermissions11592)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.ProtectionDomain.staticClass, _getPermissions11592)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implies11593; 
		public virtual bool implies(java.security.Permission arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return @__env.CallBooleanMethod(this, _implies11593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.ProtectionDomain.staticClass, _implies11593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProtectionDomain11594; 
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.ProtectionDomain.staticClass, _ProtectionDomain11594, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProtectionDomain11595; 
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1, java.lang.ClassLoader arg2, java.security.Principal[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.ProtectionDomain.staticClass, _ProtectionDomain11595, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.security.Principal[], java.security.Principal>(@__env, arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.ProtectionDomain.staticClass = @__class; 
			global::java.security.ProtectionDomain._toString11588 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.ProtectionDomain._getClassLoader11589 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;"); 
			global::java.security.ProtectionDomain._getCodeSource11590 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getCodeSource", "()Ljava/security/CodeSource;"); 
			global::java.security.ProtectionDomain._getPrincipals11591 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getPrincipals", "()[Ljava/security/Principal;"); 
			global::java.security.ProtectionDomain._getPermissions11592 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getPermissions", "()Ljava/security/PermissionCollection;"); 
			global::java.security.ProtectionDomain._implies11593 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "implies", "(Ljava/security/Permission;)Z"); 
			global::java.security.ProtectionDomain._ProtectionDomain11594 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V"); 
			global::java.security.ProtectionDomain._ProtectionDomain11595 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLoader;[Ljava/security/Principal;)V"); 
		} 
	} 
} 
