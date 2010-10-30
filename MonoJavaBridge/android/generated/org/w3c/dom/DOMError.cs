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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMError_._getLocation34340.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMError_._getLocation34340 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getLocation", "()Lorg/w3c/dom/DOMLocator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMLocator>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getLocation34340)) as org.w3c.dom.DOMLocator;
		}
		internal static global::MonoJavaBridge.MethodId _getMessage34341;
		global::java.lang.String org.w3c.dom.DOMError.getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMError_._getMessage34341.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMError_._getMessage34341 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getMessage", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getMessage34341)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34342;
		global::java.lang.String org.w3c.dom.DOMError.getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMError_._getType34342.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMError_._getType34342 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getType34342)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSeverity34343;
		short org.w3c.dom.DOMError.getSeverity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMError_._getSeverity34343.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMError_._getSeverity34343 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getSeverity", "()S");
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getSeverity34343);
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedException34344;
		global::java.lang.Object org.w3c.dom.DOMError.getRelatedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMError_._getRelatedException34344.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMError_._getRelatedException34344 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getRelatedException", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getRelatedException34344)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedData34345;
		global::java.lang.Object org.w3c.dom.DOMError.getRelatedData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.DOMError_._getRelatedData34345.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.DOMError_._getRelatedData34345 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getRelatedData", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getRelatedData34345)) as java.lang.Object;
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
