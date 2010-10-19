namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.Header_))]
	public interface Header  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::org.apache.http.HeaderElement[] getElements();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.Header))]
	public sealed partial class Header_ : java.lang.Object, Header
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Header_()
		{
			InitJNI();
		}
		internal Header_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName24889;
		 global::java.lang.String org.apache.http.Header.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.Header_._getName24889)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.Header_.staticClass, global::org.apache.http.Header_._getName24889)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue24890;
		 global::java.lang.String org.apache.http.Header.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.Header_._getValue24890)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.Header_.staticClass, global::org.apache.http.Header_._getValue24890)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getElements24891;
		 global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.Header_._getElements24891)) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.Header_.staticClass, global::org.apache.http.Header_._getElements24891)) as org.apache.http.HeaderElement[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.Header_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/Header"));
			global::org.apache.http.Header_._getName24889 = @__env.GetMethodIDNoThrow(global::org.apache.http.Header_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.Header_._getValue24890 = @__env.GetMethodIDNoThrow(global::org.apache.http.Header_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.Header_._getElements24891 = @__env.GetMethodIDNoThrow(global::org.apache.http.Header_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
		}
	}
}
