namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.SAXParser_))]
	public abstract partial class SAXParser : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXParser()
		{
			InitJNI();
		}
		protected SAXParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty24307;
		public abstract void setProperty(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getProperty24308;
		public abstract global::java.lang.Object getProperty(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _reset24309;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._reset24309);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._reset24309);
		}
		internal static global::MonoJavaBridge.MethodId _parse24310;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.helpers.DefaultHandler arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _parse24311;
		public virtual void parse(java.lang.String arg0, org.xml.sax.HandlerBase arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse24312;
		public virtual void parse(java.lang.String arg0, org.xml.sax.helpers.DefaultHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse24313;
		public virtual void parse(java.io.File arg0, org.xml.sax.HandlerBase arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse24314;
		public virtual void parse(java.io.File arg0, org.xml.sax.helpers.DefaultHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse24315;
		public virtual void parse(org.xml.sax.InputSource arg0, org.xml.sax.helpers.DefaultHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse24316;
		public virtual void parse(org.xml.sax.InputSource arg0, org.xml.sax.HandlerBase arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse24317;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.HandlerBase arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse24318;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.HandlerBase arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _parse24319;
		public virtual void parse(java.io.InputStream arg0, org.xml.sax.helpers.DefaultHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._parse24319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._parse24319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware24320;
		public abstract bool isNamespaceAware();
		internal static global::MonoJavaBridge.MethodId _isValidating24321;
		public abstract bool isValidating();
		internal static global::MonoJavaBridge.MethodId _getSchema24322;
		public virtual global::javax.xml.validation.Schema getSchema() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._getSchema24322)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._getSchema24322)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware24323;
		public virtual bool isXIncludeAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser._isXIncludeAware24323);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._isXIncludeAware24323);
		}
		internal static global::MonoJavaBridge.MethodId _getParser24324;
		public abstract global::org.xml.sax.Parser getParser();
		internal static global::MonoJavaBridge.MethodId _getXMLReader24325;
		public abstract global::org.xml.sax.XMLReader getXMLReader();
		internal static global::MonoJavaBridge.MethodId _SAXParser24326;
		protected SAXParser()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.SAXParser.staticClass, global::javax.xml.parsers.SAXParser._SAXParser24326);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParser"));
			global::javax.xml.parsers.SAXParser._setProperty24307 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.SAXParser._getProperty24308 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.SAXParser._reset24309 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "reset", "()V");
			global::javax.xml.parsers.SAXParser._parse24310 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;Ljava/lang/String;)V");
			global::javax.xml.parsers.SAXParser._parse24311 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse24312 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._parse24313 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/File;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse24314 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/File;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._parse24315 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._parse24316 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse24317 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;)V");
			global::javax.xml.parsers.SAXParser._parse24318 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;Ljava/lang/String;)V");
			global::javax.xml.parsers.SAXParser._parse24319 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;)V");
			global::javax.xml.parsers.SAXParser._isNamespaceAware24320 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.SAXParser._isValidating24321 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.SAXParser._getSchema24322 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.SAXParser._isXIncludeAware24323 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.SAXParser._getParser24324 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getParser", "()Lorg/xml/sax/Parser;");
			global::javax.xml.parsers.SAXParser._getXMLReader24325 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "getXMLReader", "()Lorg/xml/sax/XMLReader;");
			global::javax.xml.parsers.SAXParser._SAXParser24326 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.SAXParser))]
	public sealed partial class SAXParser_ : javax.xml.parsers.SAXParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXParser_()
		{
			InitJNI();
		}
		internal SAXParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty24327;
		public override void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._setProperty24327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._setProperty24327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty24328;
		public override global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._getProperty24328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._getProperty24328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware24329;
		public override bool isNamespaceAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._isNamespaceAware24329);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._isNamespaceAware24329);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating24330;
		public override bool isValidating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._isValidating24330);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._isValidating24330);
		}
		internal static global::MonoJavaBridge.MethodId _getParser24331;
		public override global::org.xml.sax.Parser getParser() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._getParser24331)) as org.xml.sax.Parser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._getParser24331)) as org.xml.sax.Parser;
		}
		internal static global::MonoJavaBridge.MethodId _getXMLReader24332;
		public override global::org.xml.sax.XMLReader getXMLReader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_._getXMLReader24332)) as org.xml.sax.XMLReader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParser_.staticClass, global::javax.xml.parsers.SAXParser_._getXMLReader24332)) as org.xml.sax.XMLReader;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParser"));
			global::javax.xml.parsers.SAXParser_._setProperty24327 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.SAXParser_._getProperty24328 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.SAXParser_._isNamespaceAware24329 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.SAXParser_._isValidating24330 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.SAXParser_._getParser24331 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "getParser", "()Lorg/xml/sax/Parser;");
			global::javax.xml.parsers.SAXParser_._getXMLReader24332 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParser_.staticClass, "getXMLReader", "()Lorg/xml/sax/XMLReader;");
		}
	}
}
