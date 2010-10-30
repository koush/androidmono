namespace org.apache.http.conn.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetAddressUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InetAddressUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool isIPv4Address(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.util.InetAddressUtils._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.util.InetAddressUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv4Address", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool isIPv6StdAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.util.InetAddressUtils._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.util.InetAddressUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv6StdAddress", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool isIPv6HexCompressedAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.util.InetAddressUtils._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.util.InetAddressUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv6HexCompressedAddress", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool isIPv6Address(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.util.InetAddressUtils._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.util.InetAddressUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.util.InetAddressUtils.staticClass, "isIPv6Address", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.util.InetAddressUtils.staticClass, global::org.apache.http.conn.util.InetAddressUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static InetAddressUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.util.InetAddressUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/util/InetAddressUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
