namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class URLUtil : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static URLUtil() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.URLUtil), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _decode8650; 
		public static byte[] decode(byte[] arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, _decode8650, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _guessUrl8651; 
		public static java.lang.String guessUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, _guessUrl8651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _composeSearchUrl8652; 
		public static java.lang.String composeSearchUrl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, _composeSearchUrl8652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAssetUrl8653; 
		public static bool isAssetUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isAssetUrl8653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCookielessProxyUrl8654; 
		public static bool isCookielessProxyUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isCookielessProxyUrl8654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFileUrl8655; 
		public static bool isFileUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isFileUrl8655, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAboutUrl8656; 
		public static bool isAboutUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isAboutUrl8656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDataUrl8657; 
		public static bool isDataUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isDataUrl8657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isJavaScriptUrl8658; 
		public static bool isJavaScriptUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isJavaScriptUrl8658, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHttpUrl8659; 
		public static bool isHttpUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isHttpUrl8659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHttpsUrl8660; 
		public static bool isHttpsUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isHttpsUrl8660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkUrl8661; 
		public static bool isNetworkUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isNetworkUrl8661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isContentUrl8662; 
		public static bool isContentUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isContentUrl8662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isValidUrl8663; 
		public static bool isValidUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, _isValidUrl8663, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stripAnchor8664; 
		public static java.lang.String stripAnchor(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, _stripAnchor8664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _guessFileName8665; 
		public static java.lang.String guessFileName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.URLUtil.staticClass, _guessFileName8665, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URLUtil8666; 
		public URLUtil()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.URLUtil.staticClass, _URLUtil8666, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.URLUtil.staticClass = @__class; 
			global::android.webkit.URLUtil._decode8650 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "decode", "([B)[B"); 
			global::android.webkit.URLUtil._guessUrl8651 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "guessUrl", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.URLUtil._composeSearchUrl8652 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.URLUtil._isAssetUrl8653 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isAssetUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isCookielessProxyUrl8654 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isCookielessProxyUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isFileUrl8655 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isFileUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isAboutUrl8656 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isAboutUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isDataUrl8657 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isDataUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isJavaScriptUrl8658 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isJavaScriptUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isHttpUrl8659 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isHttpUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isHttpsUrl8660 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isHttpsUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isNetworkUrl8661 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isNetworkUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isContentUrl8662 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isContentUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._isValidUrl8663 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "isValidUrl", "(Ljava/lang/String;)Z"); 
			global::android.webkit.URLUtil._stripAnchor8664 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.URLUtil._guessFileName8665 = @__env.GetStaticMethodID(global::android.webkit.URLUtil.staticClass, "guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.URLUtil._URLUtil8666 = @__env.GetMethodID(global::android.webkit.URLUtil.staticClass, "<init>", "()V"); 
		} 
	} 
} 
