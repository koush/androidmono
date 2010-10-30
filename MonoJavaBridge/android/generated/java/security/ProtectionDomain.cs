namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtectionDomain : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProtectionDomain(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.ProtectionDomain.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.ProtectionDomain._m0) as java.lang.String;
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.ClassLoader getClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.ProtectionDomain.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;", ref global::java.security.ProtectionDomain._m1) as java.lang.ClassLoader;
		}
		public new global::java.security.CodeSource CodeSource
		{
			get
			{
				return getCodeSource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.CodeSource getCodeSource()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.ProtectionDomain.staticClass, "getCodeSource", "()Ljava/security/CodeSource;", ref global::java.security.ProtectionDomain._m2) as java.security.CodeSource;
		}
		public new global::java.security.Principal[] Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.security.Principal[] getPrincipals()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.Principal>(this, global::java.security.ProtectionDomain.staticClass, "getPrincipals", "()[Ljava/security/Principal;", ref global::java.security.ProtectionDomain._m3) as java.security.Principal[];
		}
		public new global::java.security.PermissionCollection Permissions
		{
			get
			{
				return getPermissions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.PermissionCollection getPermissions()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.ProtectionDomain.staticClass, "getPermissions", "()Ljava/security/PermissionCollection;", ref global::java.security.ProtectionDomain._m4) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.ProtectionDomain.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.ProtectionDomain._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.ProtectionDomain._m6.native == global::System.IntPtr.Zero)
				global::java.security.ProtectionDomain._m6 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ProtectionDomain(java.security.CodeSource arg0, java.security.PermissionCollection arg1, java.lang.ClassLoader arg2, java.security.Principal[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.ProtectionDomain._m7.native == global::System.IntPtr.Zero)
				global::java.security.ProtectionDomain._m7 = @__env.GetMethodIDNoThrow(global::java.security.ProtectionDomain.staticClass, "<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLoader;[Ljava/security/Principal;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProtectionDomain.staticClass, global::java.security.ProtectionDomain._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ProtectionDomain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.ProtectionDomain.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/ProtectionDomain"));
		}
		internal static void InitJNI()
		{
		}
	}
}
