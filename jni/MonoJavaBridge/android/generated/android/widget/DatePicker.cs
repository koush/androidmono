namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatePicker : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatePicker()
		{
			InitJNI();
		}
		protected DatePicker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.DatePicker.OnDateChangedListener_))]
		public partial interface OnDateChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.DatePicker.OnDateChangedListener))]
		internal sealed partial class OnDateChangedListener_ : java.lang.Object, OnDateChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDateChangedListener_()
			{
				InitJNI();
			}
			internal OnDateChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDateChanged16950;
			void android.widget.DatePicker.OnDateChangedListener.onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker.OnDateChangedListener_._onDateChanged16950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.OnDateChangedListener_.staticClass, global::android.widget.DatePicker.OnDateChangedListener_._onDateChanged16950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.DatePicker.OnDateChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker$OnDateChangedListener"));
				global::android.widget.DatePicker.OnDateChangedListener_._onDateChanged16950 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.OnDateChangedListener_.staticClass, "onDateChanged", "(Landroid/widget/DatePicker;III)V");
			}
		}

		public delegate void OnDateChangedListenerDelegate(android.widget.DatePicker arg0, int arg1, int arg2, int arg3);

		internal partial class OnDateChangedListenerDelegateWrapper : java.lang.Object, OnDateChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDateChangedListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnDateChangedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnDateChangedListenerDelegateWrapper16951;
			public OnDateChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.OnDateChangedListenerDelegateWrapper.staticClass, global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper._OnDateChangedListenerDelegateWrapper16951);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker_OnDateChangedListenerDelegateWrapper"));
				global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper._OnDateChangedListenerDelegateWrapper16951 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnDateChangedListenerDelegateWrapper
		{
			private OnDateChangedListenerDelegate myDelegate;
			public void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3)
			{
				myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator OnDateChangedListenerDelegateWrapper(OnDateChangedListenerDelegate d)
			{
				global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper ret = new global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _init16952;
		public virtual void init(int arg0, int arg1, int arg2, android.widget.DatePicker.OnDateChangedListener arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._init16952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._init16952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void init(int arg0, int arg1, int arg2, global::android.widget.DatePicker.OnDateChangedListenerDelegate arg3)
		{
			init(arg0, arg1, arg2, (global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper)arg3);
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYear16953;
		public virtual int getYear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DatePicker._getYear16953);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getYear16953);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonth16954;
		public virtual int getMonth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DatePicker._getMonth16954);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getMonth16954);
		}
		public new int DayOfMonth
		{
			get
			{
				return getDayOfMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDayOfMonth16955;
		public virtual int getDayOfMonth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DatePicker._getDayOfMonth16955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getDayOfMonth16955);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled16956;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._setEnabled16956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._setEnabled16956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16957;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._onRestoreInstanceState16957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._onRestoreInstanceState16957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16958;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DatePicker._onSaveInstanceState16958)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._onSaveInstanceState16958)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState16959;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._dispatchRestoreInstanceState16959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._dispatchRestoreInstanceState16959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate16960;
		public virtual void updateDate(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._updateDate16960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._updateDate16960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _DatePicker16961;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker16961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatePicker16962;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker16962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatePicker16963;
		public DatePicker(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker16963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DatePicker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker"));
			global::android.widget.DatePicker._init16952 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V");
			global::android.widget.DatePicker._getYear16953 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "getYear", "()I");
			global::android.widget.DatePicker._getMonth16954 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "getMonth", "()I");
			global::android.widget.DatePicker._getDayOfMonth16955 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "getDayOfMonth", "()I");
			global::android.widget.DatePicker._setEnabled16956 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "setEnabled", "(Z)V");
			global::android.widget.DatePicker._onRestoreInstanceState16957 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.DatePicker._onSaveInstanceState16958 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.DatePicker._dispatchRestoreInstanceState16959 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.DatePicker._updateDate16960 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "updateDate", "(III)V");
			global::android.widget.DatePicker._DatePicker16961 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.DatePicker._DatePicker16962 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.DatePicker._DatePicker16963 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
