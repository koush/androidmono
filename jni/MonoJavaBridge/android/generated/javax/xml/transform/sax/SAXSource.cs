namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXSource : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXSource()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getSystemId31074;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource._getSystemId31074)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._getSystemId31074)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31075;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource._setSystemId31075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._setSystemId31075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getXMLReader31076;
		public virtual global::org.xml.sax.XMLReader getXMLReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource._getXMLReader31076)) as org.xml.sax.XMLReader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._getXMLReader31076)) as org.xml.sax.XMLReader;
		}
		internal static global::MonoJavaBridge.MethodId _setXMLReader31077;
		public virtual void setXMLReader(org.xml.sax.XMLReader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource._setXMLReader31077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._setXMLReader31077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInputSource31078;
		public virtual void setInputSource(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource._setInputSource31078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._setInputSource31078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInputSource31079;
		public virtual global::org.xml.sax.InputSource getInputSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource._getInputSource31079)) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._getInputSource31079)) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _sourceToInputSource31080;
		public static global::org.xml.sax.InputSource sourceToInputSource(javax.xml.transform.Source arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._sourceToInputSource31080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _SAXSource31081;
		public SAXSource(org.xml.sax.XMLReader arg0, org.xml.sax.InputSource arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._SAXSource31081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXSource31082;
		public SAXSource(org.xml.sax.InputSource arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._SAXSource31082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXSource31083;
		public SAXSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXSource.staticClass, global::javax.xml.transform.sax.SAXSource._SAXSource31083);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXSource/feature";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXSource"));
			global::javax.xml.transform.sax.SAXSource._getSystemId31074 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.sax.SAXSource._setSystemId31075 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.SAXSource._getXMLReader31076 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "getXMLReader", "()Lorg/xml/sax/XMLReader;");
			global::javax.xml.transform.sax.SAXSource._setXMLReader31077 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "setXMLReader", "(Lorg/xml/sax/XMLReader;)V");
			global::javax.xml.transform.sax.SAXSource._setInputSource31078 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "setInputSource", "(Lorg/xml/sax/InputSource;)V");
			global::javax.xml.transform.sax.SAXSource._getInputSource31079 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "getInputSource", "()Lorg/xml/sax/InputSource;");
			global::javax.xml.transform.sax.SAXSource._sourceToInputSource31080 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "sourceToInputSource", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/InputSource;");
			global::javax.xml.transform.sax.SAXSource._SAXSource31081 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "<init>", "(Lorg/xml/sax/XMLReader;Lorg/xml/sax/InputSource;)V");
			global::javax.xml.transform.sax.SAXSource._SAXSource31082 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "<init>", "(Lorg/xml/sax/InputSource;)V");
			global::javax.xml.transform.sax.SAXSource._SAXSource31083 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXSource.staticClass, "<init>", "()V");
		}
	}
}
