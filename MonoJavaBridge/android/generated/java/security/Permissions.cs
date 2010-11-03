namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Permissions : java.security.PermissionCollection, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Permissions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override void add(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Permissions.staticClass, "add", "(Ljava/security/Permission;)V", ref global::java.security.Permissions._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Permissions.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.Permissions._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.Permissions.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.security.Permissions._m2) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Permissions() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Permissions._m3.native == global::System.IntPtr.Zero)
				global::java.security.Permissions._m3 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Permissions.staticClass, global::java.security.Permissions._m3);
			Init(@__env, handle);
		}
		static Permissions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Permissions.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Permissions"));
		}
	}
}
