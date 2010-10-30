namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPathExpression_))]
	public partial interface XPathExpression  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object evaluate(java.lang.Object arg0, javax.xml.@namespace.QName arg1);
		global::java.lang.String evaluate(java.lang.Object arg0);
		global::java.lang.Object evaluate(org.xml.sax.InputSource arg0, javax.xml.@namespace.QName arg1);
		global::java.lang.String evaluate(org.xml.sax.InputSource arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathExpression))]
	internal sealed partial class XPathExpression_ : java.lang.Object, XPathExpression
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XPathExpression_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object javax.xml.xpath.XPathExpression.evaluate(java.lang.Object arg0, javax.xml.@namespace.QName arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", ref global::javax.xml.xpath.XPathExpression_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String javax.xml.xpath.XPathExpression.evaluate(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Ljava/lang/Object;)Ljava/lang/String;", ref global::javax.xml.xpath.XPathExpression_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object javax.xml.xpath.XPathExpression.evaluate(org.xml.sax.InputSource arg0, javax.xml.@namespace.QName arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", ref global::javax.xml.xpath.XPathExpression_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String javax.xml.xpath.XPathExpression.evaluate(org.xml.sax.InputSource arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Lorg/xml/sax/InputSource;)Ljava/lang/String;", ref global::javax.xml.xpath.XPathExpression_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static XPathExpression_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathExpression_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathExpression"));
		}
		internal static void InitJNI()
		{
		}
	}
}
