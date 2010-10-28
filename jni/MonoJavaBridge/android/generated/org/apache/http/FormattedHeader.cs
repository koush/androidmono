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
		internal FormattedHeader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBuffer31492;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.FormattedHeader.getBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getBuffer31492)) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getBuffer31492)) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getValuePos31493;
		int org.apache.http.FormattedHeader.getValuePos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getValuePos31493);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getValuePos31493);
		}
		internal static global::MonoJavaBridge.MethodId _getName31494;
		global::java.lang.String org.apache.http.Header.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getName31494)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getName31494)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue31495;
		global::java.lang.String org.apache.http.Header.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getValue31495)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getValue31495)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getElements31496;
		global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getElements31496)) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getElements31496)) as org.apache.http.HeaderElement[];
		}
		static FormattedHeader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.FormattedHeader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/FormattedHeader"));
			global::org.apache.http.FormattedHeader_._getBuffer31492 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.FormattedHeader_._getValuePos31493 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getValuePos", "()I");
			global::org.apache.http.FormattedHeader_._getName31494 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.FormattedHeader_._getValue31495 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.FormattedHeader_._getElements31496 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
		}
		internal static void InitJNI()
		{
		}
	}
}
