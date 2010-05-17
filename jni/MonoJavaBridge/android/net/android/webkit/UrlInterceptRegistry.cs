namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class UrlInterceptRegistry : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static UrlInterceptRegistry() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.UrlInterceptRegistry), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.UrlInterceptRegistry(@__env); 
			} 
		} 
		internal UrlInterceptRegistry(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPluginData8667; 
		public static android.webkit.PluginData getPluginData(java.lang.String arg0, java.util.Map arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.PluginData>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.UrlInterceptRegistry.staticClass, _getPluginData8667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUrlInterceptDisabled8668; 
		public static void setUrlInterceptDisabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.webkit.UrlInterceptRegistry.staticClass, _setUrlInterceptDisabled8668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _urlInterceptDisabled8669; 
		public static bool urlInterceptDisabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, _urlInterceptDisabled8669); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerHandler8670; 
		public static bool registerHandler(android.webkit.UrlInterceptHandler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, _registerHandler8670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterHandler8671; 
		public static bool unregisterHandler(android.webkit.UrlInterceptHandler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, _unregisterHandler8671, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSurrogate8672; 
		public static android.webkit.CacheManager.CacheResult getSurrogate(java.lang.String arg0, java.util.Map arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CacheManager.CacheResult>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.UrlInterceptRegistry.staticClass, _getSurrogate8672, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UrlInterceptRegistry8673; 
		public UrlInterceptRegistry()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.UrlInterceptRegistry.staticClass, _UrlInterceptRegistry8673, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.UrlInterceptRegistry.staticClass = @__class; 
			global::android.webkit.UrlInterceptRegistry._getPluginData8667 = @__env.GetStaticMethodID(global::android.webkit.UrlInterceptRegistry.staticClass, "getPluginData", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/PluginData;"); 
			global::android.webkit.UrlInterceptRegistry._setUrlInterceptDisabled8668 = @__env.GetStaticMethodID(global::android.webkit.UrlInterceptRegistry.staticClass, "setUrlInterceptDisabled", "(Z)V"); 
			global::android.webkit.UrlInterceptRegistry._urlInterceptDisabled8669 = @__env.GetStaticMethodID(global::android.webkit.UrlInterceptRegistry.staticClass, "urlInterceptDisabled", "()Z"); 
			global::android.webkit.UrlInterceptRegistry._registerHandler8670 = @__env.GetStaticMethodID(global::android.webkit.UrlInterceptRegistry.staticClass, "registerHandler", "(Landroid/webkit/UrlInterceptHandler;)Z"); 
			global::android.webkit.UrlInterceptRegistry._unregisterHandler8671 = @__env.GetStaticMethodID(global::android.webkit.UrlInterceptRegistry.staticClass, "unregisterHandler", "(Landroid/webkit/UrlInterceptHandler;)Z"); 
			global::android.webkit.UrlInterceptRegistry._getSurrogate8672 = @__env.GetStaticMethodID(global::android.webkit.UrlInterceptRegistry.staticClass, "getSurrogate", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;"); 
			global::android.webkit.UrlInterceptRegistry._UrlInterceptRegistry8673 = @__env.GetMethodID(global::android.webkit.UrlInterceptRegistry.staticClass, "<init>", "()V"); 
		} 
	} 
} 
