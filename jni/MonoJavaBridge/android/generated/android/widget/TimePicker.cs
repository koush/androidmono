namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimePicker : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimePicker()
		{
			InitJNI();
		}
		protected TimePicker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TimePicker.OnTimeChangedListener_))]
		public interface OnTimeChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TimePicker.OnTimeChangedListener))]
		public sealed partial class OnTimeChangedListener_ : java.lang.Object, OnTimeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnTimeChangedListener_()
			{
				InitJNI();
			}
			internal OnTimeChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTimeChanged18051;
			 void android.widget.TimePicker.OnTimeChangedListener.onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged18051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.OnTimeChangedListener_.staticClass, global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged18051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TimePicker.OnTimeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker$OnTimeChangedListener"));
				global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged18051 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.OnTimeChangedListener_.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled18052;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setEnabled18052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setEnabled18052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState18053;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._onRestoreInstanceState18053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onRestoreInstanceState18053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState18054;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._onSaveInstanceState18054)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onSaveInstanceState18054)) as android.os.Parcelable;
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline18055;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TimePicker._getBaseline18055);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getBaseline18055);
		}
		internal static global::MonoJavaBridge.MethodId _is24HourView18056;
		public virtual bool is24HourView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TimePicker._is24HourView18056);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._is24HourView18056);
		}
		internal static global::MonoJavaBridge.MethodId _setOnTimeChangedListener18057;
		public virtual void setOnTimeChangedListener(android.widget.TimePicker.OnTimeChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setOnTimeChangedListener18057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setOnTimeChangedListener18057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrentHour18058;
		public virtual global::java.lang.Integer getCurrentHour() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._getCurrentHour18058)) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentHour18058)) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentHour18059;
		public virtual void setCurrentHour(java.lang.Integer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setCurrentHour18059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentHour18059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIs24HourView18060;
		public virtual void setIs24HourView(java.lang.Boolean arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setIs24HourView18060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setIs24HourView18060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrentMinute18061;
		public virtual global::java.lang.Integer getCurrentMinute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._getCurrentMinute18061)) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentMinute18061)) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentMinute18062;
		public virtual void setCurrentMinute(java.lang.Integer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setCurrentMinute18062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentMinute18062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker18063;
		public TimePicker(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker18063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker18064;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker18064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker18065;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker18065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TimePicker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker"));
			global::android.widget.TimePicker._setEnabled18052 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setEnabled", "(Z)V");
			global::android.widget.TimePicker._onRestoreInstanceState18053 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TimePicker._onSaveInstanceState18054 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TimePicker._getBaseline18055 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getBaseline", "()I");
			global::android.widget.TimePicker._is24HourView18056 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "is24HourView", "()Z");
			global::android.widget.TimePicker._setOnTimeChangedListener18057 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V");
			global::android.widget.TimePicker._getCurrentHour18058 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getCurrentHour", "()Ljava/lang/Integer;");
			global::android.widget.TimePicker._setCurrentHour18059 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setCurrentHour", "(Ljava/lang/Integer;)V");
			global::android.widget.TimePicker._setIs24HourView18060 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setIs24HourView", "(Ljava/lang/Boolean;)V");
			global::android.widget.TimePicker._getCurrentMinute18061 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getCurrentMinute", "()Ljava/lang/Integer;");
			global::android.widget.TimePicker._setCurrentMinute18062 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setCurrentMinute", "(Ljava/lang/Integer;)V");
			global::android.widget.TimePicker._TimePicker18063 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TimePicker._TimePicker18064 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TimePicker._TimePicker18065 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
