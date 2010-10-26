namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPathVariableResolver_))]
	public partial interface XPathVariableResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object resolveVariable(javax.xml.@namespace.QName arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathVariableResolver))]
	internal sealed partial class XPathVariableResolver_ : java.lang.Object, XPathVariableResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathVariableResolver_()
		{
			InitJNI();
		}
		internal XPathVariableResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolveVariable31333;
		 global::java.lang.Object javax.xml.xpath.XPathVariableResolver.resolveVariable(javax.xml.@namespace.QName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathVariableResolver_._resolveVariable31333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathVariableResolver_.staticClass, global::javax.xml.xpath.XPathVariableResolver_._resolveVariable31333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathVariableResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathVariableResolver"));
			global::javax.xml.xpath.XPathVariableResolver_._resolveVariable31333 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathVariableResolver_.staticClass, "resolveVariable", "(Ljavax/xml/namespace/QName;)Ljava/lang/Object;");
		}
	}
}
