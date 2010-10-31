namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.DocumentHandler_))]
	public partial interface DocumentHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1);
		void characters(char[] arg0, int arg1, int arg2);
		void endElement(java.lang.String arg0);
		void startDocument();
		void endDocument();
		void ignorableWhitespace(char[] arg0, int arg1, int arg2);
		void processingInstruction(java.lang.String arg0, java.lang.String arg1);
		void setDocumentLocator(org.xml.sax.Locator arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.DocumentHandler))]
	internal sealed partial class DocumentHandler_ : java.lang.Object, DocumentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DocumentHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.xml.sax.DocumentHandler.startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", ref global::org.xml.sax.DocumentHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.xml.sax.DocumentHandler.characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "characters", "([CII)V", ref global::org.xml.sax.DocumentHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.xml.sax.DocumentHandler.endElement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "endElement", "(Ljava/lang/String;)V", ref global::org.xml.sax.DocumentHandler_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.xml.sax.DocumentHandler.startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "startDocument", "()V", ref global::org.xml.sax.DocumentHandler_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.xml.sax.DocumentHandler.endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "endDocument", "()V", ref global::org.xml.sax.DocumentHandler_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.xml.sax.DocumentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "ignorableWhitespace", "([CII)V", ref global::org.xml.sax.DocumentHandler_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.xml.sax.DocumentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.DocumentHandler_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.xml.sax.DocumentHandler.setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.DocumentHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::org.xml.sax.DocumentHandler_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DocumentHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.DocumentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/DocumentHandler"));
		}
	}
}
