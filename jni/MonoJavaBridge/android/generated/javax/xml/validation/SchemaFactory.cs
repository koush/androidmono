namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.SchemaFactory_))]
	public abstract partial class SchemaFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SchemaFactory()
		{
			InitJNI();
		}
		protected SchemaFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty31066;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._setProperty31066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._setProperty31066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty31067;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._getProperty31067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._getProperty31067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31068;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newInstance31068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.validation.SchemaFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31069;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newInstance31069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.SchemaFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31070;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._setFeature31070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._setFeature31070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31071;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._getFeature31071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._getFeature31071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31072;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31073;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31074;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31075;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _isSchemaLanguageSupported31076;
		public abstract bool isSchemaLanguageSupported(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newSchema31077;
		public virtual global::javax.xml.validation.Schema newSchema(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._newSchema31077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newSchema31077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31078;
		public virtual global::javax.xml.validation.Schema newSchema(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._newSchema31078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newSchema31078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31079;
		public abstract global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0);
		internal static global::MonoJavaBridge.MethodId _newSchema31080;
		public abstract global::javax.xml.validation.Schema newSchema();
		internal static global::MonoJavaBridge.MethodId _newSchema31081;
		public virtual global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._newSchema31081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newSchema31081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _SchemaFactory31082;
		protected SchemaFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._SchemaFactory31082);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
			global::javax.xml.validation.SchemaFactory._setProperty31066 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.validation.SchemaFactory._getProperty31067 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.validation.SchemaFactory._newInstance31068 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/validation/SchemaFactory;");
			global::javax.xml.validation.SchemaFactory._newInstance31069 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;");
			global::javax.xml.validation.SchemaFactory._setFeature31070 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.validation.SchemaFactory._getFeature31071 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.SchemaFactory._setErrorHandler31072 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.SchemaFactory._getErrorHandler31073 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.SchemaFactory._setResourceResolver31074 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.SchemaFactory._getResourceResolver31075 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.SchemaFactory._isSchemaLanguageSupported31076 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "isSchemaLanguageSupported", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.SchemaFactory._newSchema31077 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema31078 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema31079 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema31080 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema31081 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._SchemaFactory31082 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.SchemaFactory))]
	public sealed partial class SchemaFactory_ : javax.xml.validation.SchemaFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SchemaFactory_()
		{
			InitJNI();
		}
		internal SchemaFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31083;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._setErrorHandler31083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._setErrorHandler31083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31084;
		public override global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._getErrorHandler31084)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._getErrorHandler31084)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31085;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._setResourceResolver31085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._setResourceResolver31085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31086;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._getResourceResolver31086)) as org.w3c.dom.ls.LSResourceResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._getResourceResolver31086)) as org.w3c.dom.ls.LSResourceResolver;
		}
		internal static global::MonoJavaBridge.MethodId _isSchemaLanguageSupported31087;
		public override bool isSchemaLanguageSupported(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._isSchemaLanguageSupported31087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._isSchemaLanguageSupported31087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31088;
		public override global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._newSchema31088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._newSchema31088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31089;
		public override global::javax.xml.validation.Schema newSchema() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._newSchema31089)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._newSchema31089)) as javax.xml.validation.Schema;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
			global::javax.xml.validation.SchemaFactory_._setErrorHandler31083 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.SchemaFactory_._getErrorHandler31084 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.SchemaFactory_._setResourceResolver31085 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.SchemaFactory_._getResourceResolver31086 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.SchemaFactory_._isSchemaLanguageSupported31087 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "isSchemaLanguageSupported", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.SchemaFactory_._newSchema31088 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory_._newSchema31089 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "()Ljavax/xml/validation/Schema;");
		}
	}
}
