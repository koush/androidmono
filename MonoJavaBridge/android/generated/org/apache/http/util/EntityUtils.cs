namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class EntityUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EntityUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String toString(org.apache.http.HttpEntity arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EntityUtils._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EntityUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "toString", "(Lorg/apache/http/HttpEntity;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String toString(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EntityUtils._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EntityUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "toString", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static byte[] toByteArray(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EntityUtils._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EntityUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "toByteArray", "(Lorg/apache/http/HttpEntity;)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.String getContentCharSet(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EntityUtils._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EntityUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "getContentCharSet", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static EntityUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.EntityUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/EntityUtils"));
		}
	}
}
