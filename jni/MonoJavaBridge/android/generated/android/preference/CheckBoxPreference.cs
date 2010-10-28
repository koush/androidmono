namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckBoxPreference : android.preference.Preference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckBoxPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick10227;
		protected override void onClick()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onClick10227);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onClick10227);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked10228;
		public virtual bool isChecked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._isChecked10228);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._isChecked10228);
		}
		public new bool Checked
		{
			set
			{
				setChecked(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setChecked10229;
		public virtual void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setChecked10229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setChecked10229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10230;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onRestoreInstanceState10230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onRestoreInstanceState10230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10231;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onSaveInstanceState10231)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSaveInstanceState10231)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onBindView10232;
		protected override void onBindView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onBindView10232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onBindView10232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents10233;
		public override bool shouldDisableDependents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._shouldDisableDependents10233);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._shouldDisableDependents10233);
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOn10234;
		public virtual void setSummaryOn(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOn10234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn10234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOn10235;
		public virtual void setSummaryOn(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOn10235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn10235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSummaryOn10236;
		public virtual global::java.lang.CharSequence getSummaryOn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._getSummaryOn10236)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOn10236)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOff10237;
		public virtual void setSummaryOff(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOff10237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff10237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOff10238;
		public virtual void setSummaryOff(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOff10238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff10238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSummaryOff10239;
		public virtual global::java.lang.CharSequence getSummaryOff()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._getSummaryOff10239)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOff10239)) as java.lang.CharSequence;
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
		internal static global::MonoJavaBridge.MethodId _getDisableDependentsState10240;
		public virtual bool getDisableDependentsState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._getDisableDependentsState10240);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getDisableDependentsState10240);
		}
		internal static global::MonoJavaBridge.MethodId _setDisableDependentsState10241;
		public virtual void setDisableDependentsState(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setDisableDependentsState10241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setDisableDependentsState10241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10242;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onGetDefaultValue10242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onGetDefaultValue10242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10243;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onSetInitialValue10243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSetInitialValue10243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CheckBoxPreference10244;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference10244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckBoxPreference10245;
		public CheckBoxPreference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference10245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckBoxPreference10246;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference10246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CheckBoxPreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.CheckBoxPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/CheckBoxPreference"));
			global::android.preference.CheckBoxPreference._onClick10227 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onClick", "()V");
			global::android.preference.CheckBoxPreference._isChecked10228 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "isChecked", "()Z");
			global::android.preference.CheckBoxPreference._setChecked10229 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setChecked", "(Z)V");
			global::android.preference.CheckBoxPreference._onRestoreInstanceState10230 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.CheckBoxPreference._onSaveInstanceState10231 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.CheckBoxPreference._onBindView10232 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.CheckBoxPreference._shouldDisableDependents10233 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.CheckBoxPreference._setSummaryOn10234 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOn10235 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOn10236 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOn", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._setSummaryOff10237 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOff10238 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOff10239 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOff", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._getDisableDependentsState10240 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "getDisableDependentsState", "()Z");
			global::android.preference.CheckBoxPreference._setDisableDependentsState10241 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setDisableDependentsState", "(Z)V");
			global::android.preference.CheckBoxPreference._onGetDefaultValue10242 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.CheckBoxPreference._onSetInitialValue10243 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference10244 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference10245 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference10246 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
