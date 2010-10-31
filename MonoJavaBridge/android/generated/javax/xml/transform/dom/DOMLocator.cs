namespace javax.xml.transform.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.dom.DOMLocator_))]
	public partial interface DOMLocator : SourceLocator
	{
		global::org.w3c.dom.Node getOriginatingNode();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.dom.DOMLocator))]
	internal sealed partial class DOMLocator_ : java.lang.Object, DOMLocator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.w3c.dom.Node javax.xml.transform.dom.DOMLocator.getOriginatingNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::javax.xml.transform.dom.DOMLocator_.staticClass, "getOriginatingNode", "()Lorg/w3c/dom/Node;", ref global::javax.xml.transform.dom.DOMLocator_._m0) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int javax.xml.transform.SourceLocator.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.transform.dom.DOMLocator_.staticClass, "getLineNumber", "()I", ref global::javax.xml.transform.dom.DOMLocator_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String javax.xml.transform.SourceLocator.getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.dom.DOMLocator_.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::javax.xml.transform.dom.DOMLocator_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String javax.xml.transform.SourceLocator.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.dom.DOMLocator_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.dom.DOMLocator_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int javax.xml.transform.SourceLocator.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.transform.dom.DOMLocator_.staticClass, "getColumnNumber", "()I", ref global::javax.xml.transform.dom.DOMLocator_._m4);
		}
		static DOMLocator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.dom.DOMLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/dom/DOMLocator"));
		}
	}
}
