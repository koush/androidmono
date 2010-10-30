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
		internal static global::MonoJavaBridge.MethodId _addOwner23462;
		bool java.security.acl.Owner.addOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Owner_.staticClass, "addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Owner_._addOwner23462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteOwner23463;
		bool java.security.acl.Owner.deleteOwner(java.security.Principal arg0, java.security.Principal arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Owner_.staticClass, "deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", ref global::java.security.acl.Owner_._deleteOwner23463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isOwner23464;
		bool java.security.acl.Owner.isOwner(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Owner_.staticClass, "isOwner", "(Ljava/security/Principal;)Z", ref global::java.security.acl.Owner_._isOwner23464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Owner_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Owner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Owner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
