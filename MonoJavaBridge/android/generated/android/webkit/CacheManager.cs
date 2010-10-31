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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.lang.String getLocation()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getLocation", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m0) as java.lang.String;
			}
			public new global::java.lang.String LocalPath
			{
				get
				{
					return getLocalPath();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::java.lang.String getLocalPath()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getLocalPath", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m1) as java.lang.String;
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
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::java.io.InputStream getInputStream()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.webkit.CacheManager.CacheResult._m2) as java.io.InputStream;
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
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual global::java.lang.String getEncoding()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m3) as java.lang.String;
			}
			public new long ContentLength
			{
				get
				{
					return getContentLength();
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual long getContentLength()
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getContentLength", "()J", ref global::android.webkit.CacheManager.CacheResult._m4);
			}
			public new global::java.lang.String LastModified
			{
				get
				{
					return getLastModified();
				}
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::java.lang.String getLastModified()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getLastModified", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m5) as java.lang.String;
			}
			public new global::java.io.OutputStream OutputStream
			{
				get
				{
					return getOutputStream();
				}
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::java.io.OutputStream getOutputStream()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.webkit.CacheManager.CacheResult._m6) as java.io.OutputStream;
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual void setEncoding(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::android.webkit.CacheManager.CacheResult._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int HttpStatusCode
			{
				get
				{
					return getHttpStatusCode();
				}
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual int getHttpStatusCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getHttpStatusCode", "()I", ref global::android.webkit.CacheManager.CacheResult._m8);
			}
			public new long Expires
			{
				get
				{
					return getExpires();
				}
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual long getExpires()
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getExpires", "()J", ref global::android.webkit.CacheManager.CacheResult._m9);
			}
			public new global::java.lang.String ExpiresString
			{
				get
				{
					return getExpiresString();
				}
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public virtual global::java.lang.String getExpiresString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getExpiresString", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m10) as java.lang.String;
			}
			public new global::java.lang.String ETag
			{
				get
				{
					return getETag();
				}
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public virtual global::java.lang.String getETag()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getETag", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m11) as java.lang.String;
			}
			public new global::java.lang.String MimeType
			{
				get
				{
					return getMimeType();
				}
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public virtual global::java.lang.String getMimeType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getMimeType", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m12) as java.lang.String;
			}
			public new global::java.lang.String ContentDisposition
			{
				get
				{
					return getContentDisposition();
				}
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public virtual global::java.lang.String getContentDisposition()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CacheManager.CacheResult.staticClass, "getContentDisposition", "()Ljava/lang/String;", ref global::android.webkit.CacheManager.CacheResult._m13) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public virtual void setInputStream(java.io.InputStream arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, "setInputStream", "(Ljava/io/InputStream;)V", ref global::android.webkit.CacheManager.CacheResult._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m15;
			public CacheResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.CacheManager.CacheResult._m15.native == global::System.IntPtr.Zero)
					global::android.webkit.CacheManager.CacheResult._m15 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.CacheResult.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._m15);
				Init(@__env, handle);
			}
			static CacheResult()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.CacheManager.CacheResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager$CacheResult"));
			}
		}
		public static global::java.io.File CacheFileBaseDir
		{
			get
			{
				return getCacheFileBaseDir();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.io.File getCacheFileBaseDir()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFileBaseDir", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._m0)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool cacheDisabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._m1.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "cacheDisabled", "()Z");
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool startCacheTransaction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._m2.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._m2 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "startCacheTransaction", "()Z");
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool endCacheTransaction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._m3.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._m3 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "endCacheTransaction", "()Z");
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::android.webkit.CacheManager.CacheResult getCacheFile(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._m4.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._m4 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void saveCacheFile(java.lang.String arg0, android.webkit.CacheManager.CacheResult arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._m5.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._m5 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V");
			@__env.CallStaticVoidMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public CacheManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CacheManager._m6.native == global::System.IntPtr.Zero)
				global::android.webkit.CacheManager._m6 = @__env.GetMethodIDNoThrow(global::android.webkit.CacheManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._m6);
			Init(@__env, handle);
		}
		static CacheManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CacheManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CacheManager"));
		}
	}
}
