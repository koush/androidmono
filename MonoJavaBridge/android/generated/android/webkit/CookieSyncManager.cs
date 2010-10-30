namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieSyncManager : android.webkit.WebSyncManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.webkit.CookieSyncManager getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CookieSyncManager._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.CookieSyncManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieSyncManager.staticClass, "getInstance", "()Landroid/webkit/CookieSyncManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.CookieSyncManager>(@__env.CallStaticObjectMethod(android.webkit.CookieSyncManager.staticClass, global::android.webkit.CookieSyncManager._m0)) as android.webkit.CookieSyncManager;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.webkit.CookieSyncManager createInstance(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CookieSyncManager._m1.native == global::System.IntPtr.Zero)
				global::android.webkit.CookieSyncManager._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieSyncManager.staticClass, "createInstance", "(Landroid/content/Context;)Landroid/webkit/CookieSyncManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.CookieSyncManager>(@__env.CallStaticObjectMethod(android.webkit.CookieSyncManager.staticClass, global::android.webkit.CookieSyncManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.CookieSyncManager;
		}
		static CookieSyncManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CookieSyncManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CookieSyncManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
