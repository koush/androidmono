namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CompoundButton : android.widget.Button, Checkable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CompoundButton() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.CompoundButton), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CompoundButton(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnCheckedChangeListener 
		{ 
			void onCheckedChanged(android.widget.CompoundButton arg0, bool arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggle9299; 
		public virtual void toggle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _toggle9299); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _toggle9299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChecked9300; 
		public virtual bool isChecked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				return @__env.CallBooleanMethod(this, _isChecked9300); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CompoundButton.staticClass, _isChecked9300); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChecked9301; 
		public virtual void setChecked(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _setChecked9301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _setChecked9301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9302; 
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState9302, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _onRestoreInstanceState9302, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9303; 
		public override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState9303)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CompoundButton.staticClass, _onSaveInstanceState9303)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9304; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent9304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CompoundButton.staticClass, _dispatchPopulateAccessibilityEvent9304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performClick9305; 
		public override bool performClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				return @__env.CallBooleanMethod(this, _performClick9305); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CompoundButton.staticClass, _performClick9305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9306; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _onDraw9306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _onDraw9306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable9307; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable9307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CompoundButton.staticClass, _verifyDrawable9307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9308; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _drawableStateChanged9308); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _drawableStateChanged9308); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState9309; 
		protected override int[] onCreateDrawableState(int arg0) 
		{ 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _onCreateDrawableState9309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CompoundButton.staticClass, _onCreateDrawableState9309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCheckedChangeListener9310; 
		public virtual void setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _setOnCheckedChangeListener9310, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _setOnCheckedChangeListener9310, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButtonDrawable9311; 
		public virtual void setButtonDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _setButtonDrawable9311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _setButtonDrawable9311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButtonDrawable9312; 
		public virtual void setButtonDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CompoundButton)) 
				@__env.CallVoidMethod(this, _setButtonDrawable9312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CompoundButton.staticClass, _setButtonDrawable9312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CompoundButton9313; 
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CompoundButton.staticClass, _CompoundButton9313, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CompoundButton9314; 
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CompoundButton.staticClass, _CompoundButton9314, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CompoundButton9315; 
		public CompoundButton(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CompoundButton.staticClass, _CompoundButton9315, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.CompoundButton.staticClass = @__class; 
			global::android.widget.CompoundButton._toggle9299 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "toggle", "()V"); 
			global::android.widget.CompoundButton._isChecked9300 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "isChecked", "()Z"); 
			global::android.widget.CompoundButton._setChecked9301 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setChecked", "(Z)V"); 
			global::android.widget.CompoundButton._onRestoreInstanceState9302 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.CompoundButton._onSaveInstanceState9303 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent9304 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.CompoundButton._performClick9305 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "performClick", "()Z"); 
			global::android.widget.CompoundButton._onDraw9306 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.CompoundButton._verifyDrawable9307 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.CompoundButton._drawableStateChanged9308 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.CompoundButton._onCreateDrawableState9309 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.widget.CompoundButton._setOnCheckedChangeListener9310 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V"); 
			global::android.widget.CompoundButton._setButtonDrawable9311 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.CompoundButton._setButtonDrawable9312 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(I)V"); 
			global::android.widget.CompoundButton._CompoundButton9313 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.CompoundButton._CompoundButton9314 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.CompoundButton._CompoundButton9315 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
