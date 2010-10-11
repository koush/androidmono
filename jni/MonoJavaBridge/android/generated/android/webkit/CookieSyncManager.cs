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
		internal static global::MonoJavaBridge.MethodId _getInstance10305;
		public static global::android.webkit.CookieSyncManager getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CookieSyncManager.staticClass, global::android.webkit.CookieSyncManager._getInstance10305)) as android.webkit.CookieSyncManager;
		}
		internal static global::MonoJavaBridge.MethodId _createInstance10306;
		public static global::android.webkit.CookieSyncManager createInstance(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CookieSyncManager.staticClass, global::android.webkit.CookieSyncManager._createInstance10306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.CookieSyncManager;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CookieSyncManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CookieSyncManager"));
			global::android.webkit.CookieSyncManager._getInstance10305 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieSyncManager.staticClass, "getInstance", "()Landroid/webkit/CookieSyncManager;");
			global::android.webkit.CookieSyncManager._createInstance10306 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieSyncManager.staticClass, "createInstance", "(Landroid/content/Context;)Landroid/webkit/CookieSyncManager;");
		}
	}
}
