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
		internal static global::net.sf.jni4net.jni.MethodId _toString13240;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._toString13240));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._toString13240));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader13241;
		public virtual global::java.lang.ClassLoader getClassLoader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getClassLoader13241));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getClassLoader13241));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCodeSource13242;
		public virtual global::java.security.CodeSource getCodeSource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.CodeSource>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getCodeSource13242));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.CodeSource>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getCodeSource13242));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPrincipals13243;
		public virtual global::java.security.Principal[] getPrincipals() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getPrincipals13243));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getPrincipals13243));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPermissions13244;
		public virtual global::java.security.PermissionCollection getPermissions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.ProtectionDomain._getPermissions13244));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._getPermissions13244));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implies13245;
		public virtual bool implies(java.security.Permission arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.ProtectionDomain._implies13245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._implies13245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProtectionDomain13246;
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._ProtectionDomain13246, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProtectionDomain13247;
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1, java.lang.ClassLoader arg2, java.security.Principal[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._ProtectionDomain13247, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.security.Principal[], java.security.Principal>(@__env, arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.ProtectionDomain.staticClass = @__class;
			global::java.security.ProtectionDomain._toString13240 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.ProtectionDomain._getClassLoader13241 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.security.ProtectionDomain._getCodeSource13242 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getCodeSource", "()Ljava/security/CodeSource;");
			global::java.security.ProtectionDomain._getPrincipals13243 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getPrincipals", "()[Ljava/security/Principal;");
			global::java.security.ProtectionDomain._getPermissions13244 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "getPermissions", "()Ljava/security/PermissionCollection;");
			global::java.security.ProtectionDomain._implies13245 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.ProtectionDomain._ProtectionDomain13246 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V");
			global::java.security.ProtectionDomain._ProtectionDomain13247 = @__env.GetMethodID(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLoader;[Ljava/security/Principal;)V");
		}
	}
}
