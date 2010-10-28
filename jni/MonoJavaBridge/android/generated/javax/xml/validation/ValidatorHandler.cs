namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.ValidatorHandler_))]
	public abstract partial class ValidatorHandler : java.lang.Object, org.xml.sax.ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ValidatorHandler()
		{
			InitJNI();
		}
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._setProperty31250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._setProperty31250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty31251;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._getProperty31251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._getProperty31251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler31252;
		public abstract global::org.xml.sax.ContentHandler getContentHandler();
		internal static global::MonoJavaBridge.MethodId _setFeature31253;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._setFeature31253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._setFeature31253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31254;
		public virtual bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._getFeature31254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._getFeature31254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._ValidatorHandler31261);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
			global::javax.xml.validation.ValidatorHandler._startElement31239 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.validation.ValidatorHandler._characters31240 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "characters", "([CII)V");
			global::javax.xml.validation.ValidatorHandler._endElement31241 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._startDocument31242 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startDocument", "()V");
			global::javax.xml.validation.ValidatorHandler._endDocument31243 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endDocument", "()V");
			global::javax.xml.validation.ValidatorHandler._startPrefixMapping31244 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._ignorableWhitespace31245 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.validation.ValidatorHandler._processingInstruction31246 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._setDocumentLocator31247 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.validation.ValidatorHandler._skippedEntity31248 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._endPrefixMapping31249 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._setProperty31250 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.validation.ValidatorHandler._getProperty31251 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.validation.ValidatorHandler._getContentHandler31252 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::javax.xml.validation.ValidatorHandler._setFeature31253 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.validation.ValidatorHandler._getFeature31254 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.ValidatorHandler._setContentHandler31255 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.validation.ValidatorHandler._setErrorHandler31256 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.ValidatorHandler._getErrorHandler31257 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.ValidatorHandler._setResourceResolver31258 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.ValidatorHandler._getResourceResolver31259 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.ValidatorHandler._getTypeInfoProvider31260 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;");
			global::javax.xml.validation.ValidatorHandler._ValidatorHandler31261 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.ValidatorHandler))]
	internal sealed partial class ValidatorHandler_ : javax.xml.validation.ValidatorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ValidatorHandler_()
		{
			InitJNI();
		}
		internal ValidatorHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement31262;
		public override void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startElement31262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startElement31262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters31263;
		public override void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._characters31263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._characters31263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement31264;
		public override void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endElement31264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endElement31264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument31265;
		public override void startDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startDocument31265);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startDocument31265);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument31266;
		public override void endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endDocument31266);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endDocument31266);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31267;
		public override void startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startPrefixMapping31267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startPrefixMapping31267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31268;
		public override void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace31268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace31268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction31269;
		public override void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._processingInstruction31269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._processingInstruction31269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31270;
		public override void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setDocumentLocator31270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setDocumentLocator31270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity31271;
		public override void skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._skippedEntity31271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._skippedEntity31271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31272;
		public override void endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endPrefixMapping31272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endPrefixMapping31272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler31273;
		public override global::org.xml.sax.ContentHandler getContentHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getContentHandler31273)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getContentHandler31273)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler31274;
		public override void setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setContentHandler31274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setContentHandler31274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31275;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setErrorHandler31275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setErrorHandler31275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31276;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getErrorHandler31276)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getErrorHandler31276)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31277;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setResourceResolver31277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setResourceResolver31277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31278;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getResourceResolver31278)) as org.w3c.dom.ls.LSResourceResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getResourceResolver31278)) as org.w3c.dom.ls.LSResourceResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfoProvider31279;
		public override global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider31279)) as javax.xml.validation.TypeInfoProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider31279)) as javax.xml.validation.TypeInfoProvider;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
			global::javax.xml.validation.ValidatorHandler_._startElement31262 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.validation.ValidatorHandler_._characters31263 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "characters", "([CII)V");
			global::javax.xml.validation.ValidatorHandler_._endElement31264 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._startDocument31265 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startDocument", "()V");
			global::javax.xml.validation.ValidatorHandler_._endDocument31266 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endDocument", "()V");
			global::javax.xml.validation.ValidatorHandler_._startPrefixMapping31267 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace31268 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.validation.ValidatorHandler_._processingInstruction31269 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._setDocumentLocator31270 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.validation.ValidatorHandler_._skippedEntity31271 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._endPrefixMapping31272 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._getContentHandler31273 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::javax.xml.validation.ValidatorHandler_._setContentHandler31274 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.validation.ValidatorHandler_._setErrorHandler31275 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.ValidatorHandler_._getErrorHandler31276 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.ValidatorHandler_._setResourceResolver31277 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.ValidatorHandler_._getResourceResolver31278 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider31279 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;");
		}
	}
}
