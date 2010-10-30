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
		internal static global::MonoJavaBridge.MethodId _getFeature34369;
		global::java.lang.Object org.w3c.dom.DOMImplementation.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMImplementation_._getFeature34369.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMImplementation_._getFeature34369 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementation_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementation_._getFeature34369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _hasFeature34370;
		bool org.w3c.dom.DOMImplementation.hasFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMImplementation_._hasFeature34370.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMImplementation_._hasFeature34370 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementation_.staticClass, "hasFeature", "(Ljava/lang/String;Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementation_._hasFeature34370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createDocumentType34371;
		global::org.w3c.dom.DocumentType org.w3c.dom.DOMImplementation.createDocumentType(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMImplementation_._createDocumentType34371.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMImplementation_._createDocumentType34371 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementation_.staticClass, "createDocumentType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/DocumentType;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentType>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementation_._createDocumentType34371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.DocumentType;
		}
		internal static global::MonoJavaBridge.MethodId _createDocument34372;
		global::org.w3c.dom.Document org.w3c.dom.DOMImplementation.createDocument(java.lang.String arg0, java.lang.String arg1, org.w3c.dom.DocumentType arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMImplementation_._createDocument34372.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMImplementation_._createDocument34372 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementation_.staticClass, "createDocument", "(Ljava/lang/String;Ljava/lang/String;Lorg/w3c/dom/DocumentType;)Lorg/w3c/dom/Document;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementation_._createDocument34372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Document;
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
