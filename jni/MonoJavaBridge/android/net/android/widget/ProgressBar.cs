namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ProgressBar : android.view.View
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ProgressBar() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ProgressBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9814; 
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState9814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onRestoreInstanceState9814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9815; 
		public virtual new android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState9815)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _onSaveInstanceState9815)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgress9816; 
		public virtual void setProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setProgress9816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setProgress9816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress9817; 
		public virtual void setSecondaryProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setSecondaryProgress9817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setSecondaryProgress9817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility9818; 
		public override void setVisibility(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setVisibility9818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setVisibility9818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9819; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onSizeChanged9819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onSizeChanged9819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate9820; 
		public override void postInvalidate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _postInvalidate9820); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _postInvalidate9820); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9821; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onDraw9821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onDraw9821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable9822; 
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _invalidateDrawable9822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _invalidateDrawable9822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable9823; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable9823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ProgressBar.staticClass, _verifyDrawable9823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9824; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _drawableStateChanged9824); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _drawableStateChanged9824); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9825; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onMeasure9825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onMeasure9825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress9826; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallIntMethod(this, _getProgress9826); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ProgressBar.staticClass, _getProgress9826); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryProgress9827; 
		public virtual int getSecondaryProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallIntMethod(this, _getSecondaryProgress9827); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ProgressBar.staticClass, _getSecondaryProgress9827); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMax9828; 
		public virtual int getMax() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallIntMethod(this, _getMax9828); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ProgressBar.staticClass, _getMax9828); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMax9829; 
		public virtual void setMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setMax9829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setMax9829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementProgressBy9830; 
		public virtual void incrementProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _incrementProgressBy9830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _incrementProgressBy9830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementSecondaryProgressBy9831; 
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _incrementSecondaryProgressBy9831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _incrementSecondaryProgressBy9831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressDrawable9832; 
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setProgressDrawable9832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setProgressDrawable9832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminateDrawable9833; 
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setIndeterminateDrawable9833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setIndeterminateDrawable9833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminate9834; 
		public virtual void setIndeterminate(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setIndeterminate9834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setIndeterminate9834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIndeterminate9835; 
		public virtual bool isIndeterminate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallBooleanMethod(this, _isIndeterminate9835); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ProgressBar.staticClass, _isIndeterminate9835); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator9836; 
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setInterpolator9836, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setInterpolator9836, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator9837; 
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setInterpolator9837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setInterpolator9837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator9838; 
		public virtual android.view.animation.Interpolator getInterpolator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, _getInterpolator9838)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _getInterpolator9838)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndeterminateDrawable9839; 
		public virtual android.graphics.drawable.Drawable getIndeterminateDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getIndeterminateDrawable9839)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _getIndeterminateDrawable9839)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgressDrawable9840; 
		public virtual android.graphics.drawable.Drawable getProgressDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getProgressDrawable9840)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _getProgressDrawable9840)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar9841; 
		public ProgressBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ProgressBar.staticClass, _ProgressBar9841, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar9842; 
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ProgressBar.staticClass, _ProgressBar9842, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar9843; 
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ProgressBar.staticClass, _ProgressBar9843, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ProgressBar.staticClass = @__class; 
			global::android.widget.ProgressBar._onRestoreInstanceState9814 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.ProgressBar._onSaveInstanceState9815 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.ProgressBar._setProgress9816 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setProgress", "(I)V"); 
			global::android.widget.ProgressBar._setSecondaryProgress9817 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setSecondaryProgress", "(I)V"); 
			global::android.widget.ProgressBar._setVisibility9818 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setVisibility", "(I)V"); 
			global::android.widget.ProgressBar._onSizeChanged9819 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.ProgressBar._postInvalidate9820 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "postInvalidate", "()V"); 
			global::android.widget.ProgressBar._onDraw9821 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.ProgressBar._invalidateDrawable9822 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ProgressBar._verifyDrawable9823 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.ProgressBar._drawableStateChanged9824 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.ProgressBar._onMeasure9825 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.ProgressBar._getProgress9826 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getProgress", "()I"); 
			global::android.widget.ProgressBar._getSecondaryProgress9827 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getSecondaryProgress", "()I"); 
			global::android.widget.ProgressBar._getMax9828 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getMax", "()I"); 
			global::android.widget.ProgressBar._setMax9829 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setMax", "(I)V"); 
			global::android.widget.ProgressBar._incrementProgressBy9830 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "incrementProgressBy", "(I)V"); 
			global::android.widget.ProgressBar._incrementSecondaryProgressBy9831 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "incrementSecondaryProgressBy", "(I)V"); 
			global::android.widget.ProgressBar._setProgressDrawable9832 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ProgressBar._setIndeterminateDrawable9833 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ProgressBar._setIndeterminate9834 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setIndeterminate", "(Z)V"); 
			global::android.widget.ProgressBar._isIndeterminate9835 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "isIndeterminate", "()Z"); 
			global::android.widget.ProgressBar._setInterpolator9836 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"); 
			global::android.widget.ProgressBar._setInterpolator9837 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/content/Context;I)V"); 
			global::android.widget.ProgressBar._getInterpolator9838 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;"); 
			global::android.widget.ProgressBar._getIndeterminateDrawable9839 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.ProgressBar._getProgressDrawable9840 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getProgressDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.ProgressBar._ProgressBar9841 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ProgressBar._ProgressBar9842 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ProgressBar._ProgressBar9843 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
