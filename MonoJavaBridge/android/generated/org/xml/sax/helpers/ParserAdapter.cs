namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserAdapter : java.lang.Object, XMLReader, DocumentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParserAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.xml.sax.helpers.ParserAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.xml.sax.helpers.ParserAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "parse", "(Ljava/lang/String;)V", ref global::org.xml.sax.helpers.ParserAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V", ref global::org.xml.sax.helpers.ParserAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.ContentHandler ContentHandler
		{
			get
			{
				return getContentHandler();
			}
			set
			{
				setContentHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.xml.sax.ContentHandler getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;", ref global::org.xml.sax.helpers.ParserAdapter._m4) as org.xml.sax.ContentHandler;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", ref global::org.xml.sax.helpers.ParserAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "characters", "([CII)V", ref global::org.xml.sax.helpers.ParserAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void endElement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "endElement", "(Ljava/lang/String;)V", ref global::org.xml.sax.helpers.ParserAdapter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "startDocument", "()V", ref global::org.xml.sax.helpers.ParserAdapter._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "endDocument", "()V", ref global::org.xml.sax.helpers.ParserAdapter._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "ignorableWhitespace", "([CII)V", ref global::org.xml.sax.helpers.ParserAdapter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.helpers.ParserAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.Locator DocumentLocator
		{
			set
			{
				setDocumentLocator(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::org.xml.sax.helpers.ParserAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xml.sax.helpers.ParserAdapter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xml.sax.helpers.ParserAdapter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", ref global::org.xml.sax.helpers.ParserAdapter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.EntityResolver EntityResolver
		{
			get
			{
				return getEntityResolver();
			}
			set
			{
				setEntityResolver(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::org.xml.sax.EntityResolver getEntityResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.EntityResolver>(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;", ref global::org.xml.sax.helpers.ParserAdapter._m16) as org.xml.sax.EntityResolver;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", ref global::org.xml.sax.helpers.ParserAdapter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.DTDHandler DTDHandler
		{
			get
			{
				return getDTDHandler();
			}
			set
			{
				setDTDHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::org.xml.sax.DTDHandler getDTDHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.DTDHandler>(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;", ref global::org.xml.sax.helpers.ParserAdapter._m18) as org.xml.sax.DTDHandler;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", ref global::org.xml.sax.helpers.ParserAdapter._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::org.xml.sax.helpers.ParserAdapter._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.ErrorHandler ErrorHandler
		{
			get
			{
				return getErrorHandler();
			}
			set
			{
				setErrorHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::org.xml.sax.helpers.ParserAdapter.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::org.xml.sax.helpers.ParserAdapter._m21) as org.xml.sax.ErrorHandler;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public ParserAdapter(org.xml.sax.Parser arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.ParserAdapter._m22.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.ParserAdapter._m22 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "<init>", "(Lorg/xml/sax/Parser;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public ParserAdapter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.ParserAdapter._m23.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.ParserAdapter._m23 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._m23);
			Init(@__env, handle);
		}
		static ParserAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.ParserAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/ParserAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
