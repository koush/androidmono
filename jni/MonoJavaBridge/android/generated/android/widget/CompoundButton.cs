namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.CompoundButton_))]
	public abstract partial class CompoundButton : android.widget.Button, Checkable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CompoundButton()
		{
			InitJNI();
		}
		protected CompoundButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.CompoundButton.OnCheckedChangeListener_))]
		public interface OnCheckedChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCheckedChanged(android.widget.CompoundButton arg0, bool arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CompoundButton.OnCheckedChangeListener))]
		public sealed partial class OnCheckedChangeListener_ : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCheckedChangeListener_()
			{
				InitJNI();
			}
			internal OnCheckedChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCheckedChanged16779;
			 void android.widget.CompoundButton.OnCheckedChangeListener.onCheckedChanged(android.widget.CompoundButton arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton$OnCheckedChangeListener"));
				global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16779 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toggle16780;
		public virtual void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._toggle16780);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._toggle16780);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked16781;
		public virtual bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._isChecked16781);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._isChecked16781);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked16782;
		public virtual void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setChecked16782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setChecked16782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16783;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._onRestoreInstanceState16783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onRestoreInstanceState16783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16784;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CompoundButton._onSaveInstanceState16784)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onSaveInstanceState16784)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent16785;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performClick16786;
		public override bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._performClick16786);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._performClick16786);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16787;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._onDraw16787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onDraw16787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16788;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._verifyDrawable16788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._verifyDrawable16788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16789;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._drawableStateChanged16789);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._drawableStateChanged16789);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState16790;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CompoundButton._onCreateDrawableState16790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onCreateDrawableState16790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setOnCheckedChangeListener16791;
		public virtual void setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setOnCheckedChangeListener16791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setOnCheckedChangeListener16791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable16792;
		public virtual void setButtonDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setButtonDrawable16792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable16792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable16793;
		public virtual void setButtonDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setButtonDrawable16793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable16793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16794;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16795;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16796;
		public CompoundButton(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CompoundButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton"));
			global::android.widget.CompoundButton._toggle16780 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "toggle", "()V");
			global::android.widget.CompoundButton._isChecked16781 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "isChecked", "()Z");
			global::android.widget.CompoundButton._setChecked16782 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setChecked", "(Z)V");
			global::android.widget.CompoundButton._onRestoreInstanceState16783 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.CompoundButton._onSaveInstanceState16784 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16785 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.CompoundButton._performClick16786 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "performClick", "()Z");
			global::android.widget.CompoundButton._onDraw16787 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.CompoundButton._verifyDrawable16788 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.CompoundButton._drawableStateChanged16789 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "drawableStateChanged", "()V");
			global::android.widget.CompoundButton._onCreateDrawableState16790 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.CompoundButton._setOnCheckedChangeListener16791 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V");
			global::android.widget.CompoundButton._setButtonDrawable16792 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.CompoundButton._setButtonDrawable16793 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(I)V");
			global::android.widget.CompoundButton._CompoundButton16794 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CompoundButton._CompoundButton16795 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.CompoundButton._CompoundButton16796 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CompoundButton))]
	public sealed partial class CompoundButton_ : android.widget.CompoundButton
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CompoundButton_()
		{
			InitJNI();
		}
		internal CompoundButton_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CompoundButton_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton"));
		}
	}
}
