namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.EntityResolver2_))]
	public partial interface EntityResolver2 : EntityResolver
	{
		global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::org.xml.sax.InputSource getExternalSubset(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.EntityResolver2))]
	internal sealed partial class EntityResolver2_ : java.lang.Object, EntityResolver2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EntityResolver2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.xml.sax.InputSource org.xml.sax.ext.EntityResolver2.resolveEntity(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.ext.EntityResolver2_.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.ext.EntityResolver2_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as org.xml.sax.InputSource;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.xml.sax.InputSource org.xml.sax.ext.EntityResolver2.getExternalSubset(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.ext.EntityResolver2_.staticClass, "getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.ext.EntityResolver2_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xml.sax.InputSource;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.xml.sax.InputSource org.xml.sax.EntityResolver.resolveEntity(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.ext.EntityResolver2_.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.ext.EntityResolver2_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xml.sax.InputSource;
		}
		static EntityResolver2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.EntityResolver2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/EntityResolver2"));
		}
		internal static void InitJNI()
		{
		}
	}
}
