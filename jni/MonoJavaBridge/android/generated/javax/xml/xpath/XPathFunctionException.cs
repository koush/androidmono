namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathFunctionException : javax.xml.xpath.XPathExpressionException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathFunctionException()
		{
			InitJNI();
		}
		protected XPathFunctionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _XPathFunctionException24724;
		public XPathFunctionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFunctionException.staticClass, global::javax.xml.xpath.XPathFunctionException._XPathFunctionException24724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XPathFunctionException24725;
		public XPathFunctionException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFunctionException.staticClass, global::javax.xml.xpath.XPathFunctionException._XPathFunctionException24725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFunctionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFunctionException"));
			global::javax.xml.xpath.XPathFunctionException._XPathFunctionException24724 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFunctionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.xpath.XPathFunctionException._XPathFunctionException24725 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFunctionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
