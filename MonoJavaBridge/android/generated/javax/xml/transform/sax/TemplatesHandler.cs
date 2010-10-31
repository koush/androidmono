namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.sax.TemplatesHandler_))]
	public partial interface TemplatesHandler : org.xml.sax.ContentHandler
	{
		global::java.lang.String getSystemId();
		void setSystemId(java.lang.String arg0);
		global::javax.xml.transform.Templates getTemplates();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.sax.TemplatesHandler))]
	internal sealed partial class TemplatesHandler_ : java.lang.Object, TemplatesHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TemplatesHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String javax.xml.transform.sax.TemplatesHandler.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.sax.TemplatesHandler_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.xml.transform.sax.TemplatesHandler.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::javax.xml.transform.Templates javax.xml.transform.sax.TemplatesHandler.getTemplates()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Templates>(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "getTemplates", "()Ljavax/xml/transform/Templates;", ref global::javax.xml.transform.sax.TemplatesHandler_._m2) as javax.xml.transform.Templates;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "characters", "([CII)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.xml.sax.ContentHandler.startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startDocument", "()V", ref global::javax.xml.transform.sax.TemplatesHandler_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.xml.sax.ContentHandler.endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endDocument", "()V", ref global::javax.xml.transform.sax.TemplatesHandler_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "ignorableWhitespace", "([CII)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TemplatesHandler_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TemplatesHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.TemplatesHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/TemplatesHandler"));
		}
	}
}
