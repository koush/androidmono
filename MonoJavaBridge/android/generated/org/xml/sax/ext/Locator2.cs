namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.Locator2_))]
	public partial interface Locator2 : Locator
	{
		global::java.lang.String getEncoding();
		global::java.lang.String getXMLVersion();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.Locator2))]
	internal sealed partial class Locator2_ : java.lang.Object, Locator2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Locator2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.xml.sax.ext.Locator2.getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2_.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.xml.sax.ext.Locator2.getXMLVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2_.staticClass, "getXMLVersion", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int org.xml.sax.Locator.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.ext.Locator2_.staticClass, "getLineNumber", "()I", ref global::org.xml.sax.ext.Locator2_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.xml.sax.Locator.getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2_.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String org.xml.sax.Locator.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int org.xml.sax.Locator.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.ext.Locator2_.staticClass, "getColumnNumber", "()I", ref global::org.xml.sax.ext.Locator2_._m5);
		}
		static Locator2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Locator2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Locator2"));
		}
	}
}
