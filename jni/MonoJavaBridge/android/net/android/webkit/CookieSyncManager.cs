namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CookieSyncManager : android.webkit.WebSyncManager
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CookieSyncManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.CookieSyncManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.CookieSyncManager(@__env); 
			} 
		} 
		internal CookieSyncManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance8597; 
		public static android.webkit.CookieSyncManager getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CookieSyncManager>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CookieSyncManager.staticClass, _getInstance8597)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createInstance8598; 
		public static android.webkit.CookieSyncManager createInstance(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CookieSyncManager>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CookieSyncManager.staticClass, _createInstance8598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.CookieSyncManager.staticClass = @__class; 
			global::android.webkit.CookieSyncManager._getInstance8597 = @__env.GetStaticMethodID(global::android.webkit.CookieSyncManager.staticClass, "getInstance", "()Landroid/webkit/CookieSyncManager;"); 
			global::android.webkit.CookieSyncManager._createInstance8598 = @__env.GetStaticMethodID(global::android.webkit.CookieSyncManager.staticClass, "createInstance", "(Landroid/content/Context;)Landroid/webkit/CookieSyncManager;"); 
		} 
	} 
} 
