namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RingtonePreference : android.preference.Preference, android.preference.PreferenceManager.OnActivityResultListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RingtonePreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.RingtonePreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.preference.RingtonePreference(@__env); 
			} 
		} 
		protected RingtonePreference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick5832; 
		protected override void onClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _onClick5832); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _onClick5832); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onActivityResult5833; 
		public virtual bool onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallBooleanMethod(this, _onActivityResult5833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.RingtonePreference.staticClass, _onActivityResult5833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue5834; 
		protected override java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _onGetDefaultValue5834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.RingtonePreference.staticClass, _onGetDefaultValue5834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue5835; 
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _onSetInitialValue5835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _onSetInitialValue5835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToHierarchy5836; 
		protected override void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _onAttachedToHierarchy5836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _onAttachedToHierarchy5836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingtoneType5837; 
		public virtual int getRingtoneType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallIntMethod(this, _getRingtoneType5837); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.RingtonePreference.staticClass, _getRingtoneType5837); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRingtoneType5838; 
		public virtual void setRingtoneType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _setRingtoneType5838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _setRingtoneType5838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShowDefault5839; 
		public virtual bool getShowDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallBooleanMethod(this, _getShowDefault5839); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.RingtonePreference.staticClass, _getShowDefault5839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShowDefault5840; 
		public virtual void setShowDefault(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _setShowDefault5840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _setShowDefault5840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShowSilent5841; 
		public virtual bool getShowSilent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallBooleanMethod(this, _getShowSilent5841); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.RingtonePreference.staticClass, _getShowSilent5841); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShowSilent5842; 
		public virtual void setShowSilent(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _setShowSilent5842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _setShowSilent5842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareRingtonePickerIntent5843; 
		protected virtual void onPrepareRingtonePickerIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _onPrepareRingtonePickerIntent5843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _onPrepareRingtonePickerIntent5843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveRingtone5844; 
		protected virtual void onSaveRingtone(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, _onSaveRingtone5844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.RingtonePreference.staticClass, _onSaveRingtone5844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreRingtone5845; 
		protected virtual android.net.Uri onRestoreRingtone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _onRestoreRingtone5845)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.RingtonePreference.staticClass, _onRestoreRingtone5845)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtonePreference5846; 
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.RingtonePreference.staticClass, _RingtonePreference5846, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtonePreference5847; 
		public RingtonePreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.RingtonePreference.staticClass, _RingtonePreference5847, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtonePreference5848; 
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.RingtonePreference.staticClass, _RingtonePreference5848, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.RingtonePreference.staticClass = @__class; 
			global::android.preference.RingtonePreference._onClick5832 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onClick", "()V"); 
			global::android.preference.RingtonePreference._onActivityResult5833 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z"); 
			global::android.preference.RingtonePreference._onGetDefaultValue5834 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;"); 
			global::android.preference.RingtonePreference._onSetInitialValue5835 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V"); 
			global::android.preference.RingtonePreference._onAttachedToHierarchy5836 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V"); 
			global::android.preference.RingtonePreference._getRingtoneType5837 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "getRingtoneType", "()I"); 
			global::android.preference.RingtonePreference._setRingtoneType5838 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "setRingtoneType", "(I)V"); 
			global::android.preference.RingtonePreference._getShowDefault5839 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "getShowDefault", "()Z"); 
			global::android.preference.RingtonePreference._setShowDefault5840 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "setShowDefault", "(Z)V"); 
			global::android.preference.RingtonePreference._getShowSilent5841 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "getShowSilent", "()Z"); 
			global::android.preference.RingtonePreference._setShowSilent5842 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "setShowSilent", "(Z)V"); 
			global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent5843 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V"); 
			global::android.preference.RingtonePreference._onSaveRingtone5844 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onSaveRingtone", "(Landroid/net/Uri;)V"); 
			global::android.preference.RingtonePreference._onRestoreRingtone5845 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onRestoreRingtone", "()Landroid/net/Uri;"); 
			global::android.preference.RingtonePreference._RingtonePreference5846 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.RingtonePreference._RingtonePreference5847 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.preference.RingtonePreference._RingtonePreference5848 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
