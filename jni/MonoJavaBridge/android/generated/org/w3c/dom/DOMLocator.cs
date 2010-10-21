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
		internal static global::MonoJavaBridge.MethodId _getLineNumber34258;
		 int org.w3c.dom.DOMLocator.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getLineNumber34258);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getLineNumber34258);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber34259;
		 int org.w3c.dom.DOMLocator.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getColumnNumber34259);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getColumnNumber34259);
		}
		internal static global::MonoJavaBridge.MethodId _getUri34260;
		 global::java.lang.String org.w3c.dom.DOMLocator.getUri() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getUri34260)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getUri34260)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedNode34261;
		 global::org.w3c.dom.Node org.w3c.dom.DOMLocator.getRelatedNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getRelatedNode34261)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getRelatedNode34261)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getByteOffset34262;
		 int org.w3c.dom.DOMLocator.getByteOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getByteOffset34262);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getByteOffset34262);
		}
		internal static global::MonoJavaBridge.MethodId _getUtf16Offset34263;
		 int org.w3c.dom.DOMLocator.getUtf16Offset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_._getUtf16Offset34263);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.DOMLocator_.staticClass, global::org.w3c.dom.DOMLocator_._getUtf16Offset34263);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMLocator"));
			global::org.w3c.dom.DOMLocator_._getLineNumber34258 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getLineNumber", "()I");
			global::org.w3c.dom.DOMLocator_._getColumnNumber34259 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getColumnNumber", "()I");
			global::org.w3c.dom.DOMLocator_._getUri34260 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getUri", "()Ljava/lang/String;");
			global::org.w3c.dom.DOMLocator_._getRelatedNode34261 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getRelatedNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DOMLocator_._getByteOffset34262 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getByteOffset", "()I");
			global::org.w3c.dom.DOMLocator_._getUtf16Offset34263 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMLocator_.staticClass, "getUtf16Offset", "()I");
		}
	}
}
