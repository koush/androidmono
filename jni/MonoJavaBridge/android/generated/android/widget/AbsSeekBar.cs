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
		internal static global::MonoJavaBridge.MethodId _onKeyDown11338;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onKeyDown11338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onKeyDown11338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent11339;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onTouchEvent11339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onTouchEvent11339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged11340;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onSizeChanged11340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onSizeChanged11340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw11341;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onDraw11341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onDraw11341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable11342;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._verifyDrawable11342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._verifyDrawable11342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged11343;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._drawableStateChanged11343);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._drawableStateChanged11343);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11344;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onMeasure11344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onMeasure11344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMax11345;
		public override void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setMax11345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setMax11345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setThumb11346;
		public virtual void setThumb(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setThumb11346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumb11346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getThumbOffset11347;
		public virtual int getThumbOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar._getThumbOffset11347);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getThumbOffset11347);
		}
		internal static global::MonoJavaBridge.MethodId _setThumbOffset11348;
		public virtual void setThumbOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setThumbOffset11348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumbOffset11348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyProgressIncrement11349;
		public virtual void setKeyProgressIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setKeyProgressIncrement11349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setKeyProgressIncrement11349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyProgressIncrement11350;
		public virtual int getKeyProgressIncrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar._getKeyProgressIncrement11350);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getKeyProgressIncrement11350);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar11351;
		public AbsSeekBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar11351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar11352;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar11352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar11353;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar11353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSeekBar"));
			global::android.widget.AbsSeekBar._onKeyDown11338 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsSeekBar._onTouchEvent11339 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsSeekBar._onSizeChanged11340 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsSeekBar._onDraw11341 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsSeekBar._verifyDrawable11342 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsSeekBar._drawableStateChanged11343 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsSeekBar._onMeasure11344 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSeekBar._setMax11345 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setMax", "(I)V");
			global::android.widget.AbsSeekBar._setThumb11346 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumb", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsSeekBar._getThumbOffset11347 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getThumbOffset", "()I");
			global::android.widget.AbsSeekBar._setThumbOffset11348 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumbOffset", "(I)V");
			global::android.widget.AbsSeekBar._setKeyProgressIncrement11349 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setKeyProgressIncrement", "(I)V");
			global::android.widget.AbsSeekBar._getKeyProgressIncrement11350 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getKeyProgressIncrement", "()I");
			global::android.widget.AbsSeekBar._AbsSeekBar11351 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar11352 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar11353 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
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
