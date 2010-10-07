namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbsSeekBar : android.widget.ProgressBar
	{
		internal new static global::java.lang.Class staticClass;
		static AbsSeekBar()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AbsSeekBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbsSeekBar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10440;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsSeekBar._onKeyDown10440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onKeyDown10440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10441;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsSeekBar._onTouchEvent10441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onTouchEvent10441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged10442;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._onSizeChanged10442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onSizeChanged10442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw10443;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._onDraw10443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onDraw10443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable10444;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsSeekBar._verifyDrawable10444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._verifyDrawable10444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged10445;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._drawableStateChanged10445);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._drawableStateChanged10445);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10446;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._onMeasure10446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onMeasure10446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMax10447;
		public override void setMax(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._setMax10447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setMax10447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setThumb10448;
		public virtual void setThumb(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._setThumb10448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumb10448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThumbOffset10449;
		public virtual int getThumbOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsSeekBar._getThumbOffset10449);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getThumbOffset10449);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setThumbOffset10450;
		public virtual void setThumbOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._setThumbOffset10450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumbOffset10450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyProgressIncrement10451;
		public virtual void setKeyProgressIncrement(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSeekBar._setKeyProgressIncrement10451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setKeyProgressIncrement10451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyProgressIncrement10452;
		public virtual int getKeyProgressIncrement() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsSeekBar._getKeyProgressIncrement10452);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getKeyProgressIncrement10452);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSeekBar10453;
		public AbsSeekBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar10453, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSeekBar10454;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar10454, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSeekBar10455;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar10455, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AbsSeekBar.staticClass = @__class;
			global::android.widget.AbsSeekBar._onKeyDown10440 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsSeekBar._onTouchEvent10441 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsSeekBar._onSizeChanged10442 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsSeekBar._onDraw10443 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsSeekBar._verifyDrawable10444 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsSeekBar._drawableStateChanged10445 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsSeekBar._onMeasure10446 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSeekBar._setMax10447 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setMax", "(I)V");
			global::android.widget.AbsSeekBar._setThumb10448 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setThumb", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsSeekBar._getThumbOffset10449 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "getThumbOffset", "()I");
			global::android.widget.AbsSeekBar._setThumbOffset10450 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setThumbOffset", "(I)V");
			global::android.widget.AbsSeekBar._setKeyProgressIncrement10451 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setKeyProgressIncrement", "(I)V");
			global::android.widget.AbsSeekBar._getKeyProgressIncrement10452 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "getKeyProgressIncrement", "()I");
			global::android.widget.AbsSeekBar._AbsSeekBar10453 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar10454 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar10455 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
