namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CheckedTextView : android.widget.TextView, Checkable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CheckedTextView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.CheckedTextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.CheckedTextView(@__env); 
			} 
		} 
		protected CheckedTextView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggle9273; 
		public virtual void toggle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				@__env.CallVoidMethod(this, _toggle9273); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CheckedTextView.staticClass, _toggle9273); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChecked9274; 
		public virtual bool isChecked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				return @__env.CallBooleanMethod(this, _isChecked9274); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CheckedTextView.staticClass, _isChecked9274); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChecked9275; 
		public virtual void setChecked(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				@__env.CallVoidMethod(this, _setChecked9275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CheckedTextView.staticClass, _setChecked9275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9276; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent9276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CheckedTextView.staticClass, _dispatchPopulateAccessibilityEvent9276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9277; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				@__env.CallVoidMethod(this, _onDraw9277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CheckedTextView.staticClass, _onDraw9277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9278; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				@__env.CallVoidMethod(this, _drawableStateChanged9278); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CheckedTextView.staticClass, _drawableStateChanged9278); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState9279; 
		protected override int[] onCreateDrawableState(int arg0) 
		{ 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _onCreateDrawableState9279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CheckedTextView.staticClass, _onCreateDrawableState9279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding9280; 
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				@__env.CallVoidMethod(this, _setPadding9280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CheckedTextView.staticClass, _setPadding9280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCheckMarkDrawable9281; 
		public virtual void setCheckMarkDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				@__env.CallVoidMethod(this, _setCheckMarkDrawable9281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CheckedTextView.staticClass, _setCheckMarkDrawable9281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCheckMarkDrawable9282; 
		public virtual void setCheckMarkDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CheckedTextView)) 
				@__env.CallVoidMethod(this, _setCheckMarkDrawable9282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CheckedTextView.staticClass, _setCheckMarkDrawable9282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CheckedTextView9283; 
		public CheckedTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CheckedTextView.staticClass, _CheckedTextView9283, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CheckedTextView9284; 
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CheckedTextView.staticClass, _CheckedTextView9284, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CheckedTextView9285; 
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CheckedTextView.staticClass, _CheckedTextView9285, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.CheckedTextView.staticClass = @__class; 
			global::android.widget.CheckedTextView._toggle9273 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "toggle", "()V"); 
			global::android.widget.CheckedTextView._isChecked9274 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "isChecked", "()Z"); 
			global::android.widget.CheckedTextView._setChecked9275 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setChecked", "(Z)V"); 
			global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent9276 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.CheckedTextView._onDraw9277 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.CheckedTextView._drawableStateChanged9278 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.CheckedTextView._onCreateDrawableState9279 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.widget.CheckedTextView._setPadding9280 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setPadding", "(IIII)V"); 
			global::android.widget.CheckedTextView._setCheckMarkDrawable9281 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.CheckedTextView._setCheckMarkDrawable9282 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(I)V"); 
			global::android.widget.CheckedTextView._CheckedTextView9283 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.CheckedTextView._CheckedTextView9284 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.CheckedTextView._CheckedTextView9285 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
