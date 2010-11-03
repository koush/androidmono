namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Permission_))]
	public partial interface Permission  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Permission))]
	internal sealed partial class Permission_ : java.lang.Object, Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Permission_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.security.acl.Permission.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Permission_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.acl.Permission_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.security.acl.Permission.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.Permission_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.acl.Permission_._m1) as java.lang.String;
		}
		static Permission_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Permission_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Permission"));
		}
	}
}
