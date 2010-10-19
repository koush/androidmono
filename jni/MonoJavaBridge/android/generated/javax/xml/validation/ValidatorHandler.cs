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
		internal static global::MonoJavaBridge.MethodId _startElement24635;
		public abstract void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3);
		internal static global::MonoJavaBridge.MethodId _characters24636;
		public abstract void characters(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _endElement24637;
		public abstract void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _startDocument24638;
		public abstract void startDocument();
		internal static global::MonoJavaBridge.MethodId _endDocument24639;
		public abstract void endDocument();
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping24640;
		public abstract void startPrefixMapping(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace24641;
		public abstract void ignorableWhitespace(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _processingInstruction24642;
		public abstract void processingInstruction(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator24643;
		public abstract void setDocumentLocator(org.xml.sax.Locator arg0);
		internal static global::MonoJavaBridge.MethodId _skippedEntity24644;
		public abstract void skippedEntity(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping24645;
		public abstract void endPrefixMapping(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setProperty24646;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._setProperty24646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._setProperty24646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty24647;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._getProperty24647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._getProperty24647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler24648;
		public abstract global::org.xml.sax.ContentHandler getContentHandler();
		internal static global::MonoJavaBridge.MethodId _setFeature24649;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._setFeature24649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._setFeature24649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature24650;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler._getFeature24650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._getFeature24650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler24651;
		public abstract void setContentHandler(org.xml.sax.ContentHandler arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24652;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler24653;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver24654;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver24655;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _getTypeInfoProvider24656;
		public abstract global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider();
		internal static global::MonoJavaBridge.MethodId _ValidatorHandler24657;
		protected ValidatorHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._ValidatorHandler24657);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
			global::javax.xml.validation.ValidatorHandler._startElement24635 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.validation.ValidatorHandler._characters24636 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "characters", "([CII)V");
			global::javax.xml.validation.ValidatorHandler._endElement24637 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._startDocument24638 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startDocument", "()V");
			global::javax.xml.validation.ValidatorHandler._endDocument24639 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endDocument", "()V");
			global::javax.xml.validation.ValidatorHandler._startPrefixMapping24640 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._ignorableWhitespace24641 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.validation.ValidatorHandler._processingInstruction24642 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._setDocumentLocator24643 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.validation.ValidatorHandler._skippedEntity24644 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._endPrefixMapping24645 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler._setProperty24646 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.validation.ValidatorHandler._getProperty24647 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.validation.ValidatorHandler._getContentHandler24648 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::javax.xml.validation.ValidatorHandler._setFeature24649 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.validation.ValidatorHandler._getFeature24650 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.ValidatorHandler._setContentHandler24651 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.validation.ValidatorHandler._setErrorHandler24652 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.ValidatorHandler._getErrorHandler24653 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.ValidatorHandler._setResourceResolver24654 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.ValidatorHandler._getResourceResolver24655 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.ValidatorHandler._getTypeInfoProvider24656 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;");
			global::javax.xml.validation.ValidatorHandler._ValidatorHandler24657 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.ValidatorHandler))]
	public sealed partial class ValidatorHandler_ : javax.xml.validation.ValidatorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ValidatorHandler_()
		{
			InitJNI();
		}
		internal ValidatorHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement24658;
		public override void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startElement24658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startElement24658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters24659;
		public override void characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._characters24659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._characters24659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement24660;
		public override void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endElement24660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endElement24660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument24661;
		public override void startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startDocument24661);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startDocument24661);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument24662;
		public override void endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endDocument24662);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endDocument24662);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping24663;
		public override void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._startPrefixMapping24663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._startPrefixMapping24663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace24664;
		public override void ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace24664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace24664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction24665;
		public override void processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._processingInstruction24665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._processingInstruction24665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator24666;
		public override void setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setDocumentLocator24666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setDocumentLocator24666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity24667;
		public override void skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._skippedEntity24667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._skippedEntity24667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping24668;
		public override void endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._endPrefixMapping24668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._endPrefixMapping24668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler24669;
		public override global::org.xml.sax.ContentHandler getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getContentHandler24669)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getContentHandler24669)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler24670;
		public override void setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setContentHandler24670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setContentHandler24670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24671;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setErrorHandler24671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setErrorHandler24671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler24672;
		public override global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getErrorHandler24672)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getErrorHandler24672)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver24673;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._setResourceResolver24673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._setResourceResolver24673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver24674;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getResourceResolver24674)) as org.w3c.dom.ls.LSResourceResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getResourceResolver24674)) as org.w3c.dom.ls.LSResourceResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfoProvider24675;
		public override global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider24675)) as javax.xml.validation.TypeInfoProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.ValidatorHandler_.staticClass, global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider24675)) as javax.xml.validation.TypeInfoProvider;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.ValidatorHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/ValidatorHandler"));
			global::javax.xml.validation.ValidatorHandler_._startElement24658 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.validation.ValidatorHandler_._characters24659 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "characters", "([CII)V");
			global::javax.xml.validation.ValidatorHandler_._endElement24660 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._startDocument24661 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startDocument", "()V");
			global::javax.xml.validation.ValidatorHandler_._endDocument24662 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endDocument", "()V");
			global::javax.xml.validation.ValidatorHandler_._startPrefixMapping24663 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._ignorableWhitespace24664 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.validation.ValidatorHandler_._processingInstruction24665 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._setDocumentLocator24666 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.validation.ValidatorHandler_._skippedEntity24667 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._endPrefixMapping24668 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.validation.ValidatorHandler_._getContentHandler24669 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::javax.xml.validation.ValidatorHandler_._setContentHandler24670 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.validation.ValidatorHandler_._setErrorHandler24671 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.ValidatorHandler_._getErrorHandler24672 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.ValidatorHandler_._setResourceResolver24673 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.ValidatorHandler_._getResourceResolver24674 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.ValidatorHandler_._getTypeInfoProvider24675 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler_.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;");
		}
	}
}
