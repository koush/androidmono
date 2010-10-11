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
		internal static global::MonoJavaBridge.MethodId _onKeyDown10792;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onKeyDown10792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onKeyDown10792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent10793;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onTouchEvent10793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onTouchEvent10793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged10794;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onSizeChanged10794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onSizeChanged10794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw10795;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onDraw10795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onDraw10795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable10796;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar._verifyDrawable10796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._verifyDrawable10796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged10797;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._drawableStateChanged10797);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._drawableStateChanged10797);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure10798;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._onMeasure10798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._onMeasure10798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMax10799;
		public override void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setMax10799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setMax10799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setThumb10800;
		public virtual void setThumb(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setThumb10800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumb10800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getThumbOffset10801;
		public virtual int getThumbOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar._getThumbOffset10801);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getThumbOffset10801);
		}
		internal static global::MonoJavaBridge.MethodId _setThumbOffset10802;
		public virtual void setThumbOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setThumbOffset10802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setThumbOffset10802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyProgressIncrement10803;
		public virtual void setKeyProgressIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar._setKeyProgressIncrement10803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._setKeyProgressIncrement10803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyProgressIncrement10804;
		public virtual int getKeyProgressIncrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar._getKeyProgressIncrement10804);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._getKeyProgressIncrement10804);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar10805;
		public AbsSeekBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar10805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar10806;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar10806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSeekBar10807;
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSeekBar.staticClass, global::android.widget.AbsSeekBar._AbsSeekBar10807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSeekBar"));
			global::android.widget.AbsSeekBar._onKeyDown10792 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsSeekBar._onTouchEvent10793 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsSeekBar._onSizeChanged10794 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsSeekBar._onDraw10795 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsSeekBar._verifyDrawable10796 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsSeekBar._drawableStateChanged10797 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsSeekBar._onMeasure10798 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSeekBar._setMax10799 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setMax", "(I)V");
			global::android.widget.AbsSeekBar._setThumb10800 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumb", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsSeekBar._getThumbOffset10801 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getThumbOffset", "()I");
			global::android.widget.AbsSeekBar._setThumbOffset10802 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setThumbOffset", "(I)V");
			global::android.widget.AbsSeekBar._setKeyProgressIncrement10803 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "setKeyProgressIncrement", "(I)V");
			global::android.widget.AbsSeekBar._getKeyProgressIncrement10804 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "getKeyProgressIncrement", "()I");
			global::android.widget.AbsSeekBar._AbsSeekBar10805 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar10806 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSeekBar._AbsSeekBar10807 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
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
