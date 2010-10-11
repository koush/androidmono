namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditTextPreference : android.preference.DialogPreference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EditTextPreference()
		{
			InitJNI();
		}
		protected EditTextPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText6797;
		public virtual void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._setText6797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._setText6797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText6798;
		public virtual global::java.lang.String getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._getText6798)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getText6798)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState6799;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onRestoreInstanceState6799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onRestoreInstanceState6799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState6800;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._onSaveInstanceState6800)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSaveInstanceState6800)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents6801;
		public override bool shouldDisableDependents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.EditTextPreference._shouldDisableDependents6801);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._shouldDisableDependents6801);
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue6802;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._onGetDefaultValue6802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onGetDefaultValue6802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue6803;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onSetInitialValue6803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSetInitialValue6803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onBindDialogView6804;
		protected override void onBindDialogView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onBindDialogView6804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onBindDialogView6804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed6805;
		protected override void onDialogClosed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onDialogClosed6805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onDialogClosed6805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAddEditTextToDialogView6806;
		protected virtual void onAddEditTextToDialogView(android.view.View arg0, android.widget.EditText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onAddEditTextToDialogView6806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onAddEditTextToDialogView6806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getEditText6807;
		public virtual global::android.widget.EditText getEditText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._getEditText6807)) as android.widget.EditText;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getEditText6807)) as android.widget.EditText;
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference6808;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference6808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference6809;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference6809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference6810;
		public EditTextPreference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference6810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.EditTextPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/EditTextPreference"));
			global::android.preference.EditTextPreference._setText6797 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "setText", "(Ljava/lang/String;)V");
			global::android.preference.EditTextPreference._getText6798 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "getText", "()Ljava/lang/String;");
			global::android.preference.EditTextPreference._onRestoreInstanceState6799 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.EditTextPreference._onSaveInstanceState6800 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.EditTextPreference._shouldDisableDependents6801 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.EditTextPreference._onGetDefaultValue6802 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.EditTextPreference._onSetInitialValue6803 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.EditTextPreference._onBindDialogView6804 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V");
			global::android.preference.EditTextPreference._onDialogClosed6805 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.EditTextPreference._onAddEditTextToDialogView6806 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V");
			global::android.preference.EditTextPreference._getEditText6807 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "getEditText", "()Landroid/widget/EditText;");
			global::android.preference.EditTextPreference._EditTextPreference6808 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.EditTextPreference._EditTextPreference6809 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.EditTextPreference._EditTextPreference6810 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
