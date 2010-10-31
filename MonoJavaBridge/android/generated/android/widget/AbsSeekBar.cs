namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsSeekBar_))]
	public abstract partial class AbsSeekBar : android.widget.ProgressBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsSeekBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AbsSeekBar._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.AbsSeekBar._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.AbsSeekBar._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.AbsSeekBar._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.AbsSeekBar._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "drawableStateChanged", "()V", ref global::android.widget.AbsSeekBar._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "onMeasure", "(II)V", ref global::android.widget.AbsSeekBar._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setMax(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "setMax", "(I)V", ref global::android.widget.AbsSeekBar._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setThumb(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "setThumb", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.AbsSeekBar._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getThumbOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSeekBar.staticClass, "getThumbOffset", "()I", ref global::android.widget.AbsSeekBar._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setThumbOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "setThumbOffset", "(I)V", ref global::android.widget.AbsSeekBar._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setKeyProgressIncrement(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, "setKeyProgressIncrement", "(I)V", ref global::android.widget.AbsSeekBar._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getKeyProgressIncrement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSeekBar.staticClass, "getKeyProgressIncrement", "()I", ref global::android.widget.AbsSeekBar._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public AbsSeekBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._m13.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._m13 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._m14.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._m14 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSeekBar._m15.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSeekBar._m15 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AbsSeekBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSeekBar"));
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
	}
}
