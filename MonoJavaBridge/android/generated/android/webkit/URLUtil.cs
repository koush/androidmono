namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URLUtil : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URLUtil(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static byte[] decode(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "decode", "([B)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String guessUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m1.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "guessUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String composeSearchUrl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m2.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m2 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool isAssetUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m3.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m3 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isAssetUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool isCookielessProxyUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m4.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m4 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isCookielessProxyUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static bool isFileUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m5.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m5 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isFileUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static bool isAboutUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m6.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m6 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isAboutUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static bool isDataUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m7.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m7 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isDataUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static bool isJavaScriptUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m8.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m8 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isJavaScriptUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static bool isHttpUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m9.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m9 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isHttpUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static bool isHttpsUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m10.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m10 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isHttpsUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static bool isNetworkUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m11.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m11 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isNetworkUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool isContentUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m12.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m12 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isContentUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool isValidUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m13.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m13 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "isValidUrl", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.lang.String stripAnchor(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m14.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m14 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.lang.String guessFileName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m15.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m15 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public URLUtil() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.URLUtil._m16.native == global::System.IntPtr.Zero)
				global::android.webkit.URLUtil._m16 = @__env.GetMethodIDNoThrow(global::android.webkit.URLUtil.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.URLUtil.staticClass, global::android.webkit.URLUtil._m16);
			Init(@__env, handle);
		}
		static URLUtil()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.URLUtil.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/URLUtil"));
		}
	}
}
