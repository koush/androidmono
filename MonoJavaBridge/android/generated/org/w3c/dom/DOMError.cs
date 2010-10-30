namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMError_))]
	public partial interface DOMError  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.DOMLocator getLocation();
		global::java.lang.String getMessage();
		global::java.lang.String getType();
		short getSeverity();
		global::java.lang.Object getRelatedException();
		global::java.lang.Object getRelatedData();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMError))]
	internal sealed partial class DOMError_ : java.lang.Object, DOMError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMError_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLocation34340;
		global::org.w3c.dom.DOMLocator org.w3c.dom.DOMError.getLocation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMLocator>(this, global::org.w3c.dom.DOMError_.staticClass, "getLocation", "()Lorg/w3c/dom/DOMLocator;", ref global::org.w3c.dom.DOMError_._getLocation34340) as org.w3c.dom.DOMLocator;
		}
		internal static global::MonoJavaBridge.MethodId _getMessage34341;
		global::java.lang.String org.w3c.dom.DOMError.getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DOMError_.staticClass, "getMessage", "()Ljava/lang/String;", ref global::org.w3c.dom.DOMError_._getMessage34341) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34342;
		global::java.lang.String org.w3c.dom.DOMError.getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DOMError_.staticClass, "getType", "()Ljava/lang/String;", ref global::org.w3c.dom.DOMError_._getType34342) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSeverity34343;
		short org.w3c.dom.DOMError.getSeverity()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.DOMError_.staticClass, "getSeverity", "()S", ref global::org.w3c.dom.DOMError_._getSeverity34343);
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedException34344;
		global::java.lang.Object org.w3c.dom.DOMError.getRelatedException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.DOMError_.staticClass, "getRelatedException", "()Ljava/lang/Object;", ref global::org.w3c.dom.DOMError_._getRelatedException34344) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedData34345;
		global::java.lang.Object org.w3c.dom.DOMError.getRelatedData()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.DOMError_.staticClass, "getRelatedData", "()Ljava/lang/Object;", ref global::org.w3c.dom.DOMError_._getRelatedData34345) as java.lang.Object;
		}
		static DOMError_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMError_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
