namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.DocumentBuilderFactory_))]
	public abstract partial class DocumentBuilderFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DocumentBuilderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30854;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.DocumentBuilderFactory._newInstance30854.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.DocumentBuilderFactory._newInstance30854 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._newInstance30854)) as javax.xml.parsers.DocumentBuilderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30855;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.DocumentBuilderFactory._newInstance30855.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.DocumentBuilderFactory._newInstance30855 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/DocumentBuilderFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._newInstance30855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.parsers.DocumentBuilderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30856;
		public abstract global::java.lang.Object getAttribute(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setFeature30857;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature30858;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setAttribute30859;
		public abstract void setAttribute(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30860;
		public virtual bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isNamespaceAware", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._isNamespaceAware30860);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating30861;
		public virtual bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isValidating", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._isValidating30861);
		}
		internal static global::MonoJavaBridge.MethodId _getSchema30862;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;", ref global::javax.xml.parsers.DocumentBuilderFactory._getSchema30862) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware30863;
		public virtual bool isXIncludeAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isXIncludeAware", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._isXIncludeAware30863);
		}
		internal static global::MonoJavaBridge.MethodId _newDocumentBuilder30864;
		public abstract global::javax.xml.parsers.DocumentBuilder newDocumentBuilder();
		internal static global::MonoJavaBridge.MethodId _setNamespaceAware30865;
		public virtual void setNamespaceAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setNamespaceAware", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setNamespaceAware30865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValidating30866;
		public virtual void setValidating(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setValidating", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setValidating30866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoringElementContentWhitespace30867;
		public virtual void setIgnoringElementContentWhitespace(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringElementContentWhitespace", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringElementContentWhitespace30867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpandEntityReferences30868;
		public virtual void setExpandEntityReferences(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setExpandEntityReferences", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setExpandEntityReferences30868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoringComments30869;
		public virtual void setIgnoringComments(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringComments", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringComments30869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCoalescing30870;
		public virtual void setCoalescing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setCoalescing", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setCoalescing30870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIgnoringElementContentWhitespace30871;
		public virtual bool isIgnoringElementContentWhitespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringElementContentWhitespace", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringElementContentWhitespace30871);
		}
		internal static global::MonoJavaBridge.MethodId _isExpandEntityReferences30872;
		public virtual bool isExpandEntityReferences()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isExpandEntityReferences", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._isExpandEntityReferences30872);
		}
		internal static global::MonoJavaBridge.MethodId _isIgnoringComments30873;
		public virtual bool isIgnoringComments()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringComments", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringComments30873);
		}
		internal static global::MonoJavaBridge.MethodId _isCoalescing30874;
		public virtual bool isCoalescing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isCoalescing", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._isCoalescing30874);
		}
		internal static global::MonoJavaBridge.MethodId _setSchema30875;
		public virtual void setSchema(javax.xml.validation.Schema arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setSchema", "(Ljavax/xml/validation/Schema;)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setSchema30875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXIncludeAware30876;
		public virtual void setXIncludeAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setXIncludeAware", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._setXIncludeAware30876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DocumentBuilderFactory30877;
		protected DocumentBuilderFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.DocumentBuilderFactory._DocumentBuilderFactory30877.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.DocumentBuilderFactory._DocumentBuilderFactory30877 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._DocumentBuilderFactory30877);
			Init(@__env, handle);
		}
		static DocumentBuilderFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilderFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.DocumentBuilderFactory))]
	internal sealed partial class DocumentBuilderFactory_ : javax.xml.parsers.DocumentBuilderFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DocumentBuilderFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30878;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.parsers.DocumentBuilderFactory_._getAttribute30878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature30879;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory_._setFeature30879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature30880;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.parsers.DocumentBuilderFactory_._getFeature30880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute30881;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.parsers.DocumentBuilderFactory_._setAttribute30881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newDocumentBuilder30882;
		public override global::javax.xml.parsers.DocumentBuilder newDocumentBuilder()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;", ref global::javax.xml.parsers.DocumentBuilderFactory_._newDocumentBuilder30882) as javax.xml.parsers.DocumentBuilder;
		}
		static DocumentBuilderFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilderFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilderFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
