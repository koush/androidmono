namespace javax.xml
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class XMLConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLConstants()
		{
			InitJNI();
		}
		internal XMLConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _NULL_NS_URI30622;
		public static global::java.lang.String NULL_NS_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::javax.xml.XMLConstants.staticClass, _NULL_NS_URI30622)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT_NS_PREFIX30623;
		public static global::java.lang.String DEFAULT_NS_PREFIX
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::javax.xml.XMLConstants.staticClass, _DEFAULT_NS_PREFIX30623)) as java.lang.String;
			}
		}
		public static global::java.lang.String XML_NS_URI
		{
			get
			{
				return "http://www.w3.org/XML/1998/namespace";
			}
		}
		public static global::java.lang.String XML_NS_PREFIX
		{
			get
			{
				return "xml";
			}
		}
		public static global::java.lang.String XMLNS_ATTRIBUTE_NS_URI
		{
			get
			{
				return "http://www.w3.org/2000/xmlns/";
			}
		}
		public static global::java.lang.String XMLNS_ATTRIBUTE
		{
			get
			{
				return "xmlns";
			}
		}
		public static global::java.lang.String W3C_XML_SCHEMA_NS_URI
		{
			get
			{
				return "http://www.w3.org/2001/XMLSchema";
			}
		}
		public static global::java.lang.String W3C_XML_SCHEMA_INSTANCE_NS_URI
		{
			get
			{
				return "http://www.w3.org/2001/XMLSchema-instance";
			}
		}
		public static global::java.lang.String W3C_XPATH_DATATYPE_NS_URI
		{
			get
			{
				return "http://www.w3.org/2003/11/xpath-datatypes";
			}
		}
		public static global::java.lang.String XML_DTD_NS_URI
		{
			get
			{
				return "http://www.w3.org/TR/REC-xml";
			}
		}
		public static global::java.lang.String RELAXNG_NS_URI
		{
			get
			{
				return "http://relaxng.org/ns/structure/1.0";
			}
		}
		public static global::java.lang.String FEATURE_SECURE_PROCESSING
		{
			get
			{
				return "http://javax.xml.XMLConstants/feature/secure-processing";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.XMLConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/XMLConstants"));
			global::javax.xml.XMLConstants._NULL_NS_URI30622 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.XMLConstants.staticClass, "NULL_NS_URI", "Ljava/lang/String;");
			global::javax.xml.XMLConstants._DEFAULT_NS_PREFIX30623 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.XMLConstants.staticClass, "DEFAULT_NS_PREFIX", "Ljava/lang/String;");
		}
	}
}
