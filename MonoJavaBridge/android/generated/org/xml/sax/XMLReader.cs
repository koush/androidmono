namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.XMLReader_))]
	public partial interface XMLReader  : global::MonoJavaBridge.IJavaObject 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		void parse(java.lang.String arg0);
		void parse(org.xml.sax.InputSource arg0);
		global::org.xml.sax.ContentHandler getContentHandler();
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		void setEntityResolver(org.xml.sax.EntityResolver arg0);
		global::org.xml.sax.EntityResolver getEntityResolver();
		void setDTDHandler(org.xml.sax.DTDHandler arg0);
		global::org.xml.sax.DTDHandler getDTDHandler();
		void setContentHandler(org.xml.sax.ContentHandler arg0);
		void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		global::org.xml.sax.ErrorHandler getErrorHandler();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.XMLReader))]
	internal sealed partial class XMLReader_ : java.lang.Object, XMLReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XMLReader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35063;
		void org.xml.sax.XMLReader.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.xml.sax.XMLReader_._setProperty35063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35064;
		global::java.lang.Object org.xml.sax.XMLReader.getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.XMLReader_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.xml.sax.XMLReader_._getProperty35064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _parse35065;
		void org.xml.sax.XMLReader.parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "parse", "(Ljava/lang/String;)V", ref global::org.xml.sax.XMLReader_._parse35065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35066;
		void org.xml.sax.XMLReader.parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V", ref global::org.xml.sax.XMLReader_._parse35066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler35067;
		global::org.xml.sax.ContentHandler org.xml.sax.XMLReader.getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::org.xml.sax.XMLReader_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;", ref global::org.xml.sax.XMLReader_._getContentHandler35067) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35068;
		void org.xml.sax.XMLReader.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xml.sax.XMLReader_._setFeature35068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35069;
		bool org.xml.sax.XMLReader.getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.XMLReader_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xml.sax.XMLReader_._getFeature35069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35070;
		void org.xml.sax.XMLReader.setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", ref global::org.xml.sax.XMLReader_._setEntityResolver35070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35071;
		global::org.xml.sax.EntityResolver org.xml.sax.XMLReader.getEntityResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.EntityResolver>(this, global::org.xml.sax.XMLReader_.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;", ref global::org.xml.sax.XMLReader_._getEntityResolver35071) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35072;
		void org.xml.sax.XMLReader.setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", ref global::org.xml.sax.XMLReader_._setDTDHandler35072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35073;
		global::org.xml.sax.DTDHandler org.xml.sax.XMLReader.getDTDHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.DTDHandler>(this, global::org.xml.sax.XMLReader_.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;", ref global::org.xml.sax.XMLReader_._getDTDHandler35073) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35074;
		void org.xml.sax.XMLReader.setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", ref global::org.xml.sax.XMLReader_._setContentHandler35074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35075;
		void org.xml.sax.XMLReader.setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLReader_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::org.xml.sax.XMLReader_._setErrorHandler35075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35076;
		global::org.xml.sax.ErrorHandler org.xml.sax.XMLReader.getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::org.xml.sax.XMLReader_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::org.xml.sax.XMLReader_._getErrorHandler35076) as org.xml.sax.ErrorHandler;
		}
		static XMLReader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.XMLReader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/XMLReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
