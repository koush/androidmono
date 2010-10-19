namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PropertyPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PropertyPermission()
		{
			InitJNI();
		}
		internal PropertyPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20629;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PropertyPermission._equals20629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._equals20629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20630;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.PropertyPermission._hashCode20630);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._hashCode20630);
		}
		internal static global::MonoJavaBridge.MethodId _implies20631;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PropertyPermission._implies20631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._implies20631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions20632;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PropertyPermission._getActions20632)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._getActions20632)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection20633;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PropertyPermission._newPermissionCollection20633)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._newPermissionCollection20633)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _PropertyPermission20634;
		public PropertyPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PropertyPermission.staticClass, global::java.util.PropertyPermission._PropertyPermission20634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyPermission"));
			global::java.util.PropertyPermission._equals20629 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.PropertyPermission._hashCode20630 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "hashCode", "()I");
			global::java.util.PropertyPermission._implies20631 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.util.PropertyPermission._getActions20632 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.util.PropertyPermission._newPermissionCollection20633 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.util.PropertyPermission._PropertyPermission20634 = @__env.GetMethodIDNoThrow(global::java.util.PropertyPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
