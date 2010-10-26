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
		static XPath_()
		{
			InitJNI();
		}
		internal XPath_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compile31279;
		 global::javax.xml.xpath.XPathExpression javax.xml.xpath.XPath.compile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathExpression>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._compile31279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.xpath.XPathExpression;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathExpression>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._compile31279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.xpath.XPathExpression;
		}
		internal static global::MonoJavaBridge.MethodId _reset31280;
		 void javax.xml.xpath.XPath.reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._reset31280);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._reset31280);
		}
		internal static global::MonoJavaBridge.MethodId _setXPathVariableResolver31281;
		 void javax.xml.xpath.XPath.setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._setXPathVariableResolver31281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._setXPathVariableResolver31281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getXPathVariableResolver31282;
		 global::javax.xml.xpath.XPathVariableResolver javax.xml.xpath.XPath.getXPathVariableResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathVariableResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._getXPathVariableResolver31282)) as javax.xml.xpath.XPathVariableResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathVariableResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._getXPathVariableResolver31282)) as javax.xml.xpath.XPathVariableResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setXPathFunctionResolver31283;
		 void javax.xml.xpath.XPath.setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._setXPathFunctionResolver31283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._setXPathFunctionResolver31283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getXPathFunctionResolver31284;
		 global::javax.xml.xpath.XPathFunctionResolver javax.xml.xpath.XPath.getXPathFunctionResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathFunctionResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._getXPathFunctionResolver31284)) as javax.xml.xpath.XPathFunctionResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathFunctionResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._getXPathFunctionResolver31284)) as javax.xml.xpath.XPathFunctionResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceContext31285;
		 void javax.xml.xpath.XPath.setNamespaceContext(javax.xml.@namespace.NamespaceContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._setNamespaceContext31285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._setNamespaceContext31285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceContext31286;
		 global::javax.xml.@namespace.NamespaceContext javax.xml.xpath.XPath.getNamespaceContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.@namespace.NamespaceContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._getNamespaceContext31286)) as javax.xml.@namespace.NamespaceContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.@namespace.NamespaceContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._getNamespaceContext31286)) as javax.xml.@namespace.NamespaceContext;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31287;
		 global::java.lang.Object javax.xml.xpath.XPath.evaluate(java.lang.String arg0, java.lang.Object arg1, javax.xml.@namespace.QName arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31288;
		 global::java.lang.String javax.xml.xpath.XPath.evaluate(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31289;
		 global::java.lang.Object javax.xml.xpath.XPath.evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1, javax.xml.@namespace.QName arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31290;
		 global::java.lang.String javax.xml.xpath.XPath.evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPath_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPath"));
			global::javax.xml.xpath.XPath_._compile31279 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "compile", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;");
			global::javax.xml.xpath.XPath_._reset31280 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "reset", "()V");
			global::javax.xml.xpath.XPath_._setXPathVariableResolver31281 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V");
			global::javax.xml.xpath.XPath_._getXPathVariableResolver31282 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "getXPathVariableResolver", "()Ljavax/xml/xpath/XPathVariableResolver;");
			global::javax.xml.xpath.XPath_._setXPathFunctionResolver31283 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V");
			global::javax.xml.xpath.XPath_._getXPathFunctionResolver31284 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "getXPathFunctionResolver", "()Ljavax/xml/xpath/XPathFunctionResolver;");
			global::javax.xml.xpath.XPath_._setNamespaceContext31285 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V");
			global::javax.xml.xpath.XPath_._getNamespaceContext31286 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;");
			global::javax.xml.xpath.XPath_._evaluate31287 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;");
			global::javax.xml.xpath.XPath_._evaluate31288 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;");
			global::javax.xml.xpath.XPath_._evaluate31289 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;");
			global::javax.xml.xpath.XPath_._evaluate31290 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljava/lang/String;");
		}
	}
}
