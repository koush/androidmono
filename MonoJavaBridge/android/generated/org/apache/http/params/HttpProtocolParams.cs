namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpProtocolParams : java.lang.Object, CoreProtocolPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpProtocolParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33805;
		public static global::org.apache.http.ProtocolVersion getVersion(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._getVersion33805.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._getVersion33805 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getVersion", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/ProtocolVersion;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getVersion33805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _setVersion33806;
		public static void setVersion(org.apache.http.@params.HttpParams arg0, org.apache.http.ProtocolVersion arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._setVersion33806.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._setVersion33806 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setVersion", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/ProtocolVersion;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setVersion33806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent33807;
		public static void setUserAgent(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._setUserAgent33807.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._setUserAgent33807 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUserAgent", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setUserAgent33807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getUserAgent33808;
		public static global::java.lang.String getUserAgent(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._getUserAgent33808.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._getUserAgent33808 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getUserAgent", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getUserAgent33808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setHttpElementCharset33809;
		public static void setHttpElementCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._setHttpElementCharset33809.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._setHttpElementCharset33809 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setHttpElementCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setHttpElementCharset33809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setContentCharset33810;
		public static void setContentCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._setContentCharset33810.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._setContentCharset33810 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setContentCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setContentCharset33810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setUseExpectContinue33811;
		public static void setUseExpectContinue(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._setUseExpectContinue33811.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._setUseExpectContinue33811 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUseExpectContinue", "(Lorg/apache/http/params/HttpParams;Z)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setUseExpectContinue33811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _useExpectContinue33812;
		public static bool useExpectContinue(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._useExpectContinue33812.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._useExpectContinue33812 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "useExpectContinue", "(Lorg/apache/http/params/HttpParams;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._useExpectContinue33812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpElementCharset33813;
		public static global::java.lang.String getHttpElementCharset(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._getHttpElementCharset33813.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._getHttpElementCharset33813 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getHttpElementCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getHttpElementCharset33813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentCharset33814;
		public static global::java.lang.String getContentCharset(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._getContentCharset33814.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._getContentCharset33814 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getContentCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getContentCharset33814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static HttpProtocolParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpProtocolParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpProtocolParams"));
		}
		internal static void InitJNI()
		{
		}
	}
}
