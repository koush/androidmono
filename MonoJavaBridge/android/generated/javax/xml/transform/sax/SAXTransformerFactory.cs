namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.sax.SAXTransformerFactory_))]
	public abstract partial class SAXTransformerFactory : javax.xml.transform.TransformerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXTransformerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler31085;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler31086;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Templates arg0);
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler31087;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler();
		internal static global::MonoJavaBridge.MethodId _newTemplatesHandler31088;
		public abstract global::javax.xml.transform.sax.TemplatesHandler newTemplatesHandler();
		internal static global::MonoJavaBridge.MethodId _newXMLFilter31089;
		public abstract global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLFilter31090;
		public abstract global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Templates arg0);
		internal static global::MonoJavaBridge.MethodId _SAXTransformerFactory31091;
		protected SAXTransformerFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXTransformerFactory._SAXTransformerFactory31091.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXTransformerFactory._SAXTransformerFactory31091 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXTransformerFactory.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory._SAXTransformerFactory31091);
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
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler31094;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TransformerHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler31094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.sax.TransformerHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler31095;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Templates arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TransformerHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler31095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.sax.TransformerHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler31096;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TransformerHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler31096) as javax.xml.transform.sax.TransformerHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newTemplatesHandler31097;
		public override global::javax.xml.transform.sax.TemplatesHandler newTemplatesHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.sax.TemplatesHandler>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplatesHandler31097) as javax.xml.transform.sax.TemplatesHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLFilter31098;
		public override global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLFilter>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter31098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.xml.sax.XMLFilter;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLFilter31099;
		public override global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Templates arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLFilter>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter31099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.xml.sax.XMLFilter;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute31100;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._getAttribute31100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31101;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._setFeature31101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31102;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.transform.sax.SAXTransformerFactory_._getFeature31102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute31103;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._setAttribute31103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer31104;
		public override global::javax.xml.transform.Transformer newTransformer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer31104) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer31105;
		public override global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer31105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _setURIResolver31106;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._setURIResolver31106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getURIResolver31107;
		public override global::javax.xml.transform.URIResolver getURIResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.URIResolver>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._getURIResolver31107) as javax.xml.transform.URIResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorListener31108;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", ref global::javax.xml.transform.sax.SAXTransformerFactory_._setErrorListener31108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorListener31109;
		public override global::javax.xml.transform.ErrorListener getErrorListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.ErrorListener>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._getErrorListener31109) as javax.xml.transform.ErrorListener;
		}
		internal static global::MonoJavaBridge.MethodId _newTemplates31110;
		public override global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Templates>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplates31110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Templates;
		}
		internal static global::MonoJavaBridge.MethodId _getAssociatedStylesheet31111;
		public override global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Source>(this, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", ref global::javax.xml.transform.sax.SAXTransformerFactory_._getAssociatedStylesheet31111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.transform.Source;
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
