namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.XMLFilter_))]
	public partial interface XMLFilter : XMLReader
	{
		global::org.xml.sax.XMLReader getParent();
		void setParent(org.xml.sax.XMLReader arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.XMLFilter))]
	internal sealed partial class XMLFilter_ : java.lang.Object, XMLFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XMLFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent35047;
		global::org.xml.sax.XMLReader org.xml.sax.XMLFilter.getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLReader>(this, global::org.xml.sax.XMLFilter_.staticClass, "getParent", "()Lorg/xml/sax/XMLReader;", ref global::org.xml.sax.XMLFilter_._getParent35047) as org.xml.sax.XMLReader;
		}
		internal static global::MonoJavaBridge.MethodId _setParent35048;
		void org.xml.sax.XMLFilter.setParent(org.xml.sax.XMLReader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setParent", "(Lorg/xml/sax/XMLReader;)V", ref global::org.xml.sax.XMLFilter_._setParent35048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35049;
		void org.xml.sax.XMLReader.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.xml.sax.XMLFilter_._setProperty35049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35050;
		global::java.lang.Object org.xml.sax.XMLReader.getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.xml.sax.XMLFilter_._getProperty35050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _parse35051;
		void org.xml.sax.XMLReader.parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Ljava/lang/String;)V", ref global::org.xml.sax.XMLFilter_._parse35051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35052;
		void org.xml.sax.XMLReader.parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V", ref global::org.xml.sax.XMLFilter_._parse35052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler35053;
		global::org.xml.sax.ContentHandler org.xml.sax.XMLReader.getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::org.xml.sax.XMLFilter_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;", ref global::org.xml.sax.XMLFilter_._getContentHandler35053) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35054;
		void org.xml.sax.XMLReader.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xml.sax.XMLFilter_._setFeature35054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35055;
		bool org.xml.sax.XMLReader.getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xml.sax.XMLFilter_._getFeature35055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35056;
		void org.xml.sax.XMLReader.setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", ref global::org.xml.sax.XMLFilter_._setEntityResolver35056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35057;
		global::org.xml.sax.EntityResolver org.xml.sax.XMLReader.getEntityResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.EntityResolver>(this, global::org.xml.sax.XMLFilter_.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;", ref global::org.xml.sax.XMLFilter_._getEntityResolver35057) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35058;
		void org.xml.sax.XMLReader.setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", ref global::org.xml.sax.XMLFilter_._setDTDHandler35058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35059;
		global::org.xml.sax.DTDHandler org.xml.sax.XMLReader.getDTDHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.DTDHandler>(this, global::org.xml.sax.XMLFilter_.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;", ref global::org.xml.sax.XMLFilter_._getDTDHandler35059) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35060;
		void org.xml.sax.XMLReader.setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", ref global::org.xml.sax.XMLFilter_._setContentHandler35060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35061;
		void org.xml.sax.XMLReader.setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::org.xml.sax.XMLFilter_._setErrorHandler35061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35062;
		global::org.xml.sax.ErrorHandler org.xml.sax.XMLReader.getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::org.xml.sax.XMLFilter_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::org.xml.sax.XMLFilter_._getErrorHandler35062) as org.xml.sax.ErrorHandler;
		}
		static XMLFilter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.XMLFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/XMLFilter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
