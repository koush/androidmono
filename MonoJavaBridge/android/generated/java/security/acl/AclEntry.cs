namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.AclEntry_))]
	public partial interface AclEntry : java.lang.Cloneable
	{
		global::java.lang.String toString();
		global::java.lang.Object clone();
		bool checkPermission(java.security.acl.Permission arg0);
		global::java.util.Enumeration permissions();
		bool isNegative();
		bool addPermission(java.security.acl.Permission arg0);
		bool removePermission(java.security.acl.Permission arg0);
		global::java.security.Principal getPrincipal();
		bool setPrincipal(java.security.Principal arg0);
		void setNegativePermissions();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.AclEntry))]
	internal sealed partial class AclEntry_ : java.lang.Object, AclEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AclEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String java.security.acl.AclEntry.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.AclEntry_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.acl.AclEntry_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.security.acl.AclEntry.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.acl.AclEntry_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.acl.AclEntry_._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.security.acl.AclEntry.checkPermission(java.security.acl.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "checkPermission", "(Ljava/security/acl/Permission;)Z", ref global::java.security.acl.AclEntry_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.Enumeration java.security.acl.AclEntry.permissions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.acl.AclEntry_.staticClass, "permissions", "()Ljava/util/Enumeration;", ref global::java.security.acl.AclEntry_._m3) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.security.acl.AclEntry.isNegative()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "isNegative", "()Z", ref global::java.security.acl.AclEntry_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.security.acl.AclEntry.addPermission(java.security.acl.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "addPermission", "(Ljava/security/acl/Permission;)Z", ref global::java.security.acl.AclEntry_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.security.acl.AclEntry.removePermission(java.security.acl.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "removePermission", "(Ljava/security/acl/Permission;)Z", ref global::java.security.acl.AclEntry_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.security.Principal java.security.acl.AclEntry.getPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.acl.AclEntry_.staticClass, "getPrincipal", "()Ljava/security/Principal;", ref global::java.security.acl.AclEntry_._m7) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool java.security.acl.AclEntry.setPrincipal(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "setPrincipal", "(Ljava/security/Principal;)Z", ref global::java.security.acl.AclEntry_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.security.acl.AclEntry.setNegativePermissions()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.acl.AclEntry_.staticClass, "setNegativePermissions", "()V", ref global::java.security.acl.AclEntry_._m9);
		}
		static AclEntry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.AclEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/AclEntry"));
		}
	}
}
