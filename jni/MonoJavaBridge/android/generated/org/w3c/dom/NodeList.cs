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
		static NodeList_()
		{
			InitJNI();
		}
		internal NodeList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34738;
		 int org.w3c.dom.NodeList.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.NodeList_._getLength34738);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.NodeList_.staticClass, global::org.w3c.dom.NodeList_._getLength34738);
		}
		internal static global::MonoJavaBridge.MethodId _item34739;
		 global::org.w3c.dom.Node org.w3c.dom.NodeList.item(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NodeList_._item34739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NodeList_.staticClass, global::org.w3c.dom.NodeList_._item34739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.NodeList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/NodeList"));
			global::org.w3c.dom.NodeList_._getLength34738 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NodeList_.staticClass, "getLength", "()I");
			global::org.w3c.dom.NodeList_._item34739 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NodeList_.staticClass, "item", "(I)Lorg/w3c/dom/Node;");
		}
	}
}
