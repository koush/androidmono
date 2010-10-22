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
		public sealed partial class OnDateChangedListener_ : java.lang.Object, OnDateChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDateChangedListener_()
			{
				InitJNI();
			}
			internal OnDateChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDateChanged16854;
			 void android.widget.DatePicker.OnDateChangedListener.onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker.OnDateChangedListener_._onDateChanged16854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.OnDateChangedListener_.staticClass, global::android.widget.DatePicker.OnDateChangedListener_._onDateChanged16854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.DatePicker.OnDateChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker$OnDateChangedListener"));
				global::android.widget.DatePicker.OnDateChangedListener_._onDateChanged16854 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.OnDateChangedListener_.staticClass, "onDateChanged", "(Landroid/widget/DatePicker;III)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _init16855;
		public virtual void init(int arg0, int arg1, int arg2, android.widget.DatePicker.OnDateChangedListener arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._init16855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._init16855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYear16856;
		public virtual int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DatePicker._getYear16856);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getYear16856);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonth16857;
		public virtual int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DatePicker._getMonth16857);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getMonth16857);
		}
		public new int DayOfMonth
		{
			get
			{
				return getDayOfMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDayOfMonth16858;
		public virtual int getDayOfMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DatePicker._getDayOfMonth16858);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getDayOfMonth16858);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled16859;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._setEnabled16859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._setEnabled16859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16860;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._onRestoreInstanceState16860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._onRestoreInstanceState16860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16861;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DatePicker._onSaveInstanceState16861)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._onSaveInstanceState16861)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState16862;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._dispatchRestoreInstanceState16862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._dispatchRestoreInstanceState16862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate16863;
		public virtual void updateDate(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DatePicker._updateDate16863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._updateDate16863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _DatePicker16864;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker16864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatePicker16865;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker16865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatePicker16866;
		public DatePicker(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker16866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DatePicker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DatePicker"));
			global::android.widget.DatePicker._init16855 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V");
			global::android.widget.DatePicker._getYear16856 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "getYear", "()I");
			global::android.widget.DatePicker._getMonth16857 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "getMonth", "()I");
			global::android.widget.DatePicker._getDayOfMonth16858 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "getDayOfMonth", "()I");
			global::android.widget.DatePicker._setEnabled16859 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "setEnabled", "(Z)V");
			global::android.widget.DatePicker._onRestoreInstanceState16860 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.DatePicker._onSaveInstanceState16861 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.DatePicker._dispatchRestoreInstanceState16862 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.DatePicker._updateDate16863 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "updateDate", "(III)V");
			global::android.widget.DatePicker._DatePicker16864 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.DatePicker._DatePicker16865 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.DatePicker._DatePicker16866 = @__env.GetMethodIDNoThrow(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
