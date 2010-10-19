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
		internal static global::MonoJavaBridge.MethodId _equals16118;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.SocketPermission._equals16118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._equals16118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16119;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketPermission._hashCode16119);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._hashCode16119);
		}
		internal static global::MonoJavaBridge.MethodId _implies16120;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.SocketPermission._implies16120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._implies16120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions16121;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketPermission._getActions16121)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._getActions16121)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection16122;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketPermission._newPermissionCollection16122)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketPermission.staticClass, global::java.net.SocketPermission._newPermissionCollection16122)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _SocketPermission16123;
		public SocketPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketPermission.staticClass, global::java.net.SocketPermission._SocketPermission16123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketPermission"));
			global::java.net.SocketPermission._equals16118 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.SocketPermission._hashCode16119 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "hashCode", "()I");
			global::java.net.SocketPermission._implies16120 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.net.SocketPermission._getActions16121 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.net.SocketPermission._newPermissionCollection16122 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.net.SocketPermission._SocketPermission16123 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
