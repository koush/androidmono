namespace android.preference
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class PreferenceGroup : android.preference.Preference
	{
		internal new static global::java.lang.Class staticClass;
		static PreferenceGroup()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected PreferenceGroup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAll6654;
		public virtual void removeAll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._removeAll6654);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removeAll6654);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled6655;
		public override void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._setEnabled6655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setEnabled6655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState6656;
		protected virtual void dispatchSaveInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._dispatchSaveInstanceState6656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchSaveInstanceState6656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState6657;
		protected virtual void dispatchRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToActivity6658;
		protected override void onAttachedToActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._onAttachedToActivity6658);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onAttachedToActivity6658);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareForRemoval6659;
		protected override void onPrepareForRemoval() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._onPrepareForRemoval6659);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareForRemoval6659);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findPreference6660;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceGroup._findPreference6660, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._findPreference6660, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOnSameScreenAsChildren6661;
		protected virtual bool isOnSameScreenAsChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6661);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6661);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrderingAsAdded6662;
		public virtual void setOrderingAsAdded(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._setOrderingAsAdded6662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setOrderingAsAdded6662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOrderingAsAdded6663;
		public virtual bool isOrderingAsAdded() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._isOrderingAsAdded6663);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOrderingAsAdded6663);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addItemFromInflater6664;
		public virtual void addItemFromInflater(android.preference.Preference arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._addItemFromInflater6664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addItemFromInflater6664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceCount6665;
		public virtual int getPreferenceCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.PreferenceGroup._getPreferenceCount6665);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreferenceCount6665);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPreference6666;
		public virtual global::android.preference.Preference getPreference(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceGroup._getPreference6666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreference6666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addPreference6667;
		public virtual bool addPreference(android.preference.Preference arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._addPreference6667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addPreference6667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removePreference6668;
		public virtual bool removePreference(android.preference.Preference arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._removePreference6668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removePreference6668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareAddPreference6669;
		protected virtual bool onPrepareAddPreference(android.preference.Preference arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._onPrepareAddPreference6669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareAddPreference6669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceGroup6670;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup6670, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceGroup6671;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup6671, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.preference.PreferenceGroup.staticClass = @__class;
			global::android.preference.PreferenceGroup._removeAll6654 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "removeAll", "()V");
			global::android.preference.PreferenceGroup._setEnabled6655 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "setEnabled", "(Z)V");
			global::android.preference.PreferenceGroup._dispatchSaveInstanceState6656 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6657 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceGroup._onAttachedToActivity6658 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.PreferenceGroup._onPrepareForRemoval6659 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.PreferenceGroup._findPreference6660 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;");
			global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6661 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "isOnSameScreenAsChildren", "()Z");
			global::android.preference.PreferenceGroup._setOrderingAsAdded6662 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "setOrderingAsAdded", "(Z)V");
			global::android.preference.PreferenceGroup._isOrderingAsAdded6663 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "isOrderingAsAdded", "()Z");
			global::android.preference.PreferenceGroup._addItemFromInflater6664 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "addItemFromInflater", "(Landroid/preference/Preference;)V");
			global::android.preference.PreferenceGroup._getPreferenceCount6665 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "getPreferenceCount", "()I");
			global::android.preference.PreferenceGroup._getPreference6666 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "getPreference", "(I)Landroid/preference/Preference;");
			global::android.preference.PreferenceGroup._addPreference6667 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "addPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._removePreference6668 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "removePreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._onPrepareAddPreference6669 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._PreferenceGroup6670 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.PreferenceGroup._PreferenceGroup6671 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
