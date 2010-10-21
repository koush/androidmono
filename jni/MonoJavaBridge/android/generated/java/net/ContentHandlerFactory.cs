namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.ContentHandlerFactory_))]
	public interface ContentHandlerFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.ContentHandler createContentHandler(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ContentHandlerFactory))]
	public sealed partial class ContentHandlerFactory_ : java.lang.Object, ContentHandlerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentHandlerFactory_()
		{
			InitJNI();
		}
		internal ContentHandlerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createContentHandler21246;
		 global::java.net.ContentHandler java.net.ContentHandlerFactory.createContentHandler(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ContentHandlerFactory_._createContentHandler21246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ContentHandlerFactory_.staticClass, global::java.net.ContentHandlerFactory_._createContentHandler21246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ContentHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ContentHandlerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ContentHandlerFactory"));
			global::java.net.ContentHandlerFactory_._createContentHandler21246 = @__env.GetMethodIDNoThrow(global::java.net.ContentHandlerFactory_.staticClass, "createContentHandler", "(Ljava/lang/String;)Ljava/net/ContentHandler;");
		}
	}
}
