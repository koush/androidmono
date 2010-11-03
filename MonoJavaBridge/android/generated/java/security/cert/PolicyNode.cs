namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.PolicyNode_))]
	public partial interface PolicyNode  : global::MonoJavaBridge.IJavaObject 
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
	internal sealed partial class PolicyNode_ : java.lang.Object, PolicyNode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PolicyNode_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.security.cert.PolicyNode java.security.cert.PolicyNode.getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.PolicyNode>(this, global::java.security.cert.PolicyNode_.staticClass, "getParent", "()Ljava/security/cert/PolicyNode;", ref global::java.security.cert.PolicyNode_._m0) as java.security.cert.PolicyNode;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.security.cert.PolicyNode.isCritical()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PolicyNode_.staticClass, "isCritical", "()Z", ref global::java.security.cert.PolicyNode_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.security.cert.PolicyNode.getDepth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.PolicyNode_.staticClass, "getDepth", "()I", ref global::java.security.cert.PolicyNode_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.Iterator java.security.cert.PolicyNode.getChildren()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.security.cert.PolicyNode_.staticClass, "getChildren", "()Ljava/util/Iterator;", ref global::java.security.cert.PolicyNode_._m3) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String java.security.cert.PolicyNode.getValidPolicy()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PolicyNode_.staticClass, "getValidPolicy", "()Ljava/lang/String;", ref global::java.security.cert.PolicyNode_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.util.Set java.security.cert.PolicyNode.getPolicyQualifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.PolicyNode_.staticClass, "getPolicyQualifiers", "()Ljava/util/Set;", ref global::java.security.cert.PolicyNode_._m5) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.util.Set java.security.cert.PolicyNode.getExpectedPolicies()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.PolicyNode_.staticClass, "getExpectedPolicies", "()Ljava/util/Set;", ref global::java.security.cert.PolicyNode_._m6) as java.util.Set;
		}
		static PolicyNode_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PolicyNode_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PolicyNode"));
		}
	}
}
