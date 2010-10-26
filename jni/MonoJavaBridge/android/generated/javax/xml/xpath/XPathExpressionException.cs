namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathExpressionException : javax.xml.xpath.XPathException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathExpressionException()
		{
			InitJNI();
		}
		protected XPathExpressionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _XPathExpressionException31307;
		public XPathExpressionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathExpressionException.staticClass, global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XPathExpressionException31308;
		public XPathExpressionException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathExpressionException.staticClass, global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathExpressionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathExpressionException"));
			global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31307 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpressionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.xpath.XPathExpressionException._XPathExpressionException31308 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathExpressionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
