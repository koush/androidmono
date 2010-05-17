namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class EditTextPreference : android.preference.DialogPreference
	{ 
		internal new static global::java.lang.Class staticClass; 
		static EditTextPreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.EditTextPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.preference.EditTextPreference(@__env); 
			} 
		} 
		protected EditTextPreference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText5668; 
		public virtual void setText(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				@__env.CallVoidMethod(this, _setText5668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.EditTextPreference.staticClass, _setText5668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText5669; 
		public virtual java.lang.String getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getText5669)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.EditTextPreference.staticClass, _getText5669)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5670; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState5670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.EditTextPreference.staticClass, _onRestoreInstanceState5670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5671; 
		protected override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState5671)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.EditTextPreference.staticClass, _onSaveInstanceState5671)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents5672; 
		public override bool shouldDisableDependents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				return @__env.CallBooleanMethod(this, _shouldDisableDependents5672); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.EditTextPreference.staticClass, _shouldDisableDependents5672); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue5673; 
		protected override java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _onGetDefaultValue5673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.EditTextPreference.staticClass, _onGetDefaultValue5673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue5674; 
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				@__env.CallVoidMethod(this, _onSetInitialValue5674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.EditTextPreference.staticClass, _onSetInitialValue5674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindDialogView5675; 
		protected override void onBindDialogView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				@__env.CallVoidMethod(this, _onBindDialogView5675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.EditTextPreference.staticClass, _onBindDialogView5675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDialogClosed5676; 
		protected override void onDialogClosed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				@__env.CallVoidMethod(this, _onDialogClosed5676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.EditTextPreference.staticClass, _onDialogClosed5676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAddEditTextToDialogView5677; 
		protected virtual void onAddEditTextToDialogView(android.view.View arg0, android.widget.EditText arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				@__env.CallVoidMethod(this, _onAddEditTextToDialogView5677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.EditTextPreference.staticClass, _onAddEditTextToDialogView5677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEditText5678; 
		public virtual android.widget.EditText getEditText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.EditTextPreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.EditText>(@__env, @__env.CallObjectMethodPtr(this, _getEditText5678)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.EditText>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.EditTextPreference.staticClass, _getEditText5678)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditTextPreference5679; 
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.EditTextPreference.staticClass, _EditTextPreference5679, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditTextPreference5680; 
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.EditTextPreference.staticClass, _EditTextPreference5680, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditTextPreference5681; 
		public EditTextPreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.EditTextPreference.staticClass, _EditTextPreference5681, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.EditTextPreference.staticClass = @__class; 
			global::android.preference.EditTextPreference._setText5668 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "setText", "(Ljava/lang/String;)V"); 
			global::android.preference.EditTextPreference._getText5669 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "getText", "()Ljava/lang/String;"); 
			global::android.preference.EditTextPreference._onRestoreInstanceState5670 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.preference.EditTextPreference._onSaveInstanceState5671 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.preference.EditTextPreference._shouldDisableDependents5672 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "shouldDisableDependents", "()Z"); 
			global::android.preference.EditTextPreference._onGetDefaultValue5673 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;"); 
			global::android.preference.EditTextPreference._onSetInitialValue5674 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V"); 
			global::android.preference.EditTextPreference._onBindDialogView5675 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V"); 
			global::android.preference.EditTextPreference._onDialogClosed5676 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onDialogClosed", "(Z)V"); 
			global::android.preference.EditTextPreference._onAddEditTextToDialogView5677 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V"); 
			global::android.preference.EditTextPreference._getEditText5678 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "getEditText", "()Landroid/widget/EditText;"); 
			global::android.preference.EditTextPreference._EditTextPreference5679 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.preference.EditTextPreference._EditTextPreference5680 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.EditTextPreference._EditTextPreference5681 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
