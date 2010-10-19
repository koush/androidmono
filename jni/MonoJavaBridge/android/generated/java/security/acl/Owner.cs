namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Owner_))]
	public interface Owner  : global::MonoJavaBridge.IJavaObject 
	{
		bool addOwner(java.security.Principal arg0, java.security.Principal arg1);
		bool deleteOwner(java.security.Principal arg0, java.security.Principal arg1);
		bool isOwner(java.security.Principal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Owner))]
	public sealed partial class Owner_ : java.lang.Object, Owner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Owner_()
		{
			InitJNI();
		}
		internal Owner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addOwner17742;
		 bool java.security.acl.Owner.addOwner(java.security.Principal arg0, java.security.Principal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Owner_._addOwner17742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Owner_.staticClass, global::java.security.acl.Owner_._addOwner17742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteOwner17743;
		 bool java.security.acl.Owner.deleteOwner(java.security.Principal arg0, java.security.Principal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Owner_._deleteOwner17743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Owner_.staticClass, global::java.security.acl.Owner_._deleteOwner17743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isOwner17744;
		 bool java.security.acl.Owner.isOwner(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Owner_._isOwner17744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Owner_.staticClass, global::java.security.acl.Owner_._isOwner17744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Owner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Owner"));
			global::java.security.acl.Owner_._addOwner17742 = @__env.GetMethodIDNoThrow(global::java.security.acl.Owner_.staticClass, "addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z");
			global::java.security.acl.Owner_._deleteOwner17743 = @__env.GetMethodIDNoThrow(global::java.security.acl.Owner_.staticClass, "deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z");
			global::java.security.acl.Owner_._isOwner17744 = @__env.GetMethodIDNoThrow(global::java.security.acl.Owner_.staticClass, "isOwner", "(Ljava/security/Principal;)Z");
		}
	}
}
