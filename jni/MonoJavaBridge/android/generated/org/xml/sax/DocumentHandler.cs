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
		internal static global::MonoJavaBridge.MethodId _startElement34856;
		 void org.xml.sax.DocumentHandler.startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._startElement34856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._startElement34856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _characters34857;
		 void org.xml.sax.DocumentHandler.characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._characters34857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._characters34857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement34858;
		 void org.xml.sax.DocumentHandler.endElement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._endElement34858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._endElement34858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument34859;
		 void org.xml.sax.DocumentHandler.startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._startDocument34859);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._startDocument34859);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument34860;
		 void org.xml.sax.DocumentHandler.endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._endDocument34860);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._endDocument34860);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace34861;
		 void org.xml.sax.DocumentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._ignorableWhitespace34861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._ignorableWhitespace34861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction34862;
		 void org.xml.sax.DocumentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._processingInstruction34862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._processingInstruction34862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator34863;
		 void org.xml.sax.DocumentHandler.setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_._setDocumentLocator34863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DocumentHandler_.staticClass, global::org.xml.sax.DocumentHandler_._setDocumentLocator34863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.DocumentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/DocumentHandler"));
			global::org.xml.sax.DocumentHandler_._startElement34856 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.DocumentHandler_._characters34857 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "characters", "([CII)V");
			global::org.xml.sax.DocumentHandler_._endElement34858 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "endElement", "(Ljava/lang/String;)V");
			global::org.xml.sax.DocumentHandler_._startDocument34859 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "startDocument", "()V");
			global::org.xml.sax.DocumentHandler_._endDocument34860 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "endDocument", "()V");
			global::org.xml.sax.DocumentHandler_._ignorableWhitespace34861 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.DocumentHandler_._processingInstruction34862 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.DocumentHandler_._setDocumentLocator34863 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DocumentHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
		}
	}
}
