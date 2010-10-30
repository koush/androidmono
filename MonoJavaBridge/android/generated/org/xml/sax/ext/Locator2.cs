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
		internal static global::MonoJavaBridge.MethodId _getEncoding35137;
		global::java.lang.String org.xml.sax.ext.Locator2.getEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getEncoding35137)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getXMLVersion35138;
		global::java.lang.String org.xml.sax.ext.Locator2.getXMLVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getXMLVersion35138)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35139;
		int org.xml.sax.Locator.getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getLineNumber35139);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId35140;
		global::java.lang.String org.xml.sax.Locator.getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getPublicId35140)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId35141;
		global::java.lang.String org.xml.sax.Locator.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getSystemId35141)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35142;
		int org.xml.sax.Locator.getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getColumnNumber35142);
		}
		static Locator2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Locator2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Locator2"));
			global::org.xml.sax.ext.Locator2_._getEncoding35137 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getXMLVersion35138 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getXMLVersion", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getLineNumber35139 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getLineNumber", "()I");
			global::org.xml.sax.ext.Locator2_._getPublicId35140 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getSystemId35141 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getColumnNumber35142 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getColumnNumber", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
