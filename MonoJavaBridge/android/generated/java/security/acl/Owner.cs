namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Owner_))]
	public partial interface Owner  : global::MonoJavaBridge.IJavaObject 
	{
		bool addOwner(java.security.Principal arg0, java.security.Principal arg1);
		bool deleteOwner(java.security.Principal arg0, java.security.Principal arg1);
		bool isOwner(java.security.Principal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Owner))]
	internal sealed partial class Owner_ : java.lang.Object, Owner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Owner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.security.acl.Owner.addOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Owner_.staticClass, "addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Owner_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.security.acl.Owner.deleteOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Owner_.staticClass, "deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Owner_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.security.acl.Owner.isOwner(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Owner_.staticClass, "isOwner", "(Ljava/security/Principal;)Z", ref global::java.security.acl.Owner_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Owner_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Owner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Owner"));
		}
	}
}
