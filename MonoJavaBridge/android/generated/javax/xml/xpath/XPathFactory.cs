namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.xpath.XPathFactory_))]
	public abstract partial class XPathFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XPathFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31310;
		public static global::javax.xml.xpath.XPathFactory newInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._newInstance31310.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._newInstance31310 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._newInstance31310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.xpath.XPathFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31311;
		public static global::javax.xml.xpath.XPathFactory newInstance(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._newInstance31311.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._newInstance31311 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/xpath/XPathFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._newInstance31311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.xpath.XPathFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31312;
		public static global::javax.xml.xpath.XPathFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._newInstance31312.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._newInstance31312 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "()Ljavax/xml/xpath/XPathFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._newInstance31312)) as javax.xml.xpath.XPathFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31313;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature31314;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setXPathVariableResolver31315;
		public abstract void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0);
		internal static global::MonoJavaBridge.MethodId _setXPathFunctionResolver31316;
		public abstract void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0);
		internal static global::MonoJavaBridge.MethodId _isObjectModelSupported31317;
		public abstract bool isObjectModelSupported(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newXPath31318;
		public abstract global::javax.xml.xpath.XPath newXPath();
		internal static global::MonoJavaBridge.MethodId _XPathFactory31319;
		protected XPathFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._XPathFactory31319.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._XPathFactory31319 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._XPathFactory31319);
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
		static XPathFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathFactory))]
	internal sealed partial class XPathFactory_ : javax.xml.xpath.XPathFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XPathFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31322;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory_._setFeature31322.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory_._setFeature31322 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._setFeature31322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31323;
		public override bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory_._getFeature31323.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory_._getFeature31323 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._getFeature31323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXPathVariableResolver31324;
		public override void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory_._setXPathVariableResolver31324.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory_._setXPathVariableResolver31324 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._setXPathVariableResolver31324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXPathFunctionResolver31325;
		public override void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory_._setXPathFunctionResolver31325.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory_._setXPathFunctionResolver31325 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._setXPathFunctionResolver31325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isObjectModelSupported31326;
		public override bool isObjectModelSupported(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory_._isObjectModelSupported31326.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory_._isObjectModelSupported31326 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "isObjectModelSupported", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._isObjectModelSupported31326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newXPath31327;
		public override global::javax.xml.xpath.XPath newXPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory_._newXPath31327.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory_._newXPath31327 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory_.staticClass, "newXPath", "()Ljavax/xml/xpath/XPath;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPath>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFactory_._newXPath31327)) as javax.xml.xpath.XPath;
		}
		static XPathFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
