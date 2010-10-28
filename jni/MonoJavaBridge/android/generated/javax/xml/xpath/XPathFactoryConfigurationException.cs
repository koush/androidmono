namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathFactoryConfigurationException : javax.xml.xpath.XPathException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathFactoryConfigurationException()
		{
			InitJNI();
		}
		protected XPathFactoryConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _XPathFactoryConfigurationException31328;
		public XPathFactoryConfigurationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFactoryConfigurationException.staticClass, global::javax.xml.xpath.XPathFactoryConfigurationException._XPathFactoryConfigurationException31328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XPathFactoryConfigurationException31329;
		public XPathFactoryConfigurationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFactoryConfigurationException.staticClass, global::javax.xml.xpath.XPathFactoryConfigurationException._XPathFactoryConfigurationException31329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFactoryConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFactoryConfigurationException"));
			global::javax.xml.xpath.XPathFactoryConfigurationException._XPathFactoryConfigurationException31328 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactoryConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.xpath.XPathFactoryConfigurationException._XPathFactoryConfigurationException31329 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactoryConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
