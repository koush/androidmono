namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.DocumentBuilderFactory_))]
	public abstract partial class DocumentBuilderFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DocumentBuilderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.DocumentBuilderFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.DocumentBuilderFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._m0)) as javax.xml.parsers.DocumentBuilderFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.DocumentBuilderFactory._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.DocumentBuilderFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/DocumentBuilderFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.parsers.DocumentBuilderFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.lang.Object getAttribute(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool getFeature(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void setAttribute(java.lang.String arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isNamespaceAware", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isValidating", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;", ref global::javax.xml.parsers.DocumentBuilderFactory._m8) as javax.xml.validation.Schema;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isXIncludeAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isXIncludeAware", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::javax.xml.parsers.DocumentBuilder newDocumentBuilder();
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setNamespaceAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setNamespaceAware", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setValidating(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setValidating", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setIgnoringElementContentWhitespace(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringElementContentWhitespace", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setExpandEntityReferences(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setExpandEntityReferences", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setIgnoringComments(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringComments", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setCoalescing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setCoalescing", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool isIgnoringElementContentWhitespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringElementContentWhitespace", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool isExpandEntityReferences()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isExpandEntityReferences", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isIgnoringComments()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringComments", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isCoalescing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isCoalescing", "()Z", ref global::javax.xml.parsers.DocumentBuilderFactory._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setSchema(javax.xml.validation.Schema arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setSchema", "(Ljavax/xml/validation/Schema;)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setXIncludeAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setXIncludeAware", "(Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected DocumentBuilderFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.DocumentBuilderFactory._m23.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.DocumentBuilderFactory._m23 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._m23);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.parsers.DocumentBuilderFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.parsers.DocumentBuilderFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.parsers.DocumentBuilderFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.parsers.DocumentBuilderFactory_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::javax.xml.parsers.DocumentBuilder newDocumentBuilder()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;", ref global::javax.xml.parsers.DocumentBuilderFactory_._m4) as javax.xml.parsers.DocumentBuilder;
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
