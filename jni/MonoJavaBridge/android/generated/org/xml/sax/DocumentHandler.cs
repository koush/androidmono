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
		static DocumentHandler_()
		{
			InitJNI();
		}
		internal DocumentHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement34974;
		void org.xml.sax.DocumentHandler.startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._startElement34974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._startElement34974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _characters34975;
		void org.xml.sax.DocumentHandler.characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._characters34975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._characters34975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement34976;
		void org.xml.sax.DocumentHandler.endElement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._endElement34976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._endElement34976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument34977;
		void org.xml.sax.DocumentHandler.startDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._startDocument34977);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._startDocument34977);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument34978;
		void org.xml.sax.DocumentHandler.endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._endDocument34978);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._endDocument34978);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace34979;
		void org.xml.sax.DocumentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._ignorableWhitespace34979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._ignorableWhitespace34979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction34980;
		void org.xml.sax.DocumentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._processingInstruction34980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._processingInstruction34980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator34981;
		void org.xml.sax.DocumentHandler.setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._setDocumentLocator34981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._setDocumentLocator34981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.DocumentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/DocumentHandler"));
			global::org.xml.sax.DocumentHandler_._startElement34974 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.DocumentHandler_._characters34975 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "characters", "([CII)V");
			global::org.xml.sax.DocumentHandler_._endElement34976 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "endElement", "(Ljava/lang/String;)V");
			global::org.xml.sax.DocumentHandler_._startDocument34977 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "startDocument", "()V");
			global::org.xml.sax.DocumentHandler_._endDocument34978 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "endDocument", "()V");
			global::org.xml.sax.DocumentHandler_._ignorableWhitespace34979 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.DocumentHandler_._processingInstruction34980 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.DocumentHandler_._setDocumentLocator34981 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
		}
	}
}
