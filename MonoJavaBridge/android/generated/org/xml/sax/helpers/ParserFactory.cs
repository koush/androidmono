namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::org.xml.sax.Parser makeParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.ParserFactory._m0.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.ParserFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.ParserFactory.staticClass, "makeParser", "()Lorg/xml/sax/Parser;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.ParserFactory.staticClass, global::org.xml.sax.helpers.ParserFactory._m0)) as org.xml.sax.Parser;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::org.xml.sax.Parser makeParser(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.ParserFactory._m1.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.ParserFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.ParserFactory.staticClass, "makeParser", "(Ljava/lang/String;)Lorg/xml/sax/Parser;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.ParserFactory.staticClass, global::org.xml.sax.helpers.ParserFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.Parser;
		}
		static ParserFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.ParserFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/ParserFactory"));
		}
	}
}
