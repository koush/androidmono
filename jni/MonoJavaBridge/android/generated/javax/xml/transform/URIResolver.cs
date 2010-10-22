namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.URIResolver_))]
	public partial interface URIResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.xml.transform.Source resolve(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.URIResolver))]
	public sealed partial class URIResolver_ : java.lang.Object, URIResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URIResolver_()
		{
			InitJNI();
		}
		internal URIResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolve30920;
		 global::javax.xml.transform.Source javax.xml.transform.URIResolver.resolve(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Source>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.URIResolver_._resolve30920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.transform.Source;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Source>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.URIResolver_.staticClass, global::javax.xml.transform.URIResolver_._resolve30920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.transform.Source;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.URIResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/URIResolver"));
			global::javax.xml.transform.URIResolver_._resolve30920 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.URIResolver_.staticClass, "resolve", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;");
		}
	}
}
