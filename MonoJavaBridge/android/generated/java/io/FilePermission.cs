namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class FilePermission : java.security.Permission, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FilePermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilePermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.io.FilePermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilePermission.staticClass, "hashCode", "()I", ref global::java.io.FilePermission._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilePermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.io.FilePermission._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.FilePermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.io.FilePermission._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.FilePermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.io.FilePermission._m4) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public FilePermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilePermission._m5.native == global::System.IntPtr.Zero)
				global::java.io.FilePermission._m5 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilePermission.staticClass, global::java.io.FilePermission._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FilePermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilePermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilePermission"));
		}
	}
}
