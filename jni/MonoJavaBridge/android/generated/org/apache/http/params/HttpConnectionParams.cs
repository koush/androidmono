namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpConnectionParams : java.lang.Object, CoreConnectionPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpConnectionParams()
		{
			InitJNI();
		}
		internal HttpConnectionParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout27008;
		public static void setSoTimeout(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setSoTimeout27008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout27009;
		public static int getSoTimeout(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getSoTimeout27009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay27010;
		public static void setTcpNoDelay(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setTcpNoDelay27010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTcpNoDelay27011;
		public static bool getTcpNoDelay(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getTcpNoDelay27011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketBufferSize27012;
		public static void setSocketBufferSize(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setSocketBufferSize27012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLinger27013;
		public static void setLinger(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setLinger27013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionTimeout27014;
		public static void setConnectionTimeout(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setConnectionTimeout27014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStaleCheckingEnabled27015;
		public static void setStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setStaleCheckingEnabled27015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketBufferSize27016;
		public static int getSocketBufferSize(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getSocketBufferSize27016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLinger27017;
		public static int getLinger(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getLinger27017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionTimeout27018;
		public static int getConnectionTimeout(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getConnectionTimeout27018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStaleCheckingEnabled27019;
		public static bool isStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._isStaleCheckingEnabled27019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/HttpConnectionParams"));
			global::org.apache.http.@params.HttpConnectionParams._setSoTimeout27008 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSoTimeout", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._getSoTimeout27009 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSoTimeout", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._setTcpNoDelay27010 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setTcpNoDelay", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpConnectionParams._getTcpNoDelay27011 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getTcpNoDelay", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.@params.HttpConnectionParams._setSocketBufferSize27012 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSocketBufferSize", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setLinger27013 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setLinger", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setConnectionTimeout27014 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setConnectionTimeout", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setStaleCheckingEnabled27015 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setStaleCheckingEnabled", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpConnectionParams._getSocketBufferSize27016 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSocketBufferSize", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._getLinger27017 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getLinger", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._getConnectionTimeout27018 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getConnectionTimeout", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._isStaleCheckingEnabled27019 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "isStaleCheckingEnabled", "(Lorg/apache/http/@params/HttpParams;)Z");
		}
	}
}
