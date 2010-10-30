namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPath_))]
	public partial interface XPath  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.xml.xpath.XPathExpression compile(java.lang.String arg0);
		void reset();
		void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0);
		global::javax.xml.xpath.XPathVariableResolver getXPathVariableResolver();
		void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0);
		global::javax.xml.xpath.XPathFunctionResolver getXPathFunctionResolver();
		void setNamespaceContext(javax.xml.@namespace.NamespaceContext arg0);
		global::javax.xml.@namespace.NamespaceContext getNamespaceContext();
		global::java.lang.Object evaluate(java.lang.String arg0, java.lang.Object arg1, javax.xml.@namespace.QName arg2);
		global::java.lang.String evaluate(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1, javax.xml.@namespace.QName arg2);
		global::java.lang.String evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPath))]
	internal sealed partial class XPath_ : java.lang.Object, XPath
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XPath_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::javax.xml.xpath.XPathExpression javax.xml.xpath.XPath.compile(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.xpath.XPathExpression>(this, global::javax.xml.xpath.XPath_.staticClass, "compile", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;", ref global::javax.xml.xpath.XPath_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.xpath.XPathExpression;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.xml.xpath.XPath.reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPath_.staticClass, "reset", "()V", ref global::javax.xml.xpath.XPath_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.xml.xpath.XPath.setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPath_.staticClass, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", ref global::javax.xml.xpath.XPath_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::javax.xml.xpath.XPathVariableResolver javax.xml.xpath.XPath.getXPathVariableResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.xpath.XPathVariableResolver>(this, global::javax.xml.xpath.XPath_.staticClass, "getXPathVariableResolver", "()Ljavax/xml/xpath/XPathVariableResolver;", ref global::javax.xml.xpath.XPath_._m3) as javax.xml.xpath.XPathVariableResolver;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.xml.xpath.XPath.setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPath_.staticClass, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", ref global::javax.xml.xpath.XPath_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::javax.xml.xpath.XPathFunctionResolver javax.xml.xpath.XPath.getXPathFunctionResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.xpath.XPathFunctionResolver>(this, global::javax.xml.xpath.XPath_.staticClass, "getXPathFunctionResolver", "()Ljavax/xml/xpath/XPathFunctionResolver;", ref global::javax.xml.xpath.XPath_._m5) as javax.xml.xpath.XPathFunctionResolver;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void javax.xml.xpath.XPath.setNamespaceContext(javax.xml.@namespace.NamespaceContext arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPath_.staticClass, "setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V", ref global::javax.xml.xpath.XPath_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::javax.xml.@namespace.NamespaceContext javax.xml.xpath.XPath.getNamespaceContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.@namespace.NamespaceContext>(this, global::javax.xml.xpath.XPath_.staticClass, "getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;", ref global::javax.xml.xpath.XPath_._m7) as javax.xml.@namespace.NamespaceContext;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.Object javax.xml.xpath.XPath.evaluate(java.lang.String arg0, java.lang.Object arg1, javax.xml.@namespace.QName arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", ref global::javax.xml.xpath.XPath_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String javax.xml.xpath.XPath.evaluate(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", ref global::javax.xml.xpath.XPath_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.Object javax.xml.xpath.XPath.evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1, javax.xml.@namespace.QName arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", ref global::javax.xml.xpath.XPath_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.lang.String javax.xml.xpath.XPath.evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljava/lang/String;", ref global::javax.xml.xpath.XPath_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		static XPath_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPath_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPath"));
		}
		internal static void InitJNI()
		{
		}
	}
}
