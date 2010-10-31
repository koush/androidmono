namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XMLReaderAdapter : java.lang.Object, Parser, ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XMLReaderAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "parse", "(Ljava/lang/String;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Locale Locale
		{
			set
			{
				setLocale(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setLocale", "(Ljava/util/Locale;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "characters", "([CII)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startDocument", "()V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endDocument", "()V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "ignorableWhitespace", "([CII)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.Locator DocumentLocator
		{
			set
			{
				setDocumentLocator(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "skippedEntity", "(Ljava/lang/String;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.EntityResolver EntityResolver
		{
			set
			{
				setEntityResolver(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.DTDHandler DTDHandler
		{
			set
			{
				setDTDHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.ErrorHandler ErrorHandler
		{
			set
			{
				setErrorHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.DocumentHandler DocumentHandler
		{
			set
			{
				setDocumentHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setDocumentHandler(org.xml.sax.DocumentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V", ref global::org.xml.sax.helpers.XMLReaderAdapter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public XMLReaderAdapter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.XMLReaderAdapter._m18.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.XMLReaderAdapter._m18 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._m18);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public XMLReaderAdapter(org.xml.sax.XMLReader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.XMLReaderAdapter._m19.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.XMLReaderAdapter._m19 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "<init>", "(Lorg/xml/sax/XMLReader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static XMLReaderAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.XMLReaderAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/XMLReaderAdapter"));
		}
	}
}
