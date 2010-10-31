namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.TimePicker.OnTimeChangedListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimePickerDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.TimePickerDialog.OnTimeSetListener_))]
		public partial interface OnTimeSetListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.TimePickerDialog.OnTimeSetListener))]
		internal sealed partial class OnTimeSetListener_ : java.lang.Object, OnTimeSetListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnTimeSetListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.app.TimePickerDialog.OnTimeSetListener.onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass, "onTimeSet", "(Landroid/widget/TimePicker;II)V", ref global::android.app.TimePickerDialog.OnTimeSetListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnTimeSetListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog$OnTimeSetListener"));
			}
		}

		public delegate void OnTimeSetListenerDelegate(android.widget.TimePicker arg0, int arg1, int arg2);

		internal partial class OnTimeSetListenerDelegateWrapper : java.lang.Object, OnTimeSetListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTimeSetListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnTimeSetListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper.staticClass, global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnTimeSetListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog_OnTimeSetListenerDelegateWrapper"));
			}
		}
		internal partial class OnTimeSetListenerDelegateWrapper
		{
			private OnTimeSetListenerDelegate myDelegate;
			public void onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnTimeSetListenerDelegateWrapper(OnTimeSetListenerDelegate d)
			{
				global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper ret = new global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V", ref global::android.app.TimePickerDialog._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.TimePickerDialog._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.os.Bundle onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.TimePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;", ref global::android.app.TimePickerDialog._m2) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V", ref global::android.app.TimePickerDialog._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void updateTime(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, "updateTime", "(II)V", ref global::android.app.TimePickerDialog._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public TimePickerDialog(android.content.Context arg0, android.app.TimePickerDialog.OnTimeSetListener arg1, int arg2, int arg3, bool arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._m5.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._m5 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public TimePickerDialog(android.content.Context arg0, int arg1, android.app.TimePickerDialog.OnTimeSetListener arg2, int arg3, int arg4, bool arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._m6.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._m6 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		static TimePickerDialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.TimePickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog"));
		}
	}
}
