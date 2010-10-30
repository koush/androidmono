namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.EntityResolver_))]
	public partial interface EntityResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.EntityResolver))]
	internal sealed partial class EntityResolver_ : java.lang.Object, EntityResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EntityResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.xml.sax.InputSource org.xml.sax.EntityResolver.resolveEntity(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.EntityResolver_.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.EntityResolver_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xml.sax.InputSource;
		}
		static EntityResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.EntityResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/EntityResolver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
