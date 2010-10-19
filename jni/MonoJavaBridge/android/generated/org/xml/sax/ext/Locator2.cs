namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.Locator2_))]
	public interface Locator2 : Locator
	{
		global::java.lang.String getEncoding();
		global::java.lang.String getXMLVersion();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.Locator2))]
	public sealed partial class Locator2_ : java.lang.Object, Locator2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Locator2_()
		{
			InitJNI();
		}
		internal Locator2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding28267;
		 global::java.lang.String org.xml.sax.ext.Locator2.getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getEncoding28267)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_.staticClass, global::org.xml.sax.ext.Locator2_._getEncoding28267)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getXMLVersion28268;
		 global::java.lang.String org.xml.sax.ext.Locator2.getXMLVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getXMLVersion28268)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_.staticClass, global::org.xml.sax.ext.Locator2_._getXMLVersion28268)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber28269;
		 int org.xml.sax.Locator.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getLineNumber28269);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_.staticClass, global::org.xml.sax.ext.Locator2_._getLineNumber28269);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId28270;
		 global::java.lang.String org.xml.sax.Locator.getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getPublicId28270)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_.staticClass, global::org.xml.sax.ext.Locator2_._getPublicId28270)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId28271;
		 global::java.lang.String org.xml.sax.Locator.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getSystemId28271)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_.staticClass, global::org.xml.sax.ext.Locator2_._getSystemId28271)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber28272;
		 int org.xml.sax.Locator.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_._getColumnNumber28272);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Locator2_.staticClass, global::org.xml.sax.ext.Locator2_._getColumnNumber28272);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Locator2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Locator2"));
			global::org.xml.sax.ext.Locator2_._getEncoding28267 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getXMLVersion28268 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getXMLVersion", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getLineNumber28269 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getLineNumber", "()I");
			global::org.xml.sax.ext.Locator2_._getPublicId28270 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getSystemId28271 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.ext.Locator2_._getColumnNumber28272 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2_.staticClass, "getColumnNumber", "()I");
		}
	}
}
