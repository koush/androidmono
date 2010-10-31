namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.appwidget.AppWidgetManager getInstance(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetManager._m0.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/appwidget/AppWidgetManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.appwidget.AppWidgetManager;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.appwidget.AppWidgetProviderInfo getAppWidgetInfo(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetManager.staticClass, "getAppWidgetInfo", "(I)Landroid/appwidget/AppWidgetProviderInfo;", ref global::android.appwidget.AppWidgetManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.appwidget.AppWidgetProviderInfo;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void updateAppWidget(android.content.ComponentName arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "(Landroid/content/ComponentName;Landroid/widget/RemoteViews;)V", ref global::android.appwidget.AppWidgetManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void updateAppWidget(int[] arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "([ILandroid/widget/RemoteViews;)V", ref global::android.appwidget.AppWidgetManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void updateAppWidget(int arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "(ILandroid/widget/RemoteViews;)V", ref global::android.appwidget.AppWidgetManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.util.List InstalledProviders
		{
			get
			{
				return getInstalledProviders();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.List getInstalledProviders()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.appwidget.AppWidgetManager.staticClass, "getInstalledProviders", "()Ljava/util/List;", ref global::android.appwidget.AppWidgetManager._m5) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void bindAppWidgetId(int arg0, android.content.ComponentName arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, "bindAppWidgetId", "(ILandroid/content/ComponentName;)V", ref global::android.appwidget.AppWidgetManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int[] getAppWidgetIds(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.appwidget.AppWidgetManager.staticClass, "getAppWidgetIds", "(Landroid/content/ComponentName;)[I", ref global::android.appwidget.AppWidgetManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		public static global::java.lang.String ACTION_APPWIDGET_PICK
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_PICK";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_CONFIGURE
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_CONFIGURE";
			}
		}
		public static global::java.lang.String EXTRA_APPWIDGET_ID
		{
			get
			{
				return "appWidgetId";
			}
		}
		public static global::java.lang.String EXTRA_APPWIDGET_IDS
		{
			get
			{
				return "appWidgetIds";
			}
		}
		public static global::java.lang.String EXTRA_CUSTOM_INFO
		{
			get
			{
				return "customInfo";
			}
		}
		public static global::java.lang.String EXTRA_CUSTOM_EXTRAS
		{
			get
			{
				return "customExtras";
			}
		}
		public static int INVALID_APPWIDGET_ID
		{
			get
			{
				return 0;
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_UPDATE
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_UPDATE";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_DELETED
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_DELETED";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_DISABLED
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_DISABLED";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_ENABLED
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_ENABLED";
			}
		}
		public static global::java.lang.String META_DATA_APPWIDGET_PROVIDER
		{
			get
			{
				return "android.appwidget.provider";
			}
		}
		static AppWidgetManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetManager"));
		}
	}
}
