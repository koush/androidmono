namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.XMLFilter_))]
	public interface XMLFilter : XMLReader
	{
		global::org.xml.sax.XMLReader getParent();
		void setParent(org.xml.sax.XMLReader arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.XMLFilter))]
	public sealed partial class XMLFilter_ : java.lang.Object, XMLFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLFilter_()
		{
			InitJNI();
		}
		internal XMLFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent28177;
		 global::org.xml.sax.XMLReader org.xml.sax.XMLFilter.getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getParent28177)) as org.xml.sax.XMLReader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getParent28177)) as org.xml.sax.XMLReader;
		}
		internal static global::MonoJavaBridge.MethodId _setParent28178;
		 void org.xml.sax.XMLFilter.setParent(org.xml.sax.XMLReader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setParent28178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setParent28178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProperty28179;
		 void org.xml.sax.XMLReader.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setProperty28179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setProperty28179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty28180;
		 global::java.lang.Object org.xml.sax.XMLReader.getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getProperty28180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getProperty28180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _parse28181;
		 void org.xml.sax.XMLReader.parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._parse28181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._parse28181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse28182;
		 void org.xml.sax.XMLReader.parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._parse28182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._parse28182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler28183;
		 global::org.xml.sax.ContentHandler org.xml.sax.XMLReader.getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getContentHandler28183)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getContentHandler28183)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature28184;
		 void org.xml.sax.XMLReader.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setFeature28184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setFeature28184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature28185;
		 bool org.xml.sax.XMLReader.getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getFeature28185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getFeature28185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver28186;
		 void org.xml.sax.XMLReader.setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setEntityResolver28186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setEntityResolver28186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntityResolver28187;
		 global::org.xml.sax.EntityResolver org.xml.sax.XMLReader.getEntityResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getEntityResolver28187)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getEntityResolver28187)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler28188;
		 void org.xml.sax.XMLReader.setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setDTDHandler28188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setDTDHandler28188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDTDHandler28189;
		 global::org.xml.sax.DTDHandler org.xml.sax.XMLReader.getDTDHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getDTDHandler28189)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getDTDHandler28189)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler28190;
		 void org.xml.sax.XMLReader.setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setContentHandler28190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setContentHandler28190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler28191;
		 void org.xml.sax.XMLReader.setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._setErrorHandler28191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._setErrorHandler28191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler28192;
		 global::org.xml.sax.ErrorHandler org.xml.sax.XMLReader.getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_._getErrorHandler28192)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.XMLFilter_.staticClass, global::org.xml.sax.XMLFilter_._getErrorHandler28192)) as org.xml.sax.ErrorHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.XMLFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/XMLFilter"));
			global::org.xml.sax.XMLFilter_._getParent28177 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getParent", "()Lorg/xml/sax/XMLReader;");
			global::org.xml.sax.XMLFilter_._setParent28178 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setParent", "(Lorg/xml/sax/XMLReader;)V");
			global::org.xml.sax.XMLFilter_._setProperty28179 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xml.sax.XMLFilter_._getProperty28180 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xml.sax.XMLFilter_._parse28181 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.XMLFilter_._parse28182 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.XMLFilter_._getContentHandler28183 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xml.sax.XMLFilter_._setFeature28184 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xml.sax.XMLFilter_._getFeature28185 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xml.sax.XMLFilter_._setEntityResolver28186 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.XMLFilter_._getEntityResolver28187 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xml.sax.XMLFilter_._setDTDHandler28188 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.XMLFilter_._getDTDHandler28189 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xml.sax.XMLFilter_._setContentHandler28190 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xml.sax.XMLFilter_._setErrorHandler28191 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.XMLFilter_._getErrorHandler28192 = @__env.GetMethodIDNoThrow(global::org.xml.sax.XMLFilter_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
		}
	}
}
