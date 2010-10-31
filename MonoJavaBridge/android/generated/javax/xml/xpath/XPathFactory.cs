namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.xpath.XPathFactory_))]
	public abstract partial class XPathFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XPathFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.xml.xpath.XPathFactory newInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.xpath.XPathFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.xml.xpath.XPathFactory newInstance(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/xpath/XPathFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.xpath.XPathFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.xml.xpath.XPathFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._m2.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "newInstance", "()Ljavax/xml/xpath/XPathFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._m2)) as javax.xml.xpath.XPathFactory;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool getFeature(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract bool isObjectModelSupported(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::javax.xml.xpath.XPath newXPath();
		private static global::MonoJavaBridge.MethodId _m9;
		protected XPathFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactory._m9.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactory._m9 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFactory.staticClass, global::javax.xml.xpath.XPathFactory._m9);
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathFactory))]
	internal sealed partial class XPathFactory_ : javax.xml.xpath.XPathFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XPathFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPathFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.xpath.XPathFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.xpath.XPathFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.xpath.XPathFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPathFactory_.staticClass, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", ref global::javax.xml.xpath.XPathFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPathFactory_.staticClass, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", ref global::javax.xml.xpath.XPathFactory_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isObjectModelSupported(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.xpath.XPathFactory_.staticClass, "isObjectModelSupported", "(Ljava/lang/String;)Z", ref global::javax.xml.xpath.XPathFactory_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::javax.xml.xpath.XPath newXPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.xpath.XPath>(this, global::javax.xml.xpath.XPathFactory_.staticClass, "newXPath", "()Ljavax/xml/xpath/XPath;", ref global::javax.xml.xpath.XPathFactory_._m5) as javax.xml.xpath.XPath;
		}
		static XPathFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFactory"));
		}
	}
}
