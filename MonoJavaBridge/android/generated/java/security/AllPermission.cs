namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AllPermission : java.security.Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AllPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.AllPermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.AllPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.AllPermission.staticClass, "hashCode", "()I", ref global::java.security.AllPermission._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.AllPermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.AllPermission._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.AllPermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.security.AllPermission._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.AllPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.security.AllPermission._m4) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AllPermission() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AllPermission._m5.native == global::System.IntPtr.Zero)
				global::java.security.AllPermission._m5 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public AllPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AllPermission._m6.native == global::System.IntPtr.Zero)
				global::java.security.AllPermission._m6 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AllPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AllPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AllPermission"));
		}
	}
}
