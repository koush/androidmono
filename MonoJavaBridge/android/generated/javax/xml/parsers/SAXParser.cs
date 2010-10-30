namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.SAXParser_))]
	public abstract partial class SAXParser : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void setProperty(java.lang.String arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.Object getProperty(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "reset", "()V", ref global::javax.xml.parsers.SAXParser._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.helpers.DefaultHandler arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;Ljava/lang/String;)V", ref global::javax.xml.parsers.SAXParser._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void parse(java.lang.String arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/HandlerBase;)V", ref global::javax.xml.parsers.SAXParser._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void parse(java.lang.String arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/helpers/DefaultHandler;)V", ref global::javax.xml.parsers.SAXParser._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void parse(java.io.File arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/File;Lorg/xml/sax/HandlerBase;)V", ref global::javax.xml.parsers.SAXParser._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void parse(java.io.File arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/File;Lorg/xml/sax/helpers/DefaultHandler;)V", ref global::javax.xml.parsers.SAXParser._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void parse(org.xml.sax.InputSource arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/helpers/DefaultHandler;)V", ref global::javax.xml.parsers.SAXParser._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void parse(org.xml.sax.InputSource arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/HandlerBase;)V", ref global::javax.xml.parsers.SAXParser._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;)V", ref global::javax.xml.parsers.SAXParser._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.HandlerBase arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;Ljava/lang/String;)V", ref global::javax.xml.parsers.SAXParser._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;)V", ref global::javax.xml.parsers.SAXParser._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract bool isNamespaceAware();
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool isValidating();
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;", ref global::javax.xml.parsers.SAXParser._m15) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool isXIncludeAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParser.staticClass, "isXIncludeAware", "()Z", ref global::javax.xml.parsers.SAXParser._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract global::org.xml.sax.Parser getParser();
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::org.xml.sax.XMLReader getXMLReader();
		private static global::MonoJavaBridge.MethodId _m19;
		protected SAXParser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.SAXParser._m19.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.SAXParser._m19 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._m19);
			Init(@__env, handle);
		}
		static SAXParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParser"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.SAXParser))]
	internal sealed partial class SAXParser_ : javax.xml.parsers.SAXParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SAXParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.parsers.SAXParser_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.SAXParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.parsers.SAXParser_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParser_.staticClass, "isNamespaceAware", "()Z", ref global::javax.xml.parsers.SAXParser_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParser_.staticClass, "isValidating", "()Z", ref global::javax.xml.parsers.SAXParser_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::org.xml.sax.Parser getParser()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.Parser>(this, global::javax.xml.parsers.SAXParser_.staticClass, "getParser", "()Lorg/xml/sax/Parser;", ref global::javax.xml.parsers.SAXParser_._m4) as org.xml.sax.Parser;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::org.xml.sax.XMLReader getXMLReader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLReader>(this, global::javax.xml.parsers.SAXParser_.staticClass, "getXMLReader", "()Lorg/xml/sax/XMLReader;", ref global::javax.xml.parsers.SAXParser_._m5) as org.xml.sax.XMLReader;
		}
		static SAXParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
