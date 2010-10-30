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
	internal sealed partial class NameList_ : java.lang.Object, NameList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NameList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.w3c.dom.NameList.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.NameList_.staticClass, "getLength", "()I", ref global::org.w3c.dom.NameList_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.w3c.dom.NameList.getName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.NameList_.staticClass, "getName", "(I)Ljava/lang/String;", ref global::org.w3c.dom.NameList_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool org.w3c.dom.NameList.contains(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.NameList_.staticClass, "contains", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.NameList_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.w3c.dom.NameList.getNamespaceURI(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.NameList_.staticClass, "getNamespaceURI", "(I)Ljava/lang/String;", ref global::org.w3c.dom.NameList_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool org.w3c.dom.NameList.containsNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.NameList_.staticClass, "containsNS", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.NameList_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static NameList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.NameList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/NameList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
