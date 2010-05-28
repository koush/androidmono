namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RingtonePreference : android.preference.Preference, android.preference.PreferenceManager.OnActivityResultListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RingtonePreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.RingtonePreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onClick6111; 
		protected override void onClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._onClick6111); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onClick6111); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onActivityResult6112; 
		public virtual bool onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallBooleanMethod(this, global::android.preference.RingtonePreference._onActivityResult6112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onActivityResult6112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue6113; 
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.RingtonePreference._onGetDefaultValue6113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onGetDefaultValue6113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue6114; 
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._onSetInitialValue6114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onSetInitialValue6114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToHierarchy6115; 
		protected override void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._onAttachedToHierarchy6115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onAttachedToHierarchy6115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingtoneType6116; 
		public virtual int getRingtoneType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallIntMethod(this, global::android.preference.RingtonePreference._getRingtoneType6116); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getRingtoneType6116); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRingtoneType6117; 
		public virtual void setRingtoneType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._setRingtoneType6117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setRingtoneType6117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShowDefault6118; 
		public virtual bool getShowDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallBooleanMethod(this, global::android.preference.RingtonePreference._getShowDefault6118); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getShowDefault6118); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShowDefault6119; 
		public virtual void setShowDefault(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._setShowDefault6119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setShowDefault6119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShowSilent6120; 
		public virtual bool getShowSilent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return @__env.CallBooleanMethod(this, global::android.preference.RingtonePreference._getShowSilent6120); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getShowSilent6120); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShowSilent6121; 
		public virtual void setShowSilent(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._setShowSilent6121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setShowSilent6121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareRingtonePickerIntent6122; 
		protected virtual void onPrepareRingtonePickerIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent6122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent6122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveRingtone6123; 
		protected virtual void onSaveRingtone(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				@__env.CallVoidMethod(this, global::android.preference.RingtonePreference._onSaveRingtone6123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onSaveRingtone6123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreRingtone6124; 
		protected virtual global::android.net.Uri onRestoreRingtone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.RingtonePreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.RingtonePreference._onRestoreRingtone6124)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onRestoreRingtone6124)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtonePreference6125; 
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference6125, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtonePreference6126; 
		public RingtonePreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference6126, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtonePreference6127; 
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference6127, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.RingtonePreference.staticClass = @__class; 
			global::android.preference.RingtonePreference._onClick6111 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onClick", "()V"); 
			global::android.preference.RingtonePreference._onActivityResult6112 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z"); 
			global::android.preference.RingtonePreference._onGetDefaultValue6113 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;"); 
			global::android.preference.RingtonePreference._onSetInitialValue6114 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V"); 
			global::android.preference.RingtonePreference._onAttachedToHierarchy6115 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V"); 
			global::android.preference.RingtonePreference._getRingtoneType6116 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "getRingtoneType", "()I"); 
			global::android.preference.RingtonePreference._setRingtoneType6117 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "setRingtoneType", "(I)V"); 
			global::android.preference.RingtonePreference._getShowDefault6118 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "getShowDefault", "()Z"); 
			global::android.preference.RingtonePreference._setShowDefault6119 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "setShowDefault", "(Z)V"); 
			global::android.preference.RingtonePreference._getShowSilent6120 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "getShowSilent", "()Z"); 
			global::android.preference.RingtonePreference._setShowSilent6121 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "setShowSilent", "(Z)V"); 
			global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent6122 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V"); 
			global::android.preference.RingtonePreference._onSaveRingtone6123 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onSaveRingtone", "(Landroid/net/Uri;)V"); 
			global::android.preference.RingtonePreference._onRestoreRingtone6124 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "onRestoreRingtone", "()Landroid/net/Uri;"); 
			global::android.preference.RingtonePreference._RingtonePreference6125 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.RingtonePreference._RingtonePreference6126 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.preference.RingtonePreference._RingtonePreference6127 = @__env.GetMethodID(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
