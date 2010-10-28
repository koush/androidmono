namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.NamedNodeMap_))]
	public partial interface NamedNodeMap  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::org.w3c.dom.Node item(int arg0);
		global::org.w3c.dom.Node getNamedItem(java.lang.String arg0);
		global::org.w3c.dom.Node setNamedItem(org.w3c.dom.Node arg0);
		global::org.w3c.dom.Node removeNamedItem(java.lang.String arg0);
		global::org.w3c.dom.Node getNamedItemNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Node setNamedItemNS(org.w3c.dom.Node arg0);
		global::org.w3c.dom.Node removeNamedItemNS(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.NamedNodeMap))]
	internal sealed partial class NamedNodeMap_ : java.lang.Object, NamedNodeMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NamedNodeMap_()
		{
			InitJNI();
		}
		internal NamedNodeMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34676;
		int org.w3c.dom.NamedNodeMap.getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._getLength34676);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._getLength34676);
		}
		internal static global::MonoJavaBridge.MethodId _item34677;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.item(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._item34677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._item34677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNamedItem34678;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.getNamedItem(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._getNamedItem34678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._getNamedItem34678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setNamedItem34679;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.setNamedItem(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._setNamedItem34679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._setNamedItem34679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeNamedItem34680;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.removeNamedItem(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._removeNamedItem34680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._removeNamedItem34680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNamedItemNS34681;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.getNamedItemNS(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._getNamedItemNS34681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._getNamedItemNS34681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setNamedItemNS34682;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.setNamedItemNS(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._setNamedItemNS34682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._setNamedItemNS34682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeNamedItemNS34683;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.removeNamedItemNS(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_._removeNamedItemNS34683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NamedNodeMap_.staticClass, global::org.w3c.dom.NamedNodeMap_._removeNamedItemNS34683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.NamedNodeMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/NamedNodeMap"));
			global::org.w3c.dom.NamedNodeMap_._getLength34676 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "getLength", "()I");
			global::org.w3c.dom.NamedNodeMap_._item34677 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "item", "(I)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.NamedNodeMap_._getNamedItem34678 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "getNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.NamedNodeMap_._setNamedItem34679 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "setNamedItem", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.NamedNodeMap_._removeNamedItem34680 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "removeNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.NamedNodeMap_._getNamedItemNS34681 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "getNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.NamedNodeMap_._setNamedItemNS34682 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "setNamedItemNS", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.NamedNodeMap_._removeNamedItemNS34683 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NamedNodeMap_.staticClass, "removeNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;");
		}
	}
}
