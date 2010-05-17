namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DatePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.DatePicker.OnDateChangedListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DatePickerDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.DatePickerDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.DatePickerDialog(@__env); 
			} 
		} 
		protected DatePickerDialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDateSetListener 
		{ 
			void onDateSet(android.widget.DatePicker arg0, int arg1, int arg2, int arg3); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick427; 
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, _onClick427, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.DatePickerDialog.staticClass, _onClick427, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState428; 
		public override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.DatePickerDialog.staticClass, _onRestoreInstanceState428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState429; 
		public override android.os.Bundle onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState429)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.DatePickerDialog.staticClass, _onSaveInstanceState429)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show430; 
		public override void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, _show430); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.DatePickerDialog.staticClass, _show430); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDateChanged431; 
		public virtual void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, _onDateChanged431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.DatePickerDialog.staticClass, _onDateChanged431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDate432; 
		public virtual void updateDate(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, _updateDate432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.DatePickerDialog.staticClass, _updateDate432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatePickerDialog433; 
		public DatePickerDialog(android.content.Context arg0, int arg1, android.app.DatePickerDialog.OnDateSetListener arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.DatePickerDialog.staticClass, _DatePickerDialog433, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatePickerDialog434; 
		public DatePickerDialog(android.content.Context arg0, android.app.DatePickerDialog.OnDateSetListener arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.DatePickerDialog.staticClass, _DatePickerDialog434, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.DatePickerDialog.staticClass = @__class; 
			global::android.app.DatePickerDialog._onClick427 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V"); 
			global::android.app.DatePickerDialog._onRestoreInstanceState428 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.DatePickerDialog._onSaveInstanceState429 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.DatePickerDialog._show430 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "show", "()V"); 
			global::android.app.DatePickerDialog._onDateChanged431 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onDateChanged", "(Landroid/widget/DatePicker;III)V"); 
			global::android.app.DatePickerDialog._updateDate432 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "updateDate", "(III)V"); 
			global::android.app.DatePickerDialog._DatePickerDialog433 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/DatePickerDialog$OnDateSetListener;III)V"); 
			global::android.app.DatePickerDialog._DatePickerDialog434 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/DatePickerDialog$OnDateSetListener;III)V"); 
		} 
	} 
} 
