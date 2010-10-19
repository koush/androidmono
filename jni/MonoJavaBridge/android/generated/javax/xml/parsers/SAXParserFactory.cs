namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.SAXParserFactory_))]
	public abstract partial class SAXParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXParserFactory()
		{
			InitJNI();
		}
		protected SAXParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24333;
		public static global::javax.xml.parsers.SAXParserFactory newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._newInstance24333)) as javax.xml.parsers.SAXParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24334;
		public static global::javax.xml.parsers.SAXParserFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._newInstance24334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.parsers.SAXParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature24335;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature24336;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware24337;
		public virtual bool isNamespaceAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._isNamespaceAware24337);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._isNamespaceAware24337);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating24338;
		public virtual bool isValidating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._isValidating24338);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._isValidating24338);
		}
		internal static global::MonoJavaBridge.MethodId _getSchema24339;
		public virtual global::javax.xml.validation.Schema getSchema() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._getSchema24339)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._getSchema24339)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware24340;
		public virtual bool isXIncludeAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._isXIncludeAware24340);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._isXIncludeAware24340);
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceAware24341;
		public virtual void setNamespaceAware(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._setNamespaceAware24341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setNamespaceAware24341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValidating24342;
		public virtual void setValidating(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._setValidating24342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setValidating24342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSchema24343;
		public virtual void setSchema(javax.xml.validation.Schema arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._setSchema24343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setSchema24343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXIncludeAware24344;
		public virtual void setXIncludeAware(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory._setXIncludeAware24344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._setXIncludeAware24344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newSAXParser24345;
		public abstract global::javax.xml.parsers.SAXParser newSAXParser();
		internal static global::MonoJavaBridge.MethodId _SAXParserFactory24346;
		protected SAXParserFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.SAXParserFactory.staticClass, global::javax.xml.parsers.SAXParserFactory._SAXParserFactory24346);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParserFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParserFactory"));
			global::javax.xml.parsers.SAXParserFactory._newInstance24333 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newInstance", "()Ljavax/xml/parsers/SAXParserFactory;");
			global::javax.xml.parsers.SAXParserFactory._newInstance24334 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/SAXParserFactory;");
			global::javax.xml.parsers.SAXParserFactory._setFeature24335 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.SAXParserFactory._getFeature24336 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.SAXParserFactory._isNamespaceAware24337 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.SAXParserFactory._isValidating24338 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.SAXParserFactory._getSchema24339 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.SAXParserFactory._isXIncludeAware24340 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.SAXParserFactory._setNamespaceAware24341 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setNamespaceAware", "(Z)V");
			global::javax.xml.parsers.SAXParserFactory._setValidating24342 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setValidating", "(Z)V");
			global::javax.xml.parsers.SAXParserFactory._setSchema24343 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setSchema", "(Ljavax/xml/validation/Schema;)V");
			global::javax.xml.parsers.SAXParserFactory._setXIncludeAware24344 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "setXIncludeAware", "(Z)V");
			global::javax.xml.parsers.SAXParserFactory._newSAXParser24345 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "newSAXParser", "()Ljavax/xml/parsers/SAXParser;");
			global::javax.xml.parsers.SAXParserFactory._SAXParserFactory24346 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.SAXParserFactory))]
	public sealed partial class SAXParserFactory_ : javax.xml.parsers.SAXParserFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXParserFactory_()
		{
			InitJNI();
		}
		internal SAXParserFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setFeature24347;
		public override void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_._setFeature24347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_.staticClass, global::javax.xml.parsers.SAXParserFactory_._setFeature24347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature24348;
		public override bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_._getFeature24348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_.staticClass, global::javax.xml.parsers.SAXParserFactory_._getFeature24348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newSAXParser24349;
		public override global::javax.xml.parsers.SAXParser newSAXParser() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_._newSAXParser24349)) as javax.xml.parsers.SAXParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.SAXParserFactory_.staticClass, global::javax.xml.parsers.SAXParserFactory_._newSAXParser24349)) as javax.xml.parsers.SAXParser;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.SAXParserFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/SAXParserFactory"));
			global::javax.xml.parsers.SAXParserFactory_._setFeature24347 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.SAXParserFactory_._getFeature24348 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.SAXParserFactory_._newSAXParser24349 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.SAXParserFactory_.staticClass, "newSAXParser", "()Ljavax/xml/parsers/SAXParser;");
		}
	}
}
