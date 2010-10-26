namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.HttpURLConnection_))]
	public abstract partial class HttpURLConnection : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpURLConnection()
		{
			InitJNI();
		}
		protected HttpURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPermission21471;
		public override global::java.security.Permission getPermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection._getPermission21471)) as java.security.Permission;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getPermission21471)) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _setRequestMethod21472;
		public virtual void setRequestMethod(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection._setRequestMethod21472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._setRequestMethod21472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseCode21473;
		public virtual int getResponseCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.HttpURLConnection._getResponseCode21473);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getResponseCode21473);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21474;
		public override global::java.lang.String getHeaderField(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection._getHeaderField21474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getHeaderField21474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldKey21475;
		public override global::java.lang.String getHeaderFieldKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection._getHeaderFieldKey21475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getHeaderFieldKey21475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldDate21476;
		public override long getHeaderFieldDate(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.HttpURLConnection._getHeaderFieldDate21476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getHeaderFieldDate21476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect21477;
		public abstract void disconnect();
		internal static global::MonoJavaBridge.MethodId _getErrorStream21478;
		public virtual global::java.io.InputStream getErrorStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection._getErrorStream21478)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getErrorStream21478)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setFixedLengthStreamingMode21479;
		public virtual void setFixedLengthStreamingMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection._setFixedLengthStreamingMode21479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._setFixedLengthStreamingMode21479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChunkedStreamingMode21480;
		public virtual void setChunkedStreamingMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection._setChunkedStreamingMode21480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._setChunkedStreamingMode21480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFollowRedirects21481;
		public static void setFollowRedirects(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._setFollowRedirects21481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFollowRedirects21482;
		public static bool getFollowRedirects() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getFollowRedirects21482);
		}
		internal static global::MonoJavaBridge.MethodId _setInstanceFollowRedirects21483;
		public virtual void setInstanceFollowRedirects(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection._setInstanceFollowRedirects21483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._setInstanceFollowRedirects21483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstanceFollowRedirects21484;
		public virtual bool getInstanceFollowRedirects() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.HttpURLConnection._getInstanceFollowRedirects21484);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getInstanceFollowRedirects21484);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestMethod21485;
		public virtual global::java.lang.String getRequestMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection._getRequestMethod21485)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getRequestMethod21485)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseMessage21486;
		public virtual global::java.lang.String getResponseMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection._getResponseMessage21486)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._getResponseMessage21486)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _usingProxy21487;
		public abstract bool usingProxy();
		internal static global::MonoJavaBridge.MethodId _HttpURLConnection21488;
		protected HttpURLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpURLConnection.staticClass, global::java.net.HttpURLConnection._HttpURLConnection21488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.HttpURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/HttpURLConnection"));
			global::java.net.HttpURLConnection._getPermission21471 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getPermission", "()Ljava/security/Permission;");
			global::java.net.HttpURLConnection._setRequestMethod21472 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "setRequestMethod", "(Ljava/lang/String;)V");
			global::java.net.HttpURLConnection._getResponseCode21473 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getResponseCode", "()I");
			global::java.net.HttpURLConnection._getHeaderField21474 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;");
			global::java.net.HttpURLConnection._getHeaderFieldKey21475 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;");
			global::java.net.HttpURLConnection._getHeaderFieldDate21476 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J");
			global::java.net.HttpURLConnection._disconnect21477 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "disconnect", "()V");
			global::java.net.HttpURLConnection._getErrorStream21478 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getErrorStream", "()Ljava/io/InputStream;");
			global::java.net.HttpURLConnection._setFixedLengthStreamingMode21479 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "setFixedLengthStreamingMode", "(I)V");
			global::java.net.HttpURLConnection._setChunkedStreamingMode21480 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "setChunkedStreamingMode", "(I)V");
			global::java.net.HttpURLConnection._setFollowRedirects21481 = @__env.GetStaticMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "setFollowRedirects", "(Z)V");
			global::java.net.HttpURLConnection._getFollowRedirects21482 = @__env.GetStaticMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getFollowRedirects", "()Z");
			global::java.net.HttpURLConnection._setInstanceFollowRedirects21483 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "setInstanceFollowRedirects", "(Z)V");
			global::java.net.HttpURLConnection._getInstanceFollowRedirects21484 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getInstanceFollowRedirects", "()Z");
			global::java.net.HttpURLConnection._getRequestMethod21485 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getRequestMethod", "()Ljava/lang/String;");
			global::java.net.HttpURLConnection._getResponseMessage21486 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "getResponseMessage", "()Ljava/lang/String;");
			global::java.net.HttpURLConnection._usingProxy21487 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "usingProxy", "()Z");
			global::java.net.HttpURLConnection._HttpURLConnection21488 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.HttpURLConnection))]
	internal sealed partial class HttpURLConnection_ : java.net.HttpURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpURLConnection_()
		{
			InitJNI();
		}
		internal HttpURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _disconnect21525;
		public override void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection_._disconnect21525);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection_.staticClass, global::java.net.HttpURLConnection_._disconnect21525);
		}
		internal static global::MonoJavaBridge.MethodId _usingProxy21526;
		public override bool usingProxy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.HttpURLConnection_._usingProxy21526);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.HttpURLConnection_.staticClass, global::java.net.HttpURLConnection_._usingProxy21526);
		}
		internal static global::MonoJavaBridge.MethodId _connect21527;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection_._connect21527);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.HttpURLConnection_.staticClass, global::java.net.HttpURLConnection_._connect21527);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.HttpURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/HttpURLConnection"));
			global::java.net.HttpURLConnection_._disconnect21525 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection_.staticClass, "disconnect", "()V");
			global::java.net.HttpURLConnection_._usingProxy21526 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection_.staticClass, "usingProxy", "()Z");
			global::java.net.HttpURLConnection_._connect21527 = @__env.GetMethodIDNoThrow(global::java.net.HttpURLConnection_.staticClass, "connect", "()V");
		}
	}
}
