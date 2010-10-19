namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.FormattedHeader_))]
	public interface FormattedHeader : Header
	{
		global::org.apache.http.util.CharArrayBuffer getBuffer();
		int getValuePos();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.FormattedHeader))]
	public sealed partial class FormattedHeader_ : java.lang.Object, FormattedHeader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FormattedHeader_()
		{
			InitJNI();
		}
		internal FormattedHeader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBuffer24884;
		 global::org.apache.http.util.CharArrayBuffer org.apache.http.FormattedHeader.getBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getBuffer24884)) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getBuffer24884)) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getValuePos24885;
		 int org.apache.http.FormattedHeader.getValuePos() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getValuePos24885);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getValuePos24885);
		}
		internal static global::MonoJavaBridge.MethodId _getName24886;
		 global::java.lang.String org.apache.http.Header.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getName24886)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getName24886)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue24887;
		 global::java.lang.String org.apache.http.Header.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getValue24887)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getValue24887)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getElements24888;
		 global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_._getElements24888)) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.FormattedHeader_.staticClass, global::org.apache.http.FormattedHeader_._getElements24888)) as org.apache.http.HeaderElement[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.FormattedHeader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/FormattedHeader"));
			global::org.apache.http.FormattedHeader_._getBuffer24884 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.FormattedHeader_._getValuePos24885 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getValuePos", "()I");
			global::org.apache.http.FormattedHeader_._getName24886 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.FormattedHeader_._getValue24887 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.FormattedHeader_._getElements24888 = @__env.GetMethodIDNoThrow(global::org.apache.http.FormattedHeader_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
		}
	}
}
