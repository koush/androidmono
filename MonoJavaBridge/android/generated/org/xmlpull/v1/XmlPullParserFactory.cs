namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XmlPullParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XmlPullParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::org.xmlpull.v1.XmlPullParserFactory newInstance(java.lang.String arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserFactory._m0.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/xmlpull/v1/XmlPullParserFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlPullParserFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::org.xmlpull.v1.XmlPullParserFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserFactory._m1.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newInstance", "()Lorg/xmlpull/v1/XmlPullParserFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._m1)) as org.xmlpull.v1.XmlPullParserFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xmlpull.v1.XmlPullParserFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xmlpull.v1.XmlPullParserFactory._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.xmlpull.v1.XmlPullParser newPullParser()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlPullParser>(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;", ref global::org.xmlpull.v1.XmlPullParserFactory._m4) as org.xmlpull.v1.XmlPullParser;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.xmlpull.v1.XmlSerializer newSerializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlSerializer>(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;", ref global::org.xmlpull.v1.XmlPullParserFactory._m5) as org.xmlpull.v1.XmlSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "isNamespaceAware", "()Z", ref global::org.xmlpull.v1.XmlPullParserFactory._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "isValidating", "()Z", ref global::org.xmlpull.v1.XmlPullParserFactory._m7);
		}
		public new bool NamespaceAware
		{
			set
			{
				setNamespaceAware(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setNamespaceAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setNamespaceAware", "(Z)V", ref global::org.xmlpull.v1.XmlPullParserFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Validating
		{
			set
			{
				setValidating(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setValidating(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setValidating", "(Z)V", ref global::org.xmlpull.v1.XmlPullParserFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected XmlPullParserFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserFactory._m10.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserFactory._m10 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._m10);
			Init(@__env, handle);
		}
		public static global::java.lang.String PROPERTY_NAME
		{
			get
			{
				return "org.xmlpull.v1.XmlPullParserFactory";
			}
		}
		static XmlPullParserFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParserFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParserFactory"));
		}
	}
}
