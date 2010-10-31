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
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.xml.transform.ErrorListener.fatalError(javax.xml.transform.TransformerException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.ErrorListener_.staticClass, "fatalError", "(Ljavax/xml/transform/TransformerException;)V", ref global::javax.xml.transform.ErrorListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.xml.transform.ErrorListener.error(javax.xml.transform.TransformerException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.ErrorListener_.staticClass, "error", "(Ljavax/xml/transform/TransformerException;)V", ref global::javax.xml.transform.ErrorListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.xml.transform.ErrorListener.warning(javax.xml.transform.TransformerException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.ErrorListener_.staticClass, "warning", "(Ljavax/xml/transform/TransformerException;)V", ref global::javax.xml.transform.ErrorListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ErrorListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.ErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/ErrorListener"));
		}
	}
}
