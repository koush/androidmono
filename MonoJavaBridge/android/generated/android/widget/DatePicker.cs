namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatePicker : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal OnDateChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.DatePicker.OnDateChangedListener.onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DatePicker.OnDateChangedListener_.staticClass, "onDateChanged", "(Landroid/widget/DatePicker;III)V", ref global::android.widget.DatePicker.OnDateChangedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			static OnDateChangedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.DatePicker.OnDateChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker$OnDateChangedListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnDateChangedListenerDelegate(android.widget.DatePicker arg0, int arg1, int arg2, int arg3);

		internal partial class OnDateChangedListenerDelegateWrapper : java.lang.Object, OnDateChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDateChangedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnDateChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.OnDateChangedListenerDelegateWrapper.staticClass, global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnDateChangedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.DatePicker.OnDateChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker_OnDateChangedListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void init(int arg0, int arg1, int arg2, android.widget.DatePicker.OnDateChangedListener arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DatePicker.staticClass, "init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V", ref global::android.widget.DatePicker._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getYear()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.DatePicker.staticClass, "getYear", "()I", ref global::android.widget.DatePicker._m1);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.DatePicker.staticClass, "getMonth", "()I", ref global::android.widget.DatePicker._m2);
		}
		public new int DayOfMonth
		{
			get
			{
				return getDayOfMonth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getDayOfMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.DatePicker.staticClass, "getDayOfMonth", "()I", ref global::android.widget.DatePicker._m3);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DatePicker.staticClass, "setEnabled", "(Z)V", ref global::android.widget.DatePicker._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DatePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.DatePicker._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.DatePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.DatePicker._m6) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DatePicker.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.widget.DatePicker._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void updateDate(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DatePicker.staticClass, "updateDate", "(III)V", ref global::android.widget.DatePicker._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DatePicker._m9.native == global::System.IntPtr.Zero)
				global::android.widget.DatePicker._m9 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DatePicker._m10.native == global::System.IntPtr.Zero)
				global::android.widget.DatePicker._m10 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public DatePicker(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DatePicker._m11.native == global::System.IntPtr.Zero)
				global::android.widget.DatePicker._m11 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DatePicker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DatePicker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker"));
		}
		internal static void InitJNI()
		{
		}
	}
}
