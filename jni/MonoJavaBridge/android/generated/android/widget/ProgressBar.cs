namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProgressBar : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProgressBar()
		{
			InitJNI();
		}
		protected ProgressBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState12219;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onRestoreInstanceState12219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onRestoreInstanceState12219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState12220;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._onSaveInstanceState12220)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSaveInstanceState12220)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setProgress12221;
		public virtual void setProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setProgress12221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgress12221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress12222;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setSecondaryProgress12222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setSecondaryProgress12222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility12223;
		public override void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setVisibility12223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setVisibility12223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onVisibilityChanged12224;
		protected override void onVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onVisibilityChanged12224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onVisibilityChanged12224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged12225;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onSizeChanged12225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSizeChanged12225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate12226;
		public override void postInvalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._postInvalidate12226);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._postInvalidate12226);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw12227;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onDraw12227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onDraw12227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable12228;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._invalidateDrawable12228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._invalidateDrawable12228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable12229;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar._verifyDrawable12229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._verifyDrawable12229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged12230;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._drawableStateChanged12230);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._drawableStateChanged12230);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12231;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onMeasure12231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onMeasure12231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Progress
		{
			get
			{
				return getProgress();
			}
			set
			{
				setProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgress12232;
		public virtual int getProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ProgressBar._getProgress12232);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgress12232);
		}
		public new int SecondaryProgress
		{
			get
			{
				return getSecondaryProgress();
			}
			set
			{
				setSecondaryProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryProgress12233;
		public virtual int getSecondaryProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ProgressBar._getSecondaryProgress12233);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getSecondaryProgress12233);
		}
		public new int Max
		{
			get
			{
				return getMax();
			}
			set
			{
				setMax(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMax12234;
		public virtual int getMax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ProgressBar._getMax12234);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getMax12234);
		}
		internal static global::MonoJavaBridge.MethodId _setMax12235;
		public virtual void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setMax12235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setMax12235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementProgressBy12236;
		public virtual void incrementProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._incrementProgressBy12236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementProgressBy12236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementSecondaryProgressBy12237;
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._incrementSecondaryProgressBy12237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementSecondaryProgressBy12237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressDrawable12238;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setProgressDrawable12238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgressDrawable12238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminateDrawable12239;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setIndeterminateDrawable12239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminateDrawable12239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminate12240;
		public virtual void setIndeterminate(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setIndeterminate12240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminate12240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIndeterminate12241;
		public virtual bool isIndeterminate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar._isIndeterminate12241);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._isIndeterminate12241);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator12242;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setInterpolator12242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator12242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator12243;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setInterpolator12243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator12243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.animation.Interpolator Interpolator
		{
			get
			{
				return getInterpolator();
			}
			set
			{
				setInterpolator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator12244;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._getInterpolator12244)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getInterpolator12244)) as android.view.animation.Interpolator;
		}
		public new global::android.graphics.drawable.Drawable IndeterminateDrawable
		{
			get
			{
				return getIndeterminateDrawable();
			}
			set
			{
				setIndeterminateDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndeterminateDrawable12245;
		public virtual global::android.graphics.drawable.Drawable getIndeterminateDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._getIndeterminateDrawable12245)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getIndeterminateDrawable12245)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable ProgressDrawable
		{
			get
			{
				return getProgressDrawable();
			}
			set
			{
				setProgressDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgressDrawable12246;
		public virtual global::android.graphics.drawable.Drawable getProgressDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._getProgressDrawable12246)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgressDrawable12246)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar12247;
		public ProgressBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar12247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar12248;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar12248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar12249;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar12249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ProgressBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ProgressBar"));
			global::android.widget.ProgressBar._onRestoreInstanceState12219 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ProgressBar._onSaveInstanceState12220 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ProgressBar._setProgress12221 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setProgress", "(I)V");
			global::android.widget.ProgressBar._setSecondaryProgress12222 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setSecondaryProgress", "(I)V");
			global::android.widget.ProgressBar._setVisibility12223 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setVisibility", "(I)V");
			global::android.widget.ProgressBar._onVisibilityChanged12224 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.widget.ProgressBar._onSizeChanged12225 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ProgressBar._postInvalidate12226 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "postInvalidate", "()V");
			global::android.widget.ProgressBar._onDraw12227 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ProgressBar._invalidateDrawable12228 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._verifyDrawable12229 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ProgressBar._drawableStateChanged12230 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ProgressBar._onMeasure12231 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.ProgressBar._getProgress12232 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getProgress", "()I");
			global::android.widget.ProgressBar._getSecondaryProgress12233 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getSecondaryProgress", "()I");
			global::android.widget.ProgressBar._getMax12234 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getMax", "()I");
			global::android.widget.ProgressBar._setMax12235 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setMax", "(I)V");
			global::android.widget.ProgressBar._incrementProgressBy12236 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "incrementProgressBy", "(I)V");
			global::android.widget.ProgressBar._incrementSecondaryProgressBy12237 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.widget.ProgressBar._setProgressDrawable12238 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminateDrawable12239 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminate12240 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setIndeterminate", "(Z)V");
			global::android.widget.ProgressBar._isIndeterminate12241 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "isIndeterminate", "()Z");
			global::android.widget.ProgressBar._setInterpolator12242 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.widget.ProgressBar._setInterpolator12243 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.widget.ProgressBar._getInterpolator12244 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.widget.ProgressBar._getIndeterminateDrawable12245 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._getProgressDrawable12246 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getProgressDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._ProgressBar12247 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ProgressBar._ProgressBar12248 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ProgressBar._ProgressBar12249 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
