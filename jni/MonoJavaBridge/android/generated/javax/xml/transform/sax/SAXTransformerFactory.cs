namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.sax.SAXTransformerFactory_))]
	public abstract partial class SAXTransformerFactory : javax.xml.transform.TransformerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXTransformerFactory()
		{
			InitJNI();
		}
		protected SAXTransformerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler24485;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler24486;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Templates arg0);
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler24487;
		public abstract global::javax.xml.transform.sax.TransformerHandler newTransformerHandler();
		internal static global::MonoJavaBridge.MethodId _newTemplatesHandler24488;
		public abstract global::javax.xml.transform.sax.TemplatesHandler newTemplatesHandler();
		internal static global::MonoJavaBridge.MethodId _newXMLFilter24489;
		public abstract global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLFilter24490;
		public abstract global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Templates arg0);
		internal static global::MonoJavaBridge.MethodId _SAXTransformerFactory24491;
		protected SAXTransformerFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXTransformerFactory.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory._SAXTransformerFactory24491);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXTransformerFactory/feature";
			}
		}
		public static global::java.lang.String FEATURE_XMLFILTER
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXTransformerFactory/feature/xmlfilter";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXTransformerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXTransformerFactory"));
			global::javax.xml.transform.sax.SAXTransformerFactory._newTransformerHandler24485 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory._newTransformerHandler24486 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory._newTransformerHandler24487 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory._newTemplatesHandler24488 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory._newXMLFilter24489 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;");
			global::javax.xml.transform.sax.SAXTransformerFactory._newXMLFilter24490 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;");
			global::javax.xml.transform.sax.SAXTransformerFactory._SAXTransformerFactory24491 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.sax.SAXTransformerFactory))]
	public sealed partial class SAXTransformerFactory_ : javax.xml.transform.sax.SAXTransformerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXTransformerFactory_()
		{
			InitJNI();
		}
		internal SAXTransformerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler24492;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TransformerHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.sax.TransformerHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TransformerHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.sax.TransformerHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler24493;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler(javax.xml.transform.Templates arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TransformerHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.sax.TransformerHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TransformerHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.sax.TransformerHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformerHandler24494;
		public override global::javax.xml.transform.sax.TransformerHandler newTransformerHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TransformerHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24494)) as javax.xml.transform.sax.TransformerHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TransformerHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24494)) as javax.xml.transform.sax.TransformerHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newTemplatesHandler24495;
		public override global::javax.xml.transform.sax.TemplatesHandler newTemplatesHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TemplatesHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplatesHandler24495)) as javax.xml.transform.sax.TemplatesHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.sax.TemplatesHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplatesHandler24495)) as javax.xml.transform.sax.TemplatesHandler;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLFilter24496;
		public override global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLFilter>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter24496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.XMLFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter24496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.XMLFilter;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLFilter24497;
		public override global::org.xml.sax.XMLFilter newXMLFilter(javax.xml.transform.Templates arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLFilter>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter24497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.XMLFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter24497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.XMLFilter;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute24498;
		public override global::java.lang.Object getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._getAttribute24498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._getAttribute24498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature24499;
		public override void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._setFeature24499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._setFeature24499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature24500;
		public override bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._getFeature24500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._getFeature24500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute24501;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._setAttribute24501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._setAttribute24501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer24502;
		public override global::javax.xml.transform.Transformer newTransformer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer24502)) as javax.xml.transform.Transformer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer24502)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer24503;
		public override global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer24503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Transformer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer24503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _setURIResolver24504;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._setURIResolver24504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._setURIResolver24504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getURIResolver24505;
		public override global::javax.xml.transform.URIResolver getURIResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._getURIResolver24505)) as javax.xml.transform.URIResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._getURIResolver24505)) as javax.xml.transform.URIResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorListener24506;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._setErrorListener24506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._setErrorListener24506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorListener24507;
		public override global::javax.xml.transform.ErrorListener getErrorListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._getErrorListener24507)) as javax.xml.transform.ErrorListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._getErrorListener24507)) as javax.xml.transform.ErrorListener;
		}
		internal static global::MonoJavaBridge.MethodId _newTemplates24508;
		public override global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplates24508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Templates;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplates24508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Templates;
		}
		internal static global::MonoJavaBridge.MethodId _getAssociatedStylesheet24509;
		public override global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Source>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_._getAssociatedStylesheet24509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.transform.Source;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Source>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, global::javax.xml.transform.sax.SAXTransformerFactory_._getAssociatedStylesheet24509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.transform.Source;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXTransformerFactory"));
			global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24492 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24493 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformerHandler24494 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplatesHandler24495 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter24496 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newXMLFilter24497 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._getAttribute24498 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._setFeature24499 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.transform.sax.SAXTransformerFactory_._getFeature24500 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.transform.sax.SAXTransformerFactory_._setAttribute24501 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer24502 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newTransformer24503 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._setURIResolver24504 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			global::javax.xml.transform.sax.SAXTransformerFactory_._getURIResolver24505 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._setErrorListener24506 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			global::javax.xml.transform.sax.SAXTransformerFactory_._getErrorListener24507 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._newTemplates24508 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;");
			global::javax.xml.transform.sax.SAXTransformerFactory_._getAssociatedStylesheet24509 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXTransformerFactory_.staticClass, "getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;");
		}
	}
}
