namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class FilePermission : java.security.Permission, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FilePermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals19043;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilePermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.io.FilePermission._equals19043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19044;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilePermission.staticClass, "hashCode", "()I", ref global::java.io.FilePermission._hashCode19044);
		}
		internal static global::MonoJavaBridge.MethodId _implies19045;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilePermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.io.FilePermission._implies19045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions19046;
		public sealed override global::java.lang.String getActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.FilePermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.io.FilePermission._getActions19046) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection19047;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.FilePermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.io.FilePermission._newPermissionCollection19047) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _FilePermission19048;
		public FilePermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilePermission._FilePermission19048.native == global::System.IntPtr.Zero)
				global::java.io.FilePermission._FilePermission19048 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilePermission.staticClass, global::java.io.FilePermission._FilePermission19048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FilePermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilePermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilePermission"));
		}
		internal static void InitJNI()
		{
		}
	}
}
