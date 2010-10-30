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
		internal static global::MonoJavaBridge.MethodId _getLineNumber30953;
		int javax.xml.transform.SourceLocator.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.transform.SourceLocator_.staticClass, "getLineNumber", "()I", ref global::javax.xml.transform.SourceLocator_._getLineNumber30953);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId30954;
		global::java.lang.String javax.xml.transform.SourceLocator.getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.SourceLocator_.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::javax.xml.transform.SourceLocator_._getPublicId30954) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId30955;
		global::java.lang.String javax.xml.transform.SourceLocator.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.SourceLocator_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.SourceLocator_._getSystemId30955) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber30956;
		int javax.xml.transform.SourceLocator.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.transform.SourceLocator_.staticClass, "getColumnNumber", "()I", ref global::javax.xml.transform.SourceLocator_._getColumnNumber30956);
		}
		static SourceLocator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.SourceLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/SourceLocator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
