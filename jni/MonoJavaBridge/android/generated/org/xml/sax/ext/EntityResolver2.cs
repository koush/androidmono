namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.EntityResolver2_))]
	public interface EntityResolver2 : EntityResolver
	{
		global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::org.xml.sax.InputSource getExternalSubset(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.EntityResolver2))]
	public sealed partial class EntityResolver2_ : java.lang.Object, EntityResolver2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EntityResolver2_()
		{
			InitJNI();
		}
		internal EntityResolver2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity28257;
		 global::org.xml.sax.InputSource org.xml.sax.ext.EntityResolver2.resolveEntity(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.EntityResolver2_._resolveEntity28257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.EntityResolver2_.staticClass, global::org.xml.sax.ext.EntityResolver2_._resolveEntity28257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalSubset28258;
		 global::org.xml.sax.InputSource org.xml.sax.ext.EntityResolver2.getExternalSubset(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.EntityResolver2_._getExternalSubset28258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.EntityResolver2_.staticClass, global::org.xml.sax.ext.EntityResolver2_._getExternalSubset28258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity28259;
		 global::org.xml.sax.InputSource org.xml.sax.EntityResolver.resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.EntityResolver2_._resolveEntity28259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.EntityResolver2_.staticClass, global::org.xml.sax.ext.EntityResolver2_._resolveEntity28259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.EntityResolver2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/EntityResolver2"));
			global::org.xml.sax.ext.EntityResolver2_._resolveEntity28257 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.EntityResolver2_.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.EntityResolver2_._getExternalSubset28258 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.EntityResolver2_.staticClass, "getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.EntityResolver2_._resolveEntity28259 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.EntityResolver2_.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
		}
	}
}
