namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.DocumentHandler_))]
	public interface DocumentHandler  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class DocumentHandler_ : java.lang.Object, DocumentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentHandler_()
		{
			InitJNI();
		}
		internal DocumentHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement28105;
		 void org.xml.sax.DocumentHandler.startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._startElement28105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._startElement28105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _characters28106;
		 void org.xml.sax.DocumentHandler.characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._characters28106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._characters28106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement28107;
		 void org.xml.sax.DocumentHandler.endElement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._endElement28107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._endElement28107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument28108;
		 void org.xml.sax.DocumentHandler.startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._startDocument28108);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._startDocument28108);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument28109;
		 void org.xml.sax.DocumentHandler.endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._endDocument28109);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._endDocument28109);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace28110;
		 void org.xml.sax.DocumentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._ignorableWhitespace28110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._ignorableWhitespace28110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction28111;
		 void org.xml.sax.DocumentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._processingInstruction28111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._processingInstruction28111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator28112;
		 void org.xml.sax.DocumentHandler.setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._setDocumentLocator28112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._setDocumentLocator28112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.DocumentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/DocumentHandler"));
			global::org.xml.sax.DocumentHandler_._startElement28105 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.DocumentHandler_._characters28106 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "characters", "([CII)V");
			global::org.xml.sax.DocumentHandler_._endElement28107 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "endElement", "(Ljava/lang/String;)V");
			global::org.xml.sax.DocumentHandler_._startDocument28108 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "startDocument", "()V");
			global::org.xml.sax.DocumentHandler_._endDocument28109 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "endDocument", "()V");
			global::org.xml.sax.DocumentHandler_._ignorableWhitespace28110 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.DocumentHandler_._processingInstruction28111 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.DocumentHandler_._setDocumentLocator28112 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
		}
	}
}
