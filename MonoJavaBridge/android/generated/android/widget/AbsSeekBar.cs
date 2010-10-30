namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsSeekBar_))]
	public abstract partial class AbsSeekBar : android.widget.ProgressBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsSeekBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16569;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._onKeyDown16569.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._onKeyDown16569 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onKeyDown16569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent16570;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._onTouchEvent16570.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._onTouchEvent16570 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onTouchEvent16570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16571;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._onSizeChanged16571.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._onSizeChanged16571 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onSizeChanged", "(IIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onSizeChanged16571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16572;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._onDraw16572.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._onDraw16572 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onDraw16572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16573;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._verifyDrawable16573.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._verifyDrawable16573 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._verifyDrawable16573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16574;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._drawableStateChanged16574.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._drawableStateChanged16574 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "drawableStateChanged", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._drawableStateChanged16574);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16575;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._onMeasure16575.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._onMeasure16575 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onMeasure", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onMeasure16575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMax16576;
		public override void setMax(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._setMax16576.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._setMax16576 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setMax", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setMax16576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setThumb16577;
		public virtual void setThumb(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._setThumb16577.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._setThumb16577 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumb", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumb16577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getThumbOffset16578;
		public virtual int getThumbOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._getThumbOffset16578.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._getThumbOffset16578 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getThumbOffset", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getThumbOffset16578);
		}
		internal static global::MonoJavaBridge.MethodId _setThumbOffset16579;
		public virtual void setThumbOffset(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._setThumbOffset16579.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._setThumbOffset16579 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumbOffset", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumbOffset16579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyProgressIncrement16580;
		public virtual void setKeyProgressIncrement(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._setKeyProgressIncrement16580.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._setKeyProgressIncrement16580 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setKeyProgressIncrement", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setKeyProgressIncrement16580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyProgressIncrement16581;
		public virtual int getKeyProgressIncrement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._getKeyProgressIncrement16581.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._getKeyProgressIncrement16581 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getKeyProgressIncrement", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getKeyProgressIncrement16581);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar16582;
		public AbsSeekBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._AbsSeekBar16582.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._AbsSeekBar16582 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar16582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar16583;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._AbsSeekBar16583.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._AbsSeekBar16583 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar16583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar16584;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._AbsSeekBar16584.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._AbsSeekBar16584 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar16584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AbsSeekBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSeekBar"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsSeekBar))]
	internal sealed partial class AbsSeekBar_ : android.widget.AbsSeekBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbsSeekBar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbsSeekBar_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSeekBar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSeekBar"));
		}
		internal static void InitJNI()
		{
		}
	}
}
