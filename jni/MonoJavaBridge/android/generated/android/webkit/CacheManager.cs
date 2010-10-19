namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CacheManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CacheManager()
		{
			InitJNI();
		}
		internal CacheManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CacheResult : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CacheResult()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.MethodId _getLocation10807;
			public virtual global::java.lang.String getLocation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getLocation10807)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLocation10807)) as java.lang.String;
			}
			public new global::java.lang.String LocalPath
			{
				get
				{
					return getLocalPath();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLocalPath10808;
			public virtual global::java.lang.String getLocalPath() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getLocalPath10808)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLocalPath10808)) as java.lang.String;
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
			internal static global::MonoJavaBridge.MethodId _getInputStream10809;
			public virtual global::java.io.InputStream getInputStream() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getInputStream10809)) as java.io.InputStream;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getInputStream10809)) as java.io.InputStream;
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
			internal static global::MonoJavaBridge.MethodId _getEncoding10810;
			public virtual global::java.lang.String getEncoding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getEncoding10810)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getEncoding10810)) as java.lang.String;
			}
			public new long ContentLength
			{
				get
				{
					return getContentLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getContentLength10811;
			public virtual long getContentLength() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getContentLength10811);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getContentLength10811);
			}
			public new global::java.lang.String LastModified
			{
				get
				{
					return getLastModified();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLastModified10812;
			public virtual global::java.lang.String getLastModified() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getLastModified10812)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLastModified10812)) as java.lang.String;
			}
			public new global::java.io.OutputStream OutputStream
			{
				get
				{
					return getOutputStream();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getOutputStream10813;
			public virtual global::java.io.OutputStream getOutputStream() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getOutputStream10813)) as java.io.OutputStream;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getOutputStream10813)) as java.io.OutputStream;
			}
			internal static global::MonoJavaBridge.MethodId _setEncoding10814;
			public virtual void setEncoding(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._setEncoding10814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._setEncoding10814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int HttpStatusCode
			{
				get
				{
					return getHttpStatusCode();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHttpStatusCode10815;
			public virtual int getHttpStatusCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getHttpStatusCode10815);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getHttpStatusCode10815);
			}
			public new long Expires
			{
				get
				{
					return getExpires();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExpires10816;
			public virtual long getExpires() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getExpires10816);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getExpires10816);
			}
			public new global::java.lang.String ExpiresString
			{
				get
				{
					return getExpiresString();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExpiresString10817;
			public virtual global::java.lang.String getExpiresString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getExpiresString10817)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getExpiresString10817)) as java.lang.String;
			}
			public new global::java.lang.String ETag
			{
				get
				{
					return getETag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getETag10818;
			public virtual global::java.lang.String getETag() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getETag10818)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getETag10818)) as java.lang.String;
			}
			public new global::java.lang.String MimeType
			{
				get
				{
					return getMimeType();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMimeType10819;
			public virtual global::java.lang.String getMimeType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getMimeType10819)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getMimeType10819)) as java.lang.String;
			}
			public new global::java.lang.String ContentDisposition
			{
				get
				{
					return getContentDisposition();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getContentDisposition10820;
			public virtual global::java.lang.String getContentDisposition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getContentDisposition10820)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getContentDisposition10820)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setInputStream10821;
			public virtual void setInputStream(java.io.InputStream arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._setInputStream10821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._setInputStream10821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _CacheResult10822;
			public CacheResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._CacheResult10822);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.CacheManager.CacheResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager$CacheResult"));
				global::android.webkit.CacheManager.CacheResult._getLocation10807 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocation", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getLocalPath10808 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocalPath", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getInputStream10809 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getInputStream", "()Ljava/io/InputStream;");
				global::android.webkit.CacheManager.CacheResult._getEncoding10810 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getEncoding", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getContentLength10811 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentLength", "()J");
				global::android.webkit.CacheManager.CacheResult._getLastModified10812 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getLastModified", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getOutputStream10813 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
				global::android.webkit.CacheManager.CacheResult._setEncoding10814 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "setEncoding", "(Ljava/lang/String;)V");
				global::android.webkit.CacheManager.CacheResult._getHttpStatusCode10815 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getHttpStatusCode", "()I");
				global::android.webkit.CacheManager.CacheResult._getExpires10816 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpires", "()J");
				global::android.webkit.CacheManager.CacheResult._getExpiresString10817 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpiresString", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getETag10818 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getETag", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getMimeType10819 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getMimeType", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getContentDisposition10820 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentDisposition", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._setInputStream10821 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "setInputStream", "(Ljava/io/InputStream;)V");
				global::android.webkit.CacheManager.CacheResult._CacheResult10822 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "<init>", "()V");
			}
		}
		public static global::java.io.File CacheFileBaseDir
		{
			get
			{
				return getCacheFileBaseDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheFileBaseDir10823;
		public static global::java.io.File getCacheFileBaseDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFileBaseDir10823)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _cacheDisabled10824;
		public static bool cacheDisabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._cacheDisabled10824);
		}
		internal static global::MonoJavaBridge.MethodId _startCacheTransaction10825;
		public static bool startCacheTransaction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._startCacheTransaction10825);
		}
		internal static global::MonoJavaBridge.MethodId _endCacheTransaction10826;
		public static bool endCacheTransaction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._endCacheTransaction10826);
		}
		internal static global::MonoJavaBridge.MethodId _getCacheFile10827;
		public static global::android.webkit.CacheManager.CacheResult getCacheFile(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFile10827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
		}
		internal static global::MonoJavaBridge.MethodId _saveCacheFile10828;
		public static void saveCacheFile(java.lang.String arg0, android.webkit.CacheManager.CacheResult arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._saveCacheFile10828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CacheManager10829;
		public CacheManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._CacheManager10829);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CacheManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager"));
			global::android.webkit.CacheManager._getCacheFileBaseDir10823 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFileBaseDir", "()Ljava/io/File;");
			global::android.webkit.CacheManager._cacheDisabled10824 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "cacheDisabled", "()Z");
			global::android.webkit.CacheManager._startCacheTransaction10825 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "startCacheTransaction", "()Z");
			global::android.webkit.CacheManager._endCacheTransaction10826 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "endCacheTransaction", "()Z");
			global::android.webkit.CacheManager._getCacheFile10827 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			global::android.webkit.CacheManager._saveCacheFile10828 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V");
			global::android.webkit.CacheManager._CacheManager10829 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "<init>", "()V");
		}
	}
}
