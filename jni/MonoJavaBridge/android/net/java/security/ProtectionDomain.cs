namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ProtectionDomain : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ProtectionDomain() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.ProtectionDomain), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString12460; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._toString12460)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._toString12460)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader12461; 
		public virtual global::java.lang.ClassLoader getClassLoader() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getClassLoader12461)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getClassLoader12461)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCodeSource12462; 
		public virtual global::java.security.CodeSource getCodeSource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.CodeSource>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getCodeSource12462)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.CodeSource>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getCodeSource12462)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrincipals12463; 
		public virtual global::java.security.Principal[] getPrincipals() 
		{ 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getPrincipals12463)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getPrincipals12463)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPermissions12464; 
		public virtual global::java.security.PermissionCollection getPermissions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getPermissions12464)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getPermissions12464)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implies12465; 
		public virtual bool implies(java.security.Permission arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.ProtectionDomain)) 
				return @__env.CallBooleanMethod(this, global::java.security.ProtectionDomain._implies12465, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._implies12465, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProtectionDomain12466; 
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._ProtectionDomain12466, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProtectionDomain12467; 
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1, java.lang.ClassLoader arg2, java.security.Principal[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._ProtectionDomain12467, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.security.Principal[], java.security.Principal>(@__env, arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.ProtectionDomain.staticClass = @__class; 
			global::java.security.ProtectionDomain._toString12460 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.ProtectionDomain._getClassLoader12461 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;"); 
			global::java.security.ProtectionDomain._getCodeSource12462 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getCodeSource", "()Ljava/security/CodeSource;"); 
			global::java.security.ProtectionDomain._getPrincipals12463 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getPrincipals", "()[Ljava/security/Principal;"); 
			global::java.security.ProtectionDomain._getPermissions12464 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getPermissions", "()Ljava/security/PermissionCollection;"); 
			global::java.security.ProtectionDomain._implies12465 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "implies", "(Ljava/security/Permission;)Z"); 
			global::java.security.ProtectionDomain._ProtectionDomain12466 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V"); 
			global::java.security.ProtectionDomain._ProtectionDomain12467 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLoader;[Ljava/security/Principal;)V"); 
		} 
	} 
} 
