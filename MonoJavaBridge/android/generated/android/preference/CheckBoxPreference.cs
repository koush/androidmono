namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckBoxPreference : android.preference.Preference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckBoxPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onClick()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "onClick", "()V", ref global::android.preference.CheckBoxPreference._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isChecked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, "isChecked", "()Z", ref global::android.preference.CheckBoxPreference._m1);
		}
		public new bool Checked
		{
			set
			{
				setChecked(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "setChecked", "(Z)V", ref global::android.preference.CheckBoxPreference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.preference.CheckBoxPreference._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.preference.CheckBoxPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.preference.CheckBoxPreference._m4) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onBindView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "onBindView", "(Landroid/view/View;)V", ref global::android.preference.CheckBoxPreference._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool shouldDisableDependents()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, "shouldDisableDependents", "()Z", ref global::android.preference.CheckBoxPreference._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setSummaryOn(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(I)V", ref global::android.preference.CheckBoxPreference._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setSummaryOn(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(Ljava/lang/CharSequence;)V", ref global::android.preference.CheckBoxPreference._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setSummaryOn(string arg0)
		{
			setSummaryOn((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string SummaryOn
		{
			get
			{
				return getSummaryOn().toString();
			}
			set
			{
				setSummaryOn((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.CharSequence getSummaryOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.CheckBoxPreference.staticClass, "getSummaryOn", "()Ljava/lang/CharSequence;", ref global::android.preference.CheckBoxPreference._m9) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setSummaryOff(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(I)V", ref global::android.preference.CheckBoxPreference._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setSummaryOff(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(Ljava/lang/CharSequence;)V", ref global::android.preference.CheckBoxPreference._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setSummaryOff(string arg0)
		{
			setSummaryOff((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string SummaryOff
		{
			get
			{
				return getSummaryOff().toString();
			}
			set
			{
				setSummaryOff((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.CharSequence getSummaryOff()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.CheckBoxPreference.staticClass, "getSummaryOff", "()Ljava/lang/CharSequence;", ref global::android.preference.CheckBoxPreference._m12) as java.lang.CharSequence;
		}
		public new bool DisableDependentsState
		{
			get
			{
				return getDisableDependentsState();
			}
			set
			{
				setDisableDependentsState(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool getDisableDependentsState()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, "getDisableDependentsState", "()Z", ref global::android.preference.CheckBoxPreference._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setDisableDependentsState(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "setDisableDependentsState", "(Z)V", ref global::android.preference.CheckBoxPreference._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.CheckBoxPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", ref global::android.preference.CheckBoxPreference._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V", ref global::android.preference.CheckBoxPreference._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.CheckBoxPreference._m17.native == global::System.IntPtr.Zero)
				global::android.preference.CheckBoxPreference._m17 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public CheckBoxPreference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.CheckBoxPreference._m18.native == global::System.IntPtr.Zero)
				global::android.preference.CheckBoxPreference._m18 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.CheckBoxPreference._m19.native == global::System.IntPtr.Zero)
				global::android.preference.CheckBoxPreference._m19 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CheckBoxPreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.CheckBoxPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/CheckBoxPreference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
