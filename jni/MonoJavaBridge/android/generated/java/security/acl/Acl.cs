namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Acl_))]
	public interface Acl : Owner
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
	public sealed partial class Acl_ : java.lang.Object, Acl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Acl_()
		{
			InitJNI();
		}
		internal Acl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString17710;
		 global::java.lang.String java.security.acl.Acl.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._toString17710)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._toString17710)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName17711;
		 global::java.lang.String java.security.acl.Acl.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._getName17711)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._getName17711)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission17712;
		 bool java.security.acl.Acl.checkPermission(java.security.Principal arg0, java.security.acl.Permission arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._checkPermission17712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._checkPermission17712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions17713;
		 global::java.util.Enumeration java.security.acl.Acl.getPermissions(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._getPermissions17713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._getPermissions17713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setName17714;
		 void java.security.acl.Acl.setName(java.security.Principal arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.acl.Acl_._setName17714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._setName17714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addEntry17715;
		 bool java.security.acl.Acl.addEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._addEntry17715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._addEntry17715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _entries17716;
		 global::java.util.Enumeration java.security.acl.Acl.entries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Acl_._entries17716)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._entries17716)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry17717;
		 bool java.security.acl.Acl.removeEntry(java.security.Principal arg0, java.security.acl.AclEntry arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._removeEntry17717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._removeEntry17717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addOwner17718;
		 bool java.security.acl.Owner.addOwner(java.security.Principal arg0, java.security.Principal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._addOwner17718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._addOwner17718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteOwner17719;
		 bool java.security.acl.Owner.deleteOwner(java.security.Principal arg0, java.security.Principal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._deleteOwner17719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._deleteOwner17719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isOwner17720;
		 bool java.security.acl.Owner.isOwner(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_._isOwner17720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Acl_.staticClass, global::java.security.acl.Acl_._isOwner17720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Acl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Acl"));
			global::java.security.acl.Acl_._toString17710 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.acl.Acl_._getName17711 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.acl.Acl_._checkPermission17712 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "checkPermission", "(Ljava/security/Principal;Ljava/security/acl/Permission;)Z");
			global::java.security.acl.Acl_._getPermissions17713 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "getPermissions", "(Ljava/security/Principal;)Ljava/util/Enumeration;");
			global::java.security.acl.Acl_._setName17714 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "setName", "(Ljava/security/Principal;Ljava/lang/String;)V");
			global::java.security.acl.Acl_._addEntry17715 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "addEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z");
			global::java.security.acl.Acl_._entries17716 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::java.security.acl.Acl_._removeEntry17717 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "removeEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z");
			global::java.security.acl.Acl_._addOwner17718 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z");
			global::java.security.acl.Acl_._deleteOwner17719 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z");
			global::java.security.acl.Acl_._isOwner17720 = @__env.GetMethodIDNoThrow(global::java.security.acl.Acl_.staticClass, "isOwner", "(Ljava/security/Principal;)Z");
		}
	}
}
