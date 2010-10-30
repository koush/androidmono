namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.DatePicker.OnDateChangedListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatePickerDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.DatePickerDialog.OnDateSetListener_))]
		public partial interface OnDateSetListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDateSet(android.widget.DatePicker arg0, int arg1, int arg2, int arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.DatePickerDialog.OnDateSetListener))]
		internal sealed partial class OnDateSetListener_ : java.lang.Object, OnDateSetListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnDateSetListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDateSet1737;
			void android.app.DatePickerDialog.OnDateSetListener.onDateSet(android.widget.DatePicker arg0, int arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.DatePickerDialog.OnDateSetListener_.staticClass, "onDateSet", "(Landroid/widget/DatePicker;III)V", ref global::android.app.DatePickerDialog.OnDateSetListener_._onDateSet1737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			static OnDateSetListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.DatePickerDialog.OnDateSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/DatePickerDialog$OnDateSetListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnDateSetListenerDelegate(android.widget.DatePicker arg0, int arg1, int arg2, int arg3);

		internal partial class OnDateSetListenerDelegateWrapper : java.lang.Object, OnDateSetListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDateSetListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnDateSetListenerDelegateWrapper1738;
			public OnDateSetListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper._OnDateSetListenerDelegateWrapper1738.native == global::System.IntPtr.Zero)
					global::android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper._OnDateSetListenerDelegateWrapper1738 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper.staticClass, global::android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper._OnDateSetListenerDelegateWrapper1738);
				Init(@__env, handle);
			}
			static OnDateSetListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/DatePickerDialog_OnDateSetListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnDateSetListenerDelegateWrapper
		{
			private OnDateSetListenerDelegate myDelegate;
			public void onDateSet(android.widget.DatePicker arg0, int arg1, int arg2, int arg3)
			{
				myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator OnDateSetListenerDelegateWrapper(OnDateSetListenerDelegate d)
			{
				global::android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper ret = new global::android.app.DatePickerDialog.OnDateSetListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _onClick1739;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.DatePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V", ref global::android.app.DatePickerDialog._onClick1739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1740;
		public override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.DatePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.DatePickerDialog._onRestoreInstanceState1740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1741;
		public override global::android.os.Bundle onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.DatePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;", ref global::android.app.DatePickerDialog._onSaveInstanceState1741) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _show1742;
		public override void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.DatePickerDialog.staticClass, "show", "()V", ref global::android.app.DatePickerDialog._show1742);
		}
		internal static global::MonoJavaBridge.MethodId _onDateChanged1743;
		public virtual void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.DatePickerDialog.staticClass, "onDateChanged", "(Landroid/widget/DatePicker;III)V", ref global::android.app.DatePickerDialog._onDateChanged1743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate1744;
		public virtual void updateDate(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.DatePickerDialog.staticClass, "updateDate", "(III)V", ref global::android.app.DatePickerDialog._updateDate1744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _DatePickerDialog1745;
		public DatePickerDialog(android.content.Context arg0, int arg1, android.app.DatePickerDialog.OnDateSetListener arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.DatePickerDialog._DatePickerDialog1745.native == global::System.IntPtr.Zero)
				global::android.app.DatePickerDialog._DatePickerDialog1745 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/DatePickerDialog$OnDateSetListener;III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._DatePickerDialog1745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatePickerDialog1746;
		public DatePickerDialog(android.content.Context arg0, android.app.DatePickerDialog.OnDateSetListener arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.DatePickerDialog._DatePickerDialog1746.native == global::System.IntPtr.Zero)
				global::android.app.DatePickerDialog._DatePickerDialog1746 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/DatePickerDialog$OnDateSetListener;III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._DatePickerDialog1746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static DatePickerDialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.DatePickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/DatePickerDialog"));
		}
		internal static void InitJNI()
		{
		}
	}
}
