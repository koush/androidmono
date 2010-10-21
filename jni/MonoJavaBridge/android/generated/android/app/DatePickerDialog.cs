namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.DatePicker.OnDateChangedListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatePickerDialog()
		{
			InitJNI();
		}
		protected DatePickerDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.DatePickerDialog.OnDateSetListener_))]
		public interface OnDateSetListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDateSet(android.widget.DatePicker arg0, int arg1, int arg2, int arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.DatePickerDialog.OnDateSetListener))]
		public sealed partial class OnDateSetListener_ : java.lang.Object, OnDateSetListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDateSetListener_()
			{
				InitJNI();
			}
			internal OnDateSetListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDateSet1735;
			 void android.app.DatePickerDialog.OnDateSetListener.onDateSet(android.widget.DatePicker arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog.OnDateSetListener_._onDateSet1735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog.OnDateSetListener_.staticClass, global::android.app.DatePickerDialog.OnDateSetListener_._onDateSet1735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.DatePickerDialog.OnDateSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/DatePickerDialog$OnDateSetListener"));
				global::android.app.DatePickerDialog.OnDateSetListener_._onDateSet1735 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.OnDateSetListener_.staticClass, "onDateSet", "(Landroid/widget/DatePicker;III)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onClick1736;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog._onClick1736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onClick1736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1737;
		public override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog._onRestoreInstanceState1737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onRestoreInstanceState1737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1738;
		public override global::android.os.Bundle onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.DatePickerDialog._onSaveInstanceState1738)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onSaveInstanceState1738)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _show1739;
		public override void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog._show1739);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._show1739);
		}
		internal static global::MonoJavaBridge.MethodId _onDateChanged1740;
		public virtual void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog._onDateChanged1740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onDateChanged1740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate1741;
		public virtual void updateDate(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog._updateDate1741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._updateDate1741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _DatePickerDialog1742;
		public DatePickerDialog(android.content.Context arg0, int arg1, android.app.DatePickerDialog.OnDateSetListener arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._DatePickerDialog1742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatePickerDialog1743;
		public DatePickerDialog(android.content.Context arg0, android.app.DatePickerDialog.OnDateSetListener arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._DatePickerDialog1743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.DatePickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/DatePickerDialog"));
			global::android.app.DatePickerDialog._onClick1736 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.app.DatePickerDialog._onRestoreInstanceState1737 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.DatePickerDialog._onSaveInstanceState1738 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.DatePickerDialog._show1739 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "show", "()V");
			global::android.app.DatePickerDialog._onDateChanged1740 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "onDateChanged", "(Landroid/widget/DatePicker;III)V");
			global::android.app.DatePickerDialog._updateDate1741 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "updateDate", "(III)V");
			global::android.app.DatePickerDialog._DatePickerDialog1742 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/DatePickerDialog$OnDateSetListener;III)V");
			global::android.app.DatePickerDialog._DatePickerDialog1743 = @__env.GetMethodIDNoThrow(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/DatePickerDialog$OnDateSetListener;III)V");
		}
	}
}
