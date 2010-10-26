namespace android.net.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AndroidHttpClient : java.lang.Object, org.apache.http.client.HttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AndroidHttpClient()
		{
			InitJNI();
		}
		internal AndroidHttpClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance7923;
		public static global::android.net.http.AndroidHttpClient newInstance(java.lang.String arg0, android.content.Context arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.http.AndroidHttpClient>(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._newInstance7923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.http.AndroidHttpClient;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance7924;
		public static global::android.net.http.AndroidHttpClient newInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.http.AndroidHttpClient>(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._newInstance7924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.http.AndroidHttpClient;
		}
		internal static global::MonoJavaBridge.MethodId _close7925;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._close7925);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._close7925);
		}
		public new global::org.apache.http.@params.HttpParams Params
		{
			get
			{
				return getParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParams7926;
		public global::org.apache.http.@params.HttpParams getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._getParams7926)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._getParams7926)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _execute7927;
		public global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute7928;
		public global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute7929;
		public global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute7930;
		public global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute7931;
		public global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute7932;
		public global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute7933;
		public global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute7934;
		public global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._execute7934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._execute7934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _modifyRequestToAcceptGzipResponse7935;
		public static void modifyRequestToAcceptGzipResponse(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._modifyRequestToAcceptGzipResponse7935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUngzippedContent7936;
		public static global::java.io.InputStream getUngzippedContent(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._getUngzippedContent7936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		public new global::org.apache.http.conn.ClientConnectionManager ConnectionManager
		{
			get
			{
				return getConnectionManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionManager7937;
		public global::org.apache.http.conn.ClientConnectionManager getConnectionManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._getConnectionManager7937)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._getConnectionManager7937)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _getCompressedEntity7938;
		public static global::org.apache.http.entity.AbstractHttpEntity getCompressedEntity(byte[] arg0, android.content.ContentResolver arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._getCompressedEntity7938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.entity.AbstractHttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _getMinGzipSize7939;
		public static long getMinGzipSize(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._getMinGzipSize7939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enableCurlLogging7940;
		public void enableCurlLogging(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._enableCurlLogging7940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._enableCurlLogging7940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disableCurlLogging7941;
		public void disableCurlLogging() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient._disableCurlLogging7941);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._disableCurlLogging7941);
		}
		internal static global::MonoJavaBridge.MethodId _parseDate7942;
		public static long parseDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.http.AndroidHttpClient.staticClass, global::android.net.http.AndroidHttpClient._parseDate7942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT_SYNC_MIN_GZIP_BYTES7943;
		public static long DEFAULT_SYNC_MIN_GZIP_BYTES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticLongField(global::android.net.http.AndroidHttpClient.staticClass, _DEFAULT_SYNC_MIN_GZIP_BYTES7943);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.AndroidHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/AndroidHttpClient"));
			global::android.net.http.AndroidHttpClient._newInstance7923 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "newInstance", "(Ljava/lang/String;Landroid/content/Context;)Landroid/net/http/AndroidHttpClient;");
			global::android.net.http.AndroidHttpClient._newInstance7924 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "newInstance", "(Ljava/lang/String;)Landroid/net/http/AndroidHttpClient;");
			global::android.net.http.AndroidHttpClient._close7925 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "close", "()V");
			global::android.net.http.AndroidHttpClient._getParams7926 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;");
			global::android.net.http.AndroidHttpClient._execute7927 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpResponse;");
			global::android.net.http.AndroidHttpClient._execute7928 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;");
			global::android.net.http.AndroidHttpClient._execute7929 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::android.net.http.AndroidHttpClient._execute7930 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::android.net.http.AndroidHttpClient._execute7931 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::android.net.http.AndroidHttpClient._execute7932 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::android.net.http.AndroidHttpClient._execute7933 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::android.net.http.AndroidHttpClient._execute7934 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::android.net.http.AndroidHttpClient._modifyRequestToAcceptGzipResponse7935 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "modifyRequestToAcceptGzipResponse", "(Lorg/apache/http/HttpRequest;)V");
			global::android.net.http.AndroidHttpClient._getUngzippedContent7936 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getUngzippedContent", "(Lorg/apache/http/HttpEntity;)Ljava/io/InputStream;");
			global::android.net.http.AndroidHttpClient._getConnectionManager7937 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::android.net.http.AndroidHttpClient._getCompressedEntity7938 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getCompressedEntity", "([BLandroid/content/ContentResolver;)Lorg/apache/http/entity/AbstractHttpEntity;");
			global::android.net.http.AndroidHttpClient._getMinGzipSize7939 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "getMinGzipSize", "(Landroid/content/ContentResolver;)J");
			global::android.net.http.AndroidHttpClient._enableCurlLogging7940 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "enableCurlLogging", "(Ljava/lang/String;I)V");
			global::android.net.http.AndroidHttpClient._disableCurlLogging7941 = @__env.GetMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "disableCurlLogging", "()V");
			global::android.net.http.AndroidHttpClient._parseDate7942 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "parseDate", "(Ljava/lang/String;)J");
			global::android.net.http.AndroidHttpClient._DEFAULT_SYNC_MIN_GZIP_BYTES7943 = @__env.GetStaticFieldIDNoThrow(global::android.net.http.AndroidHttpClient.staticClass, "DEFAULT_SYNC_MIN_GZIP_BYTES", "J");
		}
	}
}
