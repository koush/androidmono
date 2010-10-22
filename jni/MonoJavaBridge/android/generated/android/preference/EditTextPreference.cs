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
		internal static global::MonoJavaBridge.MethodId _setText10231;
		public virtual void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._setText10231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._setText10231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getText10232;
		public virtual global::java.lang.String getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._getText10232)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getText10232)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10233;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onRestoreInstanceState10233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onRestoreInstanceState10233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10234;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._onSaveInstanceState10234)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSaveInstanceState10234)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents10235;
		public override bool shouldDisableDependents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.EditTextPreference._shouldDisableDependents10235);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._shouldDisableDependents10235);
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10236;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._onGetDefaultValue10236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onGetDefaultValue10236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10237;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onSetInitialValue10237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSetInitialValue10237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onBindDialogView10238;
		protected override void onBindDialogView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onBindDialogView10238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onBindDialogView10238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed10239;
		protected override void onDialogClosed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onDialogClosed10239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onDialogClosed10239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAddEditTextToDialogView10240;
		protected virtual void onAddEditTextToDialogView(android.view.View arg0, android.widget.EditText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference._onAddEditTextToDialogView10240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onAddEditTextToDialogView10240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.widget.EditText EditText
		{
			get
			{
				return getEditText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditText10241;
		public virtual global::android.widget.EditText getEditText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference._getEditText10241)) as android.widget.EditText;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getEditText10241)) as android.widget.EditText;
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference10242;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference10242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference10243;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference10243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditTextPreference10244;
		public EditTextPreference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference10244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.EditTextPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/EditTextPreference"));
			global::android.preference.EditTextPreference._setText10231 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "setText", "(Ljava/lang/String;)V");
			global::android.preference.EditTextPreference._getText10232 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "getText", "()Ljava/lang/String;");
			global::android.preference.EditTextPreference._onRestoreInstanceState10233 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.EditTextPreference._onSaveInstanceState10234 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.EditTextPreference._shouldDisableDependents10235 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.EditTextPreference._onGetDefaultValue10236 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.EditTextPreference._onSetInitialValue10237 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.EditTextPreference._onBindDialogView10238 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V");
			global::android.preference.EditTextPreference._onDialogClosed10239 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.EditTextPreference._onAddEditTextToDialogView10240 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V");
			global::android.preference.EditTextPreference._getEditText10241 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "getEditText", "()Landroid/widget/EditText;");
			global::android.preference.EditTextPreference._EditTextPreference10242 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.EditTextPreference._EditTextPreference10243 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.EditTextPreference._EditTextPreference10244 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
