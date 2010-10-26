namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Permissions : java.security.PermissionCollection, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Permissions()
		{
			InitJNI();
		}
		internal Permissions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add23224;
		public sealed override void add(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Permissions._add23224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Permissions.staticClass, global::java.security.Permissions._add23224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implies23225;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Permissions._implies23225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Permissions.staticClass, global::java.security.Permissions._implies23225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements23226;
		public sealed override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Permissions._elements23226)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Permissions.staticClass, global::java.security.Permissions._elements23226)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _Permissions23227;
		public Permissions()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Permissions.staticClass, global::java.security.Permissions._Permissions23227);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Permissions.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Permissions"));
			global::java.security.Permissions._add23224 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.Permissions._implies23225 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.Permissions._elements23226 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.Permissions._Permissions23227 = @__env.GetMethodIDNoThrow(global::java.security.Permissions.staticClass, "<init>", "()V");
		}
	}
}
