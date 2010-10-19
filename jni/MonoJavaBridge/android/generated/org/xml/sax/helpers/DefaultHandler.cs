namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHandler : java.lang.Object, EntityResolver, DTDHandler, ContentHandler, ErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultHandler()
		{
			InitJNI();
		}
		protected DefaultHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fatalError28315;
		public virtual void fatalError(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._fatalError28315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._fatalError28315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error28316;
		public virtual void error(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._error28316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._error28316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning28317;
		public virtual void warning(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._warning28317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._warning28317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startElement28318;
		public virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._startElement28318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._startElement28318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters28319;
		public virtual void characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._characters28319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._characters28319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement28320;
		public virtual void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._endElement28320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._endElement28320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument28321;
		public virtual void startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._startDocument28321);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._startDocument28321);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument28322;
		public virtual void endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._endDocument28322);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._endDocument28322);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping28323;
		public virtual void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._startPrefixMapping28323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._startPrefixMapping28323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace28324;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._ignorableWhitespace28324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._ignorableWhitespace28324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction28325;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._processingInstruction28325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._processingInstruction28325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator28326;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._setDocumentLocator28326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._setDocumentLocator28326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity28327;
		public virtual void skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._skippedEntity28327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._skippedEntity28327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping28328;
		public virtual void endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._endPrefixMapping28328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._endPrefixMapping28328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl28329;
		public virtual void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._unparsedEntityDecl28329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._unparsedEntityDecl28329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl28330;
		public virtual void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._notationDecl28330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._notationDecl28330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity28331;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler._resolveEntity28331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._resolveEntity28331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHandler28332;
		public DefaultHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.DefaultHandler.staticClass, global::org.xml.sax.helpers.DefaultHandler._DefaultHandler28332);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.DefaultHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/DefaultHandler"));
			global::org.xml.sax.helpers.DefaultHandler._fatalError28315 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.DefaultHandler._error28316 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.DefaultHandler._warning28317 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.helpers.DefaultHandler._startElement28318 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.helpers.DefaultHandler._characters28319 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "characters", "([CII)V");
			global::org.xml.sax.helpers.DefaultHandler._endElement28320 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.DefaultHandler._startDocument28321 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "startDocument", "()V");
			global::org.xml.sax.helpers.DefaultHandler._endDocument28322 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "endDocument", "()V");
			global::org.xml.sax.helpers.DefaultHandler._startPrefixMapping28323 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.DefaultHandler._ignorableWhitespace28324 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.helpers.DefaultHandler._processingInstruction28325 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.DefaultHandler._setDocumentLocator28326 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.helpers.DefaultHandler._skippedEntity28327 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.DefaultHandler._endPrefixMapping28328 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.DefaultHandler._unparsedEntityDecl28329 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.DefaultHandler._notationDecl28330 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.DefaultHandler._resolveEntity28331 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.helpers.DefaultHandler._DefaultHandler28332 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.DefaultHandler.staticClass, "<init>", "()V");
		}
	}
}
