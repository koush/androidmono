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
		internal static global::net.sf.jni4net.jni.MethodId _decode9337;
		public static byte[] decode(byte[] arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._decode9337, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _guessUrl9338;
		public static global::java.lang.String guessUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessUrl9338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _composeSearchUrl9339;
		public static global::java.lang.String composeSearchUrl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._composeSearchUrl9339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAssetUrl9340;
		public static bool isAssetUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAssetUrl9340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCookielessProxyUrl9341;
		public static bool isCookielessProxyUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isCookielessProxyUrl9341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFileUrl9342;
		public static bool isFileUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isFileUrl9342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAboutUrl9343;
		public static bool isAboutUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isAboutUrl9343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDataUrl9344;
		public static bool isDataUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isDataUrl9344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isJavaScriptUrl9345;
		public static bool isJavaScriptUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isJavaScriptUrl9345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHttpUrl9346;
		public static bool isHttpUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpUrl9346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHttpsUrl9347;
		public static bool isHttpsUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isHttpsUrl9347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkUrl9348;
		public static bool isNetworkUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isNetworkUrl9348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isContentUrl9349;
		public static bool isContentUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isContentUrl9349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isValidUrl9350;
		public static bool isValidUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._isValidUrl9350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stripAnchor9351;
		public static global::java.lang.String stripAnchor(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._stripAnchor9351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _guessFileName9352;
		public static global::java.lang.String guessFileName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._guessFileName9352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _URLUtil9353;
		public URLUtil()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._URLUtil9353, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.URLUtil.staticClass = @__class;
			global::android.webkit.URLUtil._decode9337 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "decode", "([B)[B");
			global::android.webkit.URLUtil._guessUrl9338 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "guessUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._composeSearchUrl9339 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._isAssetUrl9340 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isAssetUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isCookielessProxyUrl9341 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isCookielessProxyUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isFileUrl9342 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isFileUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isAboutUrl9343 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isAboutUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isDataUrl9344 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isDataUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isJavaScriptUrl9345 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isJavaScriptUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpUrl9346 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isHttpUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isHttpsUrl9347 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isHttpsUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isNetworkUrl9348 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isNetworkUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isContentUrl9349 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isContentUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._isValidUrl9350 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isValidUrl", "(Ljava/lang/String;)Z");
			global::android.webkit.URLUtil._stripAnchor9351 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._guessFileName9352 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.URLUtil._URLUtil9353 = @__env.GetMethodID(global::android.webkit.URLUtil.staticClass, "<init>", "()V");
		}
	}
}
