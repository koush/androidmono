namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CacheManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CacheManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CacheResult : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CacheResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new global::java.lang.String Location
			{
				get
				{
					return getLocation();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLocation15989;
			public virtual global::java.lang.String getLocation()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getLocation", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getLocation15989) as java.lang.String;
			}
			public new global::java.lang.String LocalPath
			{
				get
				{
					return getLocalPath();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLocalPath15990;
			public virtual global::java.lang.String getLocalPath()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getLocalPath", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getLocalPath15990) as java.lang.String;
			}
			public new global::java.io.InputStream InputStream
			{
				get
				{
					return getInputStream();
				}
				set
				{
					setInputStream(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getInputStream15991;
			public virtual global::java.io.InputStream getInputStream()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.webkit.CacheManager.CacheResult._getInputStream15991) as java.io.InputStream;
			}
			public new global::java.lang.String Encoding
			{
				get
				{
					return getEncoding();
				}
				set
				{
					setEncoding(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getEncoding15992;
			public virtual global::java.lang.String getEncoding()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getEncoding15992) as java.lang.String;
			}
			public new long ContentLength
			{
				get
				{
					return getContentLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getContentLength15993;
			public virtual long getContentLength()
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getContentLength", "()J", ref global::android.webkit.CacheManager.CacheResult._getContentLength15993);
			}
			public new global::java.lang.String LastModified
			{
				get
				{
					return getLastModified();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLastModified15994;
			public virtual global::java.lang.String getLastModified()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getLastModified", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getLastModified15994) as java.lang.String;
			}
			public new global::java.io.OutputStream OutputStream
			{
				get
				{
					return getOutputStream();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getOutputStream15995;
			public virtual global::java.io.OutputStream getOutputStream()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.webkit.CacheManager.CacheResult._getOutputStream15995) as java.io.OutputStream;
			}
			internal static global::MonoJavaBridge.MethodId _setEncoding15996;
			public virtual void setEncoding(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::android.webkit.CacheManager.CacheResult._setEncoding15996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int HttpStatusCode
			{
				get
				{
					return getHttpStatusCode();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHttpStatusCode15997;
			public virtual int getHttpStatusCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getHttpStatusCode", "()I", ref global::android.webkit.CacheManager.CacheResult._getHttpStatusCode15997);
			}
			public new long Expires
			{
				get
				{
					return getExpires();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExpires15998;
			public virtual long getExpires()
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getExpires", "()J", ref global::android.webkit.CacheManager.CacheResult._getExpires15998);
			}
			public new global::java.lang.String ExpiresString
			{
				get
				{
					return getExpiresString();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExpiresString15999;
			public virtual global::java.lang.String getExpiresString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getExpiresString", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getExpiresString15999) as java.lang.String;
			}
			public new global::java.lang.String ETag
			{
				get
				{
					return getETag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getETag16000;
			public virtual global::java.lang.String getETag()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getETag", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getETag16000) as java.lang.String;
			}
			public new global::java.lang.String MimeType
			{
				get
				{
					return getMimeType();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMimeType16001;
			public virtual global::java.lang.String getMimeType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getMimeType", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getMimeType16001) as java.lang.String;
			}
			public new global::java.lang.String ContentDisposition
			{
				get
				{
					return getContentDisposition();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getContentDisposition16002;
			public virtual global::java.lang.String getContentDisposition()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getContentDisposition", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._getContentDisposition16002) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setInputStream16003;
			public virtual void setInputStream(java.io.InputStream arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "setInputStream", "(Ljava/io/InputStream;)V", ref global::android.webkit.CacheManager.CacheResult._setInputStream16003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _CacheResult16004;
			public CacheResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.CacheManager.CacheResult._CacheResult16004.native == global::System.IntPtr.Zero)
					global::android.webkit.CacheManager.CacheResult._CacheResult16004 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._CacheResult16004);
				Init(@__env, handle);
			}
			static CacheResult()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.CacheManager.CacheResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager$CacheResult"));
			}
			internal static void InitJNI()
			{
			}
		}
		public static global::java.io.File CacheFileBaseDir
		{
			get
			{
				return getCacheFileBaseDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheFileBaseDir16005;
		public static global::java.io.File getCacheFileBaseDir()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._getCacheFileBaseDir16005.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._getCacheFileBaseDir16005 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFileBaseDir", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFileBaseDir16005)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _cacheDisabled16006;
		public static bool cacheDisabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._cacheDisabled16006.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._cacheDisabled16006 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "cacheDisabled", "()Z");
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._cacheDisabled16006);
		}
		internal static global::MonoJavaBridge.MethodId _startCacheTransaction16007;
		public static bool startCacheTransaction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._startCacheTransaction16007.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._startCacheTransaction16007 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "startCacheTransaction", "()Z");
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._startCacheTransaction16007);
		}
		internal static global::MonoJavaBridge.MethodId _endCacheTransaction16008;
		public static bool endCacheTransaction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._endCacheTransaction16008.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._endCacheTransaction16008 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "endCacheTransaction", "()Z");
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._endCacheTransaction16008);
		}
		internal static global::MonoJavaBridge.MethodId _getCacheFile16009;
		public static global::android.webkit.CacheManager.CacheResult getCacheFile(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._getCacheFile16009.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._getCacheFile16009 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFile16009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
		}
		internal static global::MonoJavaBridge.MethodId _saveCacheFile16010;
		public static void saveCacheFile(java.lang.String arg0, android.webkit.CacheManager.CacheResult arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._saveCacheFile16010.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._saveCacheFile16010 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V");
			@__env.CallStaticVoidMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._saveCacheFile16010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CacheManager16011;
		public CacheManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._CacheManager16011.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._CacheManager16011 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._CacheManager16011);
			Init(@__env, handle);
		}
		static CacheManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CacheManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
