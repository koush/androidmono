namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.TransformerFactory_))]
	public abstract partial class TransformerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransformerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31006;
		public static global::javax.xml.transform.TransformerFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactory._newInstance31006.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactory._newInstance31006 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newInstance", "()Ljavax/xml/transform/TransformerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._newInstance31006)) as javax.xml.transform.TransformerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31007;
		public static global::javax.xml.transform.TransformerFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactory._newInstance31007.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactory._newInstance31007 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/transform/TransformerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._newInstance31007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.transform.TransformerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute31008;
		public abstract global::java.lang.Object getAttribute(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setFeature31009;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature31010;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setAttribute31011;
		public abstract void setAttribute(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _newTransformer31012;
		public abstract global::javax.xml.transform.Transformer newTransformer();
		internal static global::MonoJavaBridge.MethodId _newTransformer31013;
		public abstract global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _setURIResolver31014;
		public abstract void setURIResolver(javax.xml.transform.URIResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getURIResolver31015;
		public abstract global::javax.xml.transform.URIResolver getURIResolver();
		internal static global::MonoJavaBridge.MethodId _setErrorListener31016;
		public abstract void setErrorListener(javax.xml.transform.ErrorListener arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorListener31017;
		public abstract global::javax.xml.transform.ErrorListener getErrorListener();
		internal static global::MonoJavaBridge.MethodId _newTemplates31018;
		public abstract global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _getAssociatedStylesheet31019;
		public abstract global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		internal static global::MonoJavaBridge.MethodId _TransformerFactory31020;
		protected TransformerFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactory._TransformerFactory31020.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactory._TransformerFactory31020 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._TransformerFactory31020);
			Init(@__env, handle);
		}
		static TransformerFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.TransformerFactory))]
	internal sealed partial class TransformerFactory_ : javax.xml.transform.TransformerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TransformerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute31021;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.transform.TransformerFactory_._getAttribute31021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31022;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.transform.TransformerFactory_._setFeature31022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31023;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.transform.TransformerFactory_._getFeature31023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute31024;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.transform.TransformerFactory_._setAttribute31024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer31025;
		public override global::javax.xml.transform.Transformer newTransformer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.TransformerFactory_._newTransformer31025) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer31026;
		public override global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.TransformerFactory_._newTransformer31026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _setURIResolver31027;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", ref global::javax.xml.transform.TransformerFactory_._setURIResolver31027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getURIResolver31028;
		public override global::javax.xml.transform.URIResolver getURIResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.URIResolver>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;", ref global::javax.xml.transform.TransformerFactory_._getURIResolver31028) as javax.xml.transform.URIResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorListener31029;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", ref global::javax.xml.transform.TransformerFactory_._setErrorListener31029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorListener31030;
		public override global::javax.xml.transform.ErrorListener getErrorListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.ErrorListener>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;", ref global::javax.xml.transform.TransformerFactory_._getErrorListener31030) as javax.xml.transform.ErrorListener;
		}
		internal static global::MonoJavaBridge.MethodId _newTemplates31031;
		public override global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Templates>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", ref global::javax.xml.transform.TransformerFactory_._newTemplates31031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Templates;
		}
		internal static global::MonoJavaBridge.MethodId _getAssociatedStylesheet31032;
		public override global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Source>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", ref global::javax.xml.transform.TransformerFactory_._getAssociatedStylesheet31032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.transform.Source;
		}
		static TransformerFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
