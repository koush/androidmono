namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSSerializer_))]
	public partial interface LSSerializer  : global::MonoJavaBridge.IJavaObject 
	{
		bool write(org.w3c.dom.Node arg0, org.w3c.dom.ls.LSOutput arg1);
		global::org.w3c.dom.DOMConfiguration getDomConfig();
		global::java.lang.String getNewLine();
		void setNewLine(java.lang.String arg0);
		bool writeToURI(org.w3c.dom.Node arg0, java.lang.String arg1);
		global::java.lang.String writeToString(org.w3c.dom.Node arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSSerializer))]
	internal sealed partial class LSSerializer_ : java.lang.Object, LSSerializer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LSSerializer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool org.w3c.dom.ls.LSSerializer.write(org.w3c.dom.Node arg0, org.w3c.dom.ls.LSOutput arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "write", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/ls/LSOutput;)Z", ref global::org.w3c.dom.ls.LSSerializer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.ls.LSSerializer.getDomConfig()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMConfiguration>(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", ref global::org.w3c.dom.ls.LSSerializer_._m1) as org.w3c.dom.DOMConfiguration;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.w3c.dom.ls.LSSerializer.getNewLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "getNewLine", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSSerializer_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.w3c.dom.ls.LSSerializer.setNewLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "setNewLine", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSSerializer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool org.w3c.dom.ls.LSSerializer.writeToURI(org.w3c.dom.Node arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "writeToURI", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Z", ref global::org.w3c.dom.ls.LSSerializer_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String org.w3c.dom.ls.LSSerializer.writeToString(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "writeToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", ref global::org.w3c.dom.ls.LSSerializer_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static LSSerializer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSSerializer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSSerializer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
