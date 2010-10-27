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
		static SourceLocator_()
		{
			InitJNI();
		}
		internal SourceLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber30952;
		int javax.xml.transform.SourceLocator.getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getLineNumber30952);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getLineNumber30952);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId30953;
		global::java.lang.String javax.xml.transform.SourceLocator.getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getPublicId30953)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getPublicId30953)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId30954;
		global::java.lang.String javax.xml.transform.SourceLocator.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getSystemId30954)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getSystemId30954)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber30955;
		int javax.xml.transform.SourceLocator.getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getColumnNumber30955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getColumnNumber30955);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.SourceLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/SourceLocator"));
			global::javax.xml.transform.SourceLocator_._getLineNumber30952 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getLineNumber", "()I");
			global::javax.xml.transform.SourceLocator_._getPublicId30953 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::javax.xml.transform.SourceLocator_._getSystemId30954 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.SourceLocator_._getColumnNumber30955 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getColumnNumber", "()I");
		}
	}
}
