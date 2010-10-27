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
		static TemplatesHandler_()
		{
			InitJNI();
		}
		internal TemplatesHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId31111;
		global::java.lang.String javax.xml.transform.sax.TemplatesHandler.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._getSystemId31111)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._getSystemId31111)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31112;
		void javax.xml.transform.sax.TemplatesHandler.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._setSystemId31112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._setSystemId31112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTemplates31113;
		global::javax.xml.transform.Templates javax.xml.transform.sax.TemplatesHandler.getTemplates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._getTemplates31113)) as javax.xml.transform.Templates;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._getTemplates31113)) as javax.xml.transform.Templates;
		}
		internal static global::MonoJavaBridge.MethodId _startElement31114;
		void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._startElement31114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._startElement31114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters31115;
		void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._characters31115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._characters31115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement31116;
		void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._endElement31116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._endElement31116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument31117;
		void org.xml.sax.ContentHandler.startDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._startDocument31117);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._startDocument31117);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument31118;
		void org.xml.sax.ContentHandler.endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._endDocument31118);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._endDocument31118);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping31119;
		void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._startPrefixMapping31119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._startPrefixMapping31119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace31120;
		void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._ignorableWhitespace31120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._ignorableWhitespace31120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction31121;
		void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._processingInstruction31121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._processingInstruction31121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator31122;
		void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._setDocumentLocator31122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._setDocumentLocator31122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity31123;
		void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._skippedEntity31123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._skippedEntity31123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping31124;
		void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_._endPrefixMapping31124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.TemplatesHandler_.staticClass, global::javax.xml.transform.sax.TemplatesHandler_._endPrefixMapping31124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.TemplatesHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/TemplatesHandler"));
			global::javax.xml.transform.sax.TemplatesHandler_._getSystemId31111 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.sax.TemplatesHandler_._setSystemId31112 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._getTemplates31113 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "getTemplates", "()Ljavax/xml/transform/Templates;");
			global::javax.xml.transform.sax.TemplatesHandler_._startElement31114 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._characters31115 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "characters", "([CII)V");
			global::javax.xml.transform.sax.TemplatesHandler_._endElement31116 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._startDocument31117 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startDocument", "()V");
			global::javax.xml.transform.sax.TemplatesHandler_._endDocument31118 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endDocument", "()V");
			global::javax.xml.transform.sax.TemplatesHandler_._startPrefixMapping31119 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._ignorableWhitespace31120 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::javax.xml.transform.sax.TemplatesHandler_._processingInstruction31121 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._setDocumentLocator31122 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._skippedEntity31123 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.TemplatesHandler_._endPrefixMapping31124 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.TemplatesHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
		}
	}
}
