namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMLocator_))]
	public partial interface DOMLocator  : global::MonoJavaBridge.IJavaObject 
	{
		int getLineNumber();
		int getColumnNumber();
		global::java.lang.String getUri();
		global::org.w3c.dom.Node getRelatedNode();
		int getByteOffset();
		int getUtf16Offset();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMLocator))]
	internal sealed partial class DOMLocator_ : java.lang.Object, DOMLocator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber34377;
		int org.w3c.dom.DOMLocator.getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getLineNumber34377);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber34378;
		int org.w3c.dom.DOMLocator.getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getColumnNumber34378);
		}
		internal static global::MonoJavaBridge.MethodId _getUri34379;
		global::java.lang.String org.w3c.dom.DOMLocator.getUri()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getUri34379)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedNode34380;
		global::org.w3c.dom.Node org.w3c.dom.DOMLocator.getRelatedNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getRelatedNode34380)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getByteOffset34381;
		int org.w3c.dom.DOMLocator.getByteOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getByteOffset34381);
		}
		internal static global::MonoJavaBridge.MethodId _getUtf16Offset34382;
		int org.w3c.dom.DOMLocator.getUtf16Offset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getUtf16Offset34382);
		}
		static DOMLocator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMLocator"));
			global::org.w3c.dom.DOMLocator_._getLineNumber34377 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getLineNumber", "()I");
			global::org.w3c.dom.DOMLocator_._getColumnNumber34378 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getColumnNumber", "()I");
			global::org.w3c.dom.DOMLocator_._getUri34379 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getUri", "()Ljava/lang/String;");
			global::org.w3c.dom.DOMLocator_._getRelatedNode34380 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getRelatedNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DOMLocator_._getByteOffset34381 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getByteOffset", "()I");
			global::org.w3c.dom.DOMLocator_._getUtf16Offset34382 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getUtf16Offset", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
