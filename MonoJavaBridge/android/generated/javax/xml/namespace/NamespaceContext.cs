namespace javax.xml.@namespace
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.@namespace.NamespaceContext_))]
	public partial interface NamespaceContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getPrefix(java.lang.String arg0);
		global::java.lang.String getNamespaceURI(java.lang.String arg0);
		global::java.util.Iterator getPrefixes(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.@namespace.NamespaceContext))]
	internal sealed partial class NamespaceContext_ : java.lang.Object, NamespaceContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NamespaceContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String javax.xml.@namespace.NamespaceContext.getPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.@namespace.NamespaceContext_.staticClass, "getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::javax.xml.@namespace.NamespaceContext_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String javax.xml.@namespace.NamespaceContext.getNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.@namespace.NamespaceContext_.staticClass, "getNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::javax.xml.@namespace.NamespaceContext_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.util.Iterator javax.xml.@namespace.NamespaceContext.getPrefixes(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::javax.xml.@namespace.NamespaceContext_.staticClass, "getPrefixes", "(Ljava/lang/String;)Ljava/util/Iterator;", ref global::javax.xml.@namespace.NamespaceContext_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Iterator;
		}
		static NamespaceContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.@namespace.NamespaceContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/namespace/NamespaceContext"));
		}
	}
}
