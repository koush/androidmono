namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.DocumentBuilder_))]
	public abstract partial class DocumentBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DocumentBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, "reset", "()V", ref global::javax.xml.parsers.DocumentBuilder._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;)Lorg/w3c/dom/Document;", ref global::javax.xml.parsers.DocumentBuilder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;Ljava/lang/String;)Lorg/w3c/dom/Document;", ref global::javax.xml.parsers.DocumentBuilder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.w3c.dom.Document parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", ref global::javax.xml.parsers.DocumentBuilder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.w3c.dom.Document parse(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/File;)Lorg/w3c/dom/Document;", ref global::javax.xml.parsers.DocumentBuilder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void setEntityResolver(org.xml.sax.EntityResolver arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract bool isNamespaceAware();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract bool isValidating();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::org.w3c.dom.Document newDocument();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::org.w3c.dom.DOMImplementation getDOMImplementation();
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;", ref global::javax.xml.parsers.DocumentBuilder._m12) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isXIncludeAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, "isXIncludeAware", "()Z", ref global::javax.xml.parsers.DocumentBuilder._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected DocumentBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.DocumentBuilder._m14.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.DocumentBuilder._m14 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._m14);
			Init(@__env, handle);
		}
		static DocumentBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.DocumentBuilder))]
	internal sealed partial class DocumentBuilder_ : javax.xml.parsers.DocumentBuilder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DocumentBuilder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::javax.xml.parsers.DocumentBuilder_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;", ref global::javax.xml.parsers.DocumentBuilder_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilder_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", ref global::javax.xml.parsers.DocumentBuilder_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilder_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::javax.xml.parsers.DocumentBuilder_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilder_.staticClass, "isNamespaceAware", "()Z", ref global::javax.xml.parsers.DocumentBuilder_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilder_.staticClass, "isValidating", "()Z", ref global::javax.xml.parsers.DocumentBuilder_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::org.w3c.dom.Document newDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::javax.xml.parsers.DocumentBuilder_.staticClass, "newDocument", "()Lorg/w3c/dom/Document;", ref global::javax.xml.parsers.DocumentBuilder_._m5) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::org.w3c.dom.DOMImplementation getDOMImplementation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMImplementation>(this, global::javax.xml.parsers.DocumentBuilder_.staticClass, "getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;", ref global::javax.xml.parsers.DocumentBuilder_._m6) as org.w3c.dom.DOMImplementation;
		}
		static DocumentBuilder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
