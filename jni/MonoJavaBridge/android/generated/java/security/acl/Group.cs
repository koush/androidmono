namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Group_))]
	public interface Group : Principal
	{
		global::java.util.Enumeration members();
		bool addMember(java.security.Principal arg0);
		bool removeMember(java.security.Principal arg0);
		bool isMember(java.security.Principal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Group))]
	public sealed partial class Group_ : java.lang.Object, Group
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Group_()
		{
			InitJNI();
		}
		internal Group_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _members17732;
		 global::java.util.Enumeration java.security.acl.Group.members() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._members17732)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._members17732)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _addMember17733;
		 bool java.security.acl.Group.addMember(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._addMember17733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._addMember17733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMember17734;
		 bool java.security.acl.Group.removeMember(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._removeMember17734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._removeMember17734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMember17735;
		 bool java.security.acl.Group.isMember(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._isMember17735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._isMember17735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals17736;
		 bool java.security.Principal.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._equals17736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._equals17736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString17737;
		 global::java.lang.String java.security.Principal.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._toString17737)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._toString17737)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode17738;
		 int java.security.Principal.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.acl.Group_._hashCode17738);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._hashCode17738);
		}
		internal static global::MonoJavaBridge.MethodId _getName17739;
		 global::java.lang.String java.security.Principal.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._getName17739)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._getName17739)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Group_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Group"));
			global::java.security.acl.Group_._members17732 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "members", "()Ljava/util/Enumeration;");
			global::java.security.acl.Group_._addMember17733 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "addMember", "(Ljava/security/Principal;)Z");
			global::java.security.acl.Group_._removeMember17734 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "removeMember", "(Ljava/security/Principal;)Z");
			global::java.security.acl.Group_._isMember17735 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "isMember", "(Ljava/security/Principal;)Z");
			global::java.security.acl.Group_._equals17736 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.acl.Group_._toString17737 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.acl.Group_._hashCode17738 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "hashCode", "()I");
			global::java.security.acl.Group_._getName17739 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "getName", "()Ljava/lang/String;");
		}
	}
}
