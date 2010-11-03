namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SocketPermission : java.security.Permission, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.SocketPermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.SocketPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.SocketPermission.staticClass, "hashCode", "()I", ref global::java.net.SocketPermission._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.SocketPermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.net.SocketPermission._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override global::java.lang.String getActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.SocketPermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.net.SocketPermission._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.net.SocketPermission._m4) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SocketPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketPermission._m5.native == global::System.IntPtr.Zero)
				global::java.net.SocketPermission._m5 = @__env.GetMethodIDNoThrow(global::java.net.SocketPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketPermission.staticClass, global::java.net.SocketPermission._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SocketPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketPermission"));
		}
	}
}
