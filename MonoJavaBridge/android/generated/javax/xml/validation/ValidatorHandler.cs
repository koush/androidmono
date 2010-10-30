namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.ValidatorHandler_))]
	public abstract partial class ValidatorHandler : java.lang.Object, org.xml.sax.ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ValidatorHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void characters(char[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void startDocument();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract void endDocument();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void startPrefixMapping(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void ignorableWhitespace(char[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract void processingInstruction(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void setDocumentLocator(org.xml.sax.Locator arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void skippedEntity(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void endPrefixMapping(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.validation.ValidatorHandler._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.validation.ValidatorHandler._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::org.xml.sax.ContentHandler getContentHandler();
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.validation.ValidatorHandler._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.ValidatorHandler.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.validation.ValidatorHandler._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract void setContentHandler(org.xml.sax.ContentHandler arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider();
		private static global::MonoJavaBridge.MethodId _m22;
		protected ValidatorHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.ValidatorHandler._m22.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.ValidatorHandler._m22 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.ValidatorHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.ValidatorHandler.staticClass, global::javax.xml.validation.ValidatorHandler._m22);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", ref global::javax.xml.validation.ValidatorHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "characters", "([CII)V", ref global::javax.xml.validation.ValidatorHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "startDocument", "()V", ref global::javax.xml.validation.ValidatorHandler_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "endDocument", "()V", ref global::javax.xml.validation.ValidatorHandler_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "ignorableWhitespace", "([CII)V", ref global::javax.xml.validation.ValidatorHandler_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::javax.xml.validation.ValidatorHandler_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V", ref global::javax.xml.validation.ValidatorHandler_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::org.xml.sax.ContentHandler getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;", ref global::javax.xml.validation.ValidatorHandler_._m11) as org.xml.sax.ContentHandler;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", ref global::javax.xml.validation.ValidatorHandler_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::javax.xml.validation.ValidatorHandler_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::javax.xml.validation.ValidatorHandler_._m14) as org.xml.sax.ErrorHandler;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", ref global::javax.xml.validation.ValidatorHandler_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSResourceResolver>(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", ref global::javax.xml.validation.ValidatorHandler_._m16) as org.w3c.dom.ls.LSResourceResolver;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::javax.xml.validation.TypeInfoProvider getTypeInfoProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.ValidatorHandler_.staticClass, "getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;", ref global::javax.xml.validation.ValidatorHandler_._m17) as javax.xml.validation.TypeInfoProvider;
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
