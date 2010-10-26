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
		internal static global::MonoJavaBridge.MethodId _equals22890;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.AllPermission._equals22890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._equals22890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22891;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.AllPermission._hashCode22891);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._hashCode22891);
		}
		internal static global::MonoJavaBridge.MethodId _implies22892;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.AllPermission._implies22892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._implies22892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions22893;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AllPermission._getActions22893)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._getActions22893)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection22894;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AllPermission._newPermissionCollection22894)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AllPermission.staticClass, global::java.security.AllPermission._newPermissionCollection22894)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _AllPermission22895;
		public AllPermission()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._AllPermission22895);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AllPermission22896;
		public AllPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._AllPermission22896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AllPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AllPermission"));
			global::java.security.AllPermission._equals22890 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.AllPermission._hashCode22891 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "hashCode", "()I");
			global::java.security.AllPermission._implies22892 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.AllPermission._getActions22893 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.security.AllPermission._newPermissionCollection22894 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.security.AllPermission._AllPermission22895 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "()V");
			global::java.security.AllPermission._AllPermission22896 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
