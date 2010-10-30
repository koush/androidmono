namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMImplementation_))]
	public partial interface DOMImplementation  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getFeature(java.lang.String arg0, java.lang.String arg1);
		bool hasFeature(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.DocumentType createDocumentType(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::org.w3c.dom.Document createDocument(java.lang.String arg0, java.lang.String arg1, org.w3c.dom.DocumentType arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMImplementation))]
	internal sealed partial class DOMImplementation_ : java.lang.Object, DOMImplementation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMImplementation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object org.w3c.dom.DOMImplementation.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.DOMImplementation_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.DOMImplementation_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool org.w3c.dom.DOMImplementation.hasFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DOMImplementation_.staticClass, "hasFeature", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.DOMImplementation_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.w3c.dom.DocumentType org.w3c.dom.DOMImplementation.createDocumentType(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DocumentType>(this, global::org.w3c.dom.DOMImplementation_.staticClass, "createDocumentType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/DocumentType;", ref global::org.w3c.dom.DOMImplementation_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.w3c.dom.DocumentType;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.w3c.dom.Document org.w3c.dom.DOMImplementation.createDocument(java.lang.String arg0, java.lang.String arg1, org.w3c.dom.DocumentType arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.DOMImplementation_.staticClass, "createDocument", "(Ljava/lang/String;Ljava/lang/String;Lorg/w3c/dom/DocumentType;)Lorg/w3c/dom/Document;", ref global::org.w3c.dom.DOMImplementation_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.w3c.dom.Document;
		}
		static DOMImplementation_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMImplementation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMImplementation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
