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
		internal static global::MonoJavaBridge.MethodId _parse35020;
		void org.xml.sax.Parser.parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._parse35020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35021;
		void org.xml.sax.Parser.parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._parse35021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocale35022;
		void org.xml.sax.Parser.setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setLocale35022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35023;
		void org.xml.sax.Parser.setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setEntityResolver35023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35024;
		void org.xml.sax.Parser.setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setDTDHandler35024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35025;
		void org.xml.sax.Parser.setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setErrorHandler35025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentHandler35026;
		void org.xml.sax.Parser.setDocumentHandler(org.xml.sax.DocumentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.Parser_._setDocumentHandler35026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Parser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Parser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Parser"));
			global::org.xml.sax.Parser_._parse35020 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.Parser_._parse35021 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.Parser_._setLocale35022 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::org.xml.sax.Parser_._setEntityResolver35023 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.Parser_._setDTDHandler35024 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.Parser_._setErrorHandler35025 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.Parser_._setDocumentHandler35026 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Parser_.staticClass, "setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
