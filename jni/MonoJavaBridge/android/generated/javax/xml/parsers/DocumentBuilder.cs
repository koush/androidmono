namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.DocumentBuilder_))]
	public abstract partial class DocumentBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentBuilder()
		{
			InitJNI();
		}
		protected DocumentBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset24248;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._reset24248);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._reset24248);
		}
		internal static global::MonoJavaBridge.MethodId _parse24249;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse24249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse24249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse24250;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse24250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse24250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse24251;
		public virtual global::org.w3c.dom.Document parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse24251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse24251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse24252;
		public virtual global::org.w3c.dom.Document parse(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse24252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse24252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse24253;
		public abstract global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0);
		internal static global::MonoJavaBridge.MethodId _setEntityResolver24254;
		public abstract void setEntityResolver(org.xml.sax.EntityResolver arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24255;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware24256;
		public abstract bool isNamespaceAware();
		internal static global::MonoJavaBridge.MethodId _isValidating24257;
		public abstract bool isValidating();
		internal static global::MonoJavaBridge.MethodId _newDocument24258;
		public abstract global::org.w3c.dom.Document newDocument();
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation24259;
		public abstract global::org.w3c.dom.DOMImplementation getDOMImplementation();
		internal static global::MonoJavaBridge.MethodId _getSchema24260;
		public virtual global::javax.xml.validation.Schema getSchema() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._getSchema24260)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._getSchema24260)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware24261;
		public virtual bool isXIncludeAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._isXIncludeAware24261);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._isXIncludeAware24261);
		}
		internal static global::MonoJavaBridge.MethodId _DocumentBuilder24262;
		protected DocumentBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._DocumentBuilder24262);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
			global::javax.xml.parsers.DocumentBuilder._reset24248 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "reset", "()V");
			global::javax.xml.parsers.DocumentBuilder._parse24249 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse24250 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;Ljava/lang/String;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse24251 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/lang/String;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse24252 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/File;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse24253 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._setEntityResolver24254 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::javax.xml.parsers.DocumentBuilder._setErrorHandler24255 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.parsers.DocumentBuilder._isNamespaceAware24256 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder._isValidating24257 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilder._newDocument24258 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "newDocument", "()Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._getDOMImplementation24259 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;");
			global::javax.xml.parsers.DocumentBuilder._getSchema24260 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.DocumentBuilder._isXIncludeAware24261 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder._DocumentBuilder24262 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.DocumentBuilder))]
	public sealed partial class DocumentBuilder_ : javax.xml.parsers.DocumentBuilder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentBuilder_()
		{
			InitJNI();
		}
		internal DocumentBuilder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse24263;
		public override global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._parse24263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._parse24263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver24264;
		public override void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._setEntityResolver24264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._setEntityResolver24264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24265;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._setErrorHandler24265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._setErrorHandler24265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware24266;
		public override bool isNamespaceAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware24266);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware24266);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating24267;
		public override bool isValidating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._isValidating24267);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._isValidating24267);
		}
		internal static global::MonoJavaBridge.MethodId _newDocument24268;
		public override global::org.w3c.dom.Document newDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._newDocument24268)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._newDocument24268)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation24269;
		public override global::org.w3c.dom.DOMImplementation getDOMImplementation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation24269)) as org.w3c.dom.DOMImplementation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation24269)) as org.w3c.dom.DOMImplementation;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
			global::javax.xml.parsers.DocumentBuilder_._parse24263 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder_._setEntityResolver24264 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::javax.xml.parsers.DocumentBuilder_._setErrorHandler24265 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware24266 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder_._isValidating24267 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilder_._newDocument24268 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "newDocument", "()Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation24269 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;");
		}
	}
}
