namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.xpath.XPathFactory_))]
	public abstract partial class XPathFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathFactory()
		{
			InitJNI();
		}
		protected XPathFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24705;
		public static global::javax.xml.xpath.XPathFactory newInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._newInstance24705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.xpath.XPathFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24706;
		public static global::javax.xml.xpath.XPathFactory newInstance(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._newInstance24706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.xpath.XPathFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24707;
		public static global::javax.xml.xpath.XPathFactory newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._newInstance24707)) as javax.xml.xpath.XPathFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature24708;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature24709;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setXPathVariableResolver24710;
		public abstract void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0);
		internal static global::MonoJavaBridge.MethodId _setXPathFunctionResolver24711;
		public abstract void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0);
		internal static global::MonoJavaBridge.MethodId _isObjectModelSupported24712;
		public abstract bool isObjectModelSupported(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newXPath24713;
		public abstract global::javax.xml.xpath.XPath newXPath();
		internal static global::MonoJavaBridge.MethodId _XPathFactory24714;
		protected XPathFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._XPathFactory24714);
			Init(@__env, handle);
		}
		public static global::java.lang.String DEFAULT_PROPERTY_NAME
		{
			get
			{
				return "javax.xml.xpath.XPathFactory";
			}
		}
		public static global::java.lang.String DEFAULT_OBJECT_MODEL_URI
		{
			get
			{
				return "http://java.sun.com/jaxp/xpath/dom";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFactory"));
			global::javax.xml.xpath.XPathFactory._newInstance24705 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathFactory;");
			global::javax.xml.xpath.XPathFactory._newInstance24706 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/xpath/XPathFactory;");
			global::javax.xml.xpath.XPathFactory._newInstance24707 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "()Ljavax/xml/xpath/XPathFactory;");
			global::javax.xml.xpath.XPathFactory._setFeature24708 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.xpath.XPathFactory._getFeature24709 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.xpath.XPathFactory._setXPathVariableResolver24710 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V");
			global::javax.xml.xpath.XPathFactory._setXPathFunctionResolver24711 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V");
			global::javax.xml.xpath.XPathFactory._isObjectModelSupported24712 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "isObjectModelSupported", "(Ljava/lang/String;)Z");
			global::javax.xml.xpath.XPathFactory._newXPath24713 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newXPath", "()Ljavax/xml/xpath/XPath;");
			global::javax.xml.xpath.XPathFactory._XPathFactory24714 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathFactory))]
	public sealed partial class XPathFactory_ : javax.xml.xpath.XPathFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathFactory_()
		{
			InitJNI();
		}
		internal XPathFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setFeature24715;
		public override void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._setFeature24715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_.staticClass, global::javax.xml.xpath.XPathFactory_._setFeature24715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature24716;
		public override bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._getFeature24716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_.staticClass, global::javax.xml.xpath.XPathFactory_._getFeature24716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXPathVariableResolver24717;
		public override void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._setXPathVariableResolver24717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_.staticClass, global::javax.xml.xpath.XPathFactory_._setXPathVariableResolver24717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXPathFunctionResolver24718;
		public override void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._setXPathFunctionResolver24718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_.staticClass, global::javax.xml.xpath.XPathFactory_._setXPathFunctionResolver24718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isObjectModelSupported24719;
		public override bool isObjectModelSupported(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._isObjectModelSupported24719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_.staticClass, global::javax.xml.xpath.XPathFactory_._isObjectModelSupported24719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newXPath24720;
		public override global::javax.xml.xpath.XPath newXPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPath>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._newXPath24720)) as javax.xml.xpath.XPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPath>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_.staticClass, global::javax.xml.xpath.XPathFactory_._newXPath24720)) as javax.xml.xpath.XPath;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFactory"));
			global::javax.xml.xpath.XPathFactory_._setFeature24715 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.xpath.XPathFactory_._getFeature24716 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.xpath.XPathFactory_._setXPathVariableResolver24717 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V");
			global::javax.xml.xpath.XPathFactory_._setXPathFunctionResolver24718 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V");
			global::javax.xml.xpath.XPathFactory_._isObjectModelSupported24719 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "isObjectModelSupported", "(Ljava/lang/String;)Z");
			global::javax.xml.xpath.XPathFactory_._newXPath24720 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "newXPath", "()Ljavax/xml/xpath/XPath;");
		}
	}
}
