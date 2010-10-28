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
		internal static global::MonoJavaBridge.MethodId _resolveEntity34983;
		global::org.xml.sax.InputSource org.xml.sax.EntityResolver.resolveEntity(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.EntityResolver_._resolveEntity34983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.EntityResolver_.staticClass, global::org.xml.sax.EntityResolver_._resolveEntity34983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		static EntityResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.EntityResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/EntityResolver"));
			global::org.xml.sax.EntityResolver_._resolveEntity34983 = @__env.GetMethodIDNoThrow(global::org.xml.sax.EntityResolver_.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
		}
		internal static void InitJNI()
		{
		}
	}
}
