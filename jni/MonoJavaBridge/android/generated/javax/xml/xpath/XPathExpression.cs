namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPathExpression_))]
	public interface XPathExpression  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object evaluate(java.lang.Object arg0, javax.xml.@namespace.QName arg1);
		global::java.lang.String evaluate(java.lang.Object arg0);
		global::java.lang.Object evaluate(org.xml.sax.InputSource arg0, javax.xml.@namespace.QName arg1);
		global::java.lang.String evaluate(org.xml.sax.InputSource arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPathExpression))]
	public sealed partial class XPathExpression_ : java.lang.Object, XPathExpression
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathExpression_()
		{
			InitJNI();
		}
		internal XPathExpression_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _evaluate24699;
		 global::java.lang.Object javax.xml.xpath.XPathExpression.evaluate(java.lang.Object arg0, javax.xml.@namespace.QName arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_._evaluate24699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_.staticClass, global::javax.xml.xpath.XPathExpression_._evaluate24699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate24700;
		 global::java.lang.String javax.xml.xpath.XPathExpression.evaluate(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_._evaluate24700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_.staticClass, global::javax.xml.xpath.XPathExpression_._evaluate24700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate24701;
		 global::java.lang.Object javax.xml.xpath.XPathExpression.evaluate(org.xml.sax.InputSource arg0, javax.xml.@namespace.QName arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_._evaluate24701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_.staticClass, global::javax.xml.xpath.XPathExpression_._evaluate24701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate24702;
		 global::java.lang.String javax.xml.xpath.XPathExpression.evaluate(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_._evaluate24702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathExpression_.staticClass, global::javax.xml.xpath.XPathExpression_._evaluate24702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathExpression_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathExpression"));
			global::javax.xml.xpath.XPathExpression_._evaluate24699 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Ljava/lang/Object;Ljavax/xml/@namespace/QName;)Ljava/lang/Object;");
			global::javax.xml.xpath.XPathExpression_._evaluate24700 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Ljava/lang/Object;)Ljava/lang/String;");
			global::javax.xml.xpath.XPathExpression_._evaluate24701 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Lorg/xml/sax/InputSource;Ljavax/xml/@namespace/QName;)Ljava/lang/Object;");
			global::javax.xml.xpath.XPathExpression_._evaluate24702 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpression_.staticClass, "evaluate", "(Lorg/xml/sax/InputSource;)Ljava/lang/String;");
		}
	}
}
