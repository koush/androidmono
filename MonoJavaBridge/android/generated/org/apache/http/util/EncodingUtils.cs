namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class EncodingUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EncodingUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static byte[] getBytes(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EncodingUtils._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EncodingUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getBytes", "(Ljava/lang/String;Ljava/lang/String;)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String getString(byte[] arg0, int arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EncodingUtils._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EncodingUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getString", "([BIILjava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String getString(byte[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EncodingUtils._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EncodingUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getString", "([BLjava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static byte[] getAsciiBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EncodingUtils._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EncodingUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getAsciiBytes", "(Ljava/lang/String;)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.lang.String getAsciiString(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EncodingUtils._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EncodingUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getAsciiString", "([BII)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String getAsciiString(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.EncodingUtils._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.EncodingUtils._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getAsciiString", "([B)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static EncodingUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.EncodingUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/EncodingUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
