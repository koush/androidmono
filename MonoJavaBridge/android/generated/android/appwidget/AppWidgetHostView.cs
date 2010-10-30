namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetHostView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetHostView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.appwidget.AppWidgetHostView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.appwidget.AppWidgetHostView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", ref global::android.appwidget.AppWidgetHostView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", ref global::android.appwidget.AppWidgetHostView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.FrameLayout.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setAppWidget(int arg0, android.appwidget.AppWidgetProviderInfo arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", ref global::android.appwidget.AppWidgetHostView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int AppWidgetId
		{
			get
			{
				return getAppWidgetId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getAppWidgetId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetId", "()I", ref global::android.appwidget.AppWidgetHostView._m5);
		}
		public new global::android.appwidget.AppWidgetProviderInfo AppWidgetInfo
		{
			get
			{
				return getAppWidgetInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.appwidget.AppWidgetProviderInfo getAppWidgetInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;", ref global::android.appwidget.AppWidgetHostView._m6) as android.appwidget.AppWidgetProviderInfo;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void updateAppWidget(android.widget.RemoteViews arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "updateAppWidget", "(Landroid/widget/RemoteViews;)V", ref global::android.appwidget.AppWidgetHostView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void prepareView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "prepareView", "(Landroid/view/View;)V", ref global::android.appwidget.AppWidgetHostView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.View DefaultView
		{
			get
			{
				return getDefaultView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::android.view.View getDefaultView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getDefaultView", "()Landroid/view/View;", ref global::android.appwidget.AppWidgetHostView._m9) as android.view.View;
		}
		protected new global::android.view.View ErrorView
		{
			get
			{
				return getErrorView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::android.view.View getErrorView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, "getErrorView", "()Landroid/view/View;", ref global::android.appwidget.AppWidgetHostView._m10) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public AppWidgetHostView(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetHostView._m11.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetHostView._m11 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public AppWidgetHostView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetHostView._m12.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetHostView._m12 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
