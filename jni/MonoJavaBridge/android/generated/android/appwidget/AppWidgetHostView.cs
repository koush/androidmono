namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetHostView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AppWidgetHostView()
		{
			InitJNI();
		}
		protected AppWidgetHostView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState966;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState967;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild968;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._drawChild968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._drawChild968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams969;
		public override global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._generateLayoutParams969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.FrameLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._generateLayoutParams969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setAppWidget970;
		public virtual void setAppWidget(int arg0, android.appwidget.AppWidgetProviderInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._setAppWidget970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._setAppWidget970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAppWidgetId971;
		public virtual int getAppWidgetId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._getAppWidgetId971);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getAppWidgetId971);
		}
		internal static global::MonoJavaBridge.MethodId _getAppWidgetInfo972;
		public virtual global::android.appwidget.AppWidgetProviderInfo getAppWidgetInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._getAppWidgetInfo972)) as android.appwidget.AppWidgetProviderInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getAppWidgetInfo972)) as android.appwidget.AppWidgetProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _updateAppWidget973;
		public virtual void updateAppWidget(android.widget.RemoteViews arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._updateAppWidget973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._updateAppWidget973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _prepareView974;
		protected virtual void prepareView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._prepareView974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._prepareView974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultView975;
		protected virtual global::android.view.View getDefaultView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._getDefaultView975)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getDefaultView975)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getErrorView976;
		protected virtual global::android.view.View getErrorView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView._getErrorView976)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getErrorView976)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetHostView977;
		public AppWidgetHostView(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._AppWidgetHostView977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetHostView978;
		public AppWidgetHostView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._AppWidgetHostView978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetHostView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetHostView"));
			global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState966 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState967 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.appwidget.AppWidgetHostView._drawChild968 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.appwidget.AppWidgetHostView._generateLayoutParams969 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;");
			global::android.appwidget.AppWidgetHostView._setAppWidget970 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V");
			global::android.appwidget.AppWidgetHostView._getAppWidgetId971 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetId", "()I");
			global::android.appwidget.AppWidgetHostView._getAppWidgetInfo972 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;");
			global::android.appwidget.AppWidgetHostView._updateAppWidget973 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "updateAppWidget", "(Landroid/widget/RemoteViews;)V");
			global::android.appwidget.AppWidgetHostView._prepareView974 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "prepareView", "(Landroid/view/View;)V");
			global::android.appwidget.AppWidgetHostView._getDefaultView975 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "getDefaultView", "()Landroid/view/View;");
			global::android.appwidget.AppWidgetHostView._getErrorView976 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "getErrorView", "()Landroid/view/View;");
			global::android.appwidget.AppWidgetHostView._AppWidgetHostView977 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.appwidget.AppWidgetHostView._AppWidgetHostView978 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
