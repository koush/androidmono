namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.Templates_))]
	public partial interface Templates  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.xml.transform.Transformer newTransformer();
		global::java.util.Properties getOutputProperties();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.Templates))]
	internal sealed partial class Templates_ : java.lang.Object, Templates
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Templates_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::javax.xml.transform.Transformer javax.xml.transform.Templates.newTransformer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.Templates_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;", ref global::javax.xml.transform.Templates_._m0) as javax.xml.transform.Transformer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.util.Properties javax.xml.transform.Templates.getOutputProperties()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.Templates_.staticClass, "getOutputProperties", "()Ljava/util/Properties;", ref global::javax.xml.transform.Templates_._m1) as java.util.Properties;
		}
		static Templates_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Templates_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Templates"));
		}
	}
}
