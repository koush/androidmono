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
		internal static global::MonoJavaBridge.MethodId _toString23430;
		global::java.lang.String java.security.acl.Acl.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.Acl_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.acl.Acl_._toString23430) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName23431;
		global::java.lang.String java.security.acl.Acl.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.Acl_.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.acl.Acl_._getName23431) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission23432;
		bool java.security.acl.Acl.checkPermission(java.security.Principal arg0, java.security.acl.Permission arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "checkPermission", "(Ljava/security/Principal;Ljava/security/acl/Permission;)Z", ref global::java.security.acl.Acl_._checkPermission23432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23433;
		global::java.util.Enumeration java.security.acl.Acl.getPermissions(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.acl.Acl_.staticClass, "getPermissions", "(Ljava/security/Principal;)Ljava/util/Enumeration;", ref global::java.security.acl.Acl_._getPermissions23433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setName23434;
		void java.security.acl.Acl.setName(java.security.Principal arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.acl.Acl_.staticClass, "setName", "(Ljava/security/Principal;Ljava/lang/String;)V", ref global::java.security.acl.Acl_._setName23434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addEntry23435;
		bool java.security.acl.Acl.addEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "addEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", ref global::java.security.acl.Acl_._addEntry23435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _entries23436;
		global::java.util.Enumeration java.security.acl.Acl.entries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.acl.Acl_.staticClass, "entries", "()Ljava/util/Enumeration;", ref global::java.security.acl.Acl_._entries23436) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry23437;
		bool java.security.acl.Acl.removeEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "removeEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", ref global::java.security.acl.Acl_._removeEntry23437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addOwner23438;
		bool java.security.acl.Owner.addOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Acl_._addOwner23438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteOwner23439;
		bool java.security.acl.Owner.deleteOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Acl_._deleteOwner23439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isOwner23440;
		bool java.security.acl.Owner.isOwner(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Acl_.staticClass, "isOwner", "(Ljava/security/Principal;)Z", ref global::java.security.acl.Acl_._isOwner23440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Acl_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Acl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Acl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
