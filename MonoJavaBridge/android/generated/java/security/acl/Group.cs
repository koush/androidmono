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
		internal static global::MonoJavaBridge.MethodId _members23452;
		global::java.util.Enumeration java.security.acl.Group.members()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._members23452.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._members23452 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "members", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._members23452)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _addMember23453;
		bool java.security.acl.Group.addMember(java.security.Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._addMember23453.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._addMember23453 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "addMember", "(Ljava/security/Principal;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._addMember23453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMember23454;
		bool java.security.acl.Group.removeMember(java.security.Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._removeMember23454.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._removeMember23454 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "removeMember", "(Ljava/security/Principal;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._removeMember23454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMember23455;
		bool java.security.acl.Group.isMember(java.security.Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._isMember23455.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._isMember23455 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "isMember", "(Ljava/security/Principal;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._isMember23455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals23456;
		bool java.security.Principal.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._equals23456.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._equals23456 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._equals23456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23457;
		global::java.lang.String java.security.Principal.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._toString23457.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._toString23457 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._toString23457)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23458;
		int java.security.Principal.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._hashCode23458.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._hashCode23458 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.security.acl.Group_._hashCode23458);
		}
		internal static global::MonoJavaBridge.MethodId _getName23459;
		global::java.lang.String java.security.Principal.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Group_._getName23459.native == global::System.IntPtr.Zero)
				global::java.security.acl.Group_._getName23459 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._getName23459)) as java.lang.String;
		}
		static Group_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Group_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Group"));
		}
		internal static void InitJNI()
		{
		}
	}
}
