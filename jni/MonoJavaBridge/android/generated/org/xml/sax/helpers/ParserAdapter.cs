namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserAdapter : java.lang.Object, XMLReader, DocumentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParserAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35228;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._setProperty35228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._setProperty35228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35229;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._getProperty35229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._getProperty35229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _parse35230;
		public virtual void parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._parse35230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._parse35230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35231;
		public virtual void parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._parse35231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._parse35231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentHandler35232;
		public virtual global::org.xml.sax.ContentHandler getContentHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._getContentHandler35232)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._getContentHandler35232)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _startElement35233;
		public virtual void startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._startElement35233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._startElement35233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _characters35234;
		public virtual void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._characters35234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._characters35234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement35235;
		public virtual void endElement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._endElement35235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._endElement35235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument35236;
		public virtual void startDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._startDocument35236);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._startDocument35236);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument35237;
		public virtual void endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._endDocument35237);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._endDocument35237);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace35238;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._ignorableWhitespace35238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._ignorableWhitespace35238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction35239;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._processingInstruction35239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._processingInstruction35239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.Locator DocumentLocator
		{
			set
			{
				setDocumentLocator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator35240;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._setDocumentLocator35240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._setDocumentLocator35240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35241;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._setFeature35241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._setFeature35241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35242;
		public virtual bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._getFeature35242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._getFeature35242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35243;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._setEntityResolver35243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._setEntityResolver35243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35244;
		public virtual global::org.xml.sax.EntityResolver getEntityResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._getEntityResolver35244)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._getEntityResolver35244)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35245;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._setDTDHandler35245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._setDTDHandler35245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35246;
		public virtual global::org.xml.sax.DTDHandler getDTDHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._getDTDHandler35246)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._getDTDHandler35246)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35247;
		public virtual void setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._setContentHandler35247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._setContentHandler35247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35248;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._setErrorHandler35248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._setErrorHandler35248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35249;
		public virtual global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter._getErrorHandler35249)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._getErrorHandler35249)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _ParserAdapter35250;
		public ParserAdapter(org.xml.sax.Parser arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._ParserAdapter35250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ParserAdapter35251;
		public ParserAdapter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.ParserAdapter.staticClass, global::org.xml.sax.helpers.ParserAdapter._ParserAdapter35251);
			Init(@__env, handle);
		}
		static ParserAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.ParserAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/ParserAdapter"));
			global::org.xml.sax.helpers.ParserAdapter._setProperty35228 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xml.sax.helpers.ParserAdapter._getProperty35229 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xml.sax.helpers.ParserAdapter._parse35230 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.ParserAdapter._parse35231 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.helpers.ParserAdapter._getContentHandler35232 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xml.sax.helpers.ParserAdapter._startElement35233 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.helpers.ParserAdapter._characters35234 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "characters", "([CII)V");
			global::org.xml.sax.helpers.ParserAdapter._endElement35235 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "endElement", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.ParserAdapter._startDocument35236 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "startDocument", "()V");
			global::org.xml.sax.helpers.ParserAdapter._endDocument35237 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "endDocument", "()V");
			global::org.xml.sax.helpers.ParserAdapter._ignorableWhitespace35238 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.helpers.ParserAdapter._processingInstruction35239 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.ParserAdapter._setDocumentLocator35240 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.helpers.ParserAdapter._setFeature35241 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xml.sax.helpers.ParserAdapter._getFeature35242 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xml.sax.helpers.ParserAdapter._setEntityResolver35243 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.helpers.ParserAdapter._getEntityResolver35244 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xml.sax.helpers.ParserAdapter._setDTDHandler35245 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.helpers.ParserAdapter._getDTDHandler35246 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xml.sax.helpers.ParserAdapter._setContentHandler35247 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xml.sax.helpers.ParserAdapter._setErrorHandler35248 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.helpers.ParserAdapter._getErrorHandler35249 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::org.xml.sax.helpers.ParserAdapter._ParserAdapter35250 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "<init>", "(Lorg/xml/sax/Parser;)V");
			global::org.xml.sax.helpers.ParserAdapter._ParserAdapter35251 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.ParserAdapter.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
