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
		internal static global::MonoJavaBridge.MethodId _setProperty24581;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._setProperty24581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._setProperty24581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty24582;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._getProperty24582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._getProperty24582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24583;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newInstance24583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.validation.SchemaFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24584;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newInstance24584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.SchemaFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature24585;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._setFeature24585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._setFeature24585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature24586;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._getFeature24586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._getFeature24586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24587;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler24588;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver24589;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver24590;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _isSchemaLanguageSupported24591;
		public abstract bool isSchemaLanguageSupported(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newSchema24592;
		public virtual global::javax.xml.validation.Schema newSchema(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._newSchema24592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newSchema24592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema24593;
		public virtual global::javax.xml.validation.Schema newSchema(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._newSchema24593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newSchema24593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema24594;
		public abstract global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0);
		internal static global::MonoJavaBridge.MethodId _newSchema24595;
		public abstract global::javax.xml.validation.Schema newSchema();
		internal static global::MonoJavaBridge.MethodId _newSchema24596;
		public virtual global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory._newSchema24596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._newSchema24596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _SchemaFactory24597;
		protected SchemaFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._SchemaFactory24597);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
			global::javax.xml.validation.SchemaFactory._setProperty24581 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.validation.SchemaFactory._getProperty24582 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.validation.SchemaFactory._newInstance24583 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/validation/SchemaFactory;");
			global::javax.xml.validation.SchemaFactory._newInstance24584 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;");
			global::javax.xml.validation.SchemaFactory._setFeature24585 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.validation.SchemaFactory._getFeature24586 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.SchemaFactory._setErrorHandler24587 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.SchemaFactory._getErrorHandler24588 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.SchemaFactory._setResourceResolver24589 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.SchemaFactory._getResourceResolver24590 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.SchemaFactory._isSchemaLanguageSupported24591 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "isSchemaLanguageSupported", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.SchemaFactory._newSchema24592 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema24593 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema24594 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema24595 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._newSchema24596 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory._SchemaFactory24597 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24598;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._setErrorHandler24598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._setErrorHandler24598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler24599;
		public override global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._getErrorHandler24599)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._getErrorHandler24599)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver24600;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._setResourceResolver24600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._setResourceResolver24600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver24601;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._getResourceResolver24601)) as org.w3c.dom.ls.LSResourceResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._getResourceResolver24601)) as org.w3c.dom.ls.LSResourceResolver;
		}
		internal static global::MonoJavaBridge.MethodId _isSchemaLanguageSupported24602;
		public override bool isSchemaLanguageSupported(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._isSchemaLanguageSupported24602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._isSchemaLanguageSupported24602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newSchema24603;
		public override global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._newSchema24603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._newSchema24603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _newSchema24604;
		public override global::javax.xml.validation.Schema newSchema() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_._newSchema24604)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactory_.staticClass, global::javax.xml.validation.SchemaFactory_._newSchema24604)) as javax.xml.validation.Schema;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
			global::javax.xml.validation.SchemaFactory_._setErrorHandler24598 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.SchemaFactory_._getErrorHandler24599 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.SchemaFactory_._setResourceResolver24600 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.SchemaFactory_._getResourceResolver24601 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.SchemaFactory_._isSchemaLanguageSupported24602 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "isSchemaLanguageSupported", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.SchemaFactory_._newSchema24603 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;");
			global::javax.xml.validation.SchemaFactory_._newSchema24604 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "()Ljavax/xml/validation/Schema;");
		}
	}
}
