namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.URLStreamHandlerFactory_))]
	public partial interface URLStreamHandlerFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.URLStreamHandler createURLStreamHandler(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLStreamHandlerFactory))]
	internal sealed partial class URLStreamHandlerFactory_ : java.lang.Object, URLStreamHandlerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URLStreamHandlerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createURLStreamHandler21990;
		global::java.net.URLStreamHandler java.net.URLStreamHandlerFactory.createURLStreamHandler(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLStreamHandlerFactory_.staticClass, "createURLStreamHandler", "(Ljava/lang/String;)Ljava/net/URLStreamHandler;", ref global::java.net.URLStreamHandlerFactory_._createURLStreamHandler21990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URLStreamHandler;
		}
		static URLStreamHandlerFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLStreamHandlerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLStreamHandlerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
