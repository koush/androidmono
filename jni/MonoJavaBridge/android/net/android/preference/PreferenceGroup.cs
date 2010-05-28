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
		internal static global::net.sf.jni4net.jni.MethodId _removeAll6075; 
		public virtual void removeAll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._removeAll6075); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removeAll6075); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled6076; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._setEnabled6076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setEnabled6076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState6077; 
		protected virtual void dispatchSaveInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._dispatchSaveInstanceState6077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchSaveInstanceState6077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState6078; 
		protected virtual void dispatchRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToActivity6079; 
		protected override void onAttachedToActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._onAttachedToActivity6079); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onAttachedToActivity6079); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareForRemoval6080; 
		protected override void onPrepareForRemoval() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._onPrepareForRemoval6080); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareForRemoval6080); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPreference6081; 
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceGroup._findPreference6081, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._findPreference6081, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOnSameScreenAsChildren6082; 
		protected virtual bool isOnSameScreenAsChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6082); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6082); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrderingAsAdded6083; 
		public virtual void setOrderingAsAdded(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._setOrderingAsAdded6083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setOrderingAsAdded6083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOrderingAsAdded6084; 
		public virtual bool isOrderingAsAdded() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._isOrderingAsAdded6084); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOrderingAsAdded6084); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addItemFromInflater6085; 
		public virtual void addItemFromInflater(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceGroup._addItemFromInflater6085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addItemFromInflater6085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceCount6086; 
		public virtual int getPreferenceCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallIntMethod(this, global::android.preference.PreferenceGroup._getPreferenceCount6086); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreferenceCount6086); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreference6087; 
		public virtual global::android.preference.Preference getPreference(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceGroup._getPreference6087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreference6087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPreference6088; 
		public virtual bool addPreference(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._addPreference6088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addPreference6088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removePreference6089; 
		public virtual bool removePreference(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._removePreference6089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removePreference6089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareAddPreference6090; 
		protected virtual bool onPrepareAddPreference(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceGroup)) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceGroup._onPrepareAddPreference6090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareAddPreference6090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceGroup6091; 
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup6091, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceGroup6092; 
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup6092, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceGroup.staticClass = @__class; 
			global::android.preference.PreferenceGroup._removeAll6075 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "removeAll", "()V"); 
			global::android.preference.PreferenceGroup._setEnabled6076 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "setEnabled", "(Z)V"); 
			global::android.preference.PreferenceGroup._dispatchSaveInstanceState6077 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6078 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceGroup._onAttachedToActivity6079 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onAttachedToActivity", "()V"); 
			global::android.preference.PreferenceGroup._onPrepareForRemoval6080 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onPrepareForRemoval", "()V"); 
			global::android.preference.PreferenceGroup._findPreference6081 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6082 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "isOnSameScreenAsChildren", "()Z"); 
			global::android.preference.PreferenceGroup._setOrderingAsAdded6083 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "setOrderingAsAdded", "(Z)V"); 
			global::android.preference.PreferenceGroup._isOrderingAsAdded6084 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "isOrderingAsAdded", "()Z"); 
			global::android.preference.PreferenceGroup._addItemFromInflater6085 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "addItemFromInflater", "(Landroid/preference/Preference;)V"); 
			global::android.preference.PreferenceGroup._getPreferenceCount6086 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "getPreferenceCount", "()I"); 
			global::android.preference.PreferenceGroup._getPreference6087 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "getPreference", "(I)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceGroup._addPreference6088 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "addPreference", "(Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceGroup._removePreference6089 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "removePreference", "(Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceGroup._onPrepareAddPreference6090 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceGroup._PreferenceGroup6091 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.preference.PreferenceGroup._PreferenceGroup6092 = @__env.GetMethodID(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
