namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMStringList_))]
	public interface DOMStringList  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		bool contains(java.lang.String arg0);
		global::java.lang.String item(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMStringList))]
	public sealed partial class DOMStringList_ : java.lang.Object, DOMStringList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMStringList_()
		{
			InitJNI();
		}
		internal DOMStringList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength27553;
		 int org.w3c.dom.DOMStringList.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMStringList_._getLength27553);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMStringList_.staticClass, global::org.w3c.dom.DOMStringList_._getLength27553);
		}
		internal static global::MonoJavaBridge.MethodId _contains27554;
		 bool org.w3c.dom.DOMStringList.contains(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DOMStringList_._contains27554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DOMStringList_.staticClass, global::org.w3c.dom.DOMStringList_._contains27554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _item27555;
		 global::java.lang.String org.w3c.dom.DOMStringList.item(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMStringList_._item27555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMStringList_.staticClass, global::org.w3c.dom.DOMStringList_._item27555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMStringList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMStringList"));
			global::org.w3c.dom.DOMStringList_._getLength27553 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMStringList_.staticClass, "getLength", "()I");
			global::org.w3c.dom.DOMStringList_._contains27554 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMStringList_.staticClass, "contains", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.DOMStringList_._item27555 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMStringList_.staticClass, "item", "(I)Ljava/lang/String;");
		}
	}
}
