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
			internal static global::MonoJavaBridge.MethodId _onTimeSet2166;
			 void android.app.TimePickerDialog.OnTimeSetListener.onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet2166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass, global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet2166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog$OnTimeSetListener"));
				global::android.app.TimePickerDialog.OnTimeSetListener_._onTimeSet2166 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.OnTimeSetListener_.staticClass, "onTimeSet", "(Landroid/widget/TimePicker;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onClick2167;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._onClick2167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onClick2167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState2168;
		public override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._onRestoreInstanceState2168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onRestoreInstanceState2168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState2169;
		public override global::android.os.Bundle onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.TimePickerDialog._onSaveInstanceState2169)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onSaveInstanceState2169)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onTimeChanged2170;
		public virtual void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._onTimeChanged2170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onTimeChanged2170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime2171;
		public virtual void updateTime(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog._updateTime2171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._updateTime2171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TimePickerDialog2172;
		public TimePickerDialog(android.content.Context arg0, android.app.TimePickerDialog.OnTimeSetListener arg1, int arg2, int arg3, bool arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog2172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePickerDialog2173;
		public TimePickerDialog(android.content.Context arg0, int arg1, android.app.TimePickerDialog.OnTimeSetListener arg2, int arg3, int arg4, bool arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog2173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.TimePickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TimePickerDialog"));
			global::android.app.TimePickerDialog._onClick2167 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.app.TimePickerDialog._onRestoreInstanceState2168 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TimePickerDialog._onSaveInstanceState2169 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.TimePickerDialog._onTimeChanged2170 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V");
			global::android.app.TimePickerDialog._updateTime2171 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "updateTime", "(II)V");
			global::android.app.TimePickerDialog._TimePickerDialog2172 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
			global::android.app.TimePickerDialog._TimePickerDialog2173 = @__env.GetMethodIDNoThrow(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V");
		}
	}
}
