namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.Locator_))]
	public partial interface Locator  : global::MonoJavaBridge.IJavaObject 
	{
		int getLineNumber();
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		int getColumnNumber();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.Locator))]
	internal sealed partial class Locator_ : java.lang.Object, Locator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Locator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.xml.sax.Locator.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.Locator_.staticClass, "getLineNumber", "()I", ref global::org.xml.sax.Locator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.xml.sax.Locator.getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Locator_.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.xml.sax.Locator_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.xml.sax.Locator.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Locator_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.xml.sax.Locator_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int org.xml.sax.Locator.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.Locator_.staticClass, "getColumnNumber", "()I", ref global::org.xml.sax.Locator_._m3);
		}
		static Locator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Locator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Locator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
