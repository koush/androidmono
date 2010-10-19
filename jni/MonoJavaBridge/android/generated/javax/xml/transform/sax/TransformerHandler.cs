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
		internal static global::MonoJavaBridge.MethodId _getSystemId24524;
		 global::java.lang.String javax.xml.transform.sax.TransformerHandler.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._getSystemId24524)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._getSystemId24524)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setResult24525;
		 void javax.xml.transform.sax.TransformerHandler.setResult(javax.xml.transform.Result arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setResult24525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._setResult24525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId24526;
		 void javax.xml.transform.sax.TransformerHandler.setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setSystemId24526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._setSystemId24526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformer24527;
		 global::javax.xml.transform.Transformer javax.xml.transform.sax.TransformerHandler.getTransformer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._getTransformer24527)) as javax.xml.transform.Transformer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._getTransformer24527)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _startElement24528;
		 void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startElement24528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startElement24528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters24529;
		 void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._characters24529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._characters24529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement24530;
		 void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endElement24530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endElement24530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument24531;
		 void org.xml.sax.ContentHandler.startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startDocument24531);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startDocument24531);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument24532;
		 void org.xml.sax.ContentHandler.endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endDocument24532);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endDocument24532);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping24533;
		 void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping24533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping24533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace24534;
		 void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace24534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace24534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction24535;
		 void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._processingInstruction24535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._processingInstruction24535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator24536;
		 void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator24536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator24536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity24537;
		 void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._skippedEntity24537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._skippedEntity24537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping24538;
		 void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping24538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping24538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comment24539;
		 void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._comment24539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._comment24539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA24540;
		 void org.xml.sax.ext.LexicalHandler.startCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startCDATA24540);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startCDATA24540);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA24541;
		 void org.xml.sax.ext.LexicalHandler.endCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endCDATA24541);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endCDATA24541);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity24542;
		 void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startEntity24542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startEntity24542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity24543;
		 void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endEntity24543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endEntity24543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD24544;
		 void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startDTD24544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._startDTD24544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD24545;
		 void org.xml.sax.ext.LexicalHandler.endDTD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endDTD24545);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._endDTD24545);
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl24546;
		 void org.xml.sax.DTDHandler.unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl24546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl24546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl24547;
		 void org.xml.sax.DTDHandler.notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._notationDecl24547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_.staticClass, global::javax.xml.transform.sax.TransformerHandler_._notationDecl24547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.TransformerHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/TransformerHandler"));
			global::javax.xml.transform.sax.TransformerHandler_._getSystemId24524 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.sax.TransformerHandler_._setResult24525 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setResult", "(Ljavax/xml/transform/Result;)V");
			global::javax.xml.transform.sax.TransformerHandler_._setSystemId24526 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._getTransformer24527 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getTransformer", "()Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.sax.TransformerHandler_._startElement24528 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.transform.sax.TransformerHandler_._characters24529 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "characters", "([CII)V");
			global::javax.xml.transform.sax.TransformerHandler_._endElement24530 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._startDocument24531 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDocument", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._endDocument24532 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDocument", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping24533 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace24534 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.transform.sax.TransformerHandler_._processingInstruction24535 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator24536 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.transform.sax.TransformerHandler_._skippedEntity24537 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping24538 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._comment24539 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "comment", "([CII)V");
			global::javax.xml.transform.sax.TransformerHandler_._startCDATA24540 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startCDATA", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._endCDATA24541 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endCDATA", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._startEntity24542 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._endEntity24543 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._startDTD24544 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._endDTD24545 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDTD", "()V");
			global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl24546 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TransformerHandler_._notationDecl24547 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
