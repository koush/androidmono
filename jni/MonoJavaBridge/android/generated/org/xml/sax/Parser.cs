namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.Parser_))]
	public interface Parser  : global::MonoJavaBridge.IJavaObject 
	{
		void parse(org.xml.sax.InputSource arg0);
		void parse(java.lang.String arg0);
		void setLocale(java.util.Locale arg0);
		void setEntityResolver(org.xml.sax.EntityResolver arg0);
		void setDTDHandler(org.xml.sax.DTDHandler arg0);
		void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		void setDocumentHandler(org.xml.sax.DocumentHandler arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.Parser))]
	public sealed partial class Parser_ : java.lang.Object, Parser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Parser_()
		{
			InitJNI();
		}
		internal Parser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse28150;
		 void org.xml.sax.Parser.parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._parse28150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_.staticClass, global::org.xml.sax.Parser_._parse28150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse28151;
		 void org.xml.sax.Parser.parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._parse28151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_.staticClass, global::org.xml.sax.Parser_._parse28151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocale28152;
		 void org.xml.sax.Parser.setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setLocale28152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_.staticClass, global::org.xml.sax.Parser_._setLocale28152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver28153;
		 void org.xml.sax.Parser.setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setEntityResolver28153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_.staticClass, global::org.xml.sax.Parser_._setEntityResolver28153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler28154;
		 void org.xml.sax.Parser.setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setDTDHandler28154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_.staticClass, global::org.xml.sax.Parser_._setDTDHandler28154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler28155;
		 void org.xml.sax.Parser.setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setErrorHandler28155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_.staticClass, global::org.xml.sax.Parser_._setErrorHandler28155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentHandler28156;
		 void org.xml.sax.Parser.setDocumentHandler(org.xml.sax.DocumentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setDocumentHandler28156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_.staticClass, global::org.xml.sax.Parser_._setDocumentHandler28156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Parser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Parser"));
			global::org.xml.sax.Parser_._parse28150 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.Parser_._parse28151 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.Parser_._setLocale28152 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::org.xml.sax.Parser_._setEntityResolver28153 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.Parser_._setDTDHandler28154 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.Parser_._setErrorHandler28155 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.Parser_._setDocumentHandler28156 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V");
		}
	}
}
