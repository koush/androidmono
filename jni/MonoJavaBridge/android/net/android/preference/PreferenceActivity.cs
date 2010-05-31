namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class PreferenceActivity : android.app.ListActivity
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PreferenceActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected PreferenceActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate6054; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onCreate6054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onCreate6054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy6055; 
		protected override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onDestroy6055); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onDestroy6055); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState6056; 
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onRestoreInstanceState6056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onRestoreInstanceState6056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onNewIntent6057; 
		protected override void onNewIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onNewIntent6057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onNewIntent6057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState6058; 
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onSaveInstanceState6058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onSaveInstanceState6058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop6059; 
		protected override void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onStop6059); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onStop6059); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged6060; 
		public override void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onContentChanged6060); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onContentChanged6060); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onActivityResult6061; 
		protected override void onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._onActivityResult6061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onActivityResult6061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceManager6062; 
		public virtual global::android.preference.PreferenceManager getPreferenceManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceActivity._getPreferenceManager6062)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._getPreferenceManager6062)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPreference6063; 
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceActivity._findPreference6063, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._findPreference6063, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreferenceScreen6064; 
		public virtual void setPreferenceScreen(android.preference.PreferenceScreen arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._setPreferenceScreen6064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._setPreferenceScreen6064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceScreen6065; 
		public virtual global::android.preference.PreferenceScreen getPreferenceScreen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceActivity._getPreferenceScreen6065)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._getPreferenceScreen6065)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPreferencesFromIntent6066; 
		public virtual void addPreferencesFromIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._addPreferencesFromIntent6066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._addPreferencesFromIntent6066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPreferencesFromResource6067; 
		public virtual void addPreferencesFromResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceActivity._addPreferencesFromResource6067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._addPreferencesFromResource6067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPreferenceTreeClick6068; 
		public virtual bool onPreferenceTreeClick(android.preference.PreferenceScreen arg0, android.preference.Preference arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceActivity._onPreferenceTreeClick6068, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onPreferenceTreeClick6068, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceActivity6069; 
		public PreferenceActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._PreferenceActivity6069, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceActivity.staticClass = @__class; 
			global::android.preference.PreferenceActivity._onCreate6054 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceActivity._onDestroy6055 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onDestroy", "()V"); 
			global::android.preference.PreferenceActivity._onRestoreInstanceState6056 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceActivity._onNewIntent6057 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V"); 
			global::android.preference.PreferenceActivity._onSaveInstanceState6058 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceActivity._onStop6059 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onStop", "()V"); 
			global::android.preference.PreferenceActivity._onContentChanged6060 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onContentChanged", "()V"); 
			global::android.preference.PreferenceActivity._onActivityResult6061 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V"); 
			global::android.preference.PreferenceActivity._getPreferenceManager6062 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;"); 
			global::android.preference.PreferenceActivity._findPreference6063 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceActivity._setPreferenceScreen6064 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V"); 
			global::android.preference.PreferenceActivity._getPreferenceScreen6065 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "getPreferenceScreen", "()Landroid/preference/PreferenceScreen;"); 
			global::android.preference.PreferenceActivity._addPreferencesFromIntent6066 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromIntent", "(Landroid/content/Intent;)V"); 
			global::android.preference.PreferenceActivity._addPreferencesFromResource6067 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromResource", "(I)V"); 
			global::android.preference.PreferenceActivity._onPreferenceTreeClick6068 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceActivity._PreferenceActivity6069 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
