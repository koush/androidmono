namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.ErrorListener_))]
	public partial interface ErrorListener  : global::MonoJavaBridge.IJavaObject 
	{
		void fatalError(javax.xml.transform.TransformerException arg0);
		void error(javax.xml.transform.TransformerException arg0);
		void warning(javax.xml.transform.TransformerException arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.ErrorListener))]
	internal sealed partial class ErrorListener_ : java.lang.Object, ErrorListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ErrorListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fatalError30934;
		void javax.xml.transform.ErrorListener.fatalError(javax.xml.transform.TransformerException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_._fatalError30934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error30935;
		void javax.xml.transform.ErrorListener.error(javax.xml.transform.TransformerException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_._error30935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning30936;
		void javax.xml.transform.ErrorListener.warning(javax.xml.transform.TransformerException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.ErrorListener_._warning30936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ErrorListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.ErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/ErrorListener"));
			global::javax.xml.transform.ErrorListener_._fatalError30934 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.ErrorListener_.staticClass, "fatalError", "(Ljavax/xml/transform/TransformerException;)V");
			global::javax.xml.transform.ErrorListener_._error30935 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.ErrorListener_.staticClass, "error", "(Ljavax/xml/transform/TransformerException;)V");
			global::javax.xml.transform.ErrorListener_._warning30936 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.ErrorListener_.staticClass, "warning", "(Ljavax/xml/transform/TransformerException;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
