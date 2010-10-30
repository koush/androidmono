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
		internal static global::MonoJavaBridge.MethodId _newTransformer30957;
		global::javax.xml.transform.Transformer javax.xml.transform.Templates.newTransformer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Templates_._newTransformer30957.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Templates_._newTransformer30957 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Templates_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Templates_._newTransformer30957)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputProperties30958;
		global::java.util.Properties javax.xml.transform.Templates.getOutputProperties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Templates_._getOutputProperties30958.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Templates_._getOutputProperties30958 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Templates_.staticClass, "getOutputProperties", "()Ljava/util/Properties;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Templates_._getOutputProperties30958)) as java.util.Properties;
		}
		static Templates_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Templates_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Templates"));
		}
		internal static void InitJNI()
		{
		}
	}
}
