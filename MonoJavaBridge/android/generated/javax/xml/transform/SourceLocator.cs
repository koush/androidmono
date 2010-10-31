namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.SourceLocator_))]
	public partial interface SourceLocator  : global::MonoJavaBridge.IJavaObject 
	{
		int getLineNumber();
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		int getColumnNumber();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.SourceLocator))]
	internal sealed partial class SourceLocator_ : java.lang.Object, SourceLocator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SourceLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int javax.xml.transform.SourceLocator.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.transform.SourceLocator_.staticClass, "getLineNumber", "()I", ref global::javax.xml.transform.SourceLocator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String javax.xml.transform.SourceLocator.getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.SourceLocator_.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::javax.xml.transform.SourceLocator_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String javax.xml.transform.SourceLocator.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.SourceLocator_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.SourceLocator_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int javax.xml.transform.SourceLocator.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.transform.SourceLocator_.staticClass, "getColumnNumber", "()I", ref global::javax.xml.transform.SourceLocator_._m3);
		}
		static SourceLocator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.SourceLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/SourceLocator"));
		}
	}
}
