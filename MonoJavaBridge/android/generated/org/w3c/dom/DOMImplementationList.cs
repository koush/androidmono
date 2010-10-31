namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMImplementationList_))]
	public partial interface DOMImplementationList  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::org.w3c.dom.DOMImplementation item(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMImplementationList))]
	internal sealed partial class DOMImplementationList_ : java.lang.Object, DOMImplementationList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMImplementationList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.w3c.dom.DOMImplementationList.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.DOMImplementationList_.staticClass, "getLength", "()I", ref global::org.w3c.dom.DOMImplementationList_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.DOMImplementation org.w3c.dom.DOMImplementationList.item(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMImplementation>(this, global::org.w3c.dom.DOMImplementationList_.staticClass, "item", "(I)Lorg/w3c/dom/DOMImplementation;", ref global::org.w3c.dom.DOMImplementationList_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.DOMImplementation;
		}
		static DOMImplementationList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMImplementationList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMImplementationList"));
		}
	}
}
