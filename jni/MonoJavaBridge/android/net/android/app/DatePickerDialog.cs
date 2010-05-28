namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DatePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.DatePicker.OnDateChangedListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DatePickerDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.DatePickerDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class OnDateSetListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnDateSetListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnDateSetListener : java.lang.Object, OnDateSetListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnDateSetListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.DatePickerDialog.__OnDateSetListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.DatePickerDialog.__OnDateSetListener(@__env); 
				} 
			} 
			internal __OnDateSetListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDateSet434; 
			 void android.app.DatePickerDialog.OnDateSetListener.onDateSet(android.widget.DatePicker arg0, int arg1, int arg2, int arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.DatePickerDialog.__OnDateSetListener)) 
					@__env.CallVoidMethod(this, global::android.app.DatePickerDialog.__OnDateSetListener._onDateSet434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.app.DatePickerDialog.__OnDateSetListener.staticClass, global::android.app.DatePickerDialog.__OnDateSetListener._onDateSet434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.DatePickerDialog.__OnDateSetListener.staticClass = @__class; 
				global::android.app.DatePickerDialog.__OnDateSetListener._onDateSet434 = @__env.GetMethodID(global::android.app.DatePickerDialog.__OnDateSetListener.staticClass, "android.app.DatePickerDialog.OnDateSetListener.onDateSet", "(Landroid/widget/DatePicker;III)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick435; 
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.DatePickerDialog._onClick435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onClick435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState436; 
		public override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.DatePickerDialog._onRestoreInstanceState436, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onRestoreInstanceState436, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState437; 
		public override global::android.os.Bundle onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.DatePickerDialog._onSaveInstanceState437)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onSaveInstanceState437)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show438; 
		public override void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.DatePickerDialog._show438); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._show438); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDateChanged439; 
		public virtual void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.DatePickerDialog._onDateChanged439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._onDateChanged439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDate440; 
		public virtual void updateDate(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.DatePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.DatePickerDialog._updateDate440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._updateDate440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatePickerDialog441; 
		public DatePickerDialog(android.content.Context arg0, int arg1, android.app.DatePickerDialog.OnDateSetListener arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._DatePickerDialog441, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatePickerDialog442; 
		public DatePickerDialog(android.content.Context arg0, android.app.DatePickerDialog.OnDateSetListener arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.DatePickerDialog.staticClass, global::android.app.DatePickerDialog._DatePickerDialog442, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.DatePickerDialog.staticClass = @__class; 
			global::android.app.DatePickerDialog._onClick435 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V"); 
			global::android.app.DatePickerDialog._onRestoreInstanceState436 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.DatePickerDialog._onSaveInstanceState437 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.DatePickerDialog._show438 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "show", "()V"); 
			global::android.app.DatePickerDialog._onDateChanged439 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "onDateChanged", "(Landroid/widget/DatePicker;III)V"); 
			global::android.app.DatePickerDialog._updateDate440 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "updateDate", "(III)V"); 
			global::android.app.DatePickerDialog._DatePickerDialog441 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/DatePickerDialog$OnDateSetListener;III)V"); 
			global::android.app.DatePickerDialog._DatePickerDialog442 = @__env.GetMethodID(global::android.app.DatePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/DatePickerDialog$OnDateSetListener;III)V"); 
		} 
	} 
} 
