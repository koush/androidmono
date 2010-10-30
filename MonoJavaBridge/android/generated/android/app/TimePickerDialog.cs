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
			internal static global::MonoJavaBridge.MethodId _onTimeSet2173;
			void android.app.TimePickerDialog.OnTimeSetListener.onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet2173.native == global::System.IntPtr.Zero)
					global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet2173 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass, "onTimeSet", "(Landroid/widget/TimePicker;II)V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet2173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnTimeSetListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog$OnTimeSetListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnTimeSetListenerDelegate(android.widget.TimePicker arg0, int arg1, int arg2);

		internal partial class OnTimeSetListenerDelegateWrapper : java.lang.Object, OnTimeSetListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTimeSetListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnTimeSetListenerDelegateWrapper2174;
			public OnTimeSetListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper._OnTimeSetListenerDelegateWrapper2174.native == global::System.IntPtr.Zero)
					global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper._OnTimeSetListenerDelegateWrapper2174 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper.staticClass, global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper._OnTimeSetListenerDelegateWrapper2174);
				Init(@__env, handle);
			}
			static OnTimeSetListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.TimePickerDialog.OnTimeSetListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog_OnTimeSetListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _onClick2175;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._onClick2175.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._onClick2175 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onClick2175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState2176;
		public override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._onRestoreInstanceState2176.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._onRestoreInstanceState2176 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onRestoreInstanceState2176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState2177;
		public override global::android.os.Bundle onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._onSaveInstanceState2177.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._onSaveInstanceState2177 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onSaveInstanceState2177) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onTimeChanged2178;
		public virtual void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._onTimeChanged2178.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._onTimeChanged2178 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onTimeChanged2178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime2179;
		public virtual void updateTime(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._updateTime2179.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._updateTime2179 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "updateTime", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._updateTime2179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TimePickerDialog2180;
		public TimePickerDialog(android.content.Context arg0, android.app.TimePickerDialog.OnTimeSetListener arg1, int arg2, int arg3, bool arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._TimePickerDialog2180.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._TimePickerDialog2180 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog2180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePickerDialog2181;
		public TimePickerDialog(android.content.Context arg0, int arg1, android.app.TimePickerDialog.OnTimeSetListener arg2, int arg3, int arg4, bool arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TimePickerDialog._TimePickerDialog2181.native == global::System.IntPtr.Zero)
				global::android.app.TimePickerDialog._TimePickerDialog2181 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog2181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		static TimePickerDialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.TimePickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog"));
		}
		internal static void InitJNI()
		{
		}
	}
}
