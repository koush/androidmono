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
			internal static global::MonoJavaBridge.MethodId _onTimeChanged18167;
			void android.widget.TimePicker.OnTimeChangedListener.onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged18167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.OnTimeChangedListener_.staticClass, global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged18167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnTimeChangedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TimePicker.OnTimeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker$OnTimeChangedListener"));
				global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged18167 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.OnTimeChangedListener_.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnTimeChangedListenerDelegate(android.widget.TimePicker arg0, int arg1, int arg2);

		internal partial class OnTimeChangedListenerDelegateWrapper : java.lang.Object, OnTimeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTimeChangedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnTimeChangedListenerDelegateWrapper18168;
			public OnTimeChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper.staticClass, global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper._OnTimeChangedListenerDelegateWrapper18168);
				Init(@__env, handle);
			}
			static OnTimeChangedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker_OnTimeChangedListenerDelegateWrapper"));
				global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper._OnTimeChangedListenerDelegateWrapper18168 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.OnTimeChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _setEnabled18169;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setEnabled18169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setEnabled18169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState18170;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._onRestoreInstanceState18170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onRestoreInstanceState18170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState18171;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._onSaveInstanceState18171)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onSaveInstanceState18171)) as android.os.Parcelable;
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline18172;
		public override int getBaseline()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TimePicker._getBaseline18172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getBaseline18172);
		}
		internal static global::MonoJavaBridge.MethodId _is24HourView18173;
		public virtual bool is24HourView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TimePicker._is24HourView18173);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._is24HourView18173);
		}
		internal static global::MonoJavaBridge.MethodId _setOnTimeChangedListener18174;
		public virtual void setOnTimeChangedListener(android.widget.TimePicker.OnTimeChangedListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setOnTimeChangedListener18174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setOnTimeChangedListener18174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrentHour18175;
		public virtual global::java.lang.Integer getCurrentHour()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._getCurrentHour18175)) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentHour18175)) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentHour18176;
		public virtual void setCurrentHour(java.lang.Integer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setCurrentHour18176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentHour18176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIs24HourView18177;
		public virtual void setIs24HourView(java.lang.Boolean arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setIs24HourView18177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setIs24HourView18177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrentMinute18178;
		public virtual global::java.lang.Integer getCurrentMinute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._getCurrentMinute18178)) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentMinute18178)) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentMinute18179;
		public virtual void setCurrentMinute(java.lang.Integer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setCurrentMinute18179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentMinute18179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker18180;
		public TimePicker(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker18180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker18181;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker18181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker18182;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker18182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TimePicker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TimePicker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker"));
			global::android.widget.TimePicker._setEnabled18169 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setEnabled", "(Z)V");
			global::android.widget.TimePicker._onRestoreInstanceState18170 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TimePicker._onSaveInstanceState18171 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TimePicker._getBaseline18172 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getBaseline", "()I");
			global::android.widget.TimePicker._is24HourView18173 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "is24HourView", "()Z");
			global::android.widget.TimePicker._setOnTimeChangedListener18174 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V");
			global::android.widget.TimePicker._getCurrentHour18175 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getCurrentHour", "()Ljava/lang/Integer;");
			global::android.widget.TimePicker._setCurrentHour18176 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setCurrentHour", "(Ljava/lang/Integer;)V");
			global::android.widget.TimePicker._setIs24HourView18177 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setIs24HourView", "(Ljava/lang/Boolean;)V");
			global::android.widget.TimePicker._getCurrentMinute18178 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getCurrentMinute", "()Ljava/lang/Integer;");
			global::android.widget.TimePicker._setCurrentMinute18179 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setCurrentMinute", "(Ljava/lang/Integer;)V");
			global::android.widget.TimePicker._TimePicker18180 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TimePicker._TimePicker18181 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TimePicker._TimePicker18182 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
