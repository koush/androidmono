namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Acl_))]
	public partial interface Acl : Owner
	{
		global::java.lang.String toString();
		global::java.lang.String getName();
		bool checkPermission(java.security.Principal arg0, java.security.acl.Permission arg1);
		global::java.util.Enumeration getPermissions(java.security.Principal arg0);
		void setName(java.security.Principal arg0, java.lang.String arg1);
		bool addEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1);
		global::java.util.Enumeration entries();
		bool removeEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Acl))]
	internal sealed partial class Acl_ : java.lang.Object, Acl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Acl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String java.security.acl.Acl.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.Acl_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.acl.Acl_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.security.acl.Acl.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.Acl_.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.acl.Acl_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.security.acl.Acl.checkPermission(java.security.Principal arg0, java.security.acl.Permission arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "checkPermission", "(Ljava/security/Principal;Ljava/security/acl/Permission;)Z", ref global::java.security.acl.Acl_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.Enumeration java.security.acl.Acl.getPermissions(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.acl.Acl_.staticClass, "getPermissions", "(Ljava/security/Principal;)Ljava/util/Enumeration;", ref global::java.security.acl.Acl_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.security.acl.Acl.setName(java.security.Principal arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.acl.Acl_.staticClass, "setName", "(Ljava/security/Principal;Ljava/lang/String;)V", ref global::java.security.acl.Acl_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.security.acl.Acl.addEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "addEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", ref global::java.security.acl.Acl_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.util.Enumeration java.security.acl.Acl.entries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.acl.Acl_.staticClass, "entries", "()Ljava/util/Enumeration;", ref global::java.security.acl.Acl_._m6) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool java.security.acl.Acl.removeEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "removeEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", ref global::java.security.acl.Acl_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool java.security.acl.Owner.addOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Acl_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool java.security.acl.Owner.deleteOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Acl_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool java.security.acl.Owner.isOwner(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "isOwner", "(Ljava/security/Principal;)Z", ref global::java.security.acl.Acl_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Acl_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Acl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Acl"));
		}
	}
}
