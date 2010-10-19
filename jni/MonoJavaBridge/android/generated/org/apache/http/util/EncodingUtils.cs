namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class EncodingUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EncodingUtils()
		{
			InitJNI();
		}
		internal EncodingUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBytes27201;
		public static byte[] getBytes(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._getBytes27201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getString27202;
		public static global::java.lang.String getString(byte[] arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._getString27202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString27203;
		public static global::java.lang.String getString(byte[] arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._getString27203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiBytes27204;
		public static byte[] getAsciiBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._getAsciiBytes27204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiString27205;
		public static global::java.lang.String getAsciiString(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._getAsciiString27205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiString27206;
		public static global::java.lang.String getAsciiString(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.EncodingUtils.staticClass, global::org.apache.http.util.EncodingUtils._getAsciiString27206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.EncodingUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/EncodingUtils"));
			global::org.apache.http.util.EncodingUtils._getBytes27201 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getBytes", "(Ljava/lang/String;Ljava/lang/String;)[B");
			global::org.apache.http.util.EncodingUtils._getString27202 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getString", "([BIILjava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.util.EncodingUtils._getString27203 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getString", "([BLjava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.util.EncodingUtils._getAsciiBytes27204 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getAsciiBytes", "(Ljava/lang/String;)[B");
			global::org.apache.http.util.EncodingUtils._getAsciiString27205 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getAsciiString", "([BII)Ljava/lang/String;");
			global::org.apache.http.util.EncodingUtils._getAsciiString27206 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EncodingUtils.staticClass, "getAsciiString", "([B)Ljava/lang/String;");
		}
	}
}
