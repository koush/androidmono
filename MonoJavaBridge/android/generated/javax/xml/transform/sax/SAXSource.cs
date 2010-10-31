namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXSource : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
			set
			{
				setSystemId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.sax.SAXSource.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.sax.SAXSource._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXSource.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.SAXSource._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.XMLReader XMLReader
		{
			get
			{
				return getXMLReader();
			}
			set
			{
				setXMLReader(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.xml.sax.XMLReader getXMLReader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.XMLReader>(this, global::javax.xml.transform.sax.SAXSource.staticClass, "getXMLReader", "()Lorg/xml/sax/XMLReader;", ref global::javax.xml.transform.sax.SAXSource._m2) as org.xml.sax.XMLReader;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setXMLReader(org.xml.sax.XMLReader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXSource.staticClass, "setXMLReader", "(Lorg/xml/sax/XMLReader;)V", ref global::javax.xml.transform.sax.SAXSource._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setInputSource(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXSource.staticClass, "setInputSource", "(Lorg/xml/sax/InputSource;)V", ref global::javax.xml.transform.sax.SAXSource._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.InputSource InputSource
		{
			get
			{
				return getInputSource();
			}
			set
			{
				setInputSource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.xml.sax.InputSource getInputSource()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.sax.SAXSource.staticClass, "getInputSource", "()Lorg/xml/sax/InputSource;", ref global::javax.xml.transform.sax.SAXSource._m5) as org.xml.sax.InputSource;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::org.xml.sax.InputSource sourceToInputSource(javax.xml.transform.Source arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXSource._m6.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXSource._m6 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "sourceToInputSource", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/InputSource;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.InputSource;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SAXSource(org.xml.sax.XMLReader arg0, org.xml.sax.InputSource arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXSource._m7.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXSource._m7 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "<init>", "(Lorg/xml/sax/XMLReader;Lorg/xml/sax/InputSource;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public SAXSource(org.xml.sax.InputSource arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXSource._m8.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXSource._m8 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "<init>", "(Lorg/xml/sax/InputSource;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public SAXSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXSource._m9.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXSource._m9 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._m9);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXSource/feature";
			}
		}
		static SAXSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXSource"));
		}
	}
}
