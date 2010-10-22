namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Permission_))]
	public partial interface Permission  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Permission))]
	public sealed partial class Permission_ : java.lang.Object, Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Permission_()
		{
			InitJNI();
		}
		internal Permission_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23346;
		 bool java.security.acl.Permission.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Permission_._equals23346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Permission_.staticClass, global::java.security.acl.Permission_._equals23346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23347;
		 global::java.lang.String java.security.acl.Permission.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Permission_._toString23347)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Permission_.staticClass, global::java.security.acl.Permission_._toString23347)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Permission_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Permission"));
			global::java.security.acl.Permission_._equals23346 = @__env.GetMethodIDNoThrow(global::java.security.acl.Permission_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.acl.Permission_._toString23347 = @__env.GetMethodIDNoThrow(global::java.security.acl.Permission_.staticClass, "toString", "()Ljava/lang/String;");
		}
	}
}
