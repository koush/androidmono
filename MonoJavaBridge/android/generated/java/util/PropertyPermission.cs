namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PropertyPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PropertyPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals26573;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._equals26573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26574;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._hashCode26574);
		}
		internal static global::MonoJavaBridge.MethodId _implies26575;
		public sealed override bool implies(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._implies26575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions26576;
		public sealed override global::java.lang.String getActions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._getActions26576)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection26577;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._newPermissionCollection26577)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _PropertyPermission26578;
		public PropertyPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._PropertyPermission26578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PropertyPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyPermission"));
			global::java.util.PropertyPermission._equals26573 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.PropertyPermission._hashCode26574 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "hashCode", "()I");
			global::java.util.PropertyPermission._implies26575 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.util.PropertyPermission._getActions26576 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.util.PropertyPermission._newPermissionCollection26577 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.util.PropertyPermission._PropertyPermission26578 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
