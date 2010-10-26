namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieSyncManager : android.webkit.WebSyncManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieSyncManager()
		{
			InitJNI();
		}
		internal CookieSyncManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.webkit.CookieSyncManager Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance16033;
		public static global::android.webkit.CookieSyncManager getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.CookieSyncManager>(@__env.CallStaticObjectMethod(android.webkit.CookieSyncManager.staticClass, global::android.webkit.CookieSyncManager._getInstance16033)) as android.webkit.CookieSyncManager;
		}
		internal static global::MonoJavaBridge.MethodId _createInstance16034;
		public static global::android.webkit.CookieSyncManager createInstance(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.CookieSyncManager>(@__env.CallStaticObjectMethod(android.webkit.CookieSyncManager.staticClass, global::android.webkit.CookieSyncManager._createInstance16034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.CookieSyncManager;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CookieSyncManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CookieSyncManager"));
			global::android.webkit.CookieSyncManager._getInstance16033 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieSyncManager.staticClass, "getInstance", "()Landroid/webkit/CookieSyncManager;");
			global::android.webkit.CookieSyncManager._createInstance16034 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieSyncManager.staticClass, "createInstance", "(Landroid/content/Context;)Landroid/webkit/CookieSyncManager;");
		}
	}
}
