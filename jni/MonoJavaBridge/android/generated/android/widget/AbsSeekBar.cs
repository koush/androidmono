namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsSeekBar_))]
	public abstract partial class AbsSeekBar : android.widget.ProgressBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSeekBar()
		{
			InitJNI();
		}
		protected AbsSeekBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16477;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onKeyDown16477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onKeyDown16477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent16478;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onTouchEvent16478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onTouchEvent16478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16479;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onSizeChanged16479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onSizeChanged16479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16480;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onDraw16480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onDraw16480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16481;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._verifyDrawable16481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._verifyDrawable16481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16482;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._drawableStateChanged16482);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._drawableStateChanged16482);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16483;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onMeasure16483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onMeasure16483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMax16484;
		public override void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setMax16484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setMax16484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setThumb16485;
		public virtual void setThumb(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setThumb16485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumb16485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getThumbOffset16486;
		public virtual int getThumbOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar._getThumbOffset16486);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getThumbOffset16486);
		}
		internal static global::MonoJavaBridge.MethodId _setThumbOffset16487;
		public virtual void setThumbOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setThumbOffset16487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumbOffset16487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyProgressIncrement16488;
		public virtual void setKeyProgressIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setKeyProgressIncrement16488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setKeyProgressIncrement16488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyProgressIncrement16489;
		public virtual int getKeyProgressIncrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar._getKeyProgressIncrement16489);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getKeyProgressIncrement16489);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar16490;
		public AbsSeekBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar16490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar16491;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar16491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar16492;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar16492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSeekBar"));
			global::android.widget.AbsSeekBar._onKeyDown16477 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsSeekBar._onTouchEvent16478 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsSeekBar._onSizeChanged16479 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsSeekBar._onDraw16480 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsSeekBar._verifyDrawable16481 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsSeekBar._drawableStateChanged16482 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsSeekBar._onMeasure16483 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSeekBar._setMax16484 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setMax", "(I)V");
			global::android.widget.AbsSeekBar._setThumb16485 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumb", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsSeekBar._getThumbOffset16486 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getThumbOffset", "()I");
			global::android.widget.AbsSeekBar._setThumbOffset16487 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumbOffset", "(I)V");
			global::android.widget.AbsSeekBar._setKeyProgressIncrement16488 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setKeyProgressIncrement", "(I)V");
			global::android.widget.AbsSeekBar._getKeyProgressIncrement16489 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getKeyProgressIncrement", "()I");
			global::android.widget.AbsSeekBar._AbsSeekBar16490 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar16491 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar16492 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsSeekBar))]
	public sealed partial class AbsSeekBar_ : android.widget.AbsSeekBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSeekBar_()
		{
			InitJNI();
		}
		internal AbsSeekBar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSeekBar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSeekBar"));
		}
	}
}
