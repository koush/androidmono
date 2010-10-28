namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ErrorHandler_))]
	public partial interface ErrorHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void fatalError(org.xml.sax.SAXParseException arg0);
		void error(org.xml.sax.SAXParseException arg0);
		void warning(org.xml.sax.SAXParseException arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ErrorHandler))]
	internal sealed partial class ErrorHandler_ : java.lang.Object, ErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ErrorHandler_()
		{
			InitJNI();
		}
		internal ErrorHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fatalError34984;
		void org.xml.sax.ErrorHandler.fatalError(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ErrorHandler_._fatalError34984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ErrorHandler_.staticClass, global::org.xml.sax.ErrorHandler_._fatalError34984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error34985;
		void org.xml.sax.ErrorHandler.error(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ErrorHandler_._error34985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ErrorHandler_.staticClass, global::org.xml.sax.ErrorHandler_._error34985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning34986;
		void org.xml.sax.ErrorHandler.warning(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ErrorHandler_._warning34986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ErrorHandler_.staticClass, global::org.xml.sax.ErrorHandler_._warning34986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ErrorHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ErrorHandler"));
			global::org.xml.sax.ErrorHandler_._fatalError34984 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ErrorHandler_.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.ErrorHandler_._error34985 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ErrorHandler_.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.ErrorHandler_._warning34986 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ErrorHandler_.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V");
		}
	}
}
