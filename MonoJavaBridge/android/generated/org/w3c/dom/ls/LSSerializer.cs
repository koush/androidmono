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
		internal static global::MonoJavaBridge.MethodId _write34938;
		bool org.w3c.dom.ls.LSSerializer.write(org.w3c.dom.Node arg0, org.w3c.dom.ls.LSOutput arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "write", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/ls/LSOutput;)Z", ref global::org.w3c.dom.ls.LSSerializer_._write34938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig34939;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.ls.LSSerializer.getDomConfig()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMConfiguration>(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", ref global::org.w3c.dom.ls.LSSerializer_._getDomConfig34939) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _getNewLine34940;
		global::java.lang.String org.w3c.dom.ls.LSSerializer.getNewLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "getNewLine", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSSerializer_._getNewLine34940) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNewLine34941;
		void org.w3c.dom.ls.LSSerializer.setNewLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "setNewLine", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSSerializer_._setNewLine34941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToURI34942;
		bool org.w3c.dom.ls.LSSerializer.writeToURI(org.w3c.dom.Node arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "writeToURI", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Z", ref global::org.w3c.dom.ls.LSSerializer_._writeToURI34942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToString34943;
		global::java.lang.String org.w3c.dom.ls.LSSerializer.writeToString(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSSerializer_.staticClass, "writeToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", ref global::org.w3c.dom.ls.LSSerializer_._writeToString34943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
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
