namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMConfiguration_))]
	public partial interface DOMConfiguration  : global::MonoJavaBridge.IJavaObject 
	{
		void setParameter(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getParameter(java.lang.String arg0);
		bool canSetParameter(java.lang.String arg0, java.lang.Object arg1);
		global::org.w3c.dom.DOMStringList getParameterNames();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMConfiguration))]
	internal sealed partial class DOMConfiguration_ : java.lang.Object, DOMConfiguration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMConfiguration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.w3c.dom.DOMConfiguration.setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.DOMConfiguration_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.w3c.dom.DOMConfiguration_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object org.w3c.dom.DOMConfiguration.getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.DOMConfiguration_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.DOMConfiguration_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool org.w3c.dom.DOMConfiguration.canSetParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DOMConfiguration_.staticClass, "canSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)Z", ref global::org.w3c.dom.DOMConfiguration_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.w3c.dom.DOMStringList org.w3c.dom.DOMConfiguration.getParameterNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMStringList>(this, global::org.w3c.dom.DOMConfiguration_.staticClass, "getParameterNames", "()Lorg/w3c/dom/DOMStringList;", ref global::org.w3c.dom.DOMConfiguration_._m3) as org.w3c.dom.DOMStringList;
		}
		static DOMConfiguration_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMConfiguration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMConfiguration"));
		}
		internal static void InitJNI()
		{
		}
	}
}
