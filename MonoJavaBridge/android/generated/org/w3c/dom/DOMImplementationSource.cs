namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMImplementationSource_))]
	public partial interface DOMImplementationSource  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.DOMImplementation getDOMImplementation(java.lang.String arg0);
		global::org.w3c.dom.DOMImplementationList getDOMImplementationList(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMImplementationSource))]
	internal sealed partial class DOMImplementationSource_ : java.lang.Object, DOMImplementationSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMImplementationSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation34375;
		global::org.w3c.dom.DOMImplementation org.w3c.dom.DOMImplementationSource.getDOMImplementation(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMImplementationSource_._getDOMImplementation34375.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMImplementationSource_._getDOMImplementation34375 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementationSource_.staticClass, "getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationSource_._getDOMImplementation34375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementation;
		}
		internal static global::MonoJavaBridge.MethodId _getDOMImplementationList34376;
		global::org.w3c.dom.DOMImplementationList org.w3c.dom.DOMImplementationSource.getDOMImplementationList(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMImplementationSource_._getDOMImplementationList34376.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMImplementationSource_._getDOMImplementationList34376 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementationSource_.staticClass, "getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementationList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationSource_._getDOMImplementationList34376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementationList;
		}
		static DOMImplementationSource_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMImplementationSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMImplementationSource"));
		}
		internal static void InitJNI()
		{
		}
	}
}
