namespace android.preference
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CheckBoxPreference : android.preference.Preference
	{
		internal new static global::java.lang.Class staticClass;
		static CheckBoxPreference()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.CheckBoxPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.preference.CheckBoxPreference(@__env);
			}
		}
		protected CheckBoxPreference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick5891;
		protected override void onClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onClick5891);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onClick5891);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChecked5892;
		public virtual bool isChecked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.CheckBoxPreference._isChecked5892);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._isChecked5892);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked5893;
		public virtual void setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setChecked5893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setChecked5893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5894;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onRestoreInstanceState5894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onRestoreInstanceState5894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5895;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._onSaveInstanceState5895));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSaveInstanceState5895));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBindView5896;
		protected override void onBindView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onBindView5896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onBindView5896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents5897;
		public override bool shouldDisableDependents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.CheckBoxPreference._shouldDisableDependents5897);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._shouldDisableDependents5897);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOn5898;
		public virtual void setSummaryOn(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOn5898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn5898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOn5899;
		public virtual void setSummaryOn(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOn5899, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn5899, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSummaryOn5900;
		public virtual global::java.lang.CharSequence getSummaryOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._getSummaryOn5900));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOn5900));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOff5901;
		public virtual void setSummaryOff(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOff5901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff5901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOff5902;
		public virtual void setSummaryOff(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOff5902, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff5902, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSummaryOff5903;
		public virtual global::java.lang.CharSequence getSummaryOff() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._getSummaryOff5903));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOff5903));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisableDependentsState5904;
		public virtual bool getDisableDependentsState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.CheckBoxPreference._getDisableDependentsState5904);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getDisableDependentsState5904);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDisableDependentsState5905;
		public virtual void setDisableDependentsState(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setDisableDependentsState5905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setDisableDependentsState5905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue5906;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._onGetDefaultValue5906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onGetDefaultValue5906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue5907;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onSetInitialValue5907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSetInitialValue5907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference5908;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference5908, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference5909;
		public CheckBoxPreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference5909, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference5910;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference5910, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.preference.CheckBoxPreference.staticClass = @__class;
			global::android.preference.CheckBoxPreference._onClick5891 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onClick", "()V");
			global::android.preference.CheckBoxPreference._isChecked5892 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "isChecked", "()Z");
			global::android.preference.CheckBoxPreference._setChecked5893 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setChecked", "(Z)V");
			global::android.preference.CheckBoxPreference._onRestoreInstanceState5894 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.CheckBoxPreference._onSaveInstanceState5895 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.CheckBoxPreference._onBindView5896 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.CheckBoxPreference._shouldDisableDependents5897 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.CheckBoxPreference._setSummaryOn5898 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOn5899 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOn5900 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOn", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._setSummaryOff5901 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOff5902 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOff5903 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOff", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._getDisableDependentsState5904 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getDisableDependentsState", "()Z");
			global::android.preference.CheckBoxPreference._setDisableDependentsState5905 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setDisableDependentsState", "(Z)V");
			global::android.preference.CheckBoxPreference._onGetDefaultValue5906 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.CheckBoxPreference._onSetInitialValue5907 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference5908 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference5909 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference5910 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
	public static class CheckBoxPreferenceExtensionMethods
	{
		public static void setSummaryOn(this global::android.preference.CheckBoxPreference __this, string arg0)
		{
			__this.setSummaryOn((global::java.lang.String)arg0);
		}
		public static void setSummaryOff(this global::android.preference.CheckBoxPreference __this, string arg0)
		{
			__this.setSummaryOff((global::java.lang.String)arg0);
		}
	}
}
