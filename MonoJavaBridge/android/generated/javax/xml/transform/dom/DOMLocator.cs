namespace javax.xml.transform.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.dom.DOMLocator_))]
	public partial interface DOMLocator : SourceLocator
	{
		global::org.w3c.dom.Node getOriginatingNode();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.dom.DOMLocator))]
	internal sealed partial class DOMLocator_ : java.lang.Object, DOMLocator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOriginatingNode31040;
		global::org.w3c.dom.Node javax.xml.transform.dom.DOMLocator.getOriginatingNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMLocator_._getOriginatingNode31040.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMLocator_._getOriginatingNode31040 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getOriginatingNode", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getOriginatingNode31040)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber31041;
		int javax.xml.transform.SourceLocator.getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMLocator_._getLineNumber31041.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMLocator_._getLineNumber31041 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getLineNumber", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getLineNumber31041);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId31042;
		global::java.lang.String javax.xml.transform.SourceLocator.getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMLocator_._getPublicId31042.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMLocator_._getPublicId31042 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getPublicId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getPublicId31042)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId31043;
		global::java.lang.String javax.xml.transform.SourceLocator.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMLocator_._getSystemId31043.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMLocator_._getSystemId31043 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getSystemId31043)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber31044;
		int javax.xml.transform.SourceLocator.getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMLocator_._getColumnNumber31044.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMLocator_._getColumnNumber31044 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getColumnNumber", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getColumnNumber31044);
		}
		static DOMLocator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.dom.DOMLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/dom/DOMLocator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
