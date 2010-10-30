namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.HttpURLConnection_))]
	public abstract partial class HttpURLConnection : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPermission21472;
		public override global::java.security.Permission getPermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.HttpURLConnection.staticClass, "getPermission", "()Ljava/security/Permission;", ref global::java.net.HttpURLConnection._getPermission21472) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _setRequestMethod21473;
		public virtual void setRequestMethod(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.HttpURLConnection.staticClass, "setRequestMethod", "(Ljava/lang/String;)V", ref global::java.net.HttpURLConnection._setRequestMethod21473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseCode21474;
		public virtual int getResponseCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.HttpURLConnection.staticClass, "getResponseCode", "()I", ref global::java.net.HttpURLConnection._getResponseCode21474);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21475;
		public override global::java.lang.String getHeaderField(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.HttpURLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;", ref global::java.net.HttpURLConnection._getHeaderField21475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldKey21476;
		public override global::java.lang.String getHeaderFieldKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.HttpURLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;", ref global::java.net.HttpURLConnection._getHeaderFieldKey21476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldDate21477;
		public override long getHeaderFieldDate(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.HttpURLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J", ref global::java.net.HttpURLConnection._getHeaderFieldDate21477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect21478;
		public abstract void disconnect();
		internal static global::MonoJavaBridge.MethodId _getErrorStream21479;
		public virtual global::java.io.InputStream getErrorStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.HttpURLConnection.staticClass, "getErrorStream", "()Ljava/io/InputStream;", ref global::java.net.HttpURLConnection._getErrorStream21479) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setFixedLengthStreamingMode21480;
		public virtual void setFixedLengthStreamingMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.HttpURLConnection.staticClass, "setFixedLengthStreamingMode", "(I)V", ref global::java.net.HttpURLConnection._setFixedLengthStreamingMode21480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChunkedStreamingMode21481;
		public virtual void setChunkedStreamingMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.HttpURLConnection.staticClass, "setChunkedStreamingMode", "(I)V", ref global::java.net.HttpURLConnection._setChunkedStreamingMode21481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFollowRedirects21482;
		public static void setFollowRedirects(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.HttpURLConnection._setFollowRedirects21482.native == global::System.IntPtr.Zero)
				global::java.net.HttpURLConnection._setFollowRedirects21482 = @__env.GetStaticMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "setFollowRedirects", "(Z)V");
			@__env.CallStaticVoidMethod(java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._setFollowRedirects21482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFollowRedirects21483;
		public static bool getFollowRedirects()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.HttpURLConnection._getFollowRedirects21483.native == global::System.IntPtr.Zero)
				global::java.net.HttpURLConnection._getFollowRedirects21483 = @__env.GetStaticMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getFollowRedirects", "()Z");
			return @__env.CallStaticBooleanMethod(java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getFollowRedirects21483);
		}
		internal static global::MonoJavaBridge.MethodId _setInstanceFollowRedirects21484;
		public virtual void setInstanceFollowRedirects(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.HttpURLConnection.staticClass, "setInstanceFollowRedirects", "(Z)V", ref global::java.net.HttpURLConnection._setInstanceFollowRedirects21484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstanceFollowRedirects21485;
		public virtual bool getInstanceFollowRedirects()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.HttpURLConnection.staticClass, "getInstanceFollowRedirects", "()Z", ref global::java.net.HttpURLConnection._getInstanceFollowRedirects21485);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestMethod21486;
		public virtual global::java.lang.String getRequestMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.HttpURLConnection.staticClass, "getRequestMethod", "()Ljava/lang/String;", ref global::java.net.HttpURLConnection._getRequestMethod21486) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseMessage21487;
		public virtual global::java.lang.String getResponseMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.HttpURLConnection.staticClass, "getResponseMessage", "()Ljava/lang/String;", ref global::java.net.HttpURLConnection._getResponseMessage21487) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _usingProxy21488;
		public abstract bool usingProxy();
		internal static global::MonoJavaBridge.MethodId _HttpURLConnection21489;
		protected HttpURLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.HttpURLConnection._HttpURLConnection21489.native == global::System.IntPtr.Zero)
				global::java.net.HttpURLConnection._HttpURLConnection21489 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._HttpURLConnection21489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int HTTP_OK
		{
			get
			{
				return 200;
			}
		}
		public static int HTTP_CREATED
		{
			get
			{
				return 201;
			}
		}
		public static int HTTP_ACCEPTED
		{
			get
			{
				return 202;
			}
		}
		public static int HTTP_NOT_AUTHORITATIVE
		{
			get
			{
				return 203;
			}
		}
		public static int HTTP_NO_CONTENT
		{
			get
			{
				return 204;
			}
		}
		public static int HTTP_RESET
		{
			get
			{
				return 205;
			}
		}
		public static int HTTP_PARTIAL
		{
			get
			{
				return 206;
			}
		}
		public static int HTTP_MULT_CHOICE
		{
			get
			{
				return 300;
			}
		}
		public static int HTTP_MOVED_PERM
		{
			get
			{
				return 301;
			}
		}
		public static int HTTP_MOVED_TEMP
		{
			get
			{
				return 302;
			}
		}
		public static int HTTP_SEE_OTHER
		{
			get
			{
				return 303;
			}
		}
		public static int HTTP_NOT_MODIFIED
		{
			get
			{
				return 304;
			}
		}
		public static int HTTP_USE_PROXY
		{
			get
			{
				return 305;
			}
		}
		public static int HTTP_BAD_REQUEST
		{
			get
			{
				return 400;
			}
		}
		public static int HTTP_UNAUTHORIZED
		{
			get
			{
				return 401;
			}
		}
		public static int HTTP_PAYMENT_REQUIRED
		{
			get
			{
				return 402;
			}
		}
		public static int HTTP_FORBIDDEN
		{
			get
			{
				return 403;
			}
		}
		public static int HTTP_NOT_FOUND
		{
			get
			{
				return 404;
			}
		}
		public static int HTTP_BAD_METHOD
		{
			get
			{
				return 405;
			}
		}
		public static int HTTP_NOT_ACCEPTABLE
		{
			get
			{
				return 406;
			}
		}
		public static int HTTP_PROXY_AUTH
		{
			get
			{
				return 407;
			}
		}
		public static int HTTP_CLIENT_TIMEOUT
		{
			get
			{
				return 408;
			}
		}
		public static int HTTP_CONFLICT
		{
			get
			{
				return 409;
			}
		}
		public static int HTTP_GONE
		{
			get
			{
				return 410;
			}
		}
		public static int HTTP_LENGTH_REQUIRED
		{
			get
			{
				return 411;
			}
		}
		public static int HTTP_PRECON_FAILED
		{
			get
			{
				return 412;
			}
		}
		public static int HTTP_ENTITY_TOO_LARGE
		{
			get
			{
				return 413;
			}
		}
		public static int HTTP_REQ_TOO_LONG
		{
			get
			{
				return 414;
			}
		}
		public static int HTTP_UNSUPPORTED_TYPE
		{
			get
			{
				return 415;
			}
		}
		public static int HTTP_SERVER_ERROR
		{
			get
			{
				return 500;
			}
		}
		public static int HTTP_INTERNAL_ERROR
		{
			get
			{
				return 500;
			}
		}
		public static int HTTP_NOT_IMPLEMENTED
		{
			get
			{
				return 501;
			}
		}
		public static int HTTP_BAD_GATEWAY
		{
			get
			{
				return 502;
			}
		}
		public static int HTTP_UNAVAILABLE
		{
			get
			{
				return 503;
			}
		}
		public static int HTTP_GATEWAY_TIMEOUT
		{
			get
			{
				return 504;
			}
		}
		public static int HTTP_VERSION
		{
			get
			{
				return 505;
			}
		}
		static HttpURLConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.HttpURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/HttpURLConnection"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.HttpURLConnection))]
	internal sealed partial class HttpURLConnection_ : java.net.HttpURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _disconnect21526;
		public override void disconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.HttpURLConnection_.staticClass, "disconnect", "()V", ref global::java.net.HttpURLConnection_._disconnect21526);
		}
		internal static global::MonoJavaBridge.MethodId _usingProxy21527;
		public override bool usingProxy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.HttpURLConnection_.staticClass, "usingProxy", "()Z", ref global::java.net.HttpURLConnection_._usingProxy21527);
		}
		internal static global::MonoJavaBridge.MethodId _connect21528;
		public override void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.HttpURLConnection_.staticClass, "connect", "()V", ref global::java.net.HttpURLConnection_._connect21528);
		}
		static HttpURLConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.HttpURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/HttpURLConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
