namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XMLFilterImpl : java.lang.Object, XMLFilter, EntityResolver, DTDHandler, ContentHandler, ErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLFilterImpl()
		{
			InitJNI();
		}
		protected XMLFilterImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35253;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setProperty35253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setProperty35253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35254;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getProperty35254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getProperty35254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		public new global::org.xml.sax.XMLReader Parent
		{
			get
			{
				return getParent();
			}
			set
			{
				setParent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent35255;
		public virtual global::org.xml.sax.XMLReader getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getParent35255)) as org.xml.sax.XMLReader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getParent35255)) as org.xml.sax.XMLReader;
		}
		internal static global::MonoJavaBridge.MethodId _setParent35256;
		public virtual void setParent(org.xml.sax.XMLReader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setParent35256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setParent35256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatalError35257;
		public virtual void fatalError(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._fatalError35257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._fatalError35257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35258;
		public virtual void parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._parse35258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._parse35258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35259;
		public virtual void parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._parse35259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._parse35259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error35260;
		public virtual void error(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._error35260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._error35260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning35261;
		public virtual void warning(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._warning35261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._warning35261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentHandler35262;
		public virtual global::org.xml.sax.ContentHandler getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getContentHandler35262)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getContentHandler35262)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _startElement35263;
		public virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._startElement35263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._startElement35263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters35264;
		public virtual void characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._characters35264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._characters35264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement35265;
		public virtual void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._endElement35265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._endElement35265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument35266;
		public virtual void startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._startDocument35266);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._startDocument35266);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument35267;
		public virtual void endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._endDocument35267);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._endDocument35267);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping35268;
		public virtual void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._startPrefixMapping35268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._startPrefixMapping35268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace35269;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._ignorableWhitespace35269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._ignorableWhitespace35269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction35270;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._processingInstruction35270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._processingInstruction35270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator35271;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setDocumentLocator35271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setDocumentLocator35271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity35272;
		public virtual void skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._skippedEntity35272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._skippedEntity35272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping35273;
		public virtual void endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._endPrefixMapping35273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._endPrefixMapping35273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl35274;
		public virtual void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._unparsedEntityDecl35274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._unparsedEntityDecl35274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl35275;
		public virtual void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._notationDecl35275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._notationDecl35275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35276;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setFeature35276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setFeature35276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35277;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getFeature35277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getFeature35277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35278;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setEntityResolver35278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setEntityResolver35278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35279;
		public virtual global::org.xml.sax.EntityResolver getEntityResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getEntityResolver35279)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getEntityResolver35279)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35280;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setDTDHandler35280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setDTDHandler35280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35281;
		public virtual global::org.xml.sax.DTDHandler getDTDHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getDTDHandler35281)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getDTDHandler35281)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35282;
		public virtual void setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setContentHandler35282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setContentHandler35282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35283;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setErrorHandler35283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setErrorHandler35283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35284;
		public virtual global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getErrorHandler35284)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getErrorHandler35284)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity35285;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._resolveEntity35285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._resolveEntity35285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _XMLFilterImpl35286;
		public XMLFilterImpl(org.xml.sax.XMLReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl35286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XMLFilterImpl35287;
		public XMLFilterImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl35287);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.XMLFilterImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/XMLFilterImpl"));
			global::org.xml.sax.helpers.XMLFilterImpl._setProperty35253 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getProperty35254 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xml.sax.helpers.XMLFilterImpl._getParent35255 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getParent", "()Lorg/xml/sax/XMLReader;");
			global::org.xml.sax.helpers.XMLFilterImpl._setParent35256 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setParent", "(Lorg/xml/sax/XMLReader;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._fatalError35257 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._parse35258 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._parse35259 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._error35260 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._warning35261 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getContentHandler35262 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xml.sax.helpers.XMLFilterImpl._startElement35263 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._characters35264 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "characters", "([CII)V");
			global::org.xml.sax.helpers.XMLFilterImpl._endElement35265 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._startDocument35266 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "startDocument", "()V");
			global::org.xml.sax.helpers.XMLFilterImpl._endDocument35267 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "endDocument", "()V");
			global::org.xml.sax.helpers.XMLFilterImpl._startPrefixMapping35268 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._ignorableWhitespace35269 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.helpers.XMLFilterImpl._processingInstruction35270 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._setDocumentLocator35271 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._skippedEntity35272 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._endPrefixMapping35273 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._unparsedEntityDecl35274 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._notationDecl35275 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._setFeature35276 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getFeature35277 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xml.sax.helpers.XMLFilterImpl._setEntityResolver35278 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getEntityResolver35279 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xml.sax.helpers.XMLFilterImpl._setDTDHandler35280 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getDTDHandler35281 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xml.sax.helpers.XMLFilterImpl._setContentHandler35282 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._setErrorHandler35283 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getErrorHandler35284 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::org.xml.sax.helpers.XMLFilterImpl._resolveEntity35285 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl35286 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "<init>", "(Lorg/xml/sax/XMLReader;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl35287 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "<init>", "()V");
		}
	}
}
