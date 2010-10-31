namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetProvider : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.appwidget.AppWidgetProvider._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onEnabled(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, "onEnabled", "(Landroid/content/Context;)V", ref global::android.appwidget.AppWidgetProvider._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onDisabled(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, "onDisabled", "(Landroid/content/Context;)V", ref global::android.appwidget.AppWidgetProvider._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onUpdate(android.content.Context arg0, android.appwidget.AppWidgetManager arg1, int[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, "onUpdate", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V", ref global::android.appwidget.AppWidgetProvider._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onDeleted(android.content.Context arg0, int[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, "onDeleted", "(Landroid/content/Context;[I)V", ref global::android.appwidget.AppWidgetProvider._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AppWidgetProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetProvider._m5.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetProvider._m5 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._m5);
			Init(@__env, handle);
		}
		static AppWidgetProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetProvider"));
		}
	}
}
