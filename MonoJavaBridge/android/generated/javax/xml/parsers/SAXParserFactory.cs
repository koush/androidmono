namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.SAXParserFactory_))]
	public abstract partial class SAXParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30917;
		public static global::javax.xml.parsers.SAXParserFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._newInstance30917)) as javax.xml.parsers.SAXParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30918;
		public static global::javax.xml.parsers.SAXParserFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._newInstance30918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.parsers.SAXParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature30919;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature30920;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30921;
		public virtual bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._isNamespaceAware30921);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating30922;
		public virtual bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._isValidating30922);
		}
		internal static global::MonoJavaBridge.MethodId _getSchema30923;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._getSchema30923)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware30924;
		public virtual bool isXIncludeAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._isXIncludeAware30924);
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceAware30925;
		public virtual void setNamespaceAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setNamespaceAware30925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValidating30926;
		public virtual void setValidating(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setValidating30926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSchema30927;
		public virtual void setSchema(javax.xml.validation.Schema arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setSchema30927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXIncludeAware30928;
		public virtual void setXIncludeAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setXIncludeAware30928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newSAXParser30929;
		public abstract global::javax.xml.parsers.SAXParser newSAXParser();
		internal static global::MonoJavaBridge.MethodId _SAXParserFactory30930;
		protected SAXParserFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._SAXParserFactory30930);
			Init(@__env, handle);
		}
		static SAXParserFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParserFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParserFactory"));
			global::javax.xml.parsers.SAXParserFactory._newInstance30917 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newInstance", "()Ljavax/xml/parsers/SAXParserFactory;");
			global::javax.xml.parsers.SAXParserFactory._newInstance30918 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/SAXParserFactory;");
			global::javax.xml.parsers.SAXParserFactory._setFeature30919 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.SAXParserFactory._getFeature30920 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.SAXParserFactory._isNamespaceAware30921 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.SAXParserFactory._isValidating30922 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.SAXParserFactory._getSchema30923 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.SAXParserFactory._isXIncludeAware30924 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.SAXParserFactory._setNamespaceAware30925 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setNamespaceAware", "(Z)V");
			global::javax.xml.parsers.SAXParserFactory._setValidating30926 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setValidating", "(Z)V");
			global::javax.xml.parsers.SAXParserFactory._setSchema30927 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setSchema", "(Ljavax/xml/validation/Schema;)V");
			global::javax.xml.parsers.SAXParserFactory._setXIncludeAware30928 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setXIncludeAware", "(Z)V");
			global::javax.xml.parsers.SAXParserFactory._newSAXParser30929 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newSAXParser", "()Ljavax/xml/parsers/SAXParser;");
			global::javax.xml.parsers.SAXParserFactory._SAXParserFactory30930 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.SAXParserFactory))]
	internal sealed partial class SAXParserFactory_ : javax.xml.parsers.SAXParserFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SAXParserFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setFeature30931;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_._setFeature30931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature30932;
		public override bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_._getFeature30932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newSAXParser30933;
		public override global::javax.xml.parsers.SAXParser newSAXParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_._newSAXParser30933)) as javax.xml.parsers.SAXParser;
		}
		static SAXParserFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParserFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParserFactory"));
			global::javax.xml.parsers.SAXParserFactory_._setFeature30931 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.SAXParserFactory_._getFeature30932 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.SAXParserFactory_._newSAXParser30933 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory_.staticClass, "newSAXParser", "()Ljavax/xml/parsers/SAXParser;");
		}
		internal static void InitJNI()
		{
		}
	}
}
