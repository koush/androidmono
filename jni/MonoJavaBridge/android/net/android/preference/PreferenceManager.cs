namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PreferenceManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PreferenceManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.PreferenceManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.preference.PreferenceManager(@__env); 
			} 
		} 
		protected PreferenceManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnActivityDestroyListener 
		{ 
			void onActivityDestroy(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnActivityResultListener 
		{ 
			bool onActivityResult(int arg0, int arg1, android.content.Intent arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnActivityStopListener 
		{ 
			void onActivityStop(); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences5817; 
		public virtual android.content.SharedPreferences getSharedPreferences() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, _getSharedPreferences5817)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceManager.staticClass, _getSharedPreferences5817)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createPreferenceScreen5818; 
		public virtual android.preference.PreferenceScreen createPreferenceScreen(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallObjectMethodPtr(this, _createPreferenceScreen5818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceManager.staticClass, _createPreferenceScreen5818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferencesName5819; 
		public virtual java.lang.String getSharedPreferencesName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSharedPreferencesName5819)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceManager.staticClass, _getSharedPreferencesName5819)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSharedPreferencesName5820; 
		public virtual void setSharedPreferencesName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				@__env.CallVoidMethod(this, _setSharedPreferencesName5820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceManager.staticClass, _setSharedPreferencesName5820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferencesMode5821; 
		public virtual int getSharedPreferencesMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return @__env.CallIntMethod(this, _getSharedPreferencesMode5821); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.PreferenceManager.staticClass, _getSharedPreferencesMode5821); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSharedPreferencesMode5822; 
		public virtual void setSharedPreferencesMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				@__env.CallVoidMethod(this, _setSharedPreferencesMode5822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceManager.staticClass, _setSharedPreferencesMode5822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultSharedPreferences5823; 
		public static android.content.SharedPreferences getDefaultSharedPreferences(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallStaticObjectMethodPtr(android.preference.PreferenceManager.staticClass, _getDefaultSharedPreferences5823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPreference5824; 
		public virtual android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, _findPreference5824, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceManager.staticClass, _findPreference5824, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultValues5825; 
		public static void setDefaultValues(android.content.Context arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, _setDefaultValues5825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultValues5826; 
		public static void setDefaultValues(android.content.Context arg0, java.lang.String arg1, int arg2, int arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, _setDefaultValues5826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		public static java.lang.String METADATA_KEY_PREFERENCES
		{ 
			get 
			{ 
				return "android.preference"; 
			} 
		} 
		public static java.lang.String KEY_HAS_SET_DEFAULT_VALUES
		{ 
			get 
			{ 
				return "_has_set_default_values"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceManager.staticClass = @__class; 
			global::android.preference.PreferenceManager._getSharedPreferences5817 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;"); 
			global::android.preference.PreferenceManager._createPreferenceScreen5818 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "createPreferenceScreen", "(Landroid/content/Context;)Landroid/preference/PreferenceScreen;"); 
			global::android.preference.PreferenceManager._getSharedPreferencesName5819 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesName", "()Ljava/lang/String;"); 
			global::android.preference.PreferenceManager._setSharedPreferencesName5820 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesName", "(Ljava/lang/String;)V"); 
			global::android.preference.PreferenceManager._getSharedPreferencesMode5821 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesMode", "()I"); 
			global::android.preference.PreferenceManager._setSharedPreferencesMode5822 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesMode", "(I)V"); 
			global::android.preference.PreferenceManager._getDefaultSharedPreferences5823 = @__env.GetStaticMethodID(global::android.preference.PreferenceManager.staticClass, "getDefaultSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;"); 
			global::android.preference.PreferenceManager._findPreference5824 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceManager._setDefaultValues5825 = @__env.GetStaticMethodID(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;IZ)V"); 
			global::android.preference.PreferenceManager._setDefaultValues5826 = @__env.GetStaticMethodID(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;Ljava/lang/String;IIZ)V"); 
		} 
	} 
} 
