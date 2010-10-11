namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PreferenceManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreferenceManager()
		{
			InitJNI();
		}
		protected PreferenceManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.PreferenceManager.OnActivityDestroyListener_))]
		public interface OnActivityDestroyListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onActivityDestroy();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceManager.OnActivityDestroyListener))]
		public sealed partial class OnActivityDestroyListener_ : java.lang.Object, OnActivityDestroyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnActivityDestroyListener_()
			{
				InitJNI();
			}
			internal OnActivityDestroyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onActivityDestroy6948;
			 void android.preference.PreferenceManager.OnActivityDestroyListener.onActivityDestroy() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityDestroyListener_._onActivityDestroy6948);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityDestroyListener_.staticClass, global::android.preference.PreferenceManager.OnActivityDestroyListener_._onActivityDestroy6948);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityDestroyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityDestroyListener"));
				global::android.preference.PreferenceManager.OnActivityDestroyListener_._onActivityDestroy6948 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityDestroyListener_.staticClass, "onActivityDestroy", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.PreferenceManager.OnActivityResultListener_))]
		public interface OnActivityResultListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onActivityResult(int arg0, int arg1, android.content.Intent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceManager.OnActivityResultListener))]
		public sealed partial class OnActivityResultListener_ : java.lang.Object, OnActivityResultListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnActivityResultListener_()
			{
				InitJNI();
			}
			internal OnActivityResultListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onActivityResult6949;
			 bool android.preference.PreferenceManager.OnActivityResultListener.onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityResultListener_._onActivityResult6949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityResultListener_.staticClass, global::android.preference.PreferenceManager.OnActivityResultListener_._onActivityResult6949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityResultListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityResultListener"));
				global::android.preference.PreferenceManager.OnActivityResultListener_._onActivityResult6949 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityResultListener_.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.PreferenceManager.OnActivityStopListener_))]
		public interface OnActivityStopListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onActivityStop();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceManager.OnActivityStopListener))]
		public sealed partial class OnActivityStopListener_ : java.lang.Object, OnActivityStopListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnActivityStopListener_()
			{
				InitJNI();
			}
			internal OnActivityStopListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onActivityStop6950;
			 void android.preference.PreferenceManager.OnActivityStopListener.onActivityStop() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityStopListener_._onActivityStop6950);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityStopListener_.staticClass, global::android.preference.PreferenceManager.OnActivityStopListener_._onActivityStop6950);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityStopListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityStopListener"));
				global::android.preference.PreferenceManager.OnActivityStopListener_._onActivityStop6950 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityStopListener_.staticClass, "onActivityStop", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences6951;
		public virtual global::android.content.SharedPreferences getSharedPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager._getSharedPreferences6951)) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferences6951)) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _createPreferenceScreen6952;
		public virtual global::android.preference.PreferenceScreen createPreferenceScreen(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager._createPreferenceScreen6952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.PreferenceScreen;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._createPreferenceScreen6952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.PreferenceScreen;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferencesName6953;
		public virtual global::java.lang.String getSharedPreferencesName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager._getSharedPreferencesName6953)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferencesName6953)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSharedPreferencesName6954;
		public virtual void setSharedPreferencesName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager._setSharedPreferencesName6954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setSharedPreferencesName6954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferencesMode6955;
		public virtual int getSharedPreferencesMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.PreferenceManager._getSharedPreferencesMode6955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferencesMode6955);
		}
		internal static global::MonoJavaBridge.MethodId _setSharedPreferencesMode6956;
		public virtual void setSharedPreferencesMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager._setSharedPreferencesMode6956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setSharedPreferencesMode6956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSharedPreferences6957;
		public static global::android.content.SharedPreferences getDefaultSharedPreferences(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallStaticObjectMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getDefaultSharedPreferences6957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _findPreference6958;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager._findPreference6958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._findPreference6958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultValues6959;
		public static void setDefaultValues(android.content.Context arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setDefaultValues6959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultValues6960;
		public static void setDefaultValues(android.content.Context arg0, java.lang.String arg1, int arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setDefaultValues6960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static global::java.lang.String METADATA_KEY_PREFERENCES
		{
			get
			{
				return "android.preference";
			}
		}
		public static global::java.lang.String KEY_HAS_SET_DEFAULT_VALUES
		{
			get
			{
				return "_has_set_default_values";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager"));
			global::android.preference.PreferenceManager._getSharedPreferences6951 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;");
			global::android.preference.PreferenceManager._createPreferenceScreen6952 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "createPreferenceScreen", "(Landroid/content/Context;)Landroid/preference/PreferenceScreen;");
			global::android.preference.PreferenceManager._getSharedPreferencesName6953 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesName", "()Ljava/lang/String;");
			global::android.preference.PreferenceManager._setSharedPreferencesName6954 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesName", "(Ljava/lang/String;)V");
			global::android.preference.PreferenceManager._getSharedPreferencesMode6955 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesMode", "()I");
			global::android.preference.PreferenceManager._setSharedPreferencesMode6956 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesMode", "(I)V");
			global::android.preference.PreferenceManager._getDefaultSharedPreferences6957 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getDefaultSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;");
			global::android.preference.PreferenceManager._findPreference6958 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;");
			global::android.preference.PreferenceManager._setDefaultValues6959 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;IZ)V");
			global::android.preference.PreferenceManager._setDefaultValues6960 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;Ljava/lang/String;IIZ)V");
		}
	}
}
