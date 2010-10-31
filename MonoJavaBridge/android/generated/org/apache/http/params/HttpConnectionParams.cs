namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpConnectionParams : java.lang.Object, CoreConnectionPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpConnectionParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void setSoTimeout(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSoTimeout", "(Lorg/apache/http/params/HttpParams;I)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int getSoTimeout(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSoTimeout", "(Lorg/apache/http/params/HttpParams;)I");
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void setTcpNoDelay(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setTcpNoDelay", "(Lorg/apache/http/params/HttpParams;Z)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool getTcpNoDelay(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getTcpNoDelay", "(Lorg/apache/http/params/HttpParams;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void setSocketBufferSize(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setSocketBufferSize", "(Lorg/apache/http/params/HttpParams;I)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void setLinger(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setLinger", "(Lorg/apache/http/params/HttpParams;I)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void setConnectionTimeout(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m6 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setConnectionTimeout", "(Lorg/apache/http/params/HttpParams;I)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void setStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m7 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "setStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;Z)V");
			@__env.CallStaticVoidMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int getSocketBufferSize(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m8 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getSocketBufferSize", "(Lorg/apache/http/params/HttpParams;)I");
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static int getLinger(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m9 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getLinger", "(Lorg/apache/http/params/HttpParams;)I");
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int getConnectionTimeout(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m10 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "getConnectionTimeout", "(Lorg/apache/http/params/HttpParams;)I");
			return @__env.CallStaticIntMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static bool isStaleCheckingEnabled(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParams._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParams._m11 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParams.staticClass, "isStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.@params.HttpConnectionParams.staticClass, global::org.apache.http.@params.HttpConnectionParams._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpConnectionParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpConnectionParams"));
		}
	}
}
