namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PreferenceManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PreferenceManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.PreferenceManager.OnActivityDestroyListener_))]
		public partial interface OnActivityDestroyListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onActivityDestroy();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceManager.OnActivityDestroyListener))]
		internal sealed partial class OnActivityDestroyListener_ : java.lang.Object, OnActivityDestroyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnActivityDestroyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onActivityDestroy10432;
			void android.preference.PreferenceManager.OnActivityDestroyListener.onActivityDestroy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityDestroyListener_._onActivityDestroy10432);
			}
			static OnActivityDestroyListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityDestroyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityDestroyListener"));
				global::android.preference.PreferenceManager.OnActivityDestroyListener_._onActivityDestroy10432 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityDestroyListener_.staticClass, "onActivityDestroy", "()V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnActivityDestroyListenerDelegate();

		internal partial class OnActivityDestroyListenerDelegateWrapper : java.lang.Object, OnActivityDestroyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnActivityDestroyListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnActivityDestroyListenerDelegateWrapper10433;
			public OnActivityDestroyListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper.staticClass, global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper._OnActivityDestroyListenerDelegateWrapper10433);
				Init(@__env, handle);
			}
			static OnActivityDestroyListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager_OnActivityDestroyListenerDelegateWrapper"));
				global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper._OnActivityDestroyListenerDelegateWrapper10433 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnActivityDestroyListenerDelegateWrapper
		{
			private OnActivityDestroyListenerDelegate myDelegate;
			public void onActivityDestroy()
			{
				myDelegate();
			}
			public static implicit operator OnActivityDestroyListenerDelegateWrapper(OnActivityDestroyListenerDelegate d)
			{
				global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper ret = new global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.PreferenceManager.OnActivityResultListener_))]
		public partial interface OnActivityResultListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onActivityResult(int arg0, int arg1, android.content.Intent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceManager.OnActivityResultListener))]
		internal sealed partial class OnActivityResultListener_ : java.lang.Object, OnActivityResultListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnActivityResultListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onActivityResult10434;
			bool android.preference.PreferenceManager.OnActivityResultListener.onActivityResult(int arg0, int arg1, android.content.Intent arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityResultListener_._onActivityResult10434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnActivityResultListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityResultListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityResultListener"));
				global::android.preference.PreferenceManager.OnActivityResultListener_._onActivityResult10434 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityResultListener_.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnActivityResultListenerDelegate(int arg0, int arg1, android.content.Intent arg2);

		internal partial class OnActivityResultListenerDelegateWrapper : java.lang.Object, OnActivityResultListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnActivityResultListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnActivityResultListenerDelegateWrapper10435;
			public OnActivityResultListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper.staticClass, global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper._OnActivityResultListenerDelegateWrapper10435);
				Init(@__env, handle);
			}
			static OnActivityResultListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager_OnActivityResultListenerDelegateWrapper"));
				global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper._OnActivityResultListenerDelegateWrapper10435 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnActivityResultListenerDelegateWrapper
		{
			private OnActivityResultListenerDelegate myDelegate;
			public bool onActivityResult(int arg0, int arg1, android.content.Intent arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnActivityResultListenerDelegateWrapper(OnActivityResultListenerDelegate d)
			{
				global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper ret = new global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.PreferenceManager.OnActivityStopListener_))]
		public partial interface OnActivityStopListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onActivityStop();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceManager.OnActivityStopListener))]
		internal sealed partial class OnActivityStopListener_ : java.lang.Object, OnActivityStopListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnActivityStopListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onActivityStop10436;
			void android.preference.PreferenceManager.OnActivityStopListener.onActivityStop()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceManager.OnActivityStopListener_._onActivityStop10436);
			}
			static OnActivityStopListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityStopListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityStopListener"));
				global::android.preference.PreferenceManager.OnActivityStopListener_._onActivityStop10436 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityStopListener_.staticClass, "onActivityStop", "()V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnActivityStopListenerDelegate();

		internal partial class OnActivityStopListenerDelegateWrapper : java.lang.Object, OnActivityStopListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnActivityStopListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnActivityStopListenerDelegateWrapper10437;
			public OnActivityStopListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper.staticClass, global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper._OnActivityStopListenerDelegateWrapper10437);
				Init(@__env, handle);
			}
			static OnActivityStopListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager_OnActivityStopListenerDelegateWrapper"));
				global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper._OnActivityStopListenerDelegateWrapper10437 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnActivityStopListenerDelegateWrapper
		{
			private OnActivityStopListenerDelegate myDelegate;
			public void onActivityStop()
			{
				myDelegate();
			}
			public static implicit operator OnActivityStopListenerDelegateWrapper(OnActivityStopListenerDelegate d)
			{
				global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper ret = new global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public new global::android.content.SharedPreferences SharedPreferences
		{
			get
			{
				return getSharedPreferences();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences10438;
		public virtual global::android.content.SharedPreferences getSharedPreferences()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferences10438)) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _createPreferenceScreen10439;
		public virtual global::android.preference.PreferenceScreen createPreferenceScreen(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.preference.PreferenceScreen>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._createPreferenceScreen10439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.PreferenceScreen;
		}
		public new global::java.lang.String SharedPreferencesName
		{
			get
			{
				return getSharedPreferencesName();
			}
			set
			{
				setSharedPreferencesName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferencesName10440;
		public virtual global::java.lang.String getSharedPreferencesName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferencesName10440)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSharedPreferencesName10441;
		public virtual void setSharedPreferencesName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setSharedPreferencesName10441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SharedPreferencesMode
		{
			get
			{
				return getSharedPreferencesMode();
			}
			set
			{
				setSharedPreferencesMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferencesMode10442;
		public virtual int getSharedPreferencesMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferencesMode10442);
		}
		internal static global::MonoJavaBridge.MethodId _setSharedPreferencesMode10443;
		public virtual void setSharedPreferencesMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setSharedPreferencesMode10443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSharedPreferences10444;
		public static global::android.content.SharedPreferences getDefaultSharedPreferences(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallStaticObjectMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getDefaultSharedPreferences10444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _findPreference10445;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._findPreference10445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultValues10446;
		public static void setDefaultValues(android.content.Context arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setDefaultValues10446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultValues10447;
		public static void setDefaultValues(android.content.Context arg0, java.lang.String arg1, int arg2, int arg3, bool arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setDefaultValues10447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		static PreferenceManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager"));
			global::android.preference.PreferenceManager._getSharedPreferences10438 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;");
			global::android.preference.PreferenceManager._createPreferenceScreen10439 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "createPreferenceScreen", "(Landroid/content/Context;)Landroid/preference/PreferenceScreen;");
			global::android.preference.PreferenceManager._getSharedPreferencesName10440 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesName", "()Ljava/lang/String;");
			global::android.preference.PreferenceManager._setSharedPreferencesName10441 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesName", "(Ljava/lang/String;)V");
			global::android.preference.PreferenceManager._getSharedPreferencesMode10442 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesMode", "()I");
			global::android.preference.PreferenceManager._setSharedPreferencesMode10443 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesMode", "(I)V");
			global::android.preference.PreferenceManager._getDefaultSharedPreferences10444 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getDefaultSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;");
			global::android.preference.PreferenceManager._findPreference10445 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;");
			global::android.preference.PreferenceManager._setDefaultValues10446 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;IZ)V");
			global::android.preference.PreferenceManager._setDefaultValues10447 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;Ljava/lang/String;IIZ)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
