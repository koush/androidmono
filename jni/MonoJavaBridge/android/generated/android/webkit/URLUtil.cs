namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class URLUtil : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static URLUtil()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.URLUtil), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.URLUtil(@__env);
			}
		}
		internal URLUtil(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _decode10016;
		public static byte[] decode(byte[] arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._decode10016, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _guessUrl10017;
		public static global::java.lang.String guessUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessUrl10017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _composeSearchUrl10018;
		public static global::java.lang.String composeSearchUrl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._composeSearchUrl10018, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAssetUrl10019;
		public static bool isAssetUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAssetUrl10019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCookielessProxyUrl10020;
		public static bool isCookielessProxyUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isCookielessProxyUrl10020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFileUrl10021;
		public static bool isFileUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isFileUrl10021, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAboutUrl10022;
		public static bool isAboutUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAboutUrl10022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDataUrl10023;
		public static bool isDataUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isDataUrl10023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isJavaScriptUrl10024;
		public static bool isJavaScriptUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isJavaScriptUrl10024, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHttpUrl10025;
		public static bool isHttpUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpUrl10025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHttpsUrl10026;
		public static bool isHttpsUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpsUrl10026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkUrl10027;
		public static bool isNetworkUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isNetworkUrl10027, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isContentUrl10028;
		public static bool isContentUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isContentUrl10028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isValidUrl10029;
		public static bool isValidUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isValidUrl10029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stripAnchor10030;
		public static global::java.lang.String stripAnchor(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._stripAnchor10030, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _guessFileName10031;
		public static global::java.lang.String guessFileName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessFileName10031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _URLUtil10032;
		public URLUtil()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._URLUtil10032, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.URLUtil.staticClass = @__class;
			global::android.webkit.URLUtil._decode10016 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "decode", "([B)[B");
			global::android.webkit.URLUtil._guessUrl10017 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "guessUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._composeSearchUrl10018 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._isAssetUrl10019 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isAssetUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isCookielessProxyUrl10020 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isCookielessProxyUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isFileUrl10021 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isFileUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isAboutUrl10022 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isAboutUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isDataUrl10023 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isDataUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isJavaScriptUrl10024 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isJavaScriptUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpUrl10025 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isHttpUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpsUrl10026 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isHttpsUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isNetworkUrl10027 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isNetworkUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isContentUrl10028 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isContentUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isValidUrl10029 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isValidUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._stripAnchor10030 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._guessFileName10031 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._URLUtil10032 = @__env.GetMethodID(global::android.webkit.URLUtil.staticClass, "<init>", "()V");
		}
	}
}
