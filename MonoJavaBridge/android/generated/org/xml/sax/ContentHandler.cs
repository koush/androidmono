namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ContentHandler_))]
	public partial interface ContentHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3);
		void characters(char[] arg0, int arg1, int arg2);
		void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		void startDocument();
		void endDocument();
		void startPrefixMapping(java.lang.String arg0, java.lang.String arg1);
		void ignorableWhitespace(char[] arg0, int arg1, int arg2);
		void processingInstruction(java.lang.String arg0, java.lang.String arg1);
		void setDocumentLocator(org.xml.sax.Locator arg0);
		void skippedEntity(java.lang.String arg0);
		void endPrefixMapping(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ContentHandler))]
	internal sealed partial class ContentHandler_ : java.lang.Object, ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement34962;
		void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", ref global::org.xml.sax.ContentHandler_._startElement34962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters34963;
		void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "characters", "([CII)V", ref global::org.xml.sax.ContentHandler_._characters34963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement34964;
		void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ContentHandler_._endElement34964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument34965;
		void org.xml.sax.ContentHandler.startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "startDocument", "()V", ref global::org.xml.sax.ContentHandler_._startDocument34965);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument34966;
		void org.xml.sax.ContentHandler.endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "endDocument", "()V", ref global::org.xml.sax.ContentHandler_._endDocument34966);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping34967;
		void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ContentHandler_._startPrefixMapping34967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace34968;
		void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "ignorableWhitespace", "([CII)V", ref global::org.xml.sax.ContentHandler_._ignorableWhitespace34968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction34969;
		void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ContentHandler_._processingInstruction34969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator34970;
		void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::org.xml.sax.ContentHandler_._setDocumentLocator34970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity34971;
		void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V", ref global::org.xml.sax.ContentHandler_._skippedEntity34971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping34972;
		void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ContentHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V", ref global::org.xml.sax.ContentHandler_._endPrefixMapping34972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ContentHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ContentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ContentHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
