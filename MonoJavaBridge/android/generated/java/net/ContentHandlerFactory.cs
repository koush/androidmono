namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.ContentHandlerFactory_))]
	public partial interface ContentHandlerFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.ContentHandler createContentHandler(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ContentHandlerFactory))]
	internal sealed partial class ContentHandlerFactory_ : java.lang.Object, ContentHandlerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentHandlerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createContentHandler21365;
		global::java.net.ContentHandler java.net.ContentHandlerFactory.createContentHandler(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ContentHandlerFactory_.staticClass, "createContentHandler", "(Ljava/lang/String;)Ljava/net/ContentHandler;", ref global::java.net.ContentHandlerFactory_._createContentHandler21365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.ContentHandler;
		}
		static ContentHandlerFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ContentHandlerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ContentHandlerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
