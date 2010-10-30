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
		internal static global::MonoJavaBridge.MethodId _toString23441;
		global::java.lang.String java.security.acl.AclEntry.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._toString23441.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._toString23441 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._toString23441)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23442;
		global::java.lang.Object java.security.acl.AclEntry.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._clone23442.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._clone23442 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._clone23442)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission23443;
		bool java.security.acl.AclEntry.checkPermission(java.security.acl.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._checkPermission23443.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._checkPermission23443 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "checkPermission", "(Ljava/security/acl/Permission;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._checkPermission23443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _permissions23444;
		global::java.util.Enumeration java.security.acl.AclEntry.permissions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._permissions23444.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._permissions23444 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "permissions", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._permissions23444)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _isNegative23445;
		bool java.security.acl.AclEntry.isNegative()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._isNegative23445.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._isNegative23445 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "isNegative", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._isNegative23445);
		}
		internal static global::MonoJavaBridge.MethodId _addPermission23446;
		bool java.security.acl.AclEntry.addPermission(java.security.acl.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._addPermission23446.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._addPermission23446 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "addPermission", "(Ljava/security/acl/Permission;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._addPermission23446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission23447;
		bool java.security.acl.AclEntry.removePermission(java.security.acl.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._removePermission23447.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._removePermission23447 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "removePermission", "(Ljava/security/acl/Permission;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._removePermission23447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipal23448;
		global::java.security.Principal java.security.acl.AclEntry.getPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._getPrincipal23448.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._getPrincipal23448 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "getPrincipal", "()Ljava/security/Principal;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.AclEntry_._getPrincipal23448)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _setPrincipal23449;
		bool java.security.acl.AclEntry.setPrincipal(java.security.Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._setPrincipal23449.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._setPrincipal23449 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "setPrincipal", "(Ljava/security/Principal;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.AclEntry_._setPrincipal23449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNegativePermissions23450;
		void java.security.acl.AclEntry.setNegativePermissions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclEntry_._setNegativePermissions23450.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclEntry_._setNegativePermissions23450 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclEntry_.staticClass, "setNegativePermissions", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.acl.AclEntry_._setNegativePermissions23450);
		}
		static AclEntry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.AclEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/AclEntry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
