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
		internal static global::MonoJavaBridge.MethodId _setSoTimeout33654;
		public static void setSoTimeout(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setSoTimeout33654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout33655;
		public static int getSoTimeout(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getSoTimeout33655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay33656;
		public static void setTcpNoDelay(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setTcpNoDelay33656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTcpNoDelay33657;
		public static bool getTcpNoDelay(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getTcpNoDelay33657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketBufferSize33658;
		public static void setSocketBufferSize(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setSocketBufferSize33658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLinger33659;
		public static void setLinger(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setLinger33659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionTimeout33660;
		public static void setConnectionTimeout(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setConnectionTimeout33660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStaleCheckingEnabled33661;
		public static void setStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setStaleCheckingEnabled33661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketBufferSize33662;
		public static int getSocketBufferSize(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getSocketBufferSize33662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLinger33663;
		public static int getLinger(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getLinger33663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionTimeout33664;
		public static int getConnectionTimeout(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getConnectionTimeout33664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStaleCheckingEnabled33665;
		public static bool isStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._isStaleCheckingEnabled33665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/HttpConnectionParams"));
			global::org.apache.http.@params.HttpConnectionParams._setSoTimeout33654 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSoTimeout", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._getSoTimeout33655 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSoTimeout", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._setTcpNoDelay33656 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setTcpNoDelay", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpConnectionParams._getTcpNoDelay33657 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getTcpNoDelay", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.@params.HttpConnectionParams._setSocketBufferSize33658 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSocketBufferSize", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setLinger33659 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setLinger", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setConnectionTimeout33660 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setConnectionTimeout", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setStaleCheckingEnabled33661 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setStaleCheckingEnabled", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpConnectionParams._getSocketBufferSize33662 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSocketBufferSize", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._getLinger33663 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getLinger", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._getConnectionTimeout33664 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getConnectionTimeout", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._isStaleCheckingEnabled33665 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "isStaleCheckingEnabled", "(Lorg/apache/http/@params/HttpParams;)Z");
		}
	}
}
