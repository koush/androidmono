namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URLUtil : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URLUtil(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decode16095;
		public static byte[] decode(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._decode16095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _guessUrl16096;
		public static global::java.lang.String guessUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessUrl16096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _composeSearchUrl16097;
		public static global::java.lang.String composeSearchUrl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._composeSearchUrl16097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAssetUrl16098;
		public static bool isAssetUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAssetUrl16098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCookielessProxyUrl16099;
		public static bool isCookielessProxyUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isCookielessProxyUrl16099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFileUrl16100;
		public static bool isFileUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isFileUrl16100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAboutUrl16101;
		public static bool isAboutUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAboutUrl16101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDataUrl16102;
		public static bool isDataUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isDataUrl16102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaScriptUrl16103;
		public static bool isJavaScriptUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isJavaScriptUrl16103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHttpUrl16104;
		public static bool isHttpUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpUrl16104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHttpsUrl16105;
		public static bool isHttpsUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpsUrl16105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNetworkUrl16106;
		public static bool isNetworkUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isNetworkUrl16106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isContentUrl16107;
		public static bool isContentUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isContentUrl16107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isValidUrl16108;
		public static bool isValidUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isValidUrl16108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stripAnchor16109;
		public static global::java.lang.String stripAnchor(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._stripAnchor16109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _guessFileName16110;
		public static global::java.lang.String guessFileName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessFileName16110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URLUtil16111;
		public URLUtil() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._URLUtil16111);
			Init(@__env, handle);
		}
		static URLUtil()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.URLUtil.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/URLUtil"));
			global::android.webkit.URLUtil._decode16095 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "decode", "([B)[B");
			global::android.webkit.URLUtil._guessUrl16096 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "guessUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._composeSearchUrl16097 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._isAssetUrl16098 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isAssetUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isCookielessProxyUrl16099 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isCookielessProxyUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isFileUrl16100 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isFileUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isAboutUrl16101 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isAboutUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isDataUrl16102 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isDataUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isJavaScriptUrl16103 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isJavaScriptUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpUrl16104 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isHttpUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpsUrl16105 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isHttpsUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isNetworkUrl16106 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isNetworkUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isContentUrl16107 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isContentUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isValidUrl16108 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isValidUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._stripAnchor16109 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._guessFileName16110 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._URLUtil16111 = @__env.GetMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
