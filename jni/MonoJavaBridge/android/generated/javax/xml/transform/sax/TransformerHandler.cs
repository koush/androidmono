namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.sax.TransformerHandler_))]
	public interface TransformerHandler : org.xml.sax.ContentHandler, org.xml.sax.ext.LexicalHandler, org.xml.sax.DTDHandler
	{
		global::java.lang.String getSystemId();
		void setResult(javax.xml.transform.Result arg0);
		void setSystemId(java.lang.String arg0);
		global::javax.xml.transform.Transformer getTransformer();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.sax.TransformerHandler))]
	public sealed partial class TransformerHandler_ : java.lang.Object, TransformerHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransformerHandler_()
		{
			InitJNI();
		}
		internal TransformerHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId31007;
		 global::java.lang.String javax.xml.transform.sax.TransformerHandler.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._getSystemId31007)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._getSystemId31007)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setResult31008;
		 void javax.xml.transform.sax.TransformerHandler.setResult(javax.xml.transform.Result arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setResult31008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._setResult31008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31009;
		 void javax.xml.transform.sax.TransformerHandler.setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setSystemId31009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._setSystemId31009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformer31010;
		 global::javax.xml.transform.Transformer javax.xml.transform.sax.TransformerHandler.getTransformer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._getTransformer31010)) as javax.xml.transform.Transformer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._getTransformer31010)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _startElement31011;
		 void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startElement31011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startElement31011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters31012;
		 void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._characters31012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._characters31012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement31013;
		 void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endElement31013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endElement31013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument31014;
		 void org.xml.sax.ContentHandler.startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startDocument31014);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startDocument31014);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument31015;
		 void org.xml.sax.ContentHandler.endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endDocument31015);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endDocument31015);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31016;
		 void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping31016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping31016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31017;
		 void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace31017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace31017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction31018;
		 void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._processingInstruction31018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._processingInstruction31018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31019;
		 void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator31019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator31019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity31020;
		 void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._skippedEntity31020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._skippedEntity31020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31021;
		 void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping31021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping31021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comment31022;
		 void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._comment31022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._comment31022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA31023;
		 void org.xml.sax.ext.LexicalHandler.startCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startCDATA31023);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startCDATA31023);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA31024;
		 void org.xml.sax.ext.LexicalHandler.endCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endCDATA31024);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endCDATA31024);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity31025;
		 void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startEntity31025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startEntity31025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity31026;
		 void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endEntity31026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endEntity31026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD31027;
		 void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startDTD31027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startDTD31027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD31028;
		 void org.xml.sax.ext.LexicalHandler.endDTD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endDTD31028);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endDTD31028);
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl31029;
		 void org.xml.sax.DTDHandler.unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl31029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl31029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl31030;
		 void org.xml.sax.DTDHandler.notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._notationDecl31030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._notationDecl31030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.TransformerHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/TransformerHandler"));
			global::javax.xml.transform.sax.TransformerHandler_._getSystemId31007 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.sax.TransformerHandler_._setResult31008 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setResult", "(Ljavax/xml/transform/Result;)V");
			global::javax.xml.transform.sax.TransformerHandler_._setSystemId31009 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._getTransformer31010 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getTransformer", "()Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.sax.TransformerHandler_._startElement31011 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.transform.sax.TransformerHandler_._characters31012 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "characters", "([CII)V");
			global::javax.xml.transform.sax.TransformerHandler_._endElement31013 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._startDocument31014 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDocument", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._endDocument31015 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDocument", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping31016 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace31017 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.transform.sax.TransformerHandler_._processingInstruction31018 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator31019 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.transform.sax.TransformerHandler_._skippedEntity31020 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping31021 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._comment31022 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "comment", "([CII)V");
			global::javax.xml.transform.sax.TransformerHandler_._startCDATA31023 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startCDATA", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._endCDATA31024 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endCDATA", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._startEntity31025 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._endEntity31026 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._startDTD31027 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._endDTD31028 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDTD", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl31029 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._notationDecl31030 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
