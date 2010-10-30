namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance2363;
		public static global::android.appwidget.AppWidgetManager getInstance(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getInstance2363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.appwidget.AppWidgetManager;
		}
		internal static global::MonoJavaBridge.MethodId _getAppWidgetInfo2364;
		public virtual global::android.appwidget.AppWidgetProviderInfo getAppWidgetInfo(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getAppWidgetInfo2364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.appwidget.AppWidgetProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _updateAppWidget2365;
		public virtual void updateAppWidget(android.content.ComponentName arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._updateAppWidget2365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAppWidget2366;
		public virtual void updateAppWidget(int[] arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._updateAppWidget2366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAppWidget2367;
		public virtual void updateAppWidget(int arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._updateAppWidget2367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.util.List InstalledProviders
		{
			get
			{
				return getInstalledProviders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledProviders2368;
		public virtual global::java.util.List getInstalledProviders()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getInstalledProviders2368)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _bindAppWidgetId2369;
		public virtual void bindAppWidgetId(int arg0, android.content.ComponentName arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._bindAppWidgetId2369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAppWidgetIds2370;
		public virtual int[] getAppWidgetIds(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getAppWidgetIds2370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
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
			global::android.appwidget.AppWidgetManager._getInstance2363 = @__env.GetStaticMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/appwidget/AppWidgetManager;");
			global::android.appwidget.AppWidgetManager._getAppWidgetInfo2364 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "getAppWidgetInfo", "(I)Landroid/appwidget/AppWidgetProviderInfo;");
			global::android.appwidget.AppWidgetManager._updateAppWidget2365 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "(Landroid/content/ComponentName;Landroid/widget/RemoteViews;)V");
			global::android.appwidget.AppWidgetManager._updateAppWidget2366 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "([ILandroid/widget/RemoteViews;)V");
			global::android.appwidget.AppWidgetManager._updateAppWidget2367 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "(ILandroid/widget/RemoteViews;)V");
			global::android.appwidget.AppWidgetManager._getInstalledProviders2368 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "getInstalledProviders", "()Ljava/util/List;");
			global::android.appwidget.AppWidgetManager._bindAppWidgetId2369 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "bindAppWidgetId", "(ILandroid/content/ComponentName;)V");
			global::android.appwidget.AppWidgetManager._getAppWidgetIds2370 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetManager.staticClass, "getAppWidgetIds", "(Landroid/content/ComponentName;)[I");
		}
		internal static void InitJNI()
		{
		}
	}
}
