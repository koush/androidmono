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
		static Locator_()
		{
			InitJNI();
		}
		internal Locator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35016;
		int org.xml.sax.Locator.getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Locator_._getLineNumber35016);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Locator_.staticClass, global::org.xml.sax.Locator_._getLineNumber35016);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId35017;
		global::java.lang.String org.xml.sax.Locator.getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Locator_._getPublicId35017)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Locator_.staticClass, global::org.xml.sax.Locator_._getPublicId35017)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId35018;
		global::java.lang.String org.xml.sax.Locator.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Locator_._getSystemId35018)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Locator_.staticClass, global::org.xml.sax.Locator_._getSystemId35018)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35019;
		int org.xml.sax.Locator.getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Locator_._getColumnNumber35019);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Locator_.staticClass, global::org.xml.sax.Locator_._getColumnNumber35019);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Locator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Locator"));
			global::org.xml.sax.Locator_._getLineNumber35016 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Locator_.staticClass, "getLineNumber", "()I");
			global::org.xml.sax.Locator_._getPublicId35017 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Locator_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.Locator_._getSystemId35018 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Locator_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.Locator_._getColumnNumber35019 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Locator_.staticClass, "getColumnNumber", "()I");
		}
	}
}
