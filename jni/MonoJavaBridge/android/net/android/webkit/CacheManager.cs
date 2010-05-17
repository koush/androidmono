namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CacheManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CacheManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.CacheManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.CacheManager(@__env); 
			} 
		} 
		internal CacheManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class CacheResult : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static CacheResult() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.CacheManager.CacheResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.webkit.CacheManager.CacheResult(@__env); 
				} 
			} 
			protected CacheResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLocation8525; 
			public virtual java.lang.String getLocation() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLocation8525)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getLocation8525)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLocalPath8526; 
			public virtual java.lang.String getLocalPath() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLocalPath8526)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getLocalPath8526)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getEncoding8527; 
			public virtual java.lang.String getEncoding() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getEncoding8527)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getEncoding8527)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInputStream8528; 
			public virtual java.io.InputStream getInputStream() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream8528)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getInputStream8528)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getContentLength8529; 
			public virtual long getContentLength() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return @__env.CallLongMethod(this, _getContentLength8529); 
				else 
					return @__env.CallNonVirtualLongMethod(this, android.webkit.CacheManager.CacheResult.staticClass, _getContentLength8529); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLastModified8530; 
			public virtual java.lang.String getLastModified() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLastModified8530)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getLastModified8530)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getOutputStream8531; 
			public virtual java.io.OutputStream getOutputStream() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _getOutputStream8531)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getOutputStream8531)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setEncoding8532; 
			public virtual void setEncoding(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					@__env.CallVoidMethod(this, _setEncoding8532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.webkit.CacheManager.CacheResult.staticClass, _setEncoding8532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getHttpStatusCode8533; 
			public virtual int getHttpStatusCode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return @__env.CallIntMethod(this, _getHttpStatusCode8533); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.webkit.CacheManager.CacheResult.staticClass, _getHttpStatusCode8533); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getExpires8534; 
			public virtual long getExpires() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return @__env.CallLongMethod(this, _getExpires8534); 
				else 
					return @__env.CallNonVirtualLongMethod(this, android.webkit.CacheManager.CacheResult.staticClass, _getExpires8534); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getExpiresString8535; 
			public virtual java.lang.String getExpiresString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getExpiresString8535)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getExpiresString8535)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getETag8536; 
			public virtual java.lang.String getETag() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getETag8536)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getETag8536)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getMimeType8537; 
			public virtual java.lang.String getMimeType() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getMimeType8537)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getMimeType8537)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getContentDisposition8538; 
			public virtual java.lang.String getContentDisposition() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getContentDisposition8538)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CacheManager.CacheResult.staticClass, _getContentDisposition8538)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setInputStream8539; 
			public virtual void setInputStream(java.io.InputStream arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.CacheManager.CacheResult)) 
					@__env.CallVoidMethod(this, _setInputStream8539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.webkit.CacheManager.CacheResult.staticClass, _setInputStream8539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CacheResult8540; 
			public CacheResult()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.webkit.CacheManager.CacheResult.staticClass, _CacheResult8540, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.CacheManager.CacheResult.staticClass = @__class; 
				global::android.webkit.CacheManager.CacheResult._getLocation8525 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocation", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._getLocalPath8526 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocalPath", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._getEncoding8527 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getEncoding", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._getInputStream8528 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
				global::android.webkit.CacheManager.CacheResult._getContentLength8529 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentLength", "()J"); 
				global::android.webkit.CacheManager.CacheResult._getLastModified8530 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getLastModified", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._getOutputStream8531 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
				global::android.webkit.CacheManager.CacheResult._setEncoding8532 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "setEncoding", "(Ljava/lang/String;)V"); 
				global::android.webkit.CacheManager.CacheResult._getHttpStatusCode8533 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getHttpStatusCode", "()I"); 
				global::android.webkit.CacheManager.CacheResult._getExpires8534 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpires", "()J"); 
				global::android.webkit.CacheManager.CacheResult._getExpiresString8535 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpiresString", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._getETag8536 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getETag", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._getMimeType8537 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getMimeType", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._getContentDisposition8538 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentDisposition", "()Ljava/lang/String;"); 
				global::android.webkit.CacheManager.CacheResult._setInputStream8539 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "setInputStream", "(Ljava/io/InputStream;)V"); 
				global::android.webkit.CacheManager.CacheResult._CacheResult8540 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCacheFileBaseDir8541; 
		public static java.io.File getCacheFileBaseDir() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CacheManager.staticClass, _getCacheFileBaseDir8541)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cacheDisabled8542; 
		public static bool cacheDisabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, _cacheDisabled8542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startCacheTransaction8543; 
		public static bool startCacheTransaction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, _startCacheTransaction8543); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endCacheTransaction8544; 
		public static bool endCacheTransaction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, _endCacheTransaction8544); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCacheFile8545; 
		public static android.webkit.CacheManager.CacheResult getCacheFile(java.lang.String arg0, java.util.Map arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CacheManager.CacheResult>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CacheManager.staticClass, _getCacheFile8545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveCacheFile8546; 
		public static void saveCacheFile(java.lang.String arg0, android.webkit.CacheManager.CacheResult arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.webkit.CacheManager.staticClass, _saveCacheFile8546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CacheManager8547; 
		public CacheManager()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.CacheManager.staticClass, _CacheManager8547, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.CacheManager.staticClass = @__class; 
			global::android.webkit.CacheManager._getCacheFileBaseDir8541 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "getCacheFileBaseDir", "()Ljava/io/File;"); 
			global::android.webkit.CacheManager._cacheDisabled8542 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "cacheDisabled", "()Z"); 
			global::android.webkit.CacheManager._startCacheTransaction8543 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "startCacheTransaction", "()Z"); 
			global::android.webkit.CacheManager._endCacheTransaction8544 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "endCacheTransaction", "()Z"); 
			global::android.webkit.CacheManager._getCacheFile8545 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;"); 
			global::android.webkit.CacheManager._saveCacheFile8546 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V"); 
			global::android.webkit.CacheManager._CacheManager8547 = @__env.GetMethodID(global::android.webkit.CacheManager.staticClass, "<init>", "()V"); 
		} 
	} 
} 
