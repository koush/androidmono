namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.URLStreamHandlerFactory_))]
	public interface URLStreamHandlerFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.URLStreamHandler createURLStreamHandler(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLStreamHandlerFactory))]
	public sealed partial class URLStreamHandlerFactory_ : java.lang.Object, URLStreamHandlerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLStreamHandlerFactory_()
		{
			InitJNI();
		}
		internal URLStreamHandlerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createURLStreamHandler16277;
		 global::java.net.URLStreamHandler java.net.URLStreamHandlerFactory.createURLStreamHandler(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLStreamHandlerFactory_._createURLStreamHandler16277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLStreamHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLStreamHandlerFactory_.staticClass, global::java.net.URLStreamHandlerFactory_._createURLStreamHandler16277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLStreamHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLStreamHandlerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLStreamHandlerFactory"));
			global::java.net.URLStreamHandlerFactory_._createURLStreamHandler16277 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandlerFactory_.staticClass, "createURLStreamHandler", "(Ljava/lang/String;)Ljava/net/URLStreamHandler;");
		}
	}
}
