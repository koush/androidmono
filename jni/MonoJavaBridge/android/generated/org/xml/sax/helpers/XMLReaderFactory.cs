namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class XMLReaderFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XMLReaderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createXMLReader35309;
		public static global::org.xml.sax.XMLReader createXMLReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.XMLReaderFactory.staticClass, global::org.xml.sax.helpers.XMLReaderFactory._createXMLReader35309)) as org.xml.sax.XMLReader;
		}
		internal static global::MonoJavaBridge.MethodId _createXMLReader35310;
		public static global::org.xml.sax.XMLReader createXMLReader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.XMLReaderFactory.staticClass, global::org.xml.sax.helpers.XMLReaderFactory._createXMLReader35310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.XMLReader;
		}
		static XMLReaderFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.XMLReaderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/XMLReaderFactory"));
			global::org.xml.sax.helpers.XMLReaderFactory._createXMLReader35309 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderFactory.staticClass, "createXMLReader", "()Lorg/xml/sax/XMLReader;");
			global::org.xml.sax.helpers.XMLReaderFactory._createXMLReader35310 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderFactory.staticClass, "createXMLReader", "(Ljava/lang/String;)Lorg/xml/sax/XMLReader;");
		}
		internal static void InitJNI()
		{
		}
	}
}
