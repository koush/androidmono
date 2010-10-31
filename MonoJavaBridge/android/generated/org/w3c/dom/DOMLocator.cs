namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMLocator_))]
	public partial interface DOMLocator  : global::MonoJavaBridge.IJavaObject 
	{
		int getLineNumber();
		int getColumnNumber();
		global::java.lang.String getUri();
		global::org.w3c.dom.Node getRelatedNode();
		int getByteOffset();
		int getUtf16Offset();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMLocator))]
	internal sealed partial class DOMLocator_ : java.lang.Object, DOMLocator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.w3c.dom.DOMLocator.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.DOMLocator_.staticClass, "getLineNumber", "()I", ref global::org.w3c.dom.DOMLocator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int org.w3c.dom.DOMLocator.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.DOMLocator_.staticClass, "getColumnNumber", "()I", ref global::org.w3c.dom.DOMLocator_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.w3c.dom.DOMLocator.getUri()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DOMLocator_.staticClass, "getUri", "()Ljava/lang/String;", ref global::org.w3c.dom.DOMLocator_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.w3c.dom.Node org.w3c.dom.DOMLocator.getRelatedNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DOMLocator_.staticClass, "getRelatedNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DOMLocator_._m3) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int org.w3c.dom.DOMLocator.getByteOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.DOMLocator_.staticClass, "getByteOffset", "()I", ref global::org.w3c.dom.DOMLocator_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int org.w3c.dom.DOMLocator.getUtf16Offset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.DOMLocator_.staticClass, "getUtf16Offset", "()I", ref global::org.w3c.dom.DOMLocator_._m5);
		}
		static DOMLocator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMLocator"));
		}
	}
}
