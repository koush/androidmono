namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Application : android.content.ContextWrapper, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Application(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, "onCreate", "()V", ref global::android.app.Application._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.app.Application._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, "onLowMemory", "()V", ref global::android.app.Application._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onTerminate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, "onTerminate", "()V", ref global::android.app.Application._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public Application() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Application._m4.native == global::System.IntPtr.Zero)
				global::android.app.Application._m4 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Application.staticClass, global::android.app.Application._m4);
			Init(@__env, handle);
		}
		static Application()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Application.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Application"));
		}
	}
}
