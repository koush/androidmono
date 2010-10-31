namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSResourceResolver_))]
	public partial interface LSResourceResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.ls.LSInput resolveResource(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSResourceResolver))]
	internal sealed partial class LSResourceResolver_ : java.lang.Object, LSResourceResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LSResourceResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.w3c.dom.ls.LSInput org.w3c.dom.ls.LSResourceResolver.resolveResource(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSInput>(this, global::org.w3c.dom.ls.LSResourceResolver_.staticClass, "resolveResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ls/LSInput;", ref global::org.w3c.dom.ls.LSResourceResolver_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as org.w3c.dom.ls.LSInput;
		}
		static LSResourceResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSResourceResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSResourceResolver"));
		}
	}
}
