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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.CompoundButton.OnCheckedChangeListener.onCheckedChanged(android.widget.CompoundButton arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V", ref global::android.widget.CompoundButton.OnCheckedChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnCheckedChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton$OnCheckedChangeListener"));
			}
		}

		public delegate void OnCheckedChangeListenerDelegate(android.widget.CompoundButton arg0, bool arg1);

		internal partial class OnCheckedChangeListenerDelegateWrapper : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCheckedChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnCheckedChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass, global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnCheckedChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton_OnCheckedChangeListenerDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void toggle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "toggle", "()V", ref global::android.widget.CompoundButton._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isChecked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, "isChecked", "()Z", ref global::android.widget.CompoundButton._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "setChecked", "(Z)V", ref global::android.widget.CompoundButton._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.CompoundButton._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.CompoundButton.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.CompoundButton._m4) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.widget.CompoundButton._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool performClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, "performClick", "()Z", ref global::android.widget.CompoundButton._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.CompoundButton._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CompoundButton.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.CompoundButton._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "drawableStateChanged", "()V", ref global::android.widget.CompoundButton._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.CompoundButton.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.widget.CompoundButton._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V", ref global::android.widget.CompoundButton._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCheckedChangeListener(global::android.widget.CompoundButton.OnCheckedChangeListenerDelegate arg0)
		{
			setOnCheckedChangeListener((global::android.widget.CompoundButton.OnCheckedChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setButtonDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.CompoundButton._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setButtonDrawable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(I)V", ref global::android.widget.CompoundButton._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._m14.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._m14 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._m15.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._m15 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public CompoundButton(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CompoundButton._m16.native == global::System.IntPtr.Zero)
				global::android.widget.CompoundButton._m16 = @__env.GetMethodIDNoThrow(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CompoundButton()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CompoundButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CompoundButton"));
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
	}
}
