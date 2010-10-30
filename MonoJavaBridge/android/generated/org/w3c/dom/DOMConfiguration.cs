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
		internal static global::MonoJavaBridge.MethodId _setParameter34336;
		void org.w3c.dom.DOMConfiguration.setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._setParameter34336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter34337;
		global::java.lang.Object org.w3c.dom.DOMConfiguration.getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._getParameter34337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _canSetParameter34338;
		bool org.w3c.dom.DOMConfiguration.canSetParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._canSetParameter34338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterNames34339;
		global::org.w3c.dom.DOMStringList org.w3c.dom.DOMConfiguration.getParameterNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMStringList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._getParameterNames34339)) as org.w3c.dom.DOMStringList;
		}
		static DOMConfiguration_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMConfiguration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMConfiguration"));
			global::org.w3c.dom.DOMConfiguration_._setParameter34336 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.w3c.dom.DOMConfiguration_._getParameter34337 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DOMConfiguration_._canSetParameter34338 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "canSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)Z");
			global::org.w3c.dom.DOMConfiguration_._getParameterNames34339 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "getParameterNames", "()Lorg/w3c/dom/DOMStringList;");
		}
		internal static void InitJNI()
		{
		}
	}
}
