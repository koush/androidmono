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
			internal static global::MonoJavaBridge.MethodId _onCheckedChanged11634;
			 void android.widget.CompoundButton.OnCheckedChangeListener.onCheckedChanged(android.widget.CompoundButton arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged11634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged11634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton$OnCheckedChangeListener"));
				global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged11634 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toggle11635;
		public virtual void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._toggle11635);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._toggle11635);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked11636;
		public virtual bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._isChecked11636);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._isChecked11636);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked11637;
		public virtual void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setChecked11637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setChecked11637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState11638;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._onRestoreInstanceState11638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onRestoreInstanceState11638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState11639;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CompoundButton._onSaveInstanceState11639)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onSaveInstanceState11639)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent11640;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent11640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent11640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performClick11641;
		public override bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._performClick11641);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._performClick11641);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw11642;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._onDraw11642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onDraw11642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable11643;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._verifyDrawable11643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._verifyDrawable11643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged11644;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._drawableStateChanged11644);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._drawableStateChanged11644);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState11645;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CompoundButton._onCreateDrawableState11645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onCreateDrawableState11645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setOnCheckedChangeListener11646;
		public virtual void setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setOnCheckedChangeListener11646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setOnCheckedChangeListener11646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable11647;
		public virtual void setButtonDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setButtonDrawable11647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable11647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable11648;
		public virtual void setButtonDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setButtonDrawable11648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable11648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton11649;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton11649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton11650;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton11650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton11651;
		public CompoundButton(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton11651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CompoundButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton"));
			global::android.widget.CompoundButton._toggle11635 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "toggle", "()V");
			global::android.widget.CompoundButton._isChecked11636 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "isChecked", "()Z");
			global::android.widget.CompoundButton._setChecked11637 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setChecked", "(Z)V");
			global::android.widget.CompoundButton._onRestoreInstanceState11638 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.CompoundButton._onSaveInstanceState11639 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent11640 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.CompoundButton._performClick11641 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "performClick", "()Z");
			global::android.widget.CompoundButton._onDraw11642 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.CompoundButton._verifyDrawable11643 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.CompoundButton._drawableStateChanged11644 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "drawableStateChanged", "()V");
			global::android.widget.CompoundButton._onCreateDrawableState11645 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.CompoundButton._setOnCheckedChangeListener11646 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V");
			global::android.widget.CompoundButton._setButtonDrawable11647 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.CompoundButton._setButtonDrawable11648 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(I)V");
			global::android.widget.CompoundButton._CompoundButton11649 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CompoundButton._CompoundButton11650 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.CompoundButton._CompoundButton11651 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;)V");
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
