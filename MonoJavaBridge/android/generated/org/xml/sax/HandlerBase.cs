namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HandlerBase : java.lang.Object, EntityResolver, DTDHandler, DocumentHandler, ErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HandlerBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void fatalError(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V", ref global::org.xml.sax.HandlerBase._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void error(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V", ref global::org.xml.sax.HandlerBase._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void warning(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V", ref global::org.xml.sax.HandlerBase._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", ref global::org.xml.sax.HandlerBase._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "characters", "([CII)V", ref global::org.xml.sax.HandlerBase._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void endElement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "endElement", "(Ljava/lang/String;)V", ref global::org.xml.sax.HandlerBase._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void startDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "startDocument", "()V", ref global::org.xml.sax.HandlerBase._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "endDocument", "()V", ref global::org.xml.sax.HandlerBase._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "ignorableWhitespace", "([CII)V", ref global::org.xml.sax.HandlerBase._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.HandlerBase._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.Locator DocumentLocator
		{
			set
			{
				setDocumentLocator(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", ref global::org.xml.sax.HandlerBase._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.HandlerBase._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.HandlerBase.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.HandlerBase._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.HandlerBase.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.HandlerBase._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xml.sax.InputSource;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public HandlerBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.HandlerBase._m14.native == global::System.IntPtr.Zero)
				global::org.xml.sax.HandlerBase._m14 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._m14);
			Init(@__env, handle);
		}
		static HandlerBase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.HandlerBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/HandlerBase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
