namespace android.net.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AndroidHttpClient : java.lang.Object, org.apache.http.client.HttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AndroidHttpClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.net.http.AndroidHttpClient newInstance(java.lang.String arg0, android.content.Context arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.AndroidHttpClient._m0.native == global::System.IntPtr.Zero)
				global::android.net.http.AndroidHttpClient._m0 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "newInstance", "(Ljava/lang/String;Landroid/content/Context;)Landroid/net/http/AndroidHttpClient;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.http.AndroidHttpClient>(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.http.AndroidHttpClient;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.net.http.AndroidHttpClient newInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.AndroidHttpClient._m1.native == global::System.IntPtr.Zero)
				global::android.net.http.AndroidHttpClient._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "newInstance", "(Ljava/lang/String;)Landroid/net/http/AndroidHttpClient;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.http.AndroidHttpClient>(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.http.AndroidHttpClient;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.http.AndroidHttpClient.staticClass, "close", "()V", ref global::android.net.http.AndroidHttpClient._m2);
		}
		public new global::org.apache.http.@params.HttpParams Params
		{
			get
			{
				return getParams();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::org.apache.http.@params.HttpParams getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::android.net.http.AndroidHttpClient.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::android.net.http.AndroidHttpClient._m3) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpResponse;", ref global::android.net.http.AndroidHttpClient._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", ref global::android.net.http.AndroidHttpClient._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::android.net.http.AndroidHttpClient._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::android.net.http.AndroidHttpClient._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;", ref global::android.net.http.AndroidHttpClient._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::android.net.http.AndroidHttpClient._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;", ref global::android.net.http.AndroidHttpClient._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::android.net.http.AndroidHttpClient._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void modifyRequestToAcceptGzipResponse(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.AndroidHttpClient._m12.native == global::System.IntPtr.Zero)
				global::android.net.http.AndroidHttpClient._m12 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "modifyRequestToAcceptGzipResponse", "(Lorg/apache/http/HttpRequest;)V");
			@__env.CallStaticVoidMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.io.InputStream getUngzippedContent(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.AndroidHttpClient._m13.native == global::System.IntPtr.Zero)
				global::android.net.http.AndroidHttpClient._m13 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getUngzippedContent", "(Lorg/apache/http/HttpEntity;)Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		public new global::org.apache.http.conn.ClientConnectionManager ConnectionManager
		{
			get
			{
				return getConnectionManager();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::org.apache.http.conn.ClientConnectionManager getConnectionManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::android.net.http.AndroidHttpClient.staticClass, "getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", ref global::android.net.http.AndroidHttpClient._m14) as org.apache.http.conn.ClientConnectionManager;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::org.apache.http.entity.AbstractHttpEntity getCompressedEntity(byte[] arg0, android.content.ContentResolver arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.AndroidHttpClient._m15.native == global::System.IntPtr.Zero)
				global::android.net.http.AndroidHttpClient._m15 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getCompressedEntity", "([BLandroid/content/ContentResolver;)Lorg/apache/http/entity/AbstractHttpEntity;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.entity.AbstractHttpEntity;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static long getMinGzipSize(android.content.ContentResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.AndroidHttpClient._m16.native == global::System.IntPtr.Zero)
				global::android.net.http.AndroidHttpClient._m16 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getMinGzipSize", "(Landroid/content/ContentResolver;)J");
			return @__env.CallStaticLongMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public void enableCurlLogging(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.http.AndroidHttpClient.staticClass, "enableCurlLogging", "(Ljava/lang/String;I)V", ref global::android.net.http.AndroidHttpClient._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public void disableCurlLogging()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.http.AndroidHttpClient.staticClass, "disableCurlLogging", "()V", ref global::android.net.http.AndroidHttpClient._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static long parseDate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.AndroidHttpClient._m19.native == global::System.IntPtr.Zero)
				global::android.net.http.AndroidHttpClient._m19 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "parseDate", "(Ljava/lang/String;)J");
			return @__env.CallStaticLongMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT_SYNC_MIN_GZIP_BYTES3019;
		public static long DEFAULT_SYNC_MIN_GZIP_BYTES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticLongField(global::android.net.http.AndroidHttpClient.staticClass, _DEFAULT_SYNC_MIN_GZIP_BYTES3019);
			}
			set
			{
			}
		}
		static AndroidHttpClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.AndroidHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/AndroidHttpClient"));
			global::android.net.http.AndroidHttpClient._DEFAULT_SYNC_MIN_GZIP_BYTES3019 = @__env.GetStaticFieldIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "DEFAULT_SYNC_MIN_GZIP_BYTES", "J");
		}
	}
}
