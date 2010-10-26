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
		public partial interface OnCheckedChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCheckedChanged(android.widget.CompoundButton arg0, bool arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CompoundButton.OnCheckedChangeListener))]
		internal sealed partial class OnCheckedChangeListener_ : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCheckedChangeListener_()
			{
				InitJNI();
			}
			internal OnCheckedChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCheckedChanged16874;
			 void android.widget.CompoundButton.OnCheckedChangeListener.onCheckedChanged(android.widget.CompoundButton arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton$OnCheckedChangeListener"));
				global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16874 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V");
			}
		}

		public delegate void OnCheckedChangeListenerDelegate(android.widget.CompoundButton arg0, bool arg1);

		internal partial class OnCheckedChangeListenerDelegateWrapper : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCheckedChangeListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnCheckedChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnCheckedChangeListenerDelegateWrapper16875;
			public OnCheckedChangeListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass, global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper16875);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton_OnCheckedChangeListenerDelegateWrapper"));
				global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper16875 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnCheckedChangeListenerDelegateWrapper
		{
			private OnCheckedChangeListenerDelegate myDelegate;
			public void onCheckedChanged(android.widget.CompoundButton arg0, bool arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnCheckedChangeListenerDelegateWrapper(OnCheckedChangeListenerDelegate d)
			{
				global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper ret = new global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _toggle16876;
		public virtual void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._toggle16876);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._toggle16876);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked16877;
		public virtual bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._isChecked16877);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._isChecked16877);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked16878;
		public virtual void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setChecked16878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setChecked16878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16879;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._onRestoreInstanceState16879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onRestoreInstanceState16879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16880;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CompoundButton._onSaveInstanceState16880)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onSaveInstanceState16880)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent16881;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performClick16882;
		public override bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._performClick16882);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._performClick16882);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16883;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._onDraw16883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onDraw16883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16884;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton._verifyDrawable16884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._verifyDrawable16884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16885;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._drawableStateChanged16885);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._drawableStateChanged16885);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState16886;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CompoundButton._onCreateDrawableState16886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onCreateDrawableState16886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setOnCheckedChangeListener16887;
		public virtual void setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setOnCheckedChangeListener16887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setOnCheckedChangeListener16887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCheckedChangeListener(global::android.widget.CompoundButton.OnCheckedChangeListenerDelegate arg0)
		{
			setOnCheckedChangeListener((global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable16888;
		public virtual void setButtonDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setButtonDrawable16888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable16888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable16889;
		public virtual void setButtonDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton._setButtonDrawable16889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable16889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16890;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16891;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16892;
		public CompoundButton(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CompoundButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton"));
			global::android.widget.CompoundButton._toggle16876 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "toggle", "()V");
			global::android.widget.CompoundButton._isChecked16877 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "isChecked", "()Z");
			global::android.widget.CompoundButton._setChecked16878 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setChecked", "(Z)V");
			global::android.widget.CompoundButton._onRestoreInstanceState16879 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.CompoundButton._onSaveInstanceState16880 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16881 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.CompoundButton._performClick16882 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "performClick", "()Z");
			global::android.widget.CompoundButton._onDraw16883 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.CompoundButton._verifyDrawable16884 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.CompoundButton._drawableStateChanged16885 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "drawableStateChanged", "()V");
			global::android.widget.CompoundButton._onCreateDrawableState16886 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.CompoundButton._setOnCheckedChangeListener16887 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V");
			global::android.widget.CompoundButton._setButtonDrawable16888 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.CompoundButton._setButtonDrawable16889 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(I)V");
			global::android.widget.CompoundButton._CompoundButton16890 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CompoundButton._CompoundButton16891 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.CompoundButton._CompoundButton16892 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CompoundButton))]
	internal sealed partial class CompoundButton_ : android.widget.CompoundButton
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
