namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMLocator_))]
	public interface DOMLocator  : global::MonoJavaBridge.IJavaObject 
	{
		int getLineNumber();
		int getColumnNumber();
		global::java.lang.String getUri();
		global::org.w3c.dom.Node getRelatedNode();
		int getByteOffset();
		int getUtf16Offset();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMLocator))]
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
		internal static global::MonoJavaBridge.MethodId _getLineNumber27547;
		 int org.w3c.dom.DOMLocator.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getLineNumber27547);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getLineNumber27547);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber27548;
		 int org.w3c.dom.DOMLocator.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getColumnNumber27548);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getColumnNumber27548);
		}
		internal static global::MonoJavaBridge.MethodId _getUri27549;
		 global::java.lang.String org.w3c.dom.DOMLocator.getUri() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getUri27549)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getUri27549)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedNode27550;
		 global::org.w3c.dom.Node org.w3c.dom.DOMLocator.getRelatedNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getRelatedNode27550)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getRelatedNode27550)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getByteOffset27551;
		 int org.w3c.dom.DOMLocator.getByteOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getByteOffset27551);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getByteOffset27551);
		}
		internal static global::MonoJavaBridge.MethodId _getUtf16Offset27552;
		 int org.w3c.dom.DOMLocator.getUtf16Offset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getUtf16Offset27552);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getUtf16Offset27552);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMLocator"));
			global::org.w3c.dom.DOMLocator_._getLineNumber27547 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getLineNumber", "()I");
			global::org.w3c.dom.DOMLocator_._getColumnNumber27548 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getColumnNumber", "()I");
			global::org.w3c.dom.DOMLocator_._getUri27549 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getUri", "()Ljava/lang/String;");
			global::org.w3c.dom.DOMLocator_._getRelatedNode27550 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getRelatedNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DOMLocator_._getByteOffset27551 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getByteOffset", "()I");
			global::org.w3c.dom.DOMLocator_._getUtf16Offset27552 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getUtf16Offset", "()I");
		}
	}
}
