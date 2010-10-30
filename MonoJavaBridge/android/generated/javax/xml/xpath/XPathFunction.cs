namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPathFunction_))]
	public partial interface XPathFunction  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object evaluate(java.util.List arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathFunction))]
	internal sealed partial class XPathFunction_ : java.lang.Object, XPathFunction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XPathFunction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31330;
		global::java.lang.Object javax.xml.xpath.XPathFunction.evaluate(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFunction_._evaluate31330.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFunction_._evaluate31330 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFunction_.staticClass, "evaluate", "(Ljava/util/List;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFunction_._evaluate31330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static XPathFunction_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFunction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFunction"));
		}
		internal static void InitJNI()
		{
		}
	}
}
