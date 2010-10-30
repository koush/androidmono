namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.sax.TransformerHandler_))]
	public partial interface TransformerHandler : org.xml.sax.ContentHandler, org.xml.sax.ext.LexicalHandler, org.xml.sax.DTDHandler
	{
		global::java.lang.String getSystemId();
		void setResult(javax.xml.transform.Result arg0);
		void setSystemId(java.lang.String arg0);
		global::javax.xml.transform.Transformer getTransformer();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.sax.TransformerHandler))]
	internal sealed partial class TransformerHandler_ : java.lang.Object, TransformerHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TransformerHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String javax.xml.transform.sax.TransformerHandler.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.sax.TransformerHandler_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.xml.transform.sax.TransformerHandler.setResult(javax.xml.transform.Result arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setResult", "(Ljavax/xml/transform/Result;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.xml.transform.sax.TransformerHandler.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::javax.xml.transform.Transformer javax.xml.transform.sax.TransformerHandler.getTransformer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getTransformer", "()Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.sax.TransformerHandler_._m3) as javax.xml.transform.Transformer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "characters", "([CII)V", ref global::javax.xml.transform.sax.TransformerHandler_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.xml.sax.ContentHandler.startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDocument", "()V", ref global::javax.xml.transform.sax.TransformerHandler_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.xml.sax.ContentHandler.endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDocument", "()V", ref global::javax.xml.transform.sax.TransformerHandler_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "ignorableWhitespace", "([CII)V", ref global::javax.xml.transform.sax.TransformerHandler_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "comment", "([CII)V", ref global::javax.xml.transform.sax.TransformerHandler_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void org.xml.sax.ext.LexicalHandler.startCDATA()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startCDATA", "()V", ref global::javax.xml.transform.sax.TransformerHandler_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void org.xml.sax.ext.LexicalHandler.endCDATA()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endCDATA", "()V", ref global::javax.xml.transform.sax.TransformerHandler_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void org.xml.sax.ext.LexicalHandler.endDTD()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDTD", "()V", ref global::javax.xml.transform.sax.TransformerHandler_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void org.xml.sax.DTDHandler.unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void org.xml.sax.DTDHandler.notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.TransformerHandler_.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.sax.TransformerHandler_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static TransformerHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.TransformerHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/TransformerHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
