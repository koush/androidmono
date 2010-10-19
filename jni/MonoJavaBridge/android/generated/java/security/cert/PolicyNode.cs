namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.PolicyNode_))]
	public interface PolicyNode  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.security.cert.PolicyNode getParent();
		bool isCritical();
		int getDepth();
		global::java.util.Iterator getChildren();
		global::java.lang.String getValidPolicy();
		global::java.util.Set getPolicyQualifiers();
		global::java.util.Set getExpectedPolicies();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.PolicyNode))]
	public sealed partial class PolicyNode_ : java.lang.Object, PolicyNode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PolicyNode_()
		{
			InitJNI();
		}
		internal PolicyNode_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent17960;
		 global::java.security.cert.PolicyNode java.security.cert.PolicyNode.getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.PolicyNode>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getParent17960)) as java.security.cert.PolicyNode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.PolicyNode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getParent17960)) as java.security.cert.PolicyNode;
		}
		internal static global::MonoJavaBridge.MethodId _isCritical17961;
		 bool java.security.cert.PolicyNode.isCritical() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._isCritical17961);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._isCritical17961);
		}
		internal static global::MonoJavaBridge.MethodId _getDepth17962;
		 int java.security.cert.PolicyNode.getDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getDepth17962);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getDepth17962);
		}
		internal static global::MonoJavaBridge.MethodId _getChildren17963;
		 global::java.util.Iterator java.security.cert.PolicyNode.getChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getChildren17963)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getChildren17963)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _getValidPolicy17964;
		 global::java.lang.String java.security.cert.PolicyNode.getValidPolicy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getValidPolicy17964)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getValidPolicy17964)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifiers17965;
		 global::java.util.Set java.security.cert.PolicyNode.getPolicyQualifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getPolicyQualifiers17965)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getPolicyQualifiers17965)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExpectedPolicies17966;
		 global::java.util.Set java.security.cert.PolicyNode.getExpectedPolicies() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getExpectedPolicies17966)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getExpectedPolicies17966)) as java.util.Set;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PolicyNode_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PolicyNode"));
			global::java.security.cert.PolicyNode_._getParent17960 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getParent", "()Ljava/security/cert/PolicyNode;");
			global::java.security.cert.PolicyNode_._isCritical17961 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "isCritical", "()Z");
			global::java.security.cert.PolicyNode_._getDepth17962 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getDepth", "()I");
			global::java.security.cert.PolicyNode_._getChildren17963 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getChildren", "()Ljava/util/Iterator;");
			global::java.security.cert.PolicyNode_._getValidPolicy17964 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getValidPolicy", "()Ljava/lang/String;");
			global::java.security.cert.PolicyNode_._getPolicyQualifiers17965 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getPolicyQualifiers", "()Ljava/util/Set;");
			global::java.security.cert.PolicyNode_._getExpectedPolicies17966 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getExpectedPolicies", "()Ljava/util/Set;");
		}
	}
}
