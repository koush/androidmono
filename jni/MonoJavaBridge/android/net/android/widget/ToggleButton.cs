namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ToggleButton : android.widget.CompoundButton
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ToggleButton() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ToggleButton), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ToggleButton(@__env); 
			} 
		} 
		protected ToggleButton(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChecked10442; 
		public override void setChecked(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				@__env.CallVoidMethod(this, _setChecked10442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ToggleButton.staticClass, _setChecked10442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable10443; 
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				@__env.CallVoidMethod(this, _setBackgroundDrawable10443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ToggleButton.staticClass, _setBackgroundDrawable10443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10444; 
		protected override void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				@__env.CallVoidMethod(this, _onFinishInflate10444); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ToggleButton.staticClass, _onFinishInflate10444); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged10445; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				@__env.CallVoidMethod(this, _drawableStateChanged10445); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ToggleButton.staticClass, _drawableStateChanged10445); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextOn10446; 
		public virtual java.lang.CharSequence getTextOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextOn10446)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ToggleButton.staticClass, _getTextOn10446)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextOn10447; 
		public virtual void setTextOn(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				@__env.CallVoidMethod(this, _setTextOn10447, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ToggleButton.staticClass, _setTextOn10447, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextOff10448; 
		public virtual java.lang.CharSequence getTextOff() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextOff10448)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ToggleButton.staticClass, _getTextOff10448)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextOff10449; 
		public virtual void setTextOff(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ToggleButton)) 
				@__env.CallVoidMethod(this, _setTextOff10449, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ToggleButton.staticClass, _setTextOff10449, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ToggleButton10450; 
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ToggleButton.staticClass, _ToggleButton10450, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ToggleButton10451; 
		public ToggleButton(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ToggleButton.staticClass, _ToggleButton10451, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ToggleButton10452; 
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ToggleButton.staticClass, _ToggleButton10452, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ToggleButton.staticClass = @__class; 
			global::android.widget.ToggleButton._setChecked10442 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setChecked", "(Z)V"); 
			global::android.widget.ToggleButton._setBackgroundDrawable10443 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ToggleButton._onFinishInflate10444 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.ToggleButton._drawableStateChanged10445 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.ToggleButton._getTextOn10446 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "getTextOn", "()Ljava/lang/CharSequence;"); 
			global::android.widget.ToggleButton._setTextOn10447 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setTextOn", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.ToggleButton._getTextOff10448 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "getTextOff", "()Ljava/lang/CharSequence;"); 
			global::android.widget.ToggleButton._setTextOff10449 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setTextOff", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.ToggleButton._ToggleButton10450 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ToggleButton._ToggleButton10451 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ToggleButton._ToggleButton10452 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
