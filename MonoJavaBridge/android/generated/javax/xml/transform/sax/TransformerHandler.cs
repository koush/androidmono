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
		internal static global::MonoJavaBridge.MethodId _getSystemId31126;
		global::java.lang.String javax.xml.transform.sax.TransformerHandler.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._getSystemId31126.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._getSystemId31126 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._getSystemId31126)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setResult31127;
		void javax.xml.transform.sax.TransformerHandler.setResult(javax.xml.transform.Result arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._setResult31127.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._setResult31127 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setResult", "(Ljavax/xml/transform/Result;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setResult31127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31128;
		void javax.xml.transform.sax.TransformerHandler.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._setSystemId31128.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._setSystemId31128 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setSystemId31128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformer31129;
		global::javax.xml.transform.Transformer javax.xml.transform.sax.TransformerHandler.getTransformer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._getTransformer31129.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._getTransformer31129 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "getTransformer", "()Ljavax/xml/transform/Transformer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._getTransformer31129)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _startElement31130;
		void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._startElement31130.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._startElement31130 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startElement31130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters31131;
		void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._characters31131.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._characters31131 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "characters", "([CII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._characters31131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement31132;
		void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._endElement31132.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._endElement31132 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endElement31132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument31133;
		void org.xml.sax.ContentHandler.startDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._startDocument31133.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._startDocument31133 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDocument", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startDocument31133);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument31134;
		void org.xml.sax.ContentHandler.endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._endDocument31134.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._endDocument31134 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDocument", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endDocument31134);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31135;
		void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping31135.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping31135 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startPrefixMapping31135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31136;
		void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace31136.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace31136 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._ignorableWhitespace31136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction31137;
		void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._processingInstruction31137.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._processingInstruction31137 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._processingInstruction31137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31138;
		void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator31138.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator31138 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._setDocumentLocator31138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity31139;
		void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._skippedEntity31139.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._skippedEntity31139 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._skippedEntity31139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31140;
		void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping31140.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping31140 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endPrefixMapping31140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comment31141;
		void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._comment31141.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._comment31141 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "comment", "([CII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._comment31141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA31142;
		void org.xml.sax.ext.LexicalHandler.startCDATA()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._startCDATA31142.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._startCDATA31142 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startCDATA", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startCDATA31142);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA31143;
		void org.xml.sax.ext.LexicalHandler.endCDATA()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._endCDATA31143.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._endCDATA31143 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endCDATA", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endCDATA31143);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity31144;
		void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._startEntity31144.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._startEntity31144 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startEntity31144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity31145;
		void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._endEntity31145.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._endEntity31145 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endEntity31145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD31146;
		void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._startDTD31146.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._startDTD31146 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._startDTD31146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD31147;
		void org.xml.sax.ext.LexicalHandler.endDTD()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._endDTD31147.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._endDTD31147 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "endDTD", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._endDTD31147);
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl31148;
		void org.xml.sax.DTDHandler.unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl31148.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl31148 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._unparsedEntityDecl31148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl31149;
		void org.xml.sax.DTDHandler.notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.TransformerHandler_._notationDecl31149.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.TransformerHandler_._notationDecl31149 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TransformerHandler_.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TransformerHandler_._notationDecl31149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
