namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPathFunction_))]
	public interface XPathFunction  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object evaluate(java.util.List arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathFunction))]
	public sealed partial class XPathFunction_ : java.lang.Object, XPathFunction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathFunction_()
		{
			InitJNI();
		}
		internal XPathFunction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31211;
		 global::java.lang.Object javax.xml.xpath.XPathFunction.evaluate(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFunction_._evaluate31211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFunction_.staticClass, global::javax.xml.xpath.XPathFunction_._evaluate31211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFunction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFunction"));
			global::javax.xml.xpath.XPathFunction_._evaluate31211 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFunction_.staticClass, "evaluate", "(Ljava/util/List;)Ljava/lang/Object;");
		}
	}
}
