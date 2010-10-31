namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimePicker : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimePicker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TimePicker.OnTimeChangedListener_))]
		public partial interface OnTimeChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TimePicker.OnTimeChangedListener))]
		internal sealed partial class OnTimeChangedListener_ : java.lang.Object, OnTimeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnTimeChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.TimePicker.OnTimeChangedListener.onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TimePicker.OnTimeChangedListener_.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V", ref global::android.widget.TimePicker.OnTimeChangedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnTimeChangedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TimePicker.OnTimeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker$OnTimeChangedListener"));
			}
		}

		public delegate void OnTimeChangedListenerDelegate(android.widget.TimePicker arg0, int arg1, int arg2);

		internal partial class OnTimeChangedListenerDelegateWrapper : java.lang.Object, OnTimeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTimeChangedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnTimeChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper.staticClass, global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnTimeChangedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker_OnTimeChangedListenerDelegateWrapper"));
			}
		}
		internal partial class OnTimeChangedListenerDelegateWrapper
		{
			private OnTimeChangedListenerDelegate myDelegate;
			public void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnTimeChangedListenerDelegateWrapper(OnTimeChangedListenerDelegate d)
			{
				global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper ret = new global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TimePicker.staticClass, "setEnabled", "(Z)V", ref global::android.widget.TimePicker._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TimePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.TimePicker._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.TimePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.TimePicker._m2) as android.os.Parcelable;
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TimePicker.staticClass, "getBaseline", "()I", ref global::android.widget.TimePicker._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool is24HourView()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TimePicker.staticClass, "is24HourView", "()Z", ref global::android.widget.TimePicker._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setOnTimeChangedListener(android.widget.TimePicker.OnTimeChangedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TimePicker.staticClass, "setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V", ref global::android.widget.TimePicker._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnTimeChangedListener(global::android.widget.TimePicker.OnTimeChangedListenerDelegate arg0)
		{
			setOnTimeChangedListener((global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper)arg0);
		}
		public new global::java.lang.Integer CurrentHour
		{
			get
			{
				return getCurrentHour();
			}
			set
			{
				setCurrentHour(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.Integer getCurrentHour()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Integer>(this, global::android.widget.TimePicker.staticClass, "getCurrentHour", "()Ljava/lang/Integer;", ref global::android.widget.TimePicker._m6) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setCurrentHour(java.lang.Integer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TimePicker.staticClass, "setCurrentHour", "(Ljava/lang/Integer;)V", ref global::android.widget.TimePicker._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setIs24HourView(java.lang.Boolean arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TimePicker.staticClass, "setIs24HourView", "(Ljava/lang/Boolean;)V", ref global::android.widget.TimePicker._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Integer CurrentMinute
		{
			get
			{
				return getCurrentMinute();
			}
			set
			{
				setCurrentMinute(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.Integer getCurrentMinute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Integer>(this, global::android.widget.TimePicker.staticClass, "getCurrentMinute", "()Ljava/lang/Integer;", ref global::android.widget.TimePicker._m9) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setCurrentMinute(java.lang.Integer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TimePicker.staticClass, "setCurrentMinute", "(Ljava/lang/Integer;)V", ref global::android.widget.TimePicker._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public TimePicker(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TimePicker._m11.native == global::System.IntPtr.Zero)
				global::android.widget.TimePicker._m11 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TimePicker._m12.native == global::System.IntPtr.Zero)
				global::android.widget.TimePicker._m12 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TimePicker._m13.native == global::System.IntPtr.Zero)
				global::android.widget.TimePicker._m13 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TimePicker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TimePicker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker"));
		}
	}
}
