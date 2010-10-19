namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HandlerBase : java.lang.Object, EntityResolver, DTDHandler, DocumentHandler, ErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HandlerBase()
		{
			InitJNI();
		}
		protected HandlerBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fatalError28117;
		public virtual void fatalError(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._fatalError28117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._fatalError28117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error28118;
		public virtual void error(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._error28118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._error28118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning28119;
		public virtual void warning(org.xml.sax.SAXParseException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._warning28119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._warning28119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startElement28120;
		public virtual void startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._startElement28120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._startElement28120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _characters28121;
		public virtual void characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._characters28121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._characters28121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement28122;
		public virtual void endElement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._endElement28122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._endElement28122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument28123;
		public virtual void startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._startDocument28123);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._startDocument28123);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument28124;
		public virtual void endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._endDocument28124);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._endDocument28124);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace28125;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._ignorableWhitespace28125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._ignorableWhitespace28125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction28126;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._processingInstruction28126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._processingInstruction28126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator28127;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._setDocumentLocator28127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._setDocumentLocator28127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl28128;
		public virtual void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._unparsedEntityDecl28128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._unparsedEntityDecl28128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl28129;
		public virtual void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._notationDecl28129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._notationDecl28129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity28130;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._resolveEntity28130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._resolveEntity28130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _HandlerBase28131;
		public HandlerBase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._HandlerBase28131);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.HandlerBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/HandlerBase"));
			global::org.xml.sax.HandlerBase._fatalError28117 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.HandlerBase._error28118 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.HandlerBase._warning28119 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.HandlerBase._startElement28120 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.HandlerBase._characters28121 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "characters", "([CII)V");
			global::org.xml.sax.HandlerBase._endElement28122 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "endElement", "(Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._startDocument28123 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "startDocument", "()V");
			global::org.xml.sax.HandlerBase._endDocument28124 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "endDocument", "()V");
			global::org.xml.sax.HandlerBase._ignorableWhitespace28125 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.HandlerBase._processingInstruction28126 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._setDocumentLocator28127 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.HandlerBase._unparsedEntityDecl28128 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._notationDecl28129 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._resolveEntity28130 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.HandlerBase._HandlerBase28131 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "<init>", "()V");
		}
	}
}
