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
		internal static global::MonoJavaBridge.MethodId _startElement31238;
		public abstract void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3);
		internal static global::MonoJavaBridge.MethodId _characters31239;
		public abstract void characters(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _endElement31240;
		public abstract void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _startDocument31241;
		public abstract void startDocument();
		internal static global::MonoJavaBridge.MethodId _endDocument31242;
		public abstract void endDocument();
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31243;
		public abstract void startPrefixMapping(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31244;
		public abstract void ignorableWhitespace(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _processingInstruction31245;
		public abstract void processingInstruction(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31246;
		public abstract void setDocumentLocator(org.xml.sax.Locator arg0);
		internal static global::MonoJavaBridge.MethodId _skippedEntity31247;
		public abstract void skippedEntity(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31248;
		public abstract void endPrefixMapping(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setProperty31249;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._setProperty31249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._setProperty31249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty31250;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._getProperty31250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._getProperty31250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler31251;
		public abstract global::org.xml.sax.ContentHandler getContentHandler();
		internal static global::MonoJavaBridge.MethodId _setFeature31252;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._setFeature31252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._setFeature31252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31253;
		public virtual bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._getFeature31253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._getFeature31253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler31254;
		public abstract void setContentHandler(org.xml.sax.ContentHandler arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31255;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31256;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31257;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31258;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _getTypeInfoProvider31259;
		public abstract global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider();
		internal static global::MonoJavaBridge.MethodId _ValidatorHandler31260;
		protected ValidatorHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._ValidatorHandler31260);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
			global::javax.xml.validation.ValidatorHandler._startElement31238 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.validation.ValidatorHandler._characters31239 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "characters", "([CII)V");
			global::javax.xml.validation.ValidatorHandler._endElement31240 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._startDocument31241 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startDocument", "()V");
			global::javax.xml.validation.ValidatorHandler._endDocument31242 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endDocument", "()V");
			global::javax.xml.validation.ValidatorHandler._startPrefixMapping31243 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._ignorableWhitespace31244 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.validation.ValidatorHandler._processingInstruction31245 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._setDocumentLocator31246 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.validation.ValidatorHandler._skippedEntity31247 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._endPrefixMapping31248 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._setProperty31249 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.validation.ValidatorHandler._getProperty31250 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.validation.ValidatorHandler._getContentHandler31251 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::javax.xml.validation.ValidatorHandler._setFeature31252 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.validation.ValidatorHandler._getFeature31253 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.ValidatorHandler._setContentHandler31254 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.validation.ValidatorHandler._setErrorHandler31255 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.ValidatorHandler._getErrorHandler31256 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.ValidatorHandler._setResourceResolver31257 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.ValidatorHandler._getResourceResolver31258 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.ValidatorHandler._getTypeInfoProvider31259 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;");
			global::javax.xml.validation.ValidatorHandler._ValidatorHandler31260 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _startElement31261;
		public override void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startElement31261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startElement31261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters31262;
		public override void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._characters31262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._characters31262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement31263;
		public override void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endElement31263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endElement31263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument31264;
		public override void startDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startDocument31264);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startDocument31264);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument31265;
		public override void endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endDocument31265);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endDocument31265);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31266;
		public override void startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startPrefixMapping31266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startPrefixMapping31266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31267;
		public override void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace31267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace31267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction31268;
		public override void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._processingInstruction31268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._processingInstruction31268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31269;
		public override void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setDocumentLocator31269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setDocumentLocator31269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity31270;
		public override void skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._skippedEntity31270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._skippedEntity31270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31271;
		public override void endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endPrefixMapping31271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endPrefixMapping31271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler31272;
		public override global::org.xml.sax.ContentHandler getContentHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getContentHandler31272)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getContentHandler31272)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler31273;
		public override void setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setContentHandler31273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setContentHandler31273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31274;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setErrorHandler31274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setErrorHandler31274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31275;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getErrorHandler31275)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getErrorHandler31275)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31276;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setResourceResolver31276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setResourceResolver31276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31277;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getResourceResolver31277)) as org.w3c.dom.ls.LSResourceResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getResourceResolver31277)) as org.w3c.dom.ls.LSResourceResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfoProvider31278;
		public override global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider31278)) as javax.xml.validation.TypeInfoProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider31278)) as javax.xml.validation.TypeInfoProvider;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
			global::javax.xml.validation.ValidatorHandler_._startElement31261 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.validation.ValidatorHandler_._characters31262 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "characters", "([CII)V");
			global::javax.xml.validation.ValidatorHandler_._endElement31263 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._startDocument31264 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startDocument", "()V");
			global::javax.xml.validation.ValidatorHandler_._endDocument31265 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endDocument", "()V");
			global::javax.xml.validation.ValidatorHandler_._startPrefixMapping31266 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace31267 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.validation.ValidatorHandler_._processingInstruction31268 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._setDocumentLocator31269 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.validation.ValidatorHandler_._skippedEntity31270 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._endPrefixMapping31271 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._getContentHandler31272 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::javax.xml.validation.ValidatorHandler_._setContentHandler31273 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.validation.ValidatorHandler_._setErrorHandler31274 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.ValidatorHandler_._getErrorHandler31275 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.ValidatorHandler_._setResourceResolver31276 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.ValidatorHandler_._getResourceResolver31277 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider31278 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;");
		}
	}
}
