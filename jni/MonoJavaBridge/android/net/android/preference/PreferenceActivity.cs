namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class PreferenceActivity : android.app.ListActivity
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PreferenceActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.PreferenceActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected PreferenceActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate5778; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onCreate5778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onCreate5778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy5779; 
		protected override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onDestroy5779); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onDestroy5779); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5780; 
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState5780, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onRestoreInstanceState5780, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onNewIntent5781; 
		protected override void onNewIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onNewIntent5781, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onNewIntent5781, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5782; 
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onSaveInstanceState5782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onSaveInstanceState5782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop5783; 
		protected override void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onStop5783); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onStop5783); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged5784; 
		public override void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onContentChanged5784); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onContentChanged5784); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onActivityResult5785; 
		protected override void onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _onActivityResult5785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _onActivityResult5785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceManager5786; 
		public virtual android.preference.PreferenceManager getPreferenceManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallObjectMethodPtr(this, _getPreferenceManager5786)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceActivity.staticClass, _getPreferenceManager5786)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPreference5787; 
		public virtual android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, _findPreference5787, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceActivity.staticClass, _findPreference5787, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreferenceScreen5788; 
		public virtual void setPreferenceScreen(android.preference.PreferenceScreen arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _setPreferenceScreen5788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _setPreferenceScreen5788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceScreen5789; 
		public virtual android.preference.PreferenceScreen getPreferenceScreen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallObjectMethodPtr(this, _getPreferenceScreen5789)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceActivity.staticClass, _getPreferenceScreen5789)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPreferencesFromIntent5790; 
		public virtual void addPreferencesFromIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _addPreferencesFromIntent5790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _addPreferencesFromIntent5790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPreferencesFromResource5791; 
		public virtual void addPreferencesFromResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				@__env.CallVoidMethod(this, _addPreferencesFromResource5791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceActivity.staticClass, _addPreferencesFromResource5791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPreferenceTreeClick5792; 
		public virtual bool onPreferenceTreeClick(android.preference.PreferenceScreen arg0, android.preference.Preference arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceActivity)) 
				return @__env.CallBooleanMethod(this, _onPreferenceTreeClick5792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.PreferenceActivity.staticClass, _onPreferenceTreeClick5792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceActivity5793; 
		public PreferenceActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceActivity.staticClass, _PreferenceActivity5793, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceActivity.staticClass = @__class; 
			global::android.preference.PreferenceActivity._onCreate5778 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceActivity._onDestroy5779 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onDestroy", "()V"); 
			global::android.preference.PreferenceActivity._onRestoreInstanceState5780 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceActivity._onNewIntent5781 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V"); 
			global::android.preference.PreferenceActivity._onSaveInstanceState5782 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.PreferenceActivity._onStop5783 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onStop", "()V"); 
			global::android.preference.PreferenceActivity._onContentChanged5784 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onContentChanged", "()V"); 
			global::android.preference.PreferenceActivity._onActivityResult5785 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V"); 
			global::android.preference.PreferenceActivity._getPreferenceManager5786 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;"); 
			global::android.preference.PreferenceActivity._findPreference5787 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceActivity._setPreferenceScreen5788 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V"); 
			global::android.preference.PreferenceActivity._getPreferenceScreen5789 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "getPreferenceScreen", "()Landroid/preference/PreferenceScreen;"); 
			global::android.preference.PreferenceActivity._addPreferencesFromIntent5790 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromIntent", "(Landroid/content/Intent;)V"); 
			global::android.preference.PreferenceActivity._addPreferencesFromResource5791 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromResource", "(I)V"); 
			global::android.preference.PreferenceActivity._onPreferenceTreeClick5792 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceActivity._PreferenceActivity5793 = @__env.GetMethodID(global::android.preference.PreferenceActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
