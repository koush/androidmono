namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XMLReaderAdapter : java.lang.Object, Parser, ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLReaderAdapter()
		{
			InitJNI();
		}
		protected XMLReaderAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse28417;
		public virtual void parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._parse28417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._parse28417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse28418;
		public virtual void parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._parse28418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._parse28418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocale28419;
		public virtual void setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setLocale28419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setLocale28419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startElement28420;
		public virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._startElement28420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._startElement28420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters28421;
		public virtual void characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._characters28421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._characters28421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement28422;
		public virtual void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._endElement28422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._endElement28422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument28423;
		public virtual void startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._startDocument28423);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._startDocument28423);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument28424;
		public virtual void endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._endDocument28424);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._endDocument28424);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping28425;
		public virtual void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._startPrefixMapping28425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._startPrefixMapping28425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace28426;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._ignorableWhitespace28426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._ignorableWhitespace28426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction28427;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._processingInstruction28427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._processingInstruction28427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator28428;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentLocator28428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentLocator28428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity28429;
		public virtual void skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._skippedEntity28429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._skippedEntity28429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping28430;
		public virtual void endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._endPrefixMapping28430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._endPrefixMapping28430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver28431;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setEntityResolver28431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setEntityResolver28431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler28432;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setDTDHandler28432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setDTDHandler28432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler28433;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setErrorHandler28433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setErrorHandler28433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentHandler28434;
		public virtual void setDocumentHandler(org.xml.sax.DocumentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentHandler28434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentHandler28434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _XMLReaderAdapter28435;
		public XMLReaderAdapter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter28435);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XMLReaderAdapter28436;
		public XMLReaderAdapter(org.xml.sax.XMLReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter28436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.XMLReaderAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/XMLReaderAdapter"));
			global::org.xml.sax.helpers.XMLReaderAdapter._parse28417 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._parse28418 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setLocale28419 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._startElement28420 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._characters28421 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "characters", "([CII)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._endElement28422 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._startDocument28423 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startDocument", "()V");
			global::org.xml.sax.helpers.XMLReaderAdapter._endDocument28424 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endDocument", "()V");
			global::org.xml.sax.helpers.XMLReaderAdapter._startPrefixMapping28425 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._ignorableWhitespace28426 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._processingInstruction28427 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentLocator28428 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._skippedEntity28429 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._endPrefixMapping28430 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setEntityResolver28431 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setDTDHandler28432 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setErrorHandler28433 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentHandler28434 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter28435 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "<init>", "()V");
			global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter28436 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "<init>", "(Lorg/xml/sax/XMLReader;)V");
		}
	}
}
