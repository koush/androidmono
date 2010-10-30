namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetHostView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetHostView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState2350;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState2350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState2351;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState2351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild2352;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", ref global::android.appwidget.AppWidgetHostView._drawChild2352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams2353;
		public override global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", ref global::android.appwidget.AppWidgetHostView._generateLayoutParams2353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setAppWidget2354;
		public virtual void setAppWidget(int arg0, android.appwidget.AppWidgetProviderInfo arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", ref global::android.appwidget.AppWidgetHostView._setAppWidget2354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int AppWidgetId
		{
			get
			{
				return getAppWidgetId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAppWidgetId2355;
		public virtual int getAppWidgetId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetId", "()I", ref global::android.appwidget.AppWidgetHostView._getAppWidgetId2355);
		}
		public new global::android.appwidget.AppWidgetProviderInfo AppWidgetInfo
		{
			get
			{
				return getAppWidgetInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAppWidgetInfo2356;
		public virtual global::android.appwidget.AppWidgetProviderInfo getAppWidgetInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;", ref global::android.appwidget.AppWidgetHostView._getAppWidgetInfo2356) as android.appwidget.AppWidgetProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _updateAppWidget2357;
		public virtual void updateAppWidget(android.widget.RemoteViews arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "updateAppWidget", "(Landroid/widget/RemoteViews;)V", ref global::android.appwidget.AppWidgetHostView._updateAppWidget2357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _prepareView2358;
		protected virtual void prepareView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "prepareView", "(Landroid/view/View;)V", ref global::android.appwidget.AppWidgetHostView._prepareView2358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.View DefaultView
		{
			get
			{
				return getDefaultView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultView2359;
		protected virtual global::android.view.View getDefaultView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getDefaultView", "()Landroid/view/View;", ref global::android.appwidget.AppWidgetHostView._getDefaultView2359) as android.view.View;
		}
		protected new global::android.view.View ErrorView
		{
			get
			{
				return getErrorView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getErrorView2360;
		protected virtual global::android.view.View getErrorView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getErrorView", "()Landroid/view/View;", ref global::android.appwidget.AppWidgetHostView._getErrorView2360) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetHostView2361;
		public AppWidgetHostView(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetHostView._AppWidgetHostView2361.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetHostView._AppWidgetHostView2361 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._AppWidgetHostView2361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetHostView2362;
		public AppWidgetHostView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetHostView._AppWidgetHostView2362.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetHostView._AppWidgetHostView2362 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._AppWidgetHostView2362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AppWidgetHostView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetHostView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetHostView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
