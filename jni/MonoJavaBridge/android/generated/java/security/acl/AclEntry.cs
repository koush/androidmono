namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.AclEntry_))]
	public interface AclEntry : java.lang.Cloneable
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
	public sealed partial class AclEntry_ : java.lang.Object, AclEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AclEntry_()
		{
			InitJNI();
		}
		internal AclEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23322;
		 global::java.lang.String java.security.acl.AclEntry.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._toString23322)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._toString23322)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23323;
		 global::java.lang.Object java.security.acl.AclEntry.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._clone23323)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._clone23323)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission23324;
		 bool java.security.acl.AclEntry.checkPermission(java.security.acl.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._checkPermission23324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._checkPermission23324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _permissions23325;
		 global::java.util.Enumeration java.security.acl.AclEntry.permissions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._permissions23325)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._permissions23325)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _isNegative23326;
		 bool java.security.acl.AclEntry.isNegative() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._isNegative23326);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._isNegative23326);
		}
		internal static global::MonoJavaBridge.MethodId _addPermission23327;
		 bool java.security.acl.AclEntry.addPermission(java.security.acl.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._addPermission23327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._addPermission23327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission23328;
		 bool java.security.acl.AclEntry.removePermission(java.security.acl.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._removePermission23328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._removePermission23328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipal23329;
		 global::java.security.Principal java.security.acl.AclEntry.getPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._getPrincipal23329)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._getPrincipal23329)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _setPrincipal23330;
		 bool java.security.acl.AclEntry.setPrincipal(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._setPrincipal23330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._setPrincipal23330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNegativePermissions23331;
		 void java.security.acl.AclEntry.setNegativePermissions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.acl.AclEntry_._setNegativePermissions23331);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.acl.AclEntry_.staticClass, global::java.security.acl.AclEntry_._setNegativePermissions23331);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.AclEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/AclEntry"));
			global::java.security.acl.AclEntry_._toString23322 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.acl.AclEntry_._clone23323 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.acl.AclEntry_._checkPermission23324 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "checkPermission", "(Ljava/security/acl/Permission;)Z");
			global::java.security.acl.AclEntry_._permissions23325 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "permissions", "()Ljava/util/Enumeration;");
			global::java.security.acl.AclEntry_._isNegative23326 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "isNegative", "()Z");
			global::java.security.acl.AclEntry_._addPermission23327 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "addPermission", "(Ljava/security/acl/Permission;)Z");
			global::java.security.acl.AclEntry_._removePermission23328 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "removePermission", "(Ljava/security/acl/Permission;)Z");
			global::java.security.acl.AclEntry_._getPrincipal23329 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "getPrincipal", "()Ljava/security/Principal;");
			global::java.security.acl.AclEntry_._setPrincipal23330 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "setPrincipal", "(Ljava/security/Principal;)Z");
			global::java.security.acl.AclEntry_._setNegativePermissions23331 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "setNegativePermissions", "()V");
		}
	}
}
