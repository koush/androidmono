namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMImplementationSource_))]
	public partial interface DOMImplementationSource  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.DOMImplementation getDOMImplementation(java.lang.String arg0);
		global::org.w3c.dom.DOMImplementationList getDOMImplementationList(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMImplementationSource))]
	internal sealed partial class DOMImplementationSource_ : java.lang.Object, DOMImplementationSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMImplementationSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.w3c.dom.DOMImplementation org.w3c.dom.DOMImplementationSource.getDOMImplementation(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMImplementation>(this, global::org.w3c.dom.DOMImplementationSource_.staticClass, "getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;", ref global::org.w3c.dom.DOMImplementationSource_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.DOMImplementation;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.DOMImplementationList org.w3c.dom.DOMImplementationSource.getDOMImplementationList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMImplementationList>(this, global::org.w3c.dom.DOMImplementationSource_.staticClass, "getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;", ref global::org.w3c.dom.DOMImplementationSource_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.DOMImplementationList;
		}
		static DOMImplementationSource_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMImplementationSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMImplementationSource"));
		}
	}
}
