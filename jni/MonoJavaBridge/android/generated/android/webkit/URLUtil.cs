namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URLUtil : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLUtil()
		{
			InitJNI();
		}
		internal URLUtil(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decode10909;
		public static byte[] decode(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._decode10909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _guessUrl10910;
		public static global::java.lang.String guessUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessUrl10910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _composeSearchUrl10911;
		public static global::java.lang.String composeSearchUrl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._composeSearchUrl10911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAssetUrl10912;
		public static bool isAssetUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAssetUrl10912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCookielessProxyUrl10913;
		public static bool isCookielessProxyUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isCookielessProxyUrl10913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFileUrl10914;
		public static bool isFileUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isFileUrl10914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAboutUrl10915;
		public static bool isAboutUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAboutUrl10915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDataUrl10916;
		public static bool isDataUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isDataUrl10916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaScriptUrl10917;
		public static bool isJavaScriptUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isJavaScriptUrl10917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHttpUrl10918;
		public static bool isHttpUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpUrl10918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHttpsUrl10919;
		public static bool isHttpsUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpsUrl10919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNetworkUrl10920;
		public static bool isNetworkUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isNetworkUrl10920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isContentUrl10921;
		public static bool isContentUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isContentUrl10921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isValidUrl10922;
		public static bool isValidUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isValidUrl10922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stripAnchor10923;
		public static global::java.lang.String stripAnchor(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._stripAnchor10923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _guessFileName10924;
		public static global::java.lang.String guessFileName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessFileName10924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URLUtil10925;
		public URLUtil()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._URLUtil10925);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.URLUtil.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/URLUtil"));
			global::android.webkit.URLUtil._decode10909 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "decode", "([B)[B");
			global::android.webkit.URLUtil._guessUrl10910 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "guessUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._composeSearchUrl10911 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._isAssetUrl10912 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isAssetUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isCookielessProxyUrl10913 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isCookielessProxyUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isFileUrl10914 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isFileUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isAboutUrl10915 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isAboutUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isDataUrl10916 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isDataUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isJavaScriptUrl10917 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isJavaScriptUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpUrl10918 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isHttpUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpsUrl10919 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isHttpsUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isNetworkUrl10920 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isNetworkUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isContentUrl10921 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isContentUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isValidUrl10922 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isValidUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._stripAnchor10923 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._guessFileName10924 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._URLUtil10925 = @__env.GetMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "<init>", "()V");
		}
	}
}
