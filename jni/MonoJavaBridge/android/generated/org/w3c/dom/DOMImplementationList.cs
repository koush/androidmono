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
		static DOMImplementationList_()
		{
			InitJNI();
		}
		internal DOMImplementationList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34372;
		int org.w3c.dom.DOMImplementationList.getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationList_._getLength34372);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationList_.staticClass, global::org.w3c.dom.DOMImplementationList_._getLength34372);
		}
		internal static global::MonoJavaBridge.MethodId _item34373;
		global::org.w3c.dom.DOMImplementation org.w3c.dom.DOMImplementationList.item(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationList_._item34373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationList_.staticClass, global::org.w3c.dom.DOMImplementationList_._item34373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementation;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMImplementationList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMImplementationList"));
			global::org.w3c.dom.DOMImplementationList_._getLength34372 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementationList_.staticClass, "getLength", "()I");
			global::org.w3c.dom.DOMImplementationList_._item34373 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementationList_.staticClass, "item", "(I)Lorg/w3c/dom/DOMImplementation;");
		}
	}
}
