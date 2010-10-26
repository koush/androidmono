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
		internal static global::MonoJavaBridge.MethodId _reset30831;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._reset30831);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._reset30831);
		}
		internal static global::MonoJavaBridge.MethodId _parse30832;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse30832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30833;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse30833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30834;
		public virtual global::org.w3c.dom.Document parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse30834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30835;
		public virtual global::org.w3c.dom.Document parse(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._parse30835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30836;
		public abstract global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0);
		internal static global::MonoJavaBridge.MethodId _setEntityResolver30837;
		public abstract void setEntityResolver(org.xml.sax.EntityResolver arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorHandler30838;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30839;
		public abstract bool isNamespaceAware();
		internal static global::MonoJavaBridge.MethodId _isValidating30840;
		public abstract bool isValidating();
		internal static global::MonoJavaBridge.MethodId _newDocument30841;
		public abstract global::org.w3c.dom.Document newDocument();
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation30842;
		public abstract global::org.w3c.dom.DOMImplementation getDOMImplementation();
		internal static global::MonoJavaBridge.MethodId _getSchema30843;
		public virtual global::javax.xml.validation.Schema getSchema() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._getSchema30843)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._getSchema30843)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware30844;
		public virtual bool isXIncludeAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder._isXIncludeAware30844);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._isXIncludeAware30844);
		}
		internal static global::MonoJavaBridge.MethodId _DocumentBuilder30845;
		protected DocumentBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._DocumentBuilder30845);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
			global::javax.xml.parsers.DocumentBuilder._reset30831 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "reset", "()V");
			global::javax.xml.parsers.DocumentBuilder._parse30832 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30833 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;Ljava/lang/String;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30834 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/lang/String;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30835 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/File;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30836 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._setEntityResolver30837 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::javax.xml.parsers.DocumentBuilder._setErrorHandler30838 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.parsers.DocumentBuilder._isNamespaceAware30839 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder._isValidating30840 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilder._newDocument30841 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "newDocument", "()Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._getDOMImplementation30842 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;");
			global::javax.xml.parsers.DocumentBuilder._getSchema30843 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.DocumentBuilder._isXIncludeAware30844 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder._DocumentBuilder30845 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.DocumentBuilder))]
	internal sealed partial class DocumentBuilder_ : javax.xml.parsers.DocumentBuilder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentBuilder_()
		{
			InitJNI();
		}
		internal DocumentBuilder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse30846;
		public override global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._parse30846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._parse30846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver30847;
		public override void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._setEntityResolver30847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._setEntityResolver30847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler30848;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._setErrorHandler30848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._setErrorHandler30848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30849;
		public override bool isNamespaceAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware30849);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware30849);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating30850;
		public override bool isValidating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._isValidating30850);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._isValidating30850);
		}
		internal static global::MonoJavaBridge.MethodId _newDocument30851;
		public override global::org.w3c.dom.Document newDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._newDocument30851)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._newDocument30851)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation30852;
		public override global::org.w3c.dom.DOMImplementation getDOMImplementation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation30852)) as org.w3c.dom.DOMImplementation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_.staticClass, global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation30852)) as org.w3c.dom.DOMImplementation;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
			global::javax.xml.parsers.DocumentBuilder_._parse30846 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder_._setEntityResolver30847 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::javax.xml.parsers.DocumentBuilder_._setErrorHandler30848 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware30849 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder_._isValidating30850 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilder_._newDocument30851 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "newDocument", "()Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation30852 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;");
		}
	}
}
