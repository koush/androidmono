namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditTextPreference : android.preference.DialogPreference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EditTextPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.EditTextPreference.staticClass, "setText", "(Ljava/lang/String;)V", ref global::android.preference.EditTextPreference._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.preference.EditTextPreference.staticClass, "getText", "()Ljava/lang/String;", ref global::android.preference.EditTextPreference._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.EditTextPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.preference.EditTextPreference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.preference.EditTextPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.preference.EditTextPreference._m3) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool shouldDisableDependents()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.EditTextPreference.staticClass, "shouldDisableDependents", "()Z", ref global::android.preference.EditTextPreference._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.EditTextPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", ref global::android.preference.EditTextPreference._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.EditTextPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V", ref global::android.preference.EditTextPreference._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onBindDialogView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.EditTextPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V", ref global::android.preference.EditTextPreference._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onDialogClosed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.EditTextPreference.staticClass, "onDialogClosed", "(Z)V", ref global::android.preference.EditTextPreference._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void onAddEditTextToDialogView(android.view.View arg0, android.widget.EditText arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.EditTextPreference.staticClass, "onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V", ref global::android.preference.EditTextPreference._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.widget.EditText EditText
		{
			get
			{
				return getEditText();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.widget.EditText getEditText()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.EditTextPreference.staticClass, "getEditText", "()Landroid/widget/EditText;", ref global::android.preference.EditTextPreference._m10) as android.widget.EditText;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.EditTextPreference._m11.native == global::System.IntPtr.Zero)
				global::android.preference.EditTextPreference._m11 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.EditTextPreference._m12.native == global::System.IntPtr.Zero)
				global::android.preference.EditTextPreference._m12 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public EditTextPreference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.EditTextPreference._m13.native == global::System.IntPtr.Zero)
				global::android.preference.EditTextPreference._m13 = @__env.GetMethodIDNoThrow(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EditTextPreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.EditTextPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/EditTextPreference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
