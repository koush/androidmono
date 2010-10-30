namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class XMLReaderFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XMLReaderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::org.xml.sax.XMLReader createXMLReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.XMLReaderFactory._m0.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.XMLReaderFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderFactory.staticClass, "createXMLReader", "()Lorg/xml/sax/XMLReader;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.XMLReaderFactory.staticClass, global::org.xml.sax.helpers.XMLReaderFactory._m0)) as org.xml.sax.XMLReader;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::org.xml.sax.XMLReader createXMLReader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.XMLReaderFactory._m1.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.XMLReaderFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderFactory.staticClass, "createXMLReader", "(Ljava/lang/String;)Lorg/xml/sax/XMLReader;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.XMLReader>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.XMLReaderFactory.staticClass, global::org.xml.sax.helpers.XMLReaderFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.XMLReader;
		}
		static XMLReaderFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.XMLReaderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/XMLReaderFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
