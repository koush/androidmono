namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetHost : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::android.appwidget.AppWidgetHostView onCreateView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;", ref global::android.appwidget.AppWidgetHost._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.appwidget.AppWidgetHostView;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.appwidget.AppWidgetHostView createView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;", ref global::android.appwidget.AppWidgetHost._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.appwidget.AppWidgetHostView;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void startListening()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "startListening", "()V", ref global::android.appwidget.AppWidgetHost._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void stopListening()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "stopListening", "()V", ref global::android.appwidget.AppWidgetHost._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int allocateAppWidgetId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "allocateAppWidgetId", "()I", ref global::android.appwidget.AppWidgetHost._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void deleteAppWidgetId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "deleteAppWidgetId", "(I)V", ref global::android.appwidget.AppWidgetHost._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void deleteHost()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "deleteHost", "()V", ref global::android.appwidget.AppWidgetHost._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void deleteAllHosts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetHost._m7.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetHost._m7 = @__env.GetStaticMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "deleteAllHosts", "()V");
			@__env.CallStaticVoidMethod(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void onProviderChanged(int arg0, android.appwidget.AppWidgetProviderInfo arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, "onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", ref global::android.appwidget.AppWidgetHost._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AppWidgetHost(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetHost._m9.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetHost._m9 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AppWidgetHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetHost"));
		}
		internal static void InitJNI()
		{
		}
	}
}
