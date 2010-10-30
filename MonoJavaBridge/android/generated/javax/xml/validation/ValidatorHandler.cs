namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.ValidatorHandler_))]
	public abstract partial class ValidatorHandler : java.lang.Object, org.xml.sax.ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ValidatorHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement31239;
		public abstract void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3);
		internal static global::MonoJavaBridge.MethodId _characters31240;
		public abstract void characters(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _endElement31241;
		public abstract void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _startDocument31242;
		public abstract void startDocument();
		internal static global::MonoJavaBridge.MethodId _endDocument31243;
		public abstract void endDocument();
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31244;
		public abstract void startPrefixMapping(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31245;
		public abstract void ignorableWhitespace(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _processingInstruction31246;
		public abstract void processingInstruction(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31247;
		public abstract void setDocumentLocator(org.xml.sax.Locator arg0);
		internal static global::MonoJavaBridge.MethodId _skippedEntity31248;
		public abstract void skippedEntity(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31249;
		public abstract void endPrefixMapping(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setProperty31250;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.validation.ValidatorHandler._setProperty31250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty31251;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.validation.ValidatorHandler._getProperty31251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler31252;
		public abstract global::org.xml.sax.ContentHandler getContentHandler();
		internal static global::MonoJavaBridge.MethodId _setFeature31253;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.validation.ValidatorHandler._setFeature31253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31254;
		public virtual bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.validation.ValidatorHandler._getFeature31254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler31255;
		public abstract void setContentHandler(org.xml.sax.ContentHandler arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31256;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31257;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31258;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31259;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _getTypeInfoProvider31260;
		public abstract global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider();
		internal static global::MonoJavaBridge.MethodId _ValidatorHandler31261;
		protected ValidatorHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.ValidatorHandler._ValidatorHandler31261.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.ValidatorHandler._ValidatorHandler31261 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._ValidatorHandler31261);
			Init(@__env, handle);
		}
		static ValidatorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.ValidatorHandler))]
	internal sealed partial class ValidatorHandler_ : javax.xml.validation.ValidatorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ValidatorHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement31262;
		public override void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", ref global::javax.xml.validation.ValidatorHandler_._startElement31262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters31263;
		public override void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "characters", "([CII)V", ref global::javax.xml.validation.ValidatorHandler_._characters31263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement31264;
		public override void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._endElement31264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument31265;
		public override void startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "startDocument", "()V", ref global::javax.xml.validation.ValidatorHandler_._startDocument31265);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument31266;
		public override void endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "endDocument", "()V", ref global::javax.xml.validation.ValidatorHandler_._endDocument31266);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31267;
		public override void startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._startPrefixMapping31267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31268;
		public override void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "ignorableWhitespace", "([CII)V", ref global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace31268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction31269;
		public override void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._processingInstruction31269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31270;
		public override void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::javax.xml.validation.ValidatorHandler_._setDocumentLocator31270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity31271;
		public override void skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._skippedEntity31271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31272;
		public override void endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._endPrefixMapping31272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler31273;
		public override global::org.xml.sax.ContentHandler getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;", ref global::javax.xml.validation.ValidatorHandler_._getContentHandler31273) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler31274;
		public override void setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", ref global::javax.xml.validation.ValidatorHandler_._setContentHandler31274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31275;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::javax.xml.validation.ValidatorHandler_._setErrorHandler31275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31276;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::javax.xml.validation.ValidatorHandler_._getErrorHandler31276) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31277;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", ref global::javax.xml.validation.ValidatorHandler_._setResourceResolver31277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31278;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSResourceResolver>(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", ref global::javax.xml.validation.ValidatorHandler_._getResourceResolver31278) as org.w3c.dom.ls.LSResourceResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfoProvider31279;
		public override global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;", ref global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider31279) as javax.xml.validation.TypeInfoProvider;
		}
		static ValidatorHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
