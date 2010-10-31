namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.SAXParserFactory_))]
	public abstract partial class SAXParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.xml.parsers.SAXParserFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.SAXParserFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.SAXParserFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newInstance", "()Ljavax/xml/parsers/SAXParserFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._m0)) as javax.xml.parsers.SAXParserFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.xml.parsers.SAXParserFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.SAXParserFactory._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.SAXParserFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/SAXParserFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.parsers.SAXParserFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool getFeature(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "isNamespaceAware", "()Z", ref global::javax.xml.parsers.SAXParserFactory._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "isValidating", "()Z", ref global::javax.xml.parsers.SAXParserFactory._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;", ref global::javax.xml.parsers.SAXParserFactory._m6) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isXIncludeAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "isXIncludeAware", "()Z", ref global::javax.xml.parsers.SAXParserFactory._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setNamespaceAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "setNamespaceAware", "(Z)V", ref global::javax.xml.parsers.SAXParserFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setValidating(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "setValidating", "(Z)V", ref global::javax.xml.parsers.SAXParserFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setSchema(javax.xml.validation.Schema arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "setSchema", "(Ljavax/xml/validation/Schema;)V", ref global::javax.xml.parsers.SAXParserFactory._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setXIncludeAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, "setXIncludeAware", "(Z)V", ref global::javax.xml.parsers.SAXParserFactory._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract global::javax.xml.parsers.SAXParser newSAXParser();
		private static global::MonoJavaBridge.MethodId _m13;
		protected SAXParserFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.SAXParserFactory._m13.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.SAXParserFactory._m13 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._m13);
			Init(@__env, handle);
		}
		static SAXParserFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParserFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParserFactory"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.SAXParserFactory))]
	internal sealed partial class SAXParserFactory_ : javax.xml.parsers.SAXParserFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SAXParserFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.parsers.SAXParserFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParserFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.parsers.SAXParserFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::javax.xml.parsers.SAXParser newSAXParser()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.SAXParserFactory_.staticClass, "newSAXParser", "()Ljavax/xml/parsers/SAXParser;", ref global::javax.xml.parsers.SAXParserFactory_._m2) as javax.xml.parsers.SAXParser;
		}
		static SAXParserFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParserFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParserFactory"));
		}
	}
}
