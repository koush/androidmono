namespace javax.xml.transform.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.dom.DOMLocator_))]
	public interface DOMLocator : SourceLocator
	{
		global::org.w3c.dom.Node getOriginatingNode();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.dom.DOMLocator))]
	public sealed partial class DOMLocator_ : java.lang.Object, DOMLocator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMLocator_()
		{
			InitJNI();
		}
		internal DOMLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOriginatingNode24444;
		 global::org.w3c.dom.Node javax.xml.transform.dom.DOMLocator.getOriginatingNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getOriginatingNode24444)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_.staticClass, global::javax.xml.transform.dom.DOMLocator_._getOriginatingNode24444)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber24445;
		 int javax.xml.transform.SourceLocator.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getLineNumber24445);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_.staticClass, global::javax.xml.transform.dom.DOMLocator_._getLineNumber24445);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId24446;
		 global::java.lang.String javax.xml.transform.SourceLocator.getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getPublicId24446)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_.staticClass, global::javax.xml.transform.dom.DOMLocator_._getPublicId24446)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId24447;
		 global::java.lang.String javax.xml.transform.SourceLocator.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getSystemId24447)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_.staticClass, global::javax.xml.transform.dom.DOMLocator_._getSystemId24447)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber24448;
		 int javax.xml.transform.SourceLocator.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_._getColumnNumber24448);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMLocator_.staticClass, global::javax.xml.transform.dom.DOMLocator_._getColumnNumber24448);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.dom.DOMLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/dom/DOMLocator"));
			global::javax.xml.transform.dom.DOMLocator_._getOriginatingNode24444 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getOriginatingNode", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMLocator_._getLineNumber24445 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getLineNumber", "()I");
			global::javax.xml.transform.dom.DOMLocator_._getPublicId24446 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMLocator_._getSystemId24447 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMLocator_._getColumnNumber24448 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMLocator_.staticClass, "getColumnNumber", "()I");
		}
	}
}
