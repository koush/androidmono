namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.SourceLocator_))]
	public interface SourceLocator  : global::MonoJavaBridge.IJavaObject 
	{
		int getLineNumber();
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		int getColumnNumber();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.SourceLocator))]
	public sealed partial class SourceLocator_ : java.lang.Object, SourceLocator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SourceLocator_()
		{
			InitJNI();
		}
		internal SourceLocator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber30834;
		 int javax.xml.transform.SourceLocator.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getLineNumber30834);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getLineNumber30834);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId30835;
		 global::java.lang.String javax.xml.transform.SourceLocator.getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getPublicId30835)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getPublicId30835)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId30836;
		 global::java.lang.String javax.xml.transform.SourceLocator.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getSystemId30836)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getSystemId30836)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber30837;
		 int javax.xml.transform.SourceLocator.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_._getColumnNumber30837);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.transform.SourceLocator_.staticClass, global::javax.xml.transform.SourceLocator_._getColumnNumber30837);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.SourceLocator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/SourceLocator"));
			global::javax.xml.transform.SourceLocator_._getLineNumber30834 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getLineNumber", "()I");
			global::javax.xml.transform.SourceLocator_._getPublicId30835 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::javax.xml.transform.SourceLocator_._getSystemId30836 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.SourceLocator_._getColumnNumber30837 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.SourceLocator_.staticClass, "getColumnNumber", "()I");
		}
	}
}
