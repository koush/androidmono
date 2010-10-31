namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.NodeList_))]
	public partial interface NodeList  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::org.w3c.dom.Node item(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.NodeList))]
	internal sealed partial class NodeList_ : java.lang.Object, NodeList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NodeList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.w3c.dom.NodeList.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.NodeList_.staticClass, "getLength", "()I", ref global::org.w3c.dom.NodeList_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.Node org.w3c.dom.NodeList.item(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NodeList_.staticClass, "item", "(I)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NodeList_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		static NodeList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.NodeList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/NodeList"));
		}
	}
}
