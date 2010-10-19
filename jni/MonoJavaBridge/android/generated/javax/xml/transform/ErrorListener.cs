namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.ErrorListener_))]
	public interface ErrorListener  : global::MonoJavaBridge.IJavaObject 
	{
		void fatalError(javax.xml.transform.TransformerException arg0);
		void error(javax.xml.transform.TransformerException arg0);
		void warning(javax.xml.transform.TransformerException arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.ErrorListener))]
	public sealed partial class ErrorListener_ : java.lang.Object, ErrorListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ErrorListener_()
		{
			InitJNI();
		}
		internal ErrorListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fatalError24350;
		 void javax.xml.transform.ErrorListener.fatalError(javax.xml.transform.TransformerException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_._fatalError24350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_.staticClass, global::javax.xml.transform.ErrorListener_._fatalError24350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error24351;
		 void javax.xml.transform.ErrorListener.error(javax.xml.transform.TransformerException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_._error24351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_.staticClass, global::javax.xml.transform.ErrorListener_._error24351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning24352;
		 void javax.xml.transform.ErrorListener.warning(javax.xml.transform.TransformerException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_._warning24352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_.staticClass, global::javax.xml.transform.ErrorListener_._warning24352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.ErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/ErrorListener"));
			global::javax.xml.transform.ErrorListener_._fatalError24350 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.ErrorListener_.staticClass, "fatalError", "(Ljavax/xml/transform/TransformerException;)V");
			global::javax.xml.transform.ErrorListener_._error24351 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.ErrorListener_.staticClass, "error", "(Ljavax/xml/transform/TransformerException;)V");
			global::javax.xml.transform.ErrorListener_._warning24352 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.ErrorListener_.staticClass, "warning", "(Ljavax/xml/transform/TransformerException;)V");
		}
	}
}
