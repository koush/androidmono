namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.sax.SAXTransformerFactory_))]
	public abstract partial class SAXTransformerFactory : javax.xml.transform.TransformerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXTransformerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Source arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Templates arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::javax.xml.transform.sax.TemplatesHandler newTemplatesHandler();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Source arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Templates arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		protected SAXTransformerFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXTransformerFactory._m6.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXTransformerFactory._m6 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXTransformerFactory.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory._m6);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXTransformerFactory/feature";
			}
		}
		public static global::java.lang.String FEATURE_XMLFILTER
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXTransformerFactory/feature/xmlfilter";
			}
		}
		static SAXTransformerFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXTransformerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXTransformerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.sax.SAXTransformerFactory))]
	internal sealed partial class SAXTransformerFactory_ : javax.xml.transform.sax.SAXTransformerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SAXTransformerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TransformerHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.sax.TransformerHandler;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Templates arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TransformerHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.sax.TransformerHandler;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TransformerHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m2) as javax.xml.transform.sax.TransformerHandler;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::javax.xml.transform.sax.TemplatesHandler newTemplatesHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TemplatesHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m3) as javax.xml.transform.sax.TemplatesHandler;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLFilter>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.xml.sax.XMLFilter;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Templates arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLFilter>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.xml.sax.XMLFilter;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::javax.xml.transform.Transformer newTransformer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m10) as javax.xml.transform.Transformer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Transformer;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::javax.xml.transform.URIResolver getURIResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.URIResolver>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m13) as javax.xml.transform.URIResolver;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::javax.xml.transform.ErrorListener getErrorListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.ErrorListener>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m15) as javax.xml.transform.ErrorListener;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Templates>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Templates;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Source>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.transform.Source;
		}
		static SAXTransformerFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXTransformerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
