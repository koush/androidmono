namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.FormattedHeader_))]
	public partial interface FormattedHeader : Header
	{
		global::org.apache.http.util.CharArrayBuffer getBuffer();
		int getValuePos();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.FormattedHeader))]
	internal sealed partial class FormattedHeader_ : java.lang.Object, FormattedHeader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FormattedHeader_()
		{
			InitJNI();
		}
		internal FormattedHeader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBuffer31491;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.FormattedHeader.getBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getBuffer31491)) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getBuffer31491)) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getValuePos31492;
		int org.apache.http.FormattedHeader.getValuePos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getValuePos31492);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getValuePos31492);
		}
		internal static global::MonoJavaBridge.MethodId _getName31493;
		global::java.lang.String org.apache.http.Header.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getName31493)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getName31493)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue31494;
		global::java.lang.String org.apache.http.Header.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getValue31494)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getValue31494)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getElements31495;
		global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getElements31495)) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getElements31495)) as org.apache.http.HeaderElement[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.FormattedHeader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/FormattedHeader"));
			global::org.apache.http.FormattedHeader_._getBuffer31491 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.FormattedHeader_._getValuePos31492 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getValuePos", "()I");
			global::org.apache.http.FormattedHeader_._getName31493 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.FormattedHeader_._getValue31494 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.FormattedHeader_._getElements31495 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
		}
	}
}
