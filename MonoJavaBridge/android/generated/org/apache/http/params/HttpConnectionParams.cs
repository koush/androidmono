namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpConnectionParams : java.lang.Object, CoreConnectionPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpConnectionParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout33773;
		public static void setSoTimeout(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setSoTimeout33773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout33774;
		public static int getSoTimeout(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getSoTimeout33774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay33775;
		public static void setTcpNoDelay(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setTcpNoDelay33775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTcpNoDelay33776;
		public static bool getTcpNoDelay(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getTcpNoDelay33776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketBufferSize33777;
		public static void setSocketBufferSize(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setSocketBufferSize33777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLinger33778;
		public static void setLinger(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setLinger33778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionTimeout33779;
		public static void setConnectionTimeout(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setConnectionTimeout33779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStaleCheckingEnabled33780;
		public static void setStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._setStaleCheckingEnabled33780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketBufferSize33781;
		public static int getSocketBufferSize(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getSocketBufferSize33781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLinger33782;
		public static int getLinger(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getLinger33782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionTimeout33783;
		public static int getConnectionTimeout(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._getConnectionTimeout33783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStaleCheckingEnabled33784;
		public static bool isStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._isStaleCheckingEnabled33784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpConnectionParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpConnectionParams"));
			global::org.apache.http.@params.HttpConnectionParams._setSoTimeout33773 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSoTimeout", "(Lorg/apache/http/params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._getSoTimeout33774 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSoTimeout", "(Lorg/apache/http/params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._setTcpNoDelay33775 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setTcpNoDelay", "(Lorg/apache/http/params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpConnectionParams._getTcpNoDelay33776 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getTcpNoDelay", "(Lorg/apache/http/params/HttpParams;)Z");
			global::org.apache.http.@params.HttpConnectionParams._setSocketBufferSize33777 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSocketBufferSize", "(Lorg/apache/http/params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setLinger33778 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setLinger", "(Lorg/apache/http/params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setConnectionTimeout33779 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setConnectionTimeout", "(Lorg/apache/http/params/HttpParams;I)V");
			global::org.apache.http.@params.HttpConnectionParams._setStaleCheckingEnabled33780 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;Z)V");
			global::org.apache.http.@params.HttpConnectionParams._getSocketBufferSize33781 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSocketBufferSize", "(Lorg/apache/http/params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._getLinger33782 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getLinger", "(Lorg/apache/http/params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._getConnectionTimeout33783 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getConnectionTimeout", "(Lorg/apache/http/params/HttpParams;)I");
			global::org.apache.http.@params.HttpConnectionParams._isStaleCheckingEnabled33784 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "isStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
