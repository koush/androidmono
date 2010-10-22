namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HeaderElement_))]
	public interface HeaderElement  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::org.apache.http.NameValuePair[] getParameters();
		global::org.apache.http.NameValuePair getParameter(int arg0);
		int getParameterCount();
		global::org.apache.http.NameValuePair getParameterByName(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HeaderElement))]
	public sealed partial class HeaderElement_ : java.lang.Object, HeaderElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HeaderElement_()
		{
			InitJNI();
		}
		internal HeaderElement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName31381;
		 global::java.lang.String org.apache.http.HeaderElement.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getName31381)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_.staticClass, global::org.apache.http.HeaderElement_._getName31381)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue31382;
		 global::java.lang.String org.apache.http.HeaderElement.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getValue31382)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_.staticClass, global::org.apache.http.HeaderElement_._getValue31382)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameters31383;
		 global::org.apache.http.NameValuePair[] org.apache.http.HeaderElement.getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameters31383)) as org.apache.http.NameValuePair[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_.staticClass, global::org.apache.http.HeaderElement_._getParameters31383)) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _getParameter31384;
		 global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameter31384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_.staticClass, global::org.apache.http.HeaderElement_._getParameter31384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterCount31385;
		 int org.apache.http.HeaderElement.getParameterCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameterCount31385);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HeaderElement_.staticClass, global::org.apache.http.HeaderElement_._getParameterCount31385);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterByName31386;
		 global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameterByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameterByName31386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_.staticClass, global::org.apache.http.HeaderElement_._getParameterByName31386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HeaderElement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HeaderElement"));
			global::org.apache.http.HeaderElement_._getName31381 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.HeaderElement_._getValue31382 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.HeaderElement_._getParameters31383 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameters", "()[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.HeaderElement_._getParameter31384 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameter", "(I)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.HeaderElement_._getParameterCount31385 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameterCount", "()I");
			global::org.apache.http.HeaderElement_._getParameterByName31386 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;");
		}
	}
}
