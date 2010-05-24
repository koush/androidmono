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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10584; 
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState10584, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onRestoreInstanceState10584, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10585; 
		public virtual new android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState10585)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _onSaveInstanceState10585)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgress10586; 
		public virtual void setProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setProgress10586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setProgress10586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress10587; 
		public virtual void setSecondaryProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setSecondaryProgress10587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setSecondaryProgress10587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility10588; 
		public override void setVisibility(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setVisibility10588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setVisibility10588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged10589; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onSizeChanged10589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onSizeChanged10589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate10590; 
		public override void postInvalidate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _postInvalidate10590); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _postInvalidate10590); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw10591; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onDraw10591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onDraw10591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable10592; 
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _invalidateDrawable10592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _invalidateDrawable10592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable10593; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable10593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ProgressBar.staticClass, _verifyDrawable10593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged10594; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _drawableStateChanged10594); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _drawableStateChanged10594); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10595; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _onMeasure10595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _onMeasure10595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress10596; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallIntMethod(this, _getProgress10596); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ProgressBar.staticClass, _getProgress10596); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryProgress10597; 
		public virtual int getSecondaryProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallIntMethod(this, _getSecondaryProgress10597); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ProgressBar.staticClass, _getSecondaryProgress10597); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMax10598; 
		public virtual int getMax() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallIntMethod(this, _getMax10598); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ProgressBar.staticClass, _getMax10598); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMax10599; 
		public virtual void setMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setMax10599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setMax10599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementProgressBy10600; 
		public virtual void incrementProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _incrementProgressBy10600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _incrementProgressBy10600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementSecondaryProgressBy10601; 
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _incrementSecondaryProgressBy10601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _incrementSecondaryProgressBy10601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressDrawable10602; 
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setProgressDrawable10602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setProgressDrawable10602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminateDrawable10603; 
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setIndeterminateDrawable10603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setIndeterminateDrawable10603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminate10604; 
		public virtual void setIndeterminate(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setIndeterminate10604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setIndeterminate10604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIndeterminate10605; 
		public virtual bool isIndeterminate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return @__env.CallBooleanMethod(this, _isIndeterminate10605); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ProgressBar.staticClass, _isIndeterminate10605); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator10606; 
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setInterpolator10606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setInterpolator10606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator10607; 
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				@__env.CallVoidMethod(this, _setInterpolator10607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ProgressBar.staticClass, _setInterpolator10607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator10608; 
		public virtual android.view.animation.Interpolator getInterpolator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, _getInterpolator10608)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _getInterpolator10608)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndeterminateDrawable10609; 
		public virtual android.graphics.drawable.Drawable getIndeterminateDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getIndeterminateDrawable10609)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _getIndeterminateDrawable10609)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgressDrawable10610; 
		public virtual android.graphics.drawable.Drawable getProgressDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ProgressBar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getProgressDrawable10610)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ProgressBar.staticClass, _getProgressDrawable10610)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar10611; 
		public ProgressBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ProgressBar.staticClass, _ProgressBar10611, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar10612; 
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ProgressBar.staticClass, _ProgressBar10612, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressBar10613; 
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ProgressBar.staticClass, _ProgressBar10613, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ProgressBar.staticClass = @__class; 
			global::android.widget.ProgressBar._onRestoreInstanceState10584 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.ProgressBar._onSaveInstanceState10585 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.ProgressBar._setProgress10586 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setProgress", "(I)V"); 
			global::android.widget.ProgressBar._setSecondaryProgress10587 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setSecondaryProgress", "(I)V"); 
			global::android.widget.ProgressBar._setVisibility10588 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setVisibility", "(I)V"); 
			global::android.widget.ProgressBar._onSizeChanged10589 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.ProgressBar._postInvalidate10590 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "postInvalidate", "()V"); 
			global::android.widget.ProgressBar._onDraw10591 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.ProgressBar._invalidateDrawable10592 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ProgressBar._verifyDrawable10593 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.ProgressBar._drawableStateChanged10594 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.ProgressBar._onMeasure10595 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.ProgressBar._getProgress10596 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getProgress", "()I"); 
			global::android.widget.ProgressBar._getSecondaryProgress10597 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getSecondaryProgress", "()I"); 
			global::android.widget.ProgressBar._getMax10598 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getMax", "()I"); 
			global::android.widget.ProgressBar._setMax10599 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setMax", "(I)V"); 
			global::android.widget.ProgressBar._incrementProgressBy10600 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "incrementProgressBy", "(I)V"); 
			global::android.widget.ProgressBar._incrementSecondaryProgressBy10601 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "incrementSecondaryProgressBy", "(I)V"); 
			global::android.widget.ProgressBar._setProgressDrawable10602 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ProgressBar._setIndeterminateDrawable10603 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ProgressBar._setIndeterminate10604 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setIndeterminate", "(Z)V"); 
			global::android.widget.ProgressBar._isIndeterminate10605 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "isIndeterminate", "()Z"); 
			global::android.widget.ProgressBar._setInterpolator10606 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"); 
			global::android.widget.ProgressBar._setInterpolator10607 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/content/Context;I)V"); 
			global::android.widget.ProgressBar._getInterpolator10608 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;"); 
			global::android.widget.ProgressBar._getIndeterminateDrawable10609 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.ProgressBar._getProgressDrawable10610 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "getProgressDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.ProgressBar._ProgressBar10611 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ProgressBar._ProgressBar10612 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ProgressBar._ProgressBar10613 = @__env.GetMethodID(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
