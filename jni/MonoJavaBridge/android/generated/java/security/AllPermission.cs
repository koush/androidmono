namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AllPermission : java.security.Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AllPermission()
		{
			InitJNI();
		}
		internal AllPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22772;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.AllPermission._equals22772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._equals22772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22773;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.AllPermission._hashCode22773);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._hashCode22773);
		}
		internal static global::MonoJavaBridge.MethodId _implies22774;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.AllPermission._implies22774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._implies22774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions22775;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AllPermission._getActions22775)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._getActions22775)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection22776;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AllPermission._newPermissionCollection22776)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._newPermissionCollection22776)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _AllPermission22777;
		public AllPermission()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._AllPermission22777);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AllPermission22778;
		public AllPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._AllPermission22778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AllPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AllPermission"));
			global::java.security.AllPermission._equals22772 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.AllPermission._hashCode22773 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "hashCode", "()I");
			global::java.security.AllPermission._implies22774 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.AllPermission._getActions22775 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.security.AllPermission._newPermissionCollection22776 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.security.AllPermission._AllPermission22777 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "()V");
			global::java.security.AllPermission._AllPermission22778 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
