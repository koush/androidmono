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
		internal static global::MonoJavaBridge.MethodId _getVersion33686;
		public static global::org.apache.http.ProtocolVersion getVersion(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getVersion33686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _setVersion33687;
		public static void setVersion(org.apache.http.@params.HttpParams arg0, org.apache.http.ProtocolVersion arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setVersion33687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent33688;
		public static void setUserAgent(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setUserAgent33688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getUserAgent33689;
		public static global::java.lang.String getUserAgent(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getUserAgent33689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setHttpElementCharset33690;
		public static void setHttpElementCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setHttpElementCharset33690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setContentCharset33691;
		public static void setContentCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setContentCharset33691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setUseExpectContinue33692;
		public static void setUseExpectContinue(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._setUseExpectContinue33692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _useExpectContinue33693;
		public static bool useExpectContinue(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._useExpectContinue33693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpElementCharset33694;
		public static global::java.lang.String getHttpElementCharset(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getHttpElementCharset33694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentCharset33695;
		public static global::java.lang.String getContentCharset(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.@params.HttpProtocolParams.staticClass, global::org.apache.http.@params.HttpProtocolParams._getContentCharset33695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpProtocolParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/HttpProtocolParams"));
			global::org.apache.http.@params.HttpProtocolParams._getVersion33686 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getVersion", "(Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.@params.HttpProtocolParams._setVersion33687 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setVersion", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/ProtocolVersion;)V");
			global::org.apache.http.@params.HttpProtocolParams._setUserAgent33688 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUserAgent", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParams._getUserAgent33689 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getUserAgent", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
			global::org.apache.http.@params.HttpProtocolParams._setHttpElementCharset33690 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setHttpElementCharset", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParams._setContentCharset33691 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setContentCharset", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParams._setUseExpectContinue33692 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "setUseExpectContinue", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpProtocolParams._useExpectContinue33693 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "useExpectContinue", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.@params.HttpProtocolParams._getHttpElementCharset33694 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getHttpElementCharset", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
			global::org.apache.http.@params.HttpProtocolParams._getContentCharset33695 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParams.staticClass, "getContentCharset", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
		}
	}
}
