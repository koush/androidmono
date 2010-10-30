namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Application : android.content.ContextWrapper, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Application(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1732;
		public virtual void onCreate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Application._onCreate1732.native == global::System.IntPtr.Zero)
				global::android.app.Application._onCreate1732 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onCreate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onCreate1732);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged1733;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Application._onConfigurationChanged1733.native == global::System.IntPtr.Zero)
				global::android.app.Application._onConfigurationChanged1733 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onConfigurationChanged1733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory1734;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Application._onLowMemory1734.native == global::System.IntPtr.Zero)
				global::android.app.Application._onLowMemory1734 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onLowMemory", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onLowMemory1734);
		}
		internal static global::MonoJavaBridge.MethodId _onTerminate1735;
		public virtual void onTerminate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Application._onTerminate1735.native == global::System.IntPtr.Zero)
				global::android.app.Application._onTerminate1735 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onTerminate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onTerminate1735);
		}
		internal static global::MonoJavaBridge.MethodId _Application1736;
		public Application() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Application._Application1736.native == global::System.IntPtr.Zero)
				global::android.app.Application._Application1736 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Application.staticClass, global::android.app.Application._Application1736);
			Init(@__env, handle);
		}
		static Application()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Application.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Application"));
		}
		internal static void InitJNI()
		{
		}
	}
}
