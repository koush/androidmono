namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSResourceResolver_))]
	public partial interface LSResourceResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.ls.LSInput resolveResource(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSResourceResolver))]
	public sealed partial class LSResourceResolver_ : java.lang.Object, LSResourceResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LSResourceResolver_()
		{
			InitJNI();
		}
		internal LSResourceResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolveResource34818;
		 global::org.w3c.dom.ls.LSInput org.w3c.dom.ls.LSResourceResolver.resolveResource(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSInput>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSResourceResolver_._resolveResource34818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as org.w3c.dom.ls.LSInput;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSInput>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSResourceResolver_.staticClass, global::org.w3c.dom.ls.LSResourceResolver_._resolveResource34818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as org.w3c.dom.ls.LSInput;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSResourceResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSResourceResolver"));
			global::org.w3c.dom.ls.LSResourceResolver_._resolveResource34818 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSResourceResolver_.staticClass, "resolveResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ls/LSInput;");
		}
	}
}
