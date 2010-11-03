namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Group_))]
	public partial interface Group : Principal
	{
		global::java.util.Enumeration members();
		bool addMember(java.security.Principal arg0);
		bool removeMember(java.security.Principal arg0);
		bool isMember(java.security.Principal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Group))]
	internal sealed partial class Group_ : java.lang.Object, Group
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Group_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.Enumeration java.security.acl.Group.members()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.acl.Group_.staticClass, "members", "()Ljava/util/Enumeration;", ref global::java.security.acl.Group_._m0) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.security.acl.Group.addMember(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Group_.staticClass, "addMember", "(Ljava/security/Principal;)Z", ref global::java.security.acl.Group_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.security.acl.Group.removeMember(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Group_.staticClass, "removeMember", "(Ljava/security/Principal;)Z", ref global::java.security.acl.Group_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.security.acl.Group.isMember(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Group_.staticClass, "isMember", "(Ljava/security/Principal;)Z", ref global::java.security.acl.Group_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.security.Principal.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.Group_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.acl.Group_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String java.security.Principal.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.Group_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.acl.Group_._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int java.security.Principal.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.acl.Group_.staticClass, "hashCode", "()I", ref global::java.security.acl.Group_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.String java.security.Principal.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.Group_.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.acl.Group_._m7) as java.lang.String;
		}
		static Group_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Group_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Group"));
		}
	}
}
