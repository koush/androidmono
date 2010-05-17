namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class PreferenceGroup : android.preference.Preference
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PreferenceGroup() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.PreferenceGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected PreferenceGroup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAll5799; 
		public virtual void removeAll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _removeAll5799); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _removeAll5799); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled5800; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _setEnabled5800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _setEnabled5800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState5801; 
		protected virtual void dispatchSaveInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _dispatchSaveInstanceState5801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _dispatchSaveInstanceState5801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState5802; 
		protected virtual void dispatchRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _dispatchRestoreInstanceState5802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _dispatchRestoreInstanceState5802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToActivity5803; 
		protected override void onAttachedToActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _onAttachedToActivity5803); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _onAttachedToActivity5803); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareForRemoval5804; 
		protected override void onPrepareForRemoval() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _onPrepareForRemoval5804); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _onPrepareForRemoval5804); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPreference5805; 
		public virtual android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, _findPreference5805, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceGroup.staticClass, _findPreference5805, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOnSameScreenAsChildren5806; 
		protected virtual bool isOnSameScreenAsChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, _isOnSameScreenAsChildren5806); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.PreferenceGroup.staticClass, _isOnSameScreenAsChildren5806); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrderingAsAdded5807; 
		public virtual void setOrderingAsAdded(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _setOrderingAsAdded5807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _setOrderingAsAdded5807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOrderingAsAdded5808; 
		public virtual bool isOrderingAsAdded() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, _isOrderingAsAdded5808); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.PreferenceGroup.staticClass, _isOrderingAsAdded5808); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addItemFromInflater5809; 
		public virtual void addItemFromInflater(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, _addItemFromInflater5809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceGroup.staticClass, _addItemFromInflater5809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceCount5810; 
		public virtual int getPreferenceCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallIntMethod(this, _getPreferenceCount5810); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.PreferenceGroup.staticClass, _getPreferenceCount5810); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreference5811; 
		public virtual android.preference.Preference getPreference(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, _getPreference5811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceGroup.staticClass, _getPreference5811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPreference5812; 
		public virtual bool addPreference(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, _addPreference5812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.PreferenceGroup.staticClass, _addPreference5812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removePreference5813; 
		public virtual bool removePreference(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, _removePreference5813, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.PreferenceGroup.staticClass, _removePreference5813, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareAddPreference5814; 
		protected virtual bool onPrepareAddPreference(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, _onPrepareAddPreference5814, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.PreferenceGroup.staticClass, _onPrepareAddPreference5814, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceGroup5815; 
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceGroup.staticClass, _PreferenceGroup5815, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceGroup5816; 
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceGroup.staticClass, _PreferenceGroup5816, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceGroup.staticClass = @__class; 
			global::android.preference.PreferenceGroup._removeAll5799 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "removeAll", "()V"); 
			global::android.preference.PreferenceGroup._setEnabled5800 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "setEnabled", "(Z)V"); 
			global::android.preference.PreferenceGroup._dispatchSaveInstanceState5801 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceGroup._dispatchRestoreInstanceState5802 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceGroup._onAttachedToActivity5803 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onAttachedToActivity", "()V"); 
			global::android.preference.PreferenceGroup._onPrepareForRemoval5804 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onPrepareForRemoval", "()V"); 
			global::android.preference.PreferenceGroup._findPreference5805 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceGroup._isOnSameScreenAsChildren5806 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "isOnSameScreenAsChildren", "()Z"); 
			global::android.preference.PreferenceGroup._setOrderingAsAdded5807 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "setOrderingAsAdded", "(Z)V"); 
			global::android.preference.PreferenceGroup._isOrderingAsAdded5808 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "isOrderingAsAdded", "()Z"); 
			global::android.preference.PreferenceGroup._addItemFromInflater5809 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "addItemFromInflater", "(Landroid/preference/Preference;)V"); 
			global::android.preference.PreferenceGroup._getPreferenceCount5810 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "getPreferenceCount", "()I"); 
			global::android.preference.PreferenceGroup._getPreference5811 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "getPreference", "(I)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceGroup._addPreference5812 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "addPreference", "(Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceGroup._removePreference5813 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "removePreference", "(Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceGroup._onPrepareAddPreference5814 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceGroup._PreferenceGroup5815 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.preference.PreferenceGroup._PreferenceGroup5816 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
