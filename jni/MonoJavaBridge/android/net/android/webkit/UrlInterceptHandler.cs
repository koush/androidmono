namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface UrlInterceptHandler 
	{ 
		global::android.webkit.CacheManager.CacheResult service(java.lang.String arg0, java.util.Map arg1); 
		global::android.webkit.PluginData getPluginData(java.lang.String arg0, java.util.Map arg1); 
	} 

	public partial class UrlInterceptHandler_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __UrlInterceptHandler.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __UrlInterceptHandler : java.lang.Object, UrlInterceptHandler
	{ 
		internal static global::java.lang.Class staticClass; 
		static __UrlInterceptHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.__UrlInterceptHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.__UrlInterceptHandler(@__env); 
			} 
		} 
		internal __UrlInterceptHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _service9354; 
		 global::android.webkit.CacheManager.CacheResult android.webkit.UrlInterceptHandler.service(java.lang.String arg0, java.util.Map arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.__UrlInterceptHandler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CacheManager.CacheResult>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.__UrlInterceptHandler._service9354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CacheManager.CacheResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.__UrlInterceptHandler.staticClass, global::android.webkit.__UrlInterceptHandler._service9354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPluginData9355; 
		 global::android.webkit.PluginData android.webkit.UrlInterceptHandler.getPluginData(java.lang.String arg0, java.util.Map arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.__UrlInterceptHandler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.PluginData>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.__UrlInterceptHandler._getPluginData9355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.PluginData>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.__UrlInterceptHandler.staticClass, global::android.webkit.__UrlInterceptHandler._getPluginData9355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.__UrlInterceptHandler.staticClass = @__class; 
			global::android.webkit.__UrlInterceptHandler._service9354 = @__env.GetMethodID(global::android.webkit.__UrlInterceptHandler.staticClass, "android.webkit.UrlInterceptHandler.service", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;"); 
			global::android.webkit.__UrlInterceptHandler._getPluginData9355 = @__env.GetMethodID(global::android.webkit.__UrlInterceptHandler.staticClass, "android.webkit.UrlInterceptHandler.getPluginData", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/PluginData;"); 
		} 
	} 
} 
