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
		internal static global::MonoJavaBridge.MethodId _setProperty28382;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setProperty28382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setProperty28382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty28383;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getProperty28383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getProperty28383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getParent28384;
		public virtual global::org.xml.sax.XMLReader getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getParent28384)) as org.xml.sax.XMLReader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getParent28384)) as org.xml.sax.XMLReader;
		}
		internal static global::MonoJavaBridge.MethodId _setParent28385;
		public virtual void setParent(org.xml.sax.XMLReader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setParent28385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setParent28385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatalError28386;
		public virtual void fatalError(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._fatalError28386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._fatalError28386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse28387;
		public virtual void parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._parse28387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._parse28387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse28388;
		public virtual void parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._parse28388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._parse28388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error28389;
		public virtual void error(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._error28389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._error28389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning28390;
		public virtual void warning(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._warning28390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._warning28390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentHandler28391;
		public virtual global::org.xml.sax.ContentHandler getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getContentHandler28391)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getContentHandler28391)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _startElement28392;
		public virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._startElement28392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._startElement28392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters28393;
		public virtual void characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._characters28393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._characters28393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement28394;
		public virtual void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._endElement28394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._endElement28394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument28395;
		public virtual void startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._startDocument28395);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._startDocument28395);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument28396;
		public virtual void endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._endDocument28396);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._endDocument28396);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping28397;
		public virtual void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._startPrefixMapping28397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._startPrefixMapping28397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace28398;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._ignorableWhitespace28398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._ignorableWhitespace28398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction28399;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._processingInstruction28399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._processingInstruction28399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator28400;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setDocumentLocator28400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setDocumentLocator28400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity28401;
		public virtual void skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._skippedEntity28401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._skippedEntity28401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping28402;
		public virtual void endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._endPrefixMapping28402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._endPrefixMapping28402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl28403;
		public virtual void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._unparsedEntityDecl28403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._unparsedEntityDecl28403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl28404;
		public virtual void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._notationDecl28404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._notationDecl28404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature28405;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setFeature28405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setFeature28405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature28406;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getFeature28406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getFeature28406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver28407;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setEntityResolver28407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setEntityResolver28407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEntityResolver28408;
		public virtual global::org.xml.sax.EntityResolver getEntityResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getEntityResolver28408)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getEntityResolver28408)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler28409;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setDTDHandler28409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setDTDHandler28409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDTDHandler28410;
		public virtual global::org.xml.sax.DTDHandler getDTDHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getDTDHandler28410)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getDTDHandler28410)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler28411;
		public virtual void setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setContentHandler28411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setContentHandler28411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler28412;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._setErrorHandler28412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._setErrorHandler28412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getErrorHandler28413;
		public virtual global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._getErrorHandler28413)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._getErrorHandler28413)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity28414;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl._resolveEntity28414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._resolveEntity28414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _XMLFilterImpl28415;
		public XMLFilterImpl(org.xml.sax.XMLReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl28415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XMLFilterImpl28416;
		public XMLFilterImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLFilterImpl.staticClass, global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl28416);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.XMLFilterImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/XMLFilterImpl"));
			global::org.xml.sax.helpers.XMLFilterImpl._setProperty28382 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getProperty28383 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xml.sax.helpers.XMLFilterImpl._getParent28384 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getParent", "()Lorg/xml/sax/XMLReader;");
			global::org.xml.sax.helpers.XMLFilterImpl._setParent28385 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setParent", "(Lorg/xml/sax/XMLReader;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._fatalError28386 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._parse28387 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._parse28388 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._error28389 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._warning28390 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getContentHandler28391 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xml.sax.helpers.XMLFilterImpl._startElement28392 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._characters28393 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "characters", "([CII)V");
			global::org.xml.sax.helpers.XMLFilterImpl._endElement28394 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._startDocument28395 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "startDocument", "()V");
			global::org.xml.sax.helpers.XMLFilterImpl._endDocument28396 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "endDocument", "()V");
			global::org.xml.sax.helpers.XMLFilterImpl._startPrefixMapping28397 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._ignorableWhitespace28398 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.helpers.XMLFilterImpl._processingInstruction28399 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._setDocumentLocator28400 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._skippedEntity28401 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._endPrefixMapping28402 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._unparsedEntityDecl28403 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._notationDecl28404 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._setFeature28405 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getFeature28406 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xml.sax.helpers.XMLFilterImpl._setEntityResolver28407 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getEntityResolver28408 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xml.sax.helpers.XMLFilterImpl._setDTDHandler28409 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getDTDHandler28410 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xml.sax.helpers.XMLFilterImpl._setContentHandler28411 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._setErrorHandler28412 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._getErrorHandler28413 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::org.xml.sax.helpers.XMLFilterImpl._resolveEntity28414 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl28415 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "<init>", "(Lorg/xml/sax/XMLReader;)V");
			global::org.xml.sax.helpers.XMLFilterImpl._XMLFilterImpl28416 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLFilterImpl.staticClass, "<init>", "()V");
		}
	}
}
