namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.Parser_))]
	public partial interface Parser  : global::MonoJavaBridge.IJavaObject 
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
	internal sealed partial class Parser_ : java.lang.Object, Parser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Parser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.xml.sax.Parser.parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.Parser_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V", ref global::org.xml.sax.Parser_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.xml.sax.Parser.parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.Parser_.staticClass, "parse", "(Ljava/lang/String;)V", ref global::org.xml.sax.Parser_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.xml.sax.Parser.setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.Parser_.staticClass, "setLocale", "(Ljava/util/Locale;)V", ref global::org.xml.sax.Parser_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.xml.sax.Parser.setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.Parser_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", ref global::org.xml.sax.Parser_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.xml.sax.Parser.setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.Parser_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", ref global::org.xml.sax.Parser_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.xml.sax.Parser.setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.Parser_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::org.xml.sax.Parser_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.xml.sax.Parser.setDocumentHandler(org.xml.sax.DocumentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.Parser_.staticClass, "setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V", ref global::org.xml.sax.Parser_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Parser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Parser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Parser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
