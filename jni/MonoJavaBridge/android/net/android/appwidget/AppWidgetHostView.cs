namespace android.appwidget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AppWidgetHostView : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AppWidgetHostView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.appwidget.AppWidgetHostView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState821; 
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState822; 
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawChild823; 
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.appwidget.AppWidgetHostView._drawChild823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._drawChild823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams824; 
		public override global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView._generateLayoutParams824, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._generateLayoutParams824, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAppWidget825; 
		public virtual void setAppWidget(int arg0, android.appwidget.AppWidgetProviderInfo arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView._setAppWidget825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._setAppWidget825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAppWidgetId826; 
		public virtual int getAppWidgetId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.appwidget.AppWidgetHostView._getAppWidgetId826); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getAppWidgetId826); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAppWidgetInfo827; 
		public virtual global::android.appwidget.AppWidgetProviderInfo getAppWidgetInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetProviderInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView._getAppWidgetInfo827)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetProviderInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getAppWidgetInfo827)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateAppWidget828; 
		public virtual void updateAppWidget(android.widget.RemoteViews arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView._updateAppWidget828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._updateAppWidget828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepareView829; 
		protected virtual void prepareView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHostView._prepareView829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._prepareView829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultView830; 
		protected virtual global::android.view.View getDefaultView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView._getDefaultView830)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getDefaultView830)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getErrorView831; 
		protected virtual global::android.view.View getErrorView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView._getErrorView831)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._getErrorView831)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetHostView832; 
		public AppWidgetHostView(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._AppWidgetHostView832, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetHostView833; 
		public AppWidgetHostView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetHostView.staticClass, global::android.appwidget.AppWidgetHostView._AppWidgetHostView833, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.appwidget.AppWidgetHostView.staticClass = @__class; 
			global::android.appwidget.AppWidgetHostView._dispatchSaveInstanceState821 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.appwidget.AppWidgetHostView._dispatchRestoreInstanceState822 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.appwidget.AppWidgetHostView._drawChild823 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z"); 
			global::android.appwidget.AppWidgetHostView._generateLayoutParams824 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;"); 
			global::android.appwidget.AppWidgetHostView._setAppWidget825 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V"); 
			global::android.appwidget.AppWidgetHostView._getAppWidgetId826 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetId", "()I"); 
			global::android.appwidget.AppWidgetHostView._getAppWidgetInfo827 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;"); 
			global::android.appwidget.AppWidgetHostView._updateAppWidget828 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "updateAppWidget", "(Landroid/widget/RemoteViews;)V"); 
			global::android.appwidget.AppWidgetHostView._prepareView829 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "prepareView", "(Landroid/view/View;)V"); 
			global::android.appwidget.AppWidgetHostView._getDefaultView830 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getDefaultView", "()Landroid/view/View;"); 
			global::android.appwidget.AppWidgetHostView._getErrorView831 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "getErrorView", "()Landroid/view/View;"); 
			global::android.appwidget.AppWidgetHostView._AppWidgetHostView832 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;II)V"); 
			global::android.appwidget.AppWidgetHostView._AppWidgetHostView833 = @__env.GetMethodID(global::android.appwidget.AppWidgetHostView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
