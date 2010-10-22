namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SocketPermission : java.security.Permission, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketPermission()
		{
			InitJNI();
		}
		internal SocketPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21712;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.SocketPermission._equals21712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._equals21712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21713;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketPermission._hashCode21713);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._hashCode21713);
		}
		internal static global::MonoJavaBridge.MethodId _implies21714;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.SocketPermission._implies21714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._implies21714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions21715;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketPermission._getActions21715)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._getActions21715)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection21716;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketPermission._newPermissionCollection21716)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._newPermissionCollection21716)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _SocketPermission21717;
		public SocketPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketPermission.staticClass, global::java.net.SocketPermission._SocketPermission21717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketPermission"));
			global::java.net.SocketPermission._equals21712 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.SocketPermission._hashCode21713 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "hashCode", "()I");
			global::java.net.SocketPermission._implies21714 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.net.SocketPermission._getActions21715 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.net.SocketPermission._newPermissionCollection21716 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.net.SocketPermission._SocketPermission21717 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
