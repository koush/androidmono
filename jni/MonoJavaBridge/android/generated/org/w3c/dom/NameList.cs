namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.NameList_))]
	public partial interface NameList  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::java.lang.String getName(int arg0);
		bool contains(java.lang.String arg0);
		global::java.lang.String getNamespaceURI(int arg0);
		bool containsNS(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.NameList))]
	public sealed partial class NameList_ : java.lang.Object, NameList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NameList_()
		{
			InitJNI();
		}
		internal NameList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34552;
		 int org.w3c.dom.NameList.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.NameList_._getLength34552);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.NameList_.staticClass, global::org.w3c.dom.NameList_._getLength34552);
		}
		internal static global::MonoJavaBridge.MethodId _getName34553;
		 global::java.lang.String org.w3c.dom.NameList.getName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NameList_._getName34553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NameList_.staticClass, global::org.w3c.dom.NameList_._getName34553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _contains34554;
		 bool org.w3c.dom.NameList.contains(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.NameList_._contains34554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.NameList_.staticClass, global::org.w3c.dom.NameList_._contains34554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34555;
		 global::java.lang.String org.w3c.dom.NameList.getNamespaceURI(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.NameList_._getNamespaceURI34555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.NameList_.staticClass, global::org.w3c.dom.NameList_._getNamespaceURI34555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _containsNS34556;
		 bool org.w3c.dom.NameList.containsNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.NameList_._containsNS34556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.NameList_.staticClass, global::org.w3c.dom.NameList_._containsNS34556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.NameList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/NameList"));
			global::org.w3c.dom.NameList_._getLength34552 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NameList_.staticClass, "getLength", "()I");
			global::org.w3c.dom.NameList_._getName34553 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NameList_.staticClass, "getName", "(I)Ljava/lang/String;");
			global::org.w3c.dom.NameList_._contains34554 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NameList_.staticClass, "contains", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.NameList_._getNamespaceURI34555 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NameList_.staticClass, "getNamespaceURI", "(I)Ljava/lang/String;");
			global::org.w3c.dom.NameList_._containsNS34556 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.NameList_.staticClass, "containsNS", "(Ljava/lang/String;Ljava/lang/String;)Z");
		}
	}
}
