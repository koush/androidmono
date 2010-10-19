namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.sax.TemplatesHandler_))]
	public interface TemplatesHandler : org.xml.sax.ContentHandler
	{
		global::java.lang.String getSystemId();
		void setSystemId(java.lang.String arg0);
		global::javax.xml.transform.Templates getTemplates();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.sax.TemplatesHandler))]
	public sealed partial class TemplatesHandler_ : java.lang.Object, TemplatesHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TemplatesHandler_()
		{
			InitJNI();
		}
		internal TemplatesHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId24510;
		 global::java.lang.String javax.xml.transform.sax.TemplatesHandler.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._getSystemId24510)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._getSystemId24510)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId24511;
		 void javax.xml.transform.sax.TemplatesHandler.setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._setSystemId24511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._setSystemId24511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTemplates24512;
		 global::javax.xml.transform.Templates javax.xml.transform.sax.TemplatesHandler.getTemplates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._getTemplates24512)) as javax.xml.transform.Templates;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._getTemplates24512)) as javax.xml.transform.Templates;
		}
		internal static global::MonoJavaBridge.MethodId _startElement24513;
		 void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._startElement24513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._startElement24513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters24514;
		 void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._characters24514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._characters24514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement24515;
		 void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._endElement24515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._endElement24515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument24516;
		 void org.xml.sax.ContentHandler.startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._startDocument24516);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._startDocument24516);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument24517;
		 void org.xml.sax.ContentHandler.endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._endDocument24517);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._endDocument24517);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping24518;
		 void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._startPrefixMapping24518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._startPrefixMapping24518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace24519;
		 void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._ignorableWhitespace24519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._ignorableWhitespace24519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction24520;
		 void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._processingInstruction24520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._processingInstruction24520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator24521;
		 void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._setDocumentLocator24521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._setDocumentLocator24521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity24522;
		 void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._skippedEntity24522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._skippedEntity24522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping24523;
		 void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._endPrefixMapping24523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._endPrefixMapping24523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.TemplatesHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/TemplatesHandler"));
			global::javax.xml.transform.sax.TemplatesHandler_._getSystemId24510 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.sax.TemplatesHandler_._setSystemId24511 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._getTemplates24512 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "getTemplates", "()Ljavax/xml/transform/Templates;");
			global::javax.xml.transform.sax.TemplatesHandler_._startElement24513 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._characters24514 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "characters", "([CII)V");
			global::javax.xml.transform.sax.TemplatesHandler_._endElement24515 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._startDocument24516 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startDocument", "()V");
			global::javax.xml.transform.sax.TemplatesHandler_._endDocument24517 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endDocument", "()V");
			global::javax.xml.transform.sax.TemplatesHandler_._startPrefixMapping24518 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._ignorableWhitespace24519 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.transform.sax.TemplatesHandler_._processingInstruction24520 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._setDocumentLocator24521 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._skippedEntity24522 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._endPrefixMapping24523 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
		}
	}
}
