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
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.xml.sax.XMLReader org.xml.sax.XMLFilter.getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLReader>(this, global::org.xml.sax.XMLFilter_.staticClass, "getParent", "()Lorg/xml/sax/XMLReader;", ref global::org.xml.sax.XMLFilter_._m0) as org.xml.sax.XMLReader;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.xml.sax.XMLFilter.setParent(org.xml.sax.XMLReader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setParent", "(Lorg/xml/sax/XMLReader;)V", ref global::org.xml.sax.XMLFilter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.xml.sax.XMLReader.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.xml.sax.XMLFilter_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object org.xml.sax.XMLReader.getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.xml.sax.XMLFilter_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.xml.sax.XMLReader.parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Ljava/lang/String;)V", ref global::org.xml.sax.XMLFilter_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.xml.sax.XMLReader.parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V", ref global::org.xml.sax.XMLFilter_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.xml.sax.ContentHandler org.xml.sax.XMLReader.getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::org.xml.sax.XMLFilter_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;", ref global::org.xml.sax.XMLFilter_._m6) as org.xml.sax.ContentHandler;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.xml.sax.XMLReader.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xml.sax.XMLFilter_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool org.xml.sax.XMLReader.getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xml.sax.XMLFilter_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.xml.sax.XMLReader.setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", ref global::org.xml.sax.XMLFilter_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::org.xml.sax.EntityResolver org.xml.sax.XMLReader.getEntityResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.EntityResolver>(this, global::org.xml.sax.XMLFilter_.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;", ref global::org.xml.sax.XMLFilter_._m10) as org.xml.sax.EntityResolver;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void org.xml.sax.XMLReader.setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", ref global::org.xml.sax.XMLFilter_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::org.xml.sax.DTDHandler org.xml.sax.XMLReader.getDTDHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.DTDHandler>(this, global::org.xml.sax.XMLFilter_.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;", ref global::org.xml.sax.XMLFilter_._m12) as org.xml.sax.DTDHandler;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void org.xml.sax.XMLReader.setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", ref global::org.xml.sax.XMLFilter_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void org.xml.sax.XMLReader.setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.XMLFilter_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::org.xml.sax.XMLFilter_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::org.xml.sax.ErrorHandler org.xml.sax.XMLReader.getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::org.xml.sax.XMLFilter_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::org.xml.sax.XMLFilter_._m15) as org.xml.sax.ErrorHandler;
		}
		static XMLFilter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.XMLFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/XMLFilter"));
		}
	}
}
