namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpProtocolParams : java.lang.Object, CoreProtocolPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpProtocolParams()
		{
			InitJNI();
		}
		internal HttpProtocolParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getVersion27040;
		public static global::org.apache.http.ProtocolVersion getVersion(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getVersion27040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _setVersion27041;
		public static void setVersion(org.apache.http.@params.HttpParams arg0, org.apache.http.ProtocolVersion arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setVersion27041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent27042;
		public static void setUserAgent(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setUserAgent27042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getUserAgent27043;
		public static global::java.lang.String getUserAgent(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getUserAgent27043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setHttpElementCharset27044;
		public static void setHttpElementCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setHttpElementCharset27044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setContentCharset27045;
		public static void setContentCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setContentCharset27045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setUseExpectContinue27046;
		public static void setUseExpectContinue(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setUseExpectContinue27046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _useExpectContinue27047;
		public static bool useExpectContinue(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._useExpectContinue27047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpElementCharset27048;
		public static global::java.lang.String getHttpElementCharset(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getHttpElementCharset27048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentCharset27049;
		public static global::java.lang.String getContentCharset(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getContentCharset27049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpProtocolParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/HttpProtocolParams"));
			global::org.apache.http.@params.HttpProtocolParams._getVersion27040 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getVersion", "(Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.@params.HttpProtocolParams._setVersion27041 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setVersion", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/ProtocolVersion;)V");
			global::org.apache.http.@params.HttpProtocolParams._setUserAgent27042 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUserAgent", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParams._getUserAgent27043 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getUserAgent", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
			global::org.apache.http.@params.HttpProtocolParams._setHttpElementCharset27044 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setHttpElementCharset", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParams._setContentCharset27045 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setContentCharset", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParams._setUseExpectContinue27046 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUseExpectContinue", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpProtocolParams._useExpectContinue27047 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "useExpectContinue", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.@params.HttpProtocolParams._getHttpElementCharset27048 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getHttpElementCharset", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
			global::org.apache.http.@params.HttpProtocolParams._getContentCharset27049 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getContentCharset", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
		}
	}
}
