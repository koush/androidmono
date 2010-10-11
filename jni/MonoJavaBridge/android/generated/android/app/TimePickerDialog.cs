namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.TimePicker.OnTimeChangedListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimePickerDialog()
		{
			InitJNI();
		}
		protected TimePickerDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.TimePickerDialog.OnTimeSetListener_))]
		public interface OnTimeSetListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.TimePickerDialog.OnTimeSetListener))]
		public sealed partial class OnTimeSetListener_ : java.lang.Object, OnTimeSetListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnTimeSetListener_()
			{
				InitJNI();
			}
			internal OnTimeSetListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTimeSet821;
			 void android.app.TimePickerDialog.OnTimeSetListener.onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass, global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog$OnTimeSetListener"));
				global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet821 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass, "onTimeSet", "(Landroid/widget/TimePicker;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onClick822;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._onClick822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onClick822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState823;
		public override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._onRestoreInstanceState823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onRestoreInstanceState823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState824;
		public override global::android.os.Bundle onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.TimePickerDialog._onSaveInstanceState824)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onSaveInstanceState824)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onTimeChanged825;
		public virtual void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._onTimeChanged825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onTimeChanged825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime826;
		public virtual void updateTime(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._updateTime826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._updateTime826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TimePickerDialog827;
		public TimePickerDialog(android.content.Context arg0, android.app.TimePickerDialog.OnTimeSetListener arg1, int arg2, int arg3, bool arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePickerDialog828;
		public TimePickerDialog(android.content.Context arg0, int arg1, android.app.TimePickerDialog.OnTimeSetListener arg2, int arg3, int arg4, bool arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.TimePickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog"));
			global::android.app.TimePickerDialog._onClick822 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.app.TimePickerDialog._onRestoreInstanceState823 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TimePickerDialog._onSaveInstanceState824 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.TimePickerDialog._onTimeChanged825 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V");
			global::android.app.TimePickerDialog._updateTime826 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "updateTime", "(II)V");
			global::android.app.TimePickerDialog._TimePickerDialog827 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
			global::android.app.TimePickerDialog._TimePickerDialog828 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
		}
	}
}
