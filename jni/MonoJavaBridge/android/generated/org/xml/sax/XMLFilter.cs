namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.XMLFilter_))]
	public partial interface XMLFilter : XMLReader
	{
		global::org.xml.sax.XMLReader getParent();
		void setParent(org.xml.sax.XMLReader arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.XMLFilter))]
	internal sealed partial class XMLFilter_ : java.lang.Object, XMLFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLFilter_()
		{
			InitJNI();
		}
		internal XMLFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent35046;
		 global::org.xml.sax.XMLReader org.xml.sax.XMLFilter.getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getParent35046)) as org.xml.sax.XMLReader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getParent35046)) as org.xml.sax.XMLReader;
		}
		internal static global::MonoJavaBridge.MethodId _setParent35047;
		 void org.xml.sax.XMLFilter.setParent(org.xml.sax.XMLReader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setParent35047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setParent35047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35048;
		 void org.xml.sax.XMLReader.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setProperty35048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setProperty35048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35049;
		 global::java.lang.Object org.xml.sax.XMLReader.getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getProperty35049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getProperty35049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _parse35050;
		 void org.xml.sax.XMLReader.parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._parse35050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._parse35050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35051;
		 void org.xml.sax.XMLReader.parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._parse35051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._parse35051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler35052;
		 global::org.xml.sax.ContentHandler org.xml.sax.XMLReader.getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getContentHandler35052)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getContentHandler35052)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35053;
		 void org.xml.sax.XMLReader.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setFeature35053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setFeature35053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35054;
		 bool org.xml.sax.XMLReader.getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getFeature35054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getFeature35054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35055;
		 void org.xml.sax.XMLReader.setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setEntityResolver35055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setEntityResolver35055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35056;
		 global::org.xml.sax.EntityResolver org.xml.sax.XMLReader.getEntityResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getEntityResolver35056)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getEntityResolver35056)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35057;
		 void org.xml.sax.XMLReader.setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setDTDHandler35057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setDTDHandler35057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35058;
		 global::org.xml.sax.DTDHandler org.xml.sax.XMLReader.getDTDHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getDTDHandler35058)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getDTDHandler35058)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35059;
		 void org.xml.sax.XMLReader.setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setContentHandler35059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setContentHandler35059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35060;
		 void org.xml.sax.XMLReader.setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setErrorHandler35060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setErrorHandler35060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35061;
		 global::org.xml.sax.ErrorHandler org.xml.sax.XMLReader.getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getErrorHandler35061)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getErrorHandler35061)) as org.xml.sax.ErrorHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.XMLFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/XMLFilter"));
			global::org.xml.sax.XMLFilter_._getParent35046 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getParent", "()Lorg/xml/sax/XMLReader;");
			global::org.xml.sax.XMLFilter_._setParent35047 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setParent", "(Lorg/xml/sax/XMLReader;)V");
			global::org.xml.sax.XMLFilter_._setProperty35048 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xml.sax.XMLFilter_._getProperty35049 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xml.sax.XMLFilter_._parse35050 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.XMLFilter_._parse35051 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.XMLFilter_._getContentHandler35052 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xml.sax.XMLFilter_._setFeature35053 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xml.sax.XMLFilter_._getFeature35054 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xml.sax.XMLFilter_._setEntityResolver35055 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.XMLFilter_._getEntityResolver35056 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xml.sax.XMLFilter_._setDTDHandler35057 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.XMLFilter_._getDTDHandler35058 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xml.sax.XMLFilter_._setContentHandler35059 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xml.sax.XMLFilter_._setErrorHandler35060 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.XMLFilter_._getErrorHandler35061 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
		}
	}
}
