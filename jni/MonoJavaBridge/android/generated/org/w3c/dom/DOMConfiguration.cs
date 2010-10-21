namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMConfiguration_))]
	public interface DOMConfiguration  : global::MonoJavaBridge.IJavaObject 
	{
		void setParameter(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getParameter(java.lang.String arg0);
		bool canSetParameter(java.lang.String arg0, java.lang.Object arg1);
		global::org.w3c.dom.DOMStringList getParameterNames();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMConfiguration))]
	public sealed partial class DOMConfiguration_ : java.lang.Object, DOMConfiguration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMConfiguration_()
		{
			InitJNI();
		}
		internal DOMConfiguration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setParameter34217;
		 void org.w3c.dom.DOMConfiguration.setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._setParameter34217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_.staticClass, global::org.w3c.dom.DOMConfiguration_._setParameter34217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter34218;
		 global::java.lang.Object org.w3c.dom.DOMConfiguration.getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._getParameter34218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_.staticClass, global::org.w3c.dom.DOMConfiguration_._getParameter34218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _canSetParameter34219;
		 bool org.w3c.dom.DOMConfiguration.canSetParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._canSetParameter34219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_.staticClass, global::org.w3c.dom.DOMConfiguration_._canSetParameter34219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterNames34220;
		 global::org.w3c.dom.DOMStringList org.w3c.dom.DOMConfiguration.getParameterNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMStringList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_._getParameterNames34220)) as org.w3c.dom.DOMStringList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMStringList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMConfiguration_.staticClass, global::org.w3c.dom.DOMConfiguration_._getParameterNames34220)) as org.w3c.dom.DOMStringList;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMConfiguration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMConfiguration"));
			global::org.w3c.dom.DOMConfiguration_._setParameter34217 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.w3c.dom.DOMConfiguration_._getParameter34218 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DOMConfiguration_._canSetParameter34219 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "canSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)Z");
			global::org.w3c.dom.DOMConfiguration_._getParameterNames34220 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMConfiguration_.staticClass, "getParameterNames", "()Lorg/w3c/dom/DOMStringList;");
		}
	}
}
