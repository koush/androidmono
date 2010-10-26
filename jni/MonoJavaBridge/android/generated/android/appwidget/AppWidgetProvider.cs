namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetProvider : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AppWidgetProvider()
		{
			InitJNI();
		}
		protected AppWidgetProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2383;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider._onReceive2383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onReceive2383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onEnabled2384;
		public virtual void onEnabled(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider._onEnabled2384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onEnabled2384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisabled2385;
		public virtual void onDisabled(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider._onDisabled2385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onDisabled2385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdate2386;
		public virtual void onUpdate(android.content.Context arg0, android.appwidget.AppWidgetManager arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider._onUpdate2386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onUpdate2386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDeleted2387;
		public virtual void onDeleted(android.content.Context arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider._onDeleted2387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onDeleted2387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetProvider2388;
		public AppWidgetProvider()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._AppWidgetProvider2388);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetProvider"));
			global::android.appwidget.AppWidgetProvider._onReceive2383 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProvider.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.appwidget.AppWidgetProvider._onEnabled2384 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProvider.staticClass, "onEnabled", "(Landroid/content/Context;)V");
			global::android.appwidget.AppWidgetProvider._onDisabled2385 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProvider.staticClass, "onDisabled", "(Landroid/content/Context;)V");
			global::android.appwidget.AppWidgetProvider._onUpdate2386 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProvider.staticClass, "onUpdate", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V");
			global::android.appwidget.AppWidgetProvider._onDeleted2387 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProvider.staticClass, "onDeleted", "(Landroid/content/Context;[I)V");
			global::android.appwidget.AppWidgetProvider._AppWidgetProvider2388 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProvider.staticClass, "<init>", "()V");
		}
	}
}
