namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbsSeekBar : android.widget.ProgressBar
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbsSeekBar() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AbsSeekBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbsSeekBar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9046; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				return @__env.CallBooleanMethod(this, _onKeyDown9046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsSeekBar.staticClass, _onKeyDown9046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9047; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent9047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsSeekBar.staticClass, _onTouchEvent9047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9048; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _onSizeChanged9048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _onSizeChanged9048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9049; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _onDraw9049, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _onDraw9049, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable9050; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable9050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsSeekBar.staticClass, _verifyDrawable9050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9051; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _drawableStateChanged9051); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _drawableStateChanged9051); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9052; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _onMeasure9052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _onMeasure9052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMax9053; 
		public override void setMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _setMax9053, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _setMax9053, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setThumb9054; 
		public virtual void setThumb(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _setThumb9054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _setThumb9054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThumbOffset9055; 
		public virtual int getThumbOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				return @__env.CallIntMethod(this, _getThumbOffset9055); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsSeekBar.staticClass, _getThumbOffset9055); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setThumbOffset9056; 
		public virtual void setThumbOffset(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _setThumbOffset9056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _setThumbOffset9056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyProgressIncrement9057; 
		public virtual void setKeyProgressIncrement(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				@__env.CallVoidMethod(this, _setKeyProgressIncrement9057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSeekBar.staticClass, _setKeyProgressIncrement9057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyProgressIncrement9058; 
		public virtual int getKeyProgressIncrement() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSeekBar)) 
				return @__env.CallIntMethod(this, _getKeyProgressIncrement9058); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsSeekBar.staticClass, _getKeyProgressIncrement9058); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSeekBar9059; 
		public AbsSeekBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsSeekBar.staticClass, _AbsSeekBar9059, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSeekBar9060; 
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsSeekBar.staticClass, _AbsSeekBar9060, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSeekBar9061; 
		public AbsSeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsSeekBar.staticClass, _AbsSeekBar9061, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.AbsSeekBar.staticClass = @__class; 
			global::android.widget.AbsSeekBar._onKeyDown9046 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.AbsSeekBar._onTouchEvent9047 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.AbsSeekBar._onSizeChanged9048 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.AbsSeekBar._onDraw9049 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.AbsSeekBar._verifyDrawable9050 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.AbsSeekBar._drawableStateChanged9051 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.AbsSeekBar._onMeasure9052 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.AbsSeekBar._setMax9053 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setMax", "(I)V"); 
			global::android.widget.AbsSeekBar._setThumb9054 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setThumb", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.AbsSeekBar._getThumbOffset9055 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "getThumbOffset", "()I"); 
			global::android.widget.AbsSeekBar._setThumbOffset9056 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setThumbOffset", "(I)V"); 
			global::android.widget.AbsSeekBar._setKeyProgressIncrement9057 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "setKeyProgressIncrement", "(I)V"); 
			global::android.widget.AbsSeekBar._getKeyProgressIncrement9058 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "getKeyProgressIncrement", "()I"); 
			global::android.widget.AbsSeekBar._AbsSeekBar9059 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.AbsSeekBar._AbsSeekBar9060 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.AbsSeekBar._AbsSeekBar9061 = @__env.GetMethodID(global::android.widget.AbsSeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
