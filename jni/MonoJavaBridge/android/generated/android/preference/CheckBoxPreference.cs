namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckBoxPreference : android.preference.Preference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CheckBoxPreference()
		{
			InitJNI();
		}
		protected CheckBoxPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick6746;
		protected override void onClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onClick6746);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onClick6746);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked6747;
		public virtual bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._isChecked6747);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._isChecked6747);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked6748;
		public virtual void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setChecked6748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setChecked6748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState6749;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onRestoreInstanceState6749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onRestoreInstanceState6749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState6750;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onSaveInstanceState6750)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSaveInstanceState6750)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onBindView6751;
		protected override void onBindView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onBindView6751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onBindView6751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents6752;
		public override bool shouldDisableDependents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._shouldDisableDependents6752);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._shouldDisableDependents6752);
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOn6753;
		public virtual void setSummaryOn(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOn6753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn6753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOn6754;
		public virtual void setSummaryOn(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOn6754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn6754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSummaryOn6755;
		public virtual global::java.lang.CharSequence getSummaryOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._getSummaryOn6755)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOn6755)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOff6756;
		public virtual void setSummaryOff(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOff6756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff6756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSummaryOff6757;
		public virtual void setSummaryOff(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setSummaryOff6757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff6757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSummaryOff6758;
		public virtual global::java.lang.CharSequence getSummaryOff() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._getSummaryOff6758)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOff6758)) as java.lang.CharSequence;
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
		internal static global::MonoJavaBridge.MethodId _getDisableDependentsState6759;
		public virtual bool getDisableDependentsState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._getDisableDependentsState6759);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getDisableDependentsState6759);
		}
		internal static global::MonoJavaBridge.MethodId _setDisableDependentsState6760;
		public virtual void setDisableDependentsState(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._setDisableDependentsState6760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setDisableDependentsState6760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue6761;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onGetDefaultValue6761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onGetDefaultValue6761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue6762;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference._onSetInitialValue6762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSetInitialValue6762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CheckBoxPreference6763;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference6763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckBoxPreference6764;
		public CheckBoxPreference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference6764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckBoxPreference6765;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference6765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.CheckBoxPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/CheckBoxPreference"));
			global::android.preference.CheckBoxPreference._onClick6746 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onClick", "()V");
			global::android.preference.CheckBoxPreference._isChecked6747 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "isChecked", "()Z");
			global::android.preference.CheckBoxPreference._setChecked6748 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setChecked", "(Z)V");
			global::android.preference.CheckBoxPreference._onRestoreInstanceState6749 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.CheckBoxPreference._onSaveInstanceState6750 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.CheckBoxPreference._onBindView6751 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.CheckBoxPreference._shouldDisableDependents6752 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.CheckBoxPreference._setSummaryOn6753 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOn6754 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOn6755 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOn", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._setSummaryOff6756 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOff6757 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOff6758 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOff", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._getDisableDependentsState6759 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "getDisableDependentsState", "()Z");
			global::android.preference.CheckBoxPreference._setDisableDependentsState6760 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "setDisableDependentsState", "(Z)V");
			global::android.preference.CheckBoxPreference._onGetDefaultValue6761 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.CheckBoxPreference._onSetInitialValue6762 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference6763 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference6764 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference6765 = @__env.GetMethodIDNoThrow(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
