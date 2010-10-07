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
		internal static global::net.sf.jni4net.jni.MethodId _onClick6470;
		protected override void onClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onClick6470);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onClick6470);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChecked6471;
		public virtual bool isChecked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.CheckBoxPreference._isChecked6471);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._isChecked6471);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked6472;
		public virtual void setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setChecked6472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setChecked6472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState6473;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onRestoreInstanceState6473, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onRestoreInstanceState6473, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState6474;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._onSaveInstanceState6474));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSaveInstanceState6474));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBindView6475;
		protected override void onBindView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onBindView6475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onBindView6475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents6476;
		public override bool shouldDisableDependents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.CheckBoxPreference._shouldDisableDependents6476);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._shouldDisableDependents6476);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOn6477;
		public virtual void setSummaryOn(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOn6477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn6477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOn6478;
		public virtual void setSummaryOn(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOn6478, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOn6478, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setSummaryOn(string arg0)
		{
			setSummaryOn((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSummaryOn6479;
		public virtual global::java.lang.CharSequence getSummaryOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._getSummaryOn6479));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOn6479));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOff6480;
		public virtual void setSummaryOff(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOff6480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff6480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOff6481;
		public virtual void setSummaryOff(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setSummaryOff6481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setSummaryOff6481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setSummaryOff(string arg0)
		{
			setSummaryOff((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSummaryOff6482;
		public virtual global::java.lang.CharSequence getSummaryOff() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._getSummaryOff6482));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getSummaryOff6482));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisableDependentsState6483;
		public virtual bool getDisableDependentsState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.CheckBoxPreference._getDisableDependentsState6483);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._getDisableDependentsState6483);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDisableDependentsState6484;
		public virtual void setDisableDependentsState(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._setDisableDependentsState6484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._setDisableDependentsState6484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue6485;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.CheckBoxPreference._onGetDefaultValue6485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onGetDefaultValue6485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue6486;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.CheckBoxPreference._onSetInitialValue6486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._onSetInitialValue6486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference6487;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference6487, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference6488;
		public CheckBoxPreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference6488, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference6489;
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, global::android.preference.CheckBoxPreference._CheckBoxPreference6489, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.preference.CheckBoxPreference.staticClass = @__class;
			global::android.preference.CheckBoxPreference._onClick6470 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onClick", "()V");
			global::android.preference.CheckBoxPreference._isChecked6471 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "isChecked", "()Z");
			global::android.preference.CheckBoxPreference._setChecked6472 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setChecked", "(Z)V");
			global::android.preference.CheckBoxPreference._onRestoreInstanceState6473 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.CheckBoxPreference._onSaveInstanceState6474 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.CheckBoxPreference._onBindView6475 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.CheckBoxPreference._shouldDisableDependents6476 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.CheckBoxPreference._setSummaryOn6477 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOn6478 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOn6479 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOn", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._setSummaryOff6480 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(I)V");
			global::android.preference.CheckBoxPreference._setSummaryOff6481 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(Ljava/lang/CharSequence;)V");
			global::android.preference.CheckBoxPreference._getSummaryOff6482 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOff", "()Ljava/lang/CharSequence;");
			global::android.preference.CheckBoxPreference._getDisableDependentsState6483 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getDisableDependentsState", "()Z");
			global::android.preference.CheckBoxPreference._setDisableDependentsState6484 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setDisableDependentsState", "(Z)V");
			global::android.preference.CheckBoxPreference._onGetDefaultValue6485 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.CheckBoxPreference._onSetInitialValue6486 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference6487 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference6488 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.CheckBoxPreference._CheckBoxPreference6489 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
