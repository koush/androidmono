namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.TransformerFactory_))]
	public abstract partial class TransformerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransformerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.xml.transform.TransformerFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newInstance", "()Ljavax/xml/transform/TransformerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._m0)) as javax.xml.transform.TransformerFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.xml.transform.TransformerFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactory._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/transform/TransformerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.transform.TransformerFactory;
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
		public abstract global::javax.xml.transform.Transformer newTransformer();
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void setURIResolver(javax.xml.transform.URIResolver arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::javax.xml.transform.URIResolver getURIResolver();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void setErrorListener(javax.xml.transform.ErrorListener arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::javax.xml.transform.ErrorListener getErrorListener();
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		private static global::MonoJavaBridge.MethodId _m14;
		protected TransformerFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactory._m14.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactory._m14 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._m14);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.transform.TransformerFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::javax.xml.transform.TransformerFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::javax.xml.transform.TransformerFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.transform.TransformerFactory_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::javax.xml.transform.Transformer newTransformer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.TransformerFactory_._m4) as javax.xml.transform.Transformer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.TransformerFactory_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Transformer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", ref global::javax.xml.transform.TransformerFactory_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::javax.xml.transform.URIResolver getURIResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.URIResolver>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;", ref global::javax.xml.transform.TransformerFactory_._m7) as javax.xml.transform.URIResolver;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerFactory_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", ref global::javax.xml.transform.TransformerFactory_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::javax.xml.transform.ErrorListener getErrorListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.ErrorListener>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;", ref global::javax.xml.transform.TransformerFactory_._m9) as javax.xml.transform.ErrorListener;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Templates>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", ref global::javax.xml.transform.TransformerFactory_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.transform.Templates;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Source>(this, global::javax.xml.transform.TransformerFactory_.staticClass, "getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", ref global::javax.xml.transform.TransformerFactory_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.transform.Source;
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
