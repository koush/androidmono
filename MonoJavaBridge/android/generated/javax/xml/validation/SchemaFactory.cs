namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.SchemaFactory_))]
	public abstract partial class SchemaFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SchemaFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty31185;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.validation.SchemaFactory._setProperty31185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty31186;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.validation.SchemaFactory._getProperty31186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31187;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactory._newInstance31187.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactory._newInstance31187 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/validation/SchemaFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newInstance31187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.validation.SchemaFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31188;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactory._newInstance31188.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactory._newInstance31188 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newInstance31188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.SchemaFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31189;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.validation.SchemaFactory._setFeature31189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31190;
		public virtual bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.validation.SchemaFactory._getFeature31190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31191;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31192;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31193;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31194;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _isSchemaLanguageSupported31195;
		public abstract bool isSchemaLanguageSupported(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newSchema31196;
		public virtual global::javax.xml.validation.Schema newSchema(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory._newSchema31196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31197;
		public virtual global::javax.xml.validation.Schema newSchema(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory._newSchema31197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31198;
		public abstract global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0);
		internal static global::MonoJavaBridge.MethodId _newSchema31199;
		public abstract global::javax.xml.validation.Schema newSchema();
		internal static global::MonoJavaBridge.MethodId _newSchema31200;
		public virtual global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory._newSchema31200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _SchemaFactory31201;
		protected SchemaFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactory._SchemaFactory31201.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactory._SchemaFactory31201 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._SchemaFactory31201);
			Init(@__env, handle);
		}
		static SchemaFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.SchemaFactory))]
	internal sealed partial class SchemaFactory_ : javax.xml.validation.SchemaFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SchemaFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31202;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::javax.xml.validation.SchemaFactory_._setErrorHandler31202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31203;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::javax.xml.validation.SchemaFactory_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::javax.xml.validation.SchemaFactory_._getErrorHandler31203) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31204;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", ref global::javax.xml.validation.SchemaFactory_._setResourceResolver31204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31205;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSResourceResolver>(this, global::javax.xml.validation.SchemaFactory_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", ref global::javax.xml.validation.SchemaFactory_._getResourceResolver31205) as org.w3c.dom.ls.LSResourceResolver;
		}
		internal static global::MonoJavaBridge.MethodId _isSchemaLanguageSupported31206;
		public override bool isSchemaLanguageSupported(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "isSchemaLanguageSupported", "(Ljava/lang/String;)Z", ref global::javax.xml.validation.SchemaFactory_._isSchemaLanguageSupported31206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31207;
		public override global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory_._newSchema31207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema31208;
		public override global::javax.xml.validation.Schema newSchema()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "()Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory_._newSchema31208) as javax.xml.validation.Schema;
		}
		static SchemaFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
