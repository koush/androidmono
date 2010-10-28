namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathExpressionException : javax.xml.xpath.XPathException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XPathExpressionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _XPathExpressionException31308;
		public XPathExpressionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathExpressionException.staticClass, global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XPathExpressionException31309;
		public XPathExpressionException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathExpressionException.staticClass, global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static XPathExpressionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathExpressionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathExpressionException"));
			global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31308 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpressionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31309 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpressionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
