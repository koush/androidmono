namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ProgressBar : android.view.View
	{
		internal new static global::java.lang.Class staticClass;
		static ProgressBar()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ProgressBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ProgressBar(@__env);
			}
		}
		protected ProgressBar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState11294;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._onRestoreInstanceState11294, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onRestoreInstanceState11294, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState11295;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ProgressBar._onSaveInstanceState11295));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSaveInstanceState11295));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgress11296;
		public virtual void setProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setProgress11296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgress11296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress11297;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setSecondaryProgress11297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setSecondaryProgress11297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility11298;
		public override void setVisibility(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setVisibility11298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setVisibility11298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onVisibilityChanged11299;
		protected override void onVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._onVisibilityChanged11299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onVisibilityChanged11299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged11300;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._onSizeChanged11300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSizeChanged11300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate11301;
		public override void postInvalidate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._postInvalidate11301);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._postInvalidate11301);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw11302;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._onDraw11302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onDraw11302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable11303;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._invalidateDrawable11303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._invalidateDrawable11303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable11304;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ProgressBar._verifyDrawable11304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._verifyDrawable11304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged11305;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._drawableStateChanged11305);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._drawableStateChanged11305);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11306;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._onMeasure11306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onMeasure11306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProgress11307;
		public virtual int getProgress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ProgressBar._getProgress11307);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgress11307);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryProgress11308;
		public virtual int getSecondaryProgress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ProgressBar._getSecondaryProgress11308);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getSecondaryProgress11308);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMax11309;
		public virtual int getMax() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ProgressBar._getMax11309);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getMax11309);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMax11310;
		public virtual void setMax(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setMax11310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setMax11310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _incrementProgressBy11311;
		public virtual void incrementProgressBy(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._incrementProgressBy11311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementProgressBy11311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _incrementSecondaryProgressBy11312;
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._incrementSecondaryProgressBy11312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementSecondaryProgressBy11312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressDrawable11313;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setProgressDrawable11313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgressDrawable11313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminateDrawable11314;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setIndeterminateDrawable11314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminateDrawable11314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminate11315;
		public virtual void setIndeterminate(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setIndeterminate11315, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminate11315, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isIndeterminate11316;
		public virtual bool isIndeterminate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ProgressBar._isIndeterminate11316);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._isIndeterminate11316);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator11317;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setInterpolator11317, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator11317, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator11318;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ProgressBar._setInterpolator11318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator11318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator11319;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ProgressBar._getInterpolator11319));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getInterpolator11319));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndeterminateDrawable11320;
		public virtual global::android.graphics.drawable.Drawable getIndeterminateDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ProgressBar._getIndeterminateDrawable11320));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getIndeterminateDrawable11320));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProgressDrawable11321;
		public virtual global::android.graphics.drawable.Drawable getProgressDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ProgressBar._getProgressDrawable11321));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgressDrawable11321));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar11322;
		public ProgressBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar11322, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar11323;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar11323, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar11324;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar11324, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ProgressBar.staticClass = @__class;
			global::android.widget.ProgressBar._onRestoreInstanceState11294 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ProgressBar._onSaveInstanceState11295 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ProgressBar._setProgress11296 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setProgress", "(I)V");
			global::android.widget.ProgressBar._setSecondaryProgress11297 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setSecondaryProgress", "(I)V");
			global::android.widget.ProgressBar._setVisibility11298 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setVisibility", "(I)V");
			global::android.widget.ProgressBar._onVisibilityChanged11299 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.widget.ProgressBar._onSizeChanged11300 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ProgressBar._postInvalidate11301 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "postInvalidate", "()V");
			global::android.widget.ProgressBar._onDraw11302 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ProgressBar._invalidateDrawable11303 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._verifyDrawable11304 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ProgressBar._drawableStateChanged11305 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ProgressBar._onMeasure11306 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.ProgressBar._getProgress11307 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getProgress", "()I");
			global::android.widget.ProgressBar._getSecondaryProgress11308 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getSecondaryProgress", "()I");
			global::android.widget.ProgressBar._getMax11309 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getMax", "()I");
			global::android.widget.ProgressBar._setMax11310 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setMax", "(I)V");
			global::android.widget.ProgressBar._incrementProgressBy11311 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "incrementProgressBy", "(I)V");
			global::android.widget.ProgressBar._incrementSecondaryProgressBy11312 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.widget.ProgressBar._setProgressDrawable11313 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminateDrawable11314 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminate11315 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setIndeterminate", "(Z)V");
			global::android.widget.ProgressBar._isIndeterminate11316 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "isIndeterminate", "()Z");
			global::android.widget.ProgressBar._setInterpolator11317 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.widget.ProgressBar._setInterpolator11318 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.widget.ProgressBar._getInterpolator11319 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.widget.ProgressBar._getIndeterminateDrawable11320 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._getProgressDrawable11321 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getProgressDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._ProgressBar11322 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ProgressBar._ProgressBar11323 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ProgressBar._ProgressBar11324 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
