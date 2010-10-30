namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathFactoryConfigurationException : javax.xml.xpath.XPathException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XPathFactoryConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public XPathFactoryConfigurationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactoryConfigurationException._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactoryConfigurationException._m0 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactoryConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFactoryConfigurationException.staticClass, global::javax.xml.xpath.XPathFactoryConfigurationException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public XPathFactoryConfigurationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathFactoryConfigurationException._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathFactoryConfigurationException._m1 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathFactoryConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathFactoryConfigurationException.staticClass, global::javax.xml.xpath.XPathFactoryConfigurationException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static XPathFactoryConfigurationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathFactoryConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathFactoryConfigurationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
