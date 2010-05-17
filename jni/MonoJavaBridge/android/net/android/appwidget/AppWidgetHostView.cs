namespace android.appwidget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AppWidgetHostView : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AppWidgetHostView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.appwidget.AppWidgetHostView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.appwidget.AppWidgetHostView(@__env); 
			} 
		} 
		protected AppWidgetHostView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState808; 
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				@__env.CallVoidMethod(this, _dispatchSaveInstanceState808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHostView.staticClass, _dispatchSaveInstanceState808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState809; 
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				@__env.CallVoidMethod(this, _dispatchRestoreInstanceState809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHostView.staticClass, _dispatchRestoreInstanceState809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawChild810; 
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				return @__env.CallBooleanMethod(this, _drawChild810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.appwidget.AppWidgetHostView.staticClass, _drawChild810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams811; 
		public override android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams811, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.appwidget.AppWidgetHostView.staticClass, _generateLayoutParams811, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAppWidget812; 
		public virtual void setAppWidget(int arg0, android.appwidget.AppWidgetProviderInfo arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				@__env.CallVoidMethod(this, _setAppWidget812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHostView.staticClass, _setAppWidget812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAppWidgetId813; 
		public virtual int getAppWidgetId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				return @__env.CallIntMethod(this, _getAppWidgetId813); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.appwidget.AppWidgetHostView.staticClass, _getAppWidgetId813); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAppWidgetInfo814; 
		public virtual android.appwidget.AppWidgetProviderInfo getAppWidgetInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetProviderInfo>(@__env, @__env.CallObjectMethodPtr(this, _getAppWidgetInfo814)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetProviderInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.appwidget.AppWidgetHostView.staticClass, _getAppWidgetInfo814)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateAppWidget815; 
		public virtual void updateAppWidget(android.widget.RemoteViews arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				@__env.CallVoidMethod(this, _updateAppWidget815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHostView.staticClass, _updateAppWidget815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepareView816; 
		protected virtual void prepareView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				@__env.CallVoidMethod(this, _prepareView816, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHostView.staticClass, _prepareView816, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultView817; 
		protected virtual android.view.View getDefaultView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getDefaultView817)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.appwidget.AppWidgetHostView.staticClass, _getDefaultView817)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getErrorView818; 
		protected virtual android.view.View getErrorView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHostView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getErrorView818)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.appwidget.AppWidgetHostView.staticClass, _getErrorView818)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetHostView819; 
		public AppWidgetHostView(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, _AppWidgetHostView819, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetHostView820; 
		public AppWidgetHostView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, _AppWidgetHostView820, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.appwidget.AppWidgetHostView.staticClass = @__class; 
			global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState808 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState809 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.appwidget.AppWidgetHostView._drawChild810 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z"); 
			global::android.appwidget.AppWidgetHostView._generateLayoutParams811 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;"); 
			global::android.appwidget.AppWidgetHostView._setAppWidget812 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V"); 
			global::android.appwidget.AppWidgetHostView._getAppWidgetId813 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetId", "()I"); 
			global::android.appwidget.AppWidgetHostView._getAppWidgetInfo814 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;"); 
			global::android.appwidget.AppWidgetHostView._updateAppWidget815 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "updateAppWidget", "(Landroid/widget/RemoteViews;)V"); 
			global::android.appwidget.AppWidgetHostView._prepareView816 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "prepareView", "(Landroid/view/View;)V"); 
			global::android.appwidget.AppWidgetHostView._getDefaultView817 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getDefaultView", "()Landroid/view/View;"); 
			global::android.appwidget.AppWidgetHostView._getErrorView818 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getErrorView", "()Landroid/view/View;"); 
			global::android.appwidget.AppWidgetHostView._AppWidgetHostView819 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;II)V"); 
			global::android.appwidget.AppWidgetHostView._AppWidgetHostView820 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
