namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.SchemaFactory_))]
	public abstract partial class SchemaFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SchemaFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.validation.SchemaFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.validation.SchemaFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactory._m2.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/validation/SchemaFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.validation.SchemaFactory;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::javax.xml.validation.SchemaFactory newInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactory._m3.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactory._m3 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.SchemaFactory;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.validation.SchemaFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.validation.SchemaFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract bool isSchemaLanguageSupported(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::javax.xml.validation.Schema newSchema(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.xml.validation.Schema newSchema(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract global::javax.xml.validation.Schema newSchema();
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory.staticClass, "newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected SchemaFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactory._m16.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactory._m16 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.SchemaFactory.staticClass, global::javax.xml.validation.SchemaFactory._m16);
			Init(@__env, handle);
		}
		static SchemaFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.SchemaFactory))]
	internal sealed partial class SchemaFactory_ : javax.xml.validation.SchemaFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SchemaFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", ref global::javax.xml.validation.SchemaFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::javax.xml.validation.SchemaFactory_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", ref global::javax.xml.validation.SchemaFactory_._m1) as org.xml.sax.ErrorHandler;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", ref global::javax.xml.validation.SchemaFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSResourceResolver>(this, global::javax.xml.validation.SchemaFactory_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", ref global::javax.xml.validation.SchemaFactory_._m3) as org.w3c.dom.ls.LSResourceResolver;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isSchemaLanguageSupported(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "isSchemaLanguageSupported", "(Ljava/lang/String;)Z", ref global::javax.xml.validation.SchemaFactory_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::javax.xml.validation.Schema newSchema(javax.xml.transform.Source[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::javax.xml.validation.Schema newSchema()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactory_.staticClass, "newSchema", "()Ljavax/xml/validation/Schema;", ref global::javax.xml.validation.SchemaFactory_._m6) as javax.xml.validation.Schema;
		}
		static SchemaFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactory"));
		}
	}
}
