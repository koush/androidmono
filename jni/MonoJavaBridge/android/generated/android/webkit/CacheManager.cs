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
			internal static global::MonoJavaBridge.MethodId _getLocation10261;
			public virtual global::java.lang.String getLocation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getLocation10261)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLocation10261)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getLocalPath10262;
			public virtual global::java.lang.String getLocalPath() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getLocalPath10262)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLocalPath10262)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getInputStream10263;
			public virtual global::java.io.InputStream getInputStream() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getInputStream10263)) as java.io.InputStream;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getInputStream10263)) as java.io.InputStream;
			}
			internal static global::MonoJavaBridge.MethodId _getEncoding10264;
			public virtual global::java.lang.String getEncoding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getEncoding10264)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getEncoding10264)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getContentLength10265;
			public virtual long getContentLength() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getContentLength10265);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getContentLength10265);
			}
			internal static global::MonoJavaBridge.MethodId _getLastModified10266;
			public virtual global::java.lang.String getLastModified() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getLastModified10266)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLastModified10266)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getOutputStream10267;
			public virtual global::java.io.OutputStream getOutputStream() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getOutputStream10267)) as java.io.OutputStream;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getOutputStream10267)) as java.io.OutputStream;
			}
			internal static global::MonoJavaBridge.MethodId _setEncoding10268;
			public virtual void setEncoding(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._setEncoding10268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._setEncoding10268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getHttpStatusCode10269;
			public virtual int getHttpStatusCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getHttpStatusCode10269);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getHttpStatusCode10269);
			}
			internal static global::MonoJavaBridge.MethodId _getExpires10270;
			public virtual long getExpires() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getExpires10270);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getExpires10270);
			}
			internal static global::MonoJavaBridge.MethodId _getExpiresString10271;
			public virtual global::java.lang.String getExpiresString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getExpiresString10271)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getExpiresString10271)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getETag10272;
			public virtual global::java.lang.String getETag() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getETag10272)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getETag10272)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getMimeType10273;
			public virtual global::java.lang.String getMimeType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getMimeType10273)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getMimeType10273)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getContentDisposition10274;
			public virtual global::java.lang.String getContentDisposition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._getContentDisposition10274)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getContentDisposition10274)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setInputStream10275;
			public virtual void setInputStream(java.io.InputStream arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult._setInputStream10275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._setInputStream10275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _CacheResult10276;
			public CacheResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._CacheResult10276);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.CacheManager.CacheResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager$CacheResult"));
				global::android.webkit.CacheManager.CacheResult._getLocation10261 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocation", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getLocalPath10262 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocalPath", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getInputStream10263 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getInputStream", "()Ljava/io/InputStream;");
				global::android.webkit.CacheManager.CacheResult._getEncoding10264 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getEncoding", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getContentLength10265 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentLength", "()J");
				global::android.webkit.CacheManager.CacheResult._getLastModified10266 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getLastModified", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getOutputStream10267 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
				global::android.webkit.CacheManager.CacheResult._setEncoding10268 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "setEncoding", "(Ljava/lang/String;)V");
				global::android.webkit.CacheManager.CacheResult._getHttpStatusCode10269 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getHttpStatusCode", "()I");
				global::android.webkit.CacheManager.CacheResult._getExpires10270 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpires", "()J");
				global::android.webkit.CacheManager.CacheResult._getExpiresString10271 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpiresString", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getETag10272 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getETag", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getMimeType10273 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getMimeType", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getContentDisposition10274 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentDisposition", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._setInputStream10275 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "setInputStream", "(Ljava/io/InputStream;)V");
				global::android.webkit.CacheManager.CacheResult._CacheResult10276 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheFileBaseDir10277;
		public static global::java.io.File getCacheFileBaseDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFileBaseDir10277)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _cacheDisabled10278;
		public static bool cacheDisabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._cacheDisabled10278);
		}
		internal static global::MonoJavaBridge.MethodId _startCacheTransaction10279;
		public static bool startCacheTransaction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._startCacheTransaction10279);
		}
		internal static global::MonoJavaBridge.MethodId _endCacheTransaction10280;
		public static bool endCacheTransaction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._endCacheTransaction10280);
		}
		internal static global::MonoJavaBridge.MethodId _getCacheFile10281;
		public static global::android.webkit.CacheManager.CacheResult getCacheFile(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFile10281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
		}
		internal static global::MonoJavaBridge.MethodId _saveCacheFile10282;
		public static void saveCacheFile(java.lang.String arg0, android.webkit.CacheManager.CacheResult arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._saveCacheFile10282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CacheManager10283;
		public CacheManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._CacheManager10283);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CacheManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager"));
			global::android.webkit.CacheManager._getCacheFileBaseDir10277 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFileBaseDir", "()Ljava/io/File;");
			global::android.webkit.CacheManager._cacheDisabled10278 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "cacheDisabled", "()Z");
			global::android.webkit.CacheManager._startCacheTransaction10279 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "startCacheTransaction", "()Z");
			global::android.webkit.CacheManager._endCacheTransaction10280 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "endCacheTransaction", "()Z");
			global::android.webkit.CacheManager._getCacheFile10281 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			global::android.webkit.CacheManager._saveCacheFile10282 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V");
			global::android.webkit.CacheManager._CacheManager10283 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "<init>", "()V");
		}
	}
}
