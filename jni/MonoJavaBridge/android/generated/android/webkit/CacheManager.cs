namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class CacheManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CacheManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.CacheManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.CacheManager.CacheResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _getLocation9207;
			public virtual global::java.lang.String getLocation() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getLocation9207));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLocation9207));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getLocalPath9208;
			public virtual global::java.lang.String getLocalPath() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getLocalPath9208));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLocalPath9208));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getInputStream9209;
			public virtual global::java.io.InputStream getInputStream() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getInputStream9209));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getInputStream9209));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getEncoding9210;
			public virtual global::java.lang.String getEncoding() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getEncoding9210));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getEncoding9210));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getContentLength9211;
			public virtual long getContentLength() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.webkit.CacheManager.CacheResult._getContentLength9211);
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getContentLength9211);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getLastModified9212;
			public virtual global::java.lang.String getLastModified() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getLastModified9212));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getLastModified9212));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getOutputStream9213;
			public virtual global::java.io.OutputStream getOutputStream() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getOutputStream9213));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getOutputStream9213));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setEncoding9214;
			public virtual void setEncoding(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.CacheManager.CacheResult._setEncoding9214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._setEncoding9214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getHttpStatusCode9215;
			public virtual int getHttpStatusCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.webkit.CacheManager.CacheResult._getHttpStatusCode9215);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getHttpStatusCode9215);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getExpires9216;
			public virtual long getExpires() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.webkit.CacheManager.CacheResult._getExpires9216);
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getExpires9216);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getExpiresString9217;
			public virtual global::java.lang.String getExpiresString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getExpiresString9217));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getExpiresString9217));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getETag9218;
			public virtual global::java.lang.String getETag() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getETag9218));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getETag9218));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getMimeType9219;
			public virtual global::java.lang.String getMimeType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getMimeType9219));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getMimeType9219));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getContentDisposition9220;
			public virtual global::java.lang.String getContentDisposition() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult._getContentDisposition9220));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._getContentDisposition9220));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setInputStream9221;
			public virtual void setInputStream(java.io.InputStream arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.CacheManager.CacheResult._setInputStream9221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._setInputStream9221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _CacheResult9222;
			public CacheResult()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.webkit.CacheManager.CacheResult.staticClass, global::android.webkit.CacheManager.CacheResult._CacheResult9222, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.CacheManager.CacheResult.staticClass = @__class;
				global::android.webkit.CacheManager.CacheResult._getLocation9207 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocation", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getLocalPath9208 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getLocalPath", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getInputStream9209 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getInputStream", "()Ljava/io/InputStream;");
				global::android.webkit.CacheManager.CacheResult._getEncoding9210 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getEncoding", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getContentLength9211 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentLength", "()J");
				global::android.webkit.CacheManager.CacheResult._getLastModified9212 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getLastModified", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getOutputStream9213 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
				global::android.webkit.CacheManager.CacheResult._setEncoding9214 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "setEncoding", "(Ljava/lang/String;)V");
				global::android.webkit.CacheManager.CacheResult._getHttpStatusCode9215 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getHttpStatusCode", "()I");
				global::android.webkit.CacheManager.CacheResult._getExpires9216 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpires", "()J");
				global::android.webkit.CacheManager.CacheResult._getExpiresString9217 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getExpiresString", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getETag9218 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getETag", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getMimeType9219 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getMimeType", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._getContentDisposition9220 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "getContentDisposition", "()Ljava/lang/String;");
				global::android.webkit.CacheManager.CacheResult._setInputStream9221 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "setInputStream", "(Ljava/io/InputStream;)V");
				global::android.webkit.CacheManager.CacheResult._CacheResult9222 = @__env.GetMethodID(global::android.webkit.CacheManager.CacheResult.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheFileBaseDir9223;
		public static global::java.io.File getCacheFileBaseDir() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFileBaseDir9223));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cacheDisabled9224;
		public static bool cacheDisabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._cacheDisabled9224);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startCacheTransaction9225;
		public static bool startCacheTransaction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._startCacheTransaction9225);
		}
		internal static global::net.sf.jni4net.jni.MethodId _endCacheTransaction9226;
		public static bool endCacheTransaction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._endCacheTransaction9226);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheFile9227;
		public static global::android.webkit.CacheManager.CacheResult getCacheFile(java.lang.String arg0, java.util.Map arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CacheManager.CacheResult>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._getCacheFile9227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveCacheFile9228;
		public static void saveCacheFile(java.lang.String arg0, android.webkit.CacheManager.CacheResult arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._saveCacheFile9228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CacheManager9229;
		public CacheManager()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.CacheManager.staticClass, global::android.webkit.CacheManager._CacheManager9229, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.CacheManager.staticClass = @__class;
			global::android.webkit.CacheManager._getCacheFileBaseDir9223 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "getCacheFileBaseDir", "()Ljava/io/File;");
			global::android.webkit.CacheManager._cacheDisabled9224 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "cacheDisabled", "()Z");
			global::android.webkit.CacheManager._startCacheTransaction9225 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "startCacheTransaction", "()Z");
			global::android.webkit.CacheManager._endCacheTransaction9226 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "endCacheTransaction", "()Z");
			global::android.webkit.CacheManager._getCacheFile9227 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			global::android.webkit.CacheManager._saveCacheFile9228 = @__env.GetStaticMethodID(global::android.webkit.CacheManager.staticClass, "saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V");
			global::android.webkit.CacheManager._CacheManager9229 = @__env.GetMethodID(global::android.webkit.CacheManager.staticClass, "<init>", "()V");
		}
	}
}
