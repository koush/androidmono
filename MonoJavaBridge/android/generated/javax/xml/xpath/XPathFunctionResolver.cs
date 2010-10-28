namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPathFunctionResolver_))]
	public partial interface XPathFunctionResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.xml.xpath.XPathFunction resolveFunction(javax.xml.@namespace.QName arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathFunctionResolver))]
	internal sealed partial class XPathFunctionResolver_ : java.lang.Object, XPathFunctionResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XPathFunctionResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolveFunction31333;
		global::javax.xml.xpath.XPathFunction javax.xml.xpath.XPathFunctionResolver.resolveFunction(javax.xml.@namespace.QName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathFunction>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFunctionResolver_._resolveFunction31333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.xpath.XPathFunction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathFunction>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathFunctionResolver_.staticClass, global::javax.xml.xpath.XPathFunctionResolver_._resolveFunction31333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.xpath.XPathFunction;
		}
		static XPathFunctionResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFunctionResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFunctionResolver"));
			global::javax.xml.xpath.XPathFunctionResolver_._resolveFunction31333 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFunctionResolver_.staticClass, "resolveFunction", "(Ljavax/xml/namespace/QName;I)Ljavax/xml/xpath/XPathFunction;");
		}
		internal static void InitJNI()
		{
		}
	}
}
