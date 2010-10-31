namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpProtocolParams : java.lang.Object, CoreProtocolPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpProtocolParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::org.apache.http.ProtocolVersion getVersion(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getVersion", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/ProtocolVersion;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void setVersion(org.apache.http.@params.HttpParams arg0, org.apache.http.ProtocolVersion arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setVersion", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/ProtocolVersion;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void setUserAgent(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUserAgent", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.String getUserAgent(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getUserAgent", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void setHttpElementCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setHttpElementCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void setContentCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setContentCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void setUseExpectContinue(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m6 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUseExpectContinue", "(Lorg/apache/http/params/HttpParams;Z)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static bool useExpectContinue(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m7 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "useExpectContinue", "(Lorg/apache/http/params/HttpParams;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.String getHttpElementCharset(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m8 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getHttpElementCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String getContentCharset(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParams._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParams._m9 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getContentCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static HttpProtocolParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpProtocolParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpProtocolParams"));
		}
	}
}
