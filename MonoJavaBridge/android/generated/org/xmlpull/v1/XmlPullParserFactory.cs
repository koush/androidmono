namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XmlPullParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XmlPullParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance35371;
		public static global::org.xmlpull.v1.XmlPullParserFactory newInstance(java.lang.String arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserFactory._newInstance35371.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserFactory._newInstance35371 = @__env.GetStaticMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/xmlpull/v1/XmlPullParserFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._newInstance35371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlPullParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance35372;
		public static global::org.xmlpull.v1.XmlPullParserFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserFactory._newInstance35372.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserFactory._newInstance35372 = @__env.GetStaticMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newInstance", "()Lorg/xmlpull/v1/XmlPullParserFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._newInstance35372)) as org.xmlpull.v1.XmlPullParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35373;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xmlpull.v1.XmlPullParserFactory._setFeature35373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35374;
		public virtual bool getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xmlpull.v1.XmlPullParserFactory._getFeature35374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newPullParser35375;
		public virtual global::org.xmlpull.v1.XmlPullParser newPullParser()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlPullParser>(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;", ref global::org.xmlpull.v1.XmlPullParserFactory._newPullParser35375) as org.xmlpull.v1.XmlPullParser;
		}
		internal static global::MonoJavaBridge.MethodId _newSerializer35376;
		public virtual global::org.xmlpull.v1.XmlSerializer newSerializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlSerializer>(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;", ref global::org.xmlpull.v1.XmlPullParserFactory._newSerializer35376) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware35377;
		public virtual bool isNamespaceAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "isNamespaceAware", "()Z", ref global::org.xmlpull.v1.XmlPullParserFactory._isNamespaceAware35377);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating35378;
		public virtual bool isValidating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "isValidating", "()Z", ref global::org.xmlpull.v1.XmlPullParserFactory._isValidating35378);
		}
		public new bool NamespaceAware
		{
			set
			{
				setNamespaceAware(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceAware35379;
		public virtual void setNamespaceAware(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setNamespaceAware", "(Z)V", ref global::org.xmlpull.v1.XmlPullParserFactory._setNamespaceAware35379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Validating
		{
			set
			{
				setValidating(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setValidating35380;
		public virtual void setValidating(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setValidating", "(Z)V", ref global::org.xmlpull.v1.XmlPullParserFactory._setValidating35380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _XmlPullParserFactory35381;
		protected XmlPullParserFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserFactory._XmlPullParserFactory35381.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserFactory._XmlPullParserFactory35381 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._XmlPullParserFactory35381);
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
		internal static void InitJNI()
		{
		}
	}
}
