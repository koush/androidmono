namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.CompoundButton_))]
	public abstract partial class CompoundButton : android.widget.Button, Checkable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal OnCheckedChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCheckedChanged16874;
			void android.widget.CompoundButton.OnCheckedChangeListener.onCheckedChanged(android.widget.CompoundButton arg0, bool arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16874.native == global::System.IntPtr.Zero)
					global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16874 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CompoundButton.OnCheckedChangeListener_._onCheckedChanged16874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnCheckedChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton$OnCheckedChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnCheckedChangeListenerDelegate(android.widget.CompoundButton arg0, bool arg1);

		internal partial class OnCheckedChangeListenerDelegateWrapper : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCheckedChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnCheckedChangeListenerDelegateWrapper16875;
			public OnCheckedChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper16875.native == global::System.IntPtr.Zero)
					global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper16875 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass, global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper16875);
				Init(@__env, handle);
			}
			static OnCheckedChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton_OnCheckedChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
			if (global::android.widget.CompoundButton._toggle16876.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._toggle16876 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "toggle", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._toggle16876);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked16877;
		public virtual bool isChecked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._isChecked16877.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._isChecked16877 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "isChecked", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._isChecked16877);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked16878;
		public virtual void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._setChecked16878.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._setChecked16878 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setChecked", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setChecked16878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16879;
		public override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._onRestoreInstanceState16879.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._onRestoreInstanceState16879 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onRestoreInstanceState16879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16880;
		public override global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._onSaveInstanceState16880.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._onSaveInstanceState16880 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onSaveInstanceState16880) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent16881;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16881.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16881 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent16881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performClick16882;
		public override bool performClick()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._performClick16882.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._performClick16882 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "performClick", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._performClick16882);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16883;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._onDraw16883.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._onDraw16883 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onDraw16883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16884;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._verifyDrawable16884.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._verifyDrawable16884 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._verifyDrawable16884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16885;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._drawableStateChanged16885.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._drawableStateChanged16885 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "drawableStateChanged", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._drawableStateChanged16885);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState16886;
		protected override int[] onCreateDrawableState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._onCreateDrawableState16886.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._onCreateDrawableState16886 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "onCreateDrawableState", "(I)[I");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onCreateDrawableState16886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setOnCheckedChangeListener16887;
		public virtual void setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._setOnCheckedChangeListener16887.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._setOnCheckedChangeListener16887 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setOnCheckedChangeListener16887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCheckedChangeListener(global::android.widget.CompoundButton.OnCheckedChangeListenerDelegate arg0)
		{
			setOnCheckedChangeListener((global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable16888;
		public virtual void setButtonDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._setButtonDrawable16888.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._setButtonDrawable16888 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable16888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setButtonDrawable16889;
		public virtual void setButtonDrawable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._setButtonDrawable16889.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._setButtonDrawable16889 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable16889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16890;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._CompoundButton16890.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._CompoundButton16890 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16891;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._CompoundButton16891.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._CompoundButton16891 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompoundButton16892;
		public CompoundButton(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._CompoundButton16892.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._CompoundButton16892 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton16892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CompoundButton()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CompoundButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CompoundButton))]
	internal sealed partial class CompoundButton_ : android.widget.CompoundButton
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CompoundButton_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static CompoundButton_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CompoundButton_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton"));
		}
		internal static void InitJNI()
		{
		}
	}
}
