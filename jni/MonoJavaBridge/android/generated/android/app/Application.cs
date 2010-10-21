namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Application : android.content.ContextWrapper, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Application()
		{
			InitJNI();
		}
		protected Application(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1730;
		public virtual void onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Application._onCreate1730);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Application.staticClass, global::android.app.Application._onCreate1730);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged1731;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Application._onConfigurationChanged1731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Application.staticClass, global::android.app.Application._onConfigurationChanged1731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory1732;
		public virtual void onLowMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Application._onLowMemory1732);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Application.staticClass, global::android.app.Application._onLowMemory1732);
		}
		internal static global::MonoJavaBridge.MethodId _onTerminate1733;
		public virtual void onTerminate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Application._onTerminate1733);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Application.staticClass, global::android.app.Application._onTerminate1733);
		}
		internal static global::MonoJavaBridge.MethodId _Application1734;
		public Application()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Application.staticClass, global::android.app.Application._Application1734);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Application.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Application"));
			global::android.app.Application._onCreate1730 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onCreate", "()V");
			global::android.app.Application._onConfigurationChanged1731 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Application._onLowMemory1732 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onLowMemory", "()V");
			global::android.app.Application._onTerminate1733 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "onTerminate", "()V");
			global::android.app.Application._Application1734 = @__env.GetMethodIDNoThrow(global::android.app.Application.staticClass, "<init>", "()V");
		}
	}
}
