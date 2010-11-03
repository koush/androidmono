namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UnresolvedPermission : java.security.Permission, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UnresolvedPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.UnresolvedPermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.UnresolvedPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.UnresolvedPermission.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.UnresolvedPermission._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.UnresolvedPermission.staticClass, "hashCode", "()I", ref global::java.security.UnresolvedPermission._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.UnresolvedPermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.UnresolvedPermission._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::java.lang.String getActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.UnresolvedPermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.security.UnresolvedPermission._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.UnresolvedPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.security.UnresolvedPermission._m5) as java.security.PermissionCollection;
		}
		public new global::java.lang.String UnresolvedType
		{
			get
			{
				return getUnresolvedType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String getUnresolvedType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.UnresolvedPermission.staticClass, "getUnresolvedType", "()Ljava/lang/String;", ref global::java.security.UnresolvedPermission._m6) as java.lang.String;
		}
		public new global::java.lang.String UnresolvedName
		{
			get
			{
				return getUnresolvedName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.String getUnresolvedName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.UnresolvedPermission.staticClass, "getUnresolvedName", "()Ljava/lang/String;", ref global::java.security.UnresolvedPermission._m7) as java.lang.String;
		}
		public new global::java.lang.String UnresolvedActions
		{
			get
			{
				return getUnresolvedActions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.String getUnresolvedActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.UnresolvedPermission.staticClass, "getUnresolvedActions", "()Ljava/lang/String;", ref global::java.security.UnresolvedPermission._m8) as java.lang.String;
		}
		public new global::java.security.cert.Certificate[] UnresolvedCerts
		{
			get
			{
				return getUnresolvedCerts();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.security.cert.Certificate[] getUnresolvedCerts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.security.UnresolvedPermission.staticClass, "getUnresolvedCerts", "()[Ljava/security/cert/Certificate;", ref global::java.security.UnresolvedPermission._m9) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public UnresolvedPermission(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.security.cert.Certificate[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.UnresolvedPermission._m10.native == global::System.IntPtr.Zero)
				global::java.security.UnresolvedPermission._m10 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/security/cert/Certificate;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static UnresolvedPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnresolvedPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnresolvedPermission"));
		}
	}
}
