namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CheckBoxPreference : android.preference.Preference
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CheckBoxPreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.CheckBoxPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onClick5617; 
		protected override void onClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _onClick5617); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _onClick5617); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChecked5618; 
		public virtual bool isChecked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				return @__env.CallBooleanMethod(this, _isChecked5618); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.CheckBoxPreference.staticClass, _isChecked5618); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChecked5619; 
		public virtual void setChecked(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _setChecked5619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _setChecked5619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5620; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState5620, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _onRestoreInstanceState5620, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5621; 
		protected override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState5621)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.CheckBoxPreference.staticClass, _onSaveInstanceState5621)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindView5622; 
		protected override void onBindView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _onBindView5622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _onBindView5622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents5623; 
		public override bool shouldDisableDependents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				return @__env.CallBooleanMethod(this, _shouldDisableDependents5623); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.CheckBoxPreference.staticClass, _shouldDisableDependents5623); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOn5624; 
		public virtual void setSummaryOn(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _setSummaryOn5624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _setSummaryOn5624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOn5625; 
		public virtual void setSummaryOn(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _setSummaryOn5625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _setSummaryOn5625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSummaryOn5626; 
		public virtual java.lang.CharSequence getSummaryOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getSummaryOn5626)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.CheckBoxPreference.staticClass, _getSummaryOn5626)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOff5627; 
		public virtual void setSummaryOff(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _setSummaryOff5627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _setSummaryOff5627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSummaryOff5628; 
		public virtual void setSummaryOff(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _setSummaryOff5628, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _setSummaryOff5628, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSummaryOff5629; 
		public virtual java.lang.CharSequence getSummaryOff() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getSummaryOff5629)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.CheckBoxPreference.staticClass, _getSummaryOff5629)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisableDependentsState5630; 
		public virtual bool getDisableDependentsState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				return @__env.CallBooleanMethod(this, _getDisableDependentsState5630); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.CheckBoxPreference.staticClass, _getDisableDependentsState5630); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDisableDependentsState5631; 
		public virtual void setDisableDependentsState(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _setDisableDependentsState5631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _setDisableDependentsState5631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue5632; 
		protected override java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _onGetDefaultValue5632, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.CheckBoxPreference.staticClass, _onGetDefaultValue5632, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue5633; 
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.CheckBoxPreference)) 
				@__env.CallVoidMethod(this, _onSetInitialValue5633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.CheckBoxPreference.staticClass, _onSetInitialValue5633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference5634; 
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, _CheckBoxPreference5634, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference5635; 
		public CheckBoxPreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, _CheckBoxPreference5635, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CheckBoxPreference5636; 
		public CheckBoxPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.CheckBoxPreference.staticClass, _CheckBoxPreference5636, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.CheckBoxPreference.staticClass = @__class; 
			global::android.preference.CheckBoxPreference._onClick5617 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onClick", "()V"); 
			global::android.preference.CheckBoxPreference._isChecked5618 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "isChecked", "()Z"); 
			global::android.preference.CheckBoxPreference._setChecked5619 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setChecked", "(Z)V"); 
			global::android.preference.CheckBoxPreference._onRestoreInstanceState5620 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.preference.CheckBoxPreference._onSaveInstanceState5621 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.preference.CheckBoxPreference._onBindView5622 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onBindView", "(Landroid/view/View;)V"); 
			global::android.preference.CheckBoxPreference._shouldDisableDependents5623 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "shouldDisableDependents", "()Z"); 
			global::android.preference.CheckBoxPreference._setSummaryOn5624 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(I)V"); 
			global::android.preference.CheckBoxPreference._setSummaryOn5625 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOn", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.CheckBoxPreference._getSummaryOn5626 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOn", "()Ljava/lang/CharSequence;"); 
			global::android.preference.CheckBoxPreference._setSummaryOff5627 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(I)V"); 
			global::android.preference.CheckBoxPreference._setSummaryOff5628 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setSummaryOff", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.CheckBoxPreference._getSummaryOff5629 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getSummaryOff", "()Ljava/lang/CharSequence;"); 
			global::android.preference.CheckBoxPreference._getDisableDependentsState5630 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "getDisableDependentsState", "()Z"); 
			global::android.preference.CheckBoxPreference._setDisableDependentsState5631 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "setDisableDependentsState", "(Z)V"); 
			global::android.preference.CheckBoxPreference._onGetDefaultValue5632 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;"); 
			global::android.preference.CheckBoxPreference._onSetInitialValue5633 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V"); 
			global::android.preference.CheckBoxPreference._CheckBoxPreference5634 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.CheckBoxPreference._CheckBoxPreference5635 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.preference.CheckBoxPreference._CheckBoxPreference5636 = @__env.GetMethodID(global::android.preference.CheckBoxPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
