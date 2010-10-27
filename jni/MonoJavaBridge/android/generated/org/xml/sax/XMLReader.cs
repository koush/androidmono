namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.XMLReader_))]
	public partial interface XMLReader  : global::MonoJavaBridge.IJavaObject 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		void parse(java.lang.String arg0);
		void parse(org.xml.sax.InputSource arg0);
		global::org.xml.sax.ContentHandler getContentHandler();
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		void setEntityResolver(org.xml.sax.EntityResolver arg0);
		global::org.xml.sax.EntityResolver getEntityResolver();
		void setDTDHandler(org.xml.sax.DTDHandler arg0);
		global::org.xml.sax.DTDHandler getDTDHandler();
		void setContentHandler(org.xml.sax.ContentHandler arg0);
		void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		global::org.xml.sax.ErrorHandler getErrorHandler();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.XMLReader))]
	internal sealed partial class XMLReader_ : java.lang.Object, XMLReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLReader_()
		{
			InitJNI();
		}
		internal XMLReader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35062;
		void org.xml.sax.XMLReader.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._setProperty35062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._setProperty35062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35063;
		global::java.lang.Object org.xml.sax.XMLReader.getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._getProperty35063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._getProperty35063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _parse35064;
		void org.xml.sax.XMLReader.parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._parse35064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._parse35064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35065;
		void org.xml.sax.XMLReader.parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._parse35065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._parse35065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler35066;
		global::org.xml.sax.ContentHandler org.xml.sax.XMLReader.getContentHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._getContentHandler35066)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._getContentHandler35066)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35067;
		void org.xml.sax.XMLReader.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._setFeature35067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._setFeature35067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35068;
		bool org.xml.sax.XMLReader.getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._getFeature35068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._getFeature35068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35069;
		void org.xml.sax.XMLReader.setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._setEntityResolver35069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._setEntityResolver35069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35070;
		global::org.xml.sax.EntityResolver org.xml.sax.XMLReader.getEntityResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._getEntityResolver35070)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._getEntityResolver35070)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35071;
		void org.xml.sax.XMLReader.setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._setDTDHandler35071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._setDTDHandler35071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35072;
		global::org.xml.sax.DTDHandler org.xml.sax.XMLReader.getDTDHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._getDTDHandler35072)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._getDTDHandler35072)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35073;
		void org.xml.sax.XMLReader.setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._setContentHandler35073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._setContentHandler35073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35074;
		void org.xml.sax.XMLReader.setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._setErrorHandler35074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._setErrorHandler35074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35075;
		global::org.xml.sax.ErrorHandler org.xml.sax.XMLReader.getErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_._getErrorHandler35075)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLReader_.staticClass, global::org.xml.sax.XMLReader_._getErrorHandler35075)) as org.xml.sax.ErrorHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.XMLReader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/XMLReader"));
			global::org.xml.sax.XMLReader_._setProperty35062 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xml.sax.XMLReader_._getProperty35063 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xml.sax.XMLReader_._parse35064 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.XMLReader_._parse35065 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.XMLReader_._getContentHandler35066 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xml.sax.XMLReader_._setFeature35067 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xml.sax.XMLReader_._getFeature35068 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xml.sax.XMLReader_._setEntityResolver35069 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.XMLReader_._getEntityResolver35070 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xml.sax.XMLReader_._setDTDHandler35071 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.XMLReader_._getDTDHandler35072 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xml.sax.XMLReader_._setContentHandler35073 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xml.sax.XMLReader_._setErrorHandler35074 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.XMLReader_._getErrorHandler35075 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLReader_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
		}
	}
}
