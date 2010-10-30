namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Permissions : java.security.PermissionCollection, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Permissions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add23225;
		public sealed override void add(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Permissions.staticClass, global::java.security.Permissions._add23225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implies23226;
		public sealed override bool implies(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Permissions.staticClass, global::java.security.Permissions._implies23226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements23227;
		public sealed override global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Permissions.staticClass, global::java.security.Permissions._elements23227)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _Permissions23228;
		public Permissions() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Permissions.staticClass, global::java.security.Permissions._Permissions23228);
			Init(@__env, handle);
		}
		static Permissions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Permissions.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Permissions"));
			global::java.security.Permissions._add23225 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.Permissions._implies23226 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.Permissions._elements23227 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.Permissions._Permissions23228 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
