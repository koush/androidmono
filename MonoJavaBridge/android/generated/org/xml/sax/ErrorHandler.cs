namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ErrorHandler_))]
	public partial interface ErrorHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void fatalError(org.xml.sax.SAXParseException arg0);
		void error(org.xml.sax.SAXParseException arg0);
		void warning(org.xml.sax.SAXParseException arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ErrorHandler))]
	internal sealed partial class ErrorHandler_ : java.lang.Object, ErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ErrorHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.xml.sax.ErrorHandler.fatalError(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ErrorHandler_.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V", ref global::org.xml.sax.ErrorHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.xml.sax.ErrorHandler.error(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ErrorHandler_.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V", ref global::org.xml.sax.ErrorHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.xml.sax.ErrorHandler.warning(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ErrorHandler_.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V", ref global::org.xml.sax.ErrorHandler_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ErrorHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ErrorHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ErrorHandler"));
		}
	}
}
