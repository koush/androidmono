namespace org.apache.http.conn.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetAddressUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InetAddressUtils()
		{
			InitJNI();
		}
		protected InetAddressUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isIPv4Address32245;
		public static bool isIPv4Address(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._isIPv4Address32245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIPv6StdAddress32246;
		public static bool isIPv6StdAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._isIPv6StdAddress32246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIPv6HexCompressedAddress32247;
		public static bool isIPv6HexCompressedAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._isIPv6HexCompressedAddress32247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIPv6Address32248;
		public static bool isIPv6Address(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._isIPv6Address32248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.util.InetAddressUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/util/InetAddressUtils"));
			global::org.apache.http.conn.util.InetAddressUtils._isIPv4Address32245 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv4Address", "(Ljava/lang/String;)Z");
			global::org.apache.http.conn.util.InetAddressUtils._isIPv6StdAddress32246 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv6StdAddress", "(Ljava/lang/String;)Z");
			global::org.apache.http.conn.util.InetAddressUtils._isIPv6HexCompressedAddress32247 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv6HexCompressedAddress", "(Ljava/lang/String;)Z");
			global::org.apache.http.conn.util.InetAddressUtils._isIPv6Address32248 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv6Address", "(Ljava/lang/String;)Z");
		}
	}
}
