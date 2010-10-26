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
		internal static global::MonoJavaBridge.MethodId _setText10278;
		public virtual void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._setText10278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._setText10278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Text
		{
			get
			{
				return getText();
			}
			set
			{
				setText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText10279;
		public virtual global::java.lang.String getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._getText10279)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getText10279)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10280;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onRestoreInstanceState10280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onRestoreInstanceState10280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10281;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._onSaveInstanceState10281)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSaveInstanceState10281)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents10282;
		public override bool shouldDisableDependents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.EditTextPreference._shouldDisableDependents10282);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._shouldDisableDependents10282);
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10283;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._onGetDefaultValue10283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onGetDefaultValue10283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10284;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onSetInitialValue10284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSetInitialValue10284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onBindDialogView10285;
		protected override void onBindDialogView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onBindDialogView10285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onBindDialogView10285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed10286;
		protected override void onDialogClosed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onDialogClosed10286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onDialogClosed10286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAddEditTextToDialogView10287;
		protected virtual void onAddEditTextToDialogView(android.view.View arg0, android.widget.EditText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onAddEditTextToDialogView10287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onAddEditTextToDialogView10287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.widget.EditText EditText
		{
			get
			{
				return getEditText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditText10288;
		public virtual global::android.widget.EditText getEditText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._getEditText10288)) as android.widget.EditText;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getEditText10288)) as android.widget.EditText;
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference10289;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference10289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference10290;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference10290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference10291;
		public EditTextPreference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference10291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.EditTextPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/EditTextPreference"));
			global::android.preference.EditTextPreference._setText10278 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "setText", "(Ljava/lang/String;)V");
			global::android.preference.EditTextPreference._getText10279 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "getText", "()Ljava/lang/String;");
			global::android.preference.EditTextPreference._onRestoreInstanceState10280 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.EditTextPreference._onSaveInstanceState10281 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.EditTextPreference._shouldDisableDependents10282 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.EditTextPreference._onGetDefaultValue10283 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.EditTextPreference._onSetInitialValue10284 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.EditTextPreference._onBindDialogView10285 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V");
			global::android.preference.EditTextPreference._onDialogClosed10286 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.EditTextPreference._onAddEditTextToDialogView10287 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V");
			global::android.preference.EditTextPreference._getEditText10288 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "getEditText", "()Landroid/widget/EditText;");
			global::android.preference.EditTextPreference._EditTextPreference10289 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.EditTextPreference._EditTextPreference10290 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.EditTextPreference._EditTextPreference10291 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
