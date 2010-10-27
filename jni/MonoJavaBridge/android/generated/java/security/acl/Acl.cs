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
		static Acl_()
		{
			InitJNI();
		}
		internal Acl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23429;
		global::java.lang.String java.security.acl.Acl.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._toString23429)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._toString23429)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName23430;
		global::java.lang.String java.security.acl.Acl.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._getName23430)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._getName23430)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission23431;
		bool java.security.acl.Acl.checkPermission(java.security.Principal arg0, java.security.acl.Permission arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._checkPermission23431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._checkPermission23431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23432;
		global::java.util.Enumeration java.security.acl.Acl.getPermissions(java.security.Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._getPermissions23432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._getPermissions23432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setName23433;
		void java.security.acl.Acl.setName(java.security.Principal arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.acl.Acl_._setName23433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._setName23433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addEntry23434;
		bool java.security.acl.Acl.addEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._addEntry23434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._addEntry23434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _entries23435;
		global::java.util.Enumeration java.security.acl.Acl.entries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._entries23435)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._entries23435)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry23436;
		bool java.security.acl.Acl.removeEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._removeEntry23436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._removeEntry23436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addOwner23437;
		bool java.security.acl.Owner.addOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._addOwner23437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._addOwner23437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteOwner23438;
		bool java.security.acl.Owner.deleteOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._deleteOwner23438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._deleteOwner23438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isOwner23439;
		bool java.security.acl.Owner.isOwner(java.security.Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._isOwner23439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._isOwner23439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Acl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Acl"));
			global::java.security.acl.Acl_._toString23429 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.acl.Acl_._getName23430 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.acl.Acl_._checkPermission23431 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "checkPermission", "(Ljava/security/Principal;Ljava/security/acl/Permission;)Z");
			global::java.security.acl.Acl_._getPermissions23432 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "getPermissions", "(Ljava/security/Principal;)Ljava/util/Enumeration;");
			global::java.security.acl.Acl_._setName23433 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "setName", "(Ljava/security/Principal;Ljava/lang/String;)V");
			global::java.security.acl.Acl_._addEntry23434 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "addEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z");
			global::java.security.acl.Acl_._entries23435 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::java.security.acl.Acl_._removeEntry23436 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "removeEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z");
			global::java.security.acl.Acl_._addOwner23437 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z");
			global::java.security.acl.Acl_._deleteOwner23438 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z");
			global::java.security.acl.Acl_._isOwner23439 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "isOwner", "(Ljava/security/Principal;)Z");
		}
	}
}
