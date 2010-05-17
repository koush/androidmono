namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.TimePicker.OnTimeChangedListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TimePickerDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.TimePickerDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.TimePickerDialog(@__env); 
			} 
		} 
		protected TimePickerDialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTimeSetListener 
		{ 
			void onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick758; 
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, _onClick758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TimePickerDialog.staticClass, _onClick758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState759; 
		public override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TimePickerDialog.staticClass, _onRestoreInstanceState759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState760; 
		public override android.os.Bundle onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState760)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.TimePickerDialog.staticClass, _onSaveInstanceState760)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTimeChanged761; 
		public virtual void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, _onTimeChanged761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TimePickerDialog.staticClass, _onTimeChanged761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateTime762; 
		public virtual void updateTime(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, _updateTime762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TimePickerDialog.staticClass, _updateTime762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePickerDialog763; 
		public TimePickerDialog(android.content.Context arg0, android.app.TimePickerDialog.OnTimeSetListener arg1, int arg2, int arg3, bool arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.TimePickerDialog.staticClass, _TimePickerDialog763, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePickerDialog764; 
		public TimePickerDialog(android.content.Context arg0, int arg1, android.app.TimePickerDialog.OnTimeSetListener arg2, int arg3, int arg4, bool arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.TimePickerDialog.staticClass, _TimePickerDialog764, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.TimePickerDialog.staticClass = @__class; 
			global::android.app.TimePickerDialog._onClick758 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V"); 
			global::android.app.TimePickerDialog._onRestoreInstanceState759 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.TimePickerDialog._onSaveInstanceState760 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.TimePickerDialog._onTimeChanged761 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V"); 
			global::android.app.TimePickerDialog._updateTime762 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "updateTime", "(II)V"); 
			global::android.app.TimePickerDialog._TimePickerDialog763 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V"); 
			global::android.app.TimePickerDialog._TimePickerDialog764 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V"); 
		} 
	} 
} 
