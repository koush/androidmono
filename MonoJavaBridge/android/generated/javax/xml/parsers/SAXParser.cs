namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.SAXParser_))]
	public abstract partial class SAXParser : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty30891;
		public abstract void setProperty(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getProperty30892;
		public abstract global::java.lang.Object getProperty(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _reset30893;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._reset30893);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._reset30893);
		}
		internal static global::MonoJavaBridge.MethodId _parse30894;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.helpers.DefaultHandler arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _parse30895;
		public virtual void parse(java.lang.String arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse30896;
		public virtual void parse(java.lang.String arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse30897;
		public virtual void parse(java.io.File arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse30898;
		public virtual void parse(java.io.File arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse30899;
		public virtual void parse(org.xml.sax.InputSource arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse30900;
		public virtual void parse(org.xml.sax.InputSource arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse30901;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.HandlerBase arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse30902;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.HandlerBase arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _parse30903;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.helpers.DefaultHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse30903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse30903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30904;
		public abstract bool isNamespaceAware();
		internal static global::MonoJavaBridge.MethodId _isValidating30905;
		public abstract bool isValidating();
		internal static global::MonoJavaBridge.MethodId _getSchema30906;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._getSchema30906)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._getSchema30906)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware30907;
		public virtual bool isXIncludeAware()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._isXIncludeAware30907);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._isXIncludeAware30907);
		}
		internal static global::MonoJavaBridge.MethodId _getParser30908;
		public abstract global::org.xml.sax.Parser getParser();
		internal static global::MonoJavaBridge.MethodId _getXMLReader30909;
		public abstract global::org.xml.sax.XMLReader getXMLReader();
		internal static global::MonoJavaBridge.MethodId _SAXParser30910;
		protected SAXParser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._SAXParser30910);
			Init(@__env, handle);
		}
		static SAXParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParser"));
			global::javax.xml.parsers.SAXParser._setProperty30891 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.SAXParser._getProperty30892 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.SAXParser._reset30893 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "reset", "()V");
			global::javax.xml.parsers.SAXParser._parse30894 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;Ljava/lang/String;)V");
			global::javax.xml.parsers.SAXParser._parse30895 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse30896 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._parse30897 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/File;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse30898 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/File;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._parse30899 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._parse30900 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse30901 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse30902 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;Ljava/lang/String;)V");
			global::javax.xml.parsers.SAXParser._parse30903 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._isNamespaceAware30904 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.SAXParser._isValidating30905 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.SAXParser._getSchema30906 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.SAXParser._isXIncludeAware30907 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.SAXParser._getParser30908 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getParser", "()Lorg/xml/sax/Parser;");
			global::javax.xml.parsers.SAXParser._getXMLReader30909 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getXMLReader", "()Lorg/xml/sax/XMLReader;");
			global::javax.xml.parsers.SAXParser._SAXParser30910 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _setProperty30911;
		public override void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._setProperty30911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._setProperty30911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty30912;
		public override global::java.lang.Object getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._getProperty30912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._getProperty30912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30913;
		public override bool isNamespaceAware()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._isNamespaceAware30913);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._isNamespaceAware30913);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating30914;
		public override bool isValidating()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._isValidating30914);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._isValidating30914);
		}
		internal static global::MonoJavaBridge.MethodId _getParser30915;
		public override global::org.xml.sax.Parser getParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._getParser30915)) as org.xml.sax.Parser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._getParser30915)) as org.xml.sax.Parser;
		}
		internal static global::MonoJavaBridge.MethodId _getXMLReader30916;
		public override global::org.xml.sax.XMLReader getXMLReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._getXMLReader30916)) as org.xml.sax.XMLReader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._getXMLReader30916)) as org.xml.sax.XMLReader;
		}
		static SAXParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParser"));
			global::javax.xml.parsers.SAXParser_._setProperty30911 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.SAXParser_._getProperty30912 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.SAXParser_._isNamespaceAware30913 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.SAXParser_._isValidating30914 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.SAXParser_._getParser30915 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "getParser", "()Lorg/xml/sax/Parser;");
			global::javax.xml.parsers.SAXParser_._getXMLReader30916 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "getXMLReader", "()Lorg/xml/sax/XMLReader;");
		}
		internal static void InitJNI()
		{
		}
	}
}
