namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMErrorHandler_))]
	public partial interface DOMErrorHandler  : global::MonoJavaBridge.IJavaObject 
	{
		bool handleError(org.w3c.dom.DOMError arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMErrorHandler))]
	internal sealed partial class DOMErrorHandler_ : java.lang.Object, DOMErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMErrorHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handleError34349;
		bool org.w3c.dom.DOMErrorHandler.handleError(org.w3c.dom.DOMError arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DOMErrorHandler_.staticClass, "handleError", "(Lorg/w3c/dom/DOMError;)Z", ref global::org.w3c.dom.DOMErrorHandler_._handleError34349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DOMErrorHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMErrorHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMErrorHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
