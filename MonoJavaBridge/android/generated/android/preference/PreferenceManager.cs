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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.preference.PreferenceManager.OnActivityDestroyListener.onActivityDestroy()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceManager.OnActivityDestroyListener_.staticClass, "onActivityDestroy", "()V", ref global::android.preference.PreferenceManager.OnActivityDestroyListener_._m0);
			}
			static OnActivityDestroyListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityDestroyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityDestroyListener"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public OnActivityDestroyListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper.staticClass, global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnActivityDestroyListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityDestroyListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager_OnActivityDestroyListenerDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.preference.PreferenceManager.OnActivityResultListener.onActivityResult(int arg0, int arg1, android.content.Intent arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceManager.OnActivityResultListener_.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z", ref global::android.preference.PreferenceManager.OnActivityResultListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnActivityResultListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityResultListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityResultListener"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public OnActivityResultListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper.staticClass, global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnActivityResultListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityResultListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager_OnActivityResultListenerDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.preference.PreferenceManager.OnActivityStopListener.onActivityStop()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceManager.OnActivityStopListener_.staticClass, "onActivityStop", "()V", ref global::android.preference.PreferenceManager.OnActivityStopListener_._m0);
			}
			static OnActivityStopListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityStopListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager$OnActivityStopListener"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public OnActivityStopListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper.staticClass, global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnActivityStopListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.PreferenceManager.OnActivityStopListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceManager_OnActivityStopListenerDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.content.SharedPreferences getSharedPreferences()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences>(this, global::android.preference.PreferenceManager.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;", ref global::android.preference.PreferenceManager._m0) as android.content.SharedPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.preference.PreferenceScreen createPreferenceScreen(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.preference.PreferenceScreen>(this, global::android.preference.PreferenceManager.staticClass, "createPreferenceScreen", "(Landroid/content/Context;)Landroid/preference/PreferenceScreen;", ref global::android.preference.PreferenceManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.PreferenceScreen;
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getSharedPreferencesName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesName", "()Ljava/lang/String;", ref global::android.preference.PreferenceManager._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setSharedPreferencesName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesName", "(Ljava/lang/String;)V", ref global::android.preference.PreferenceManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getSharedPreferencesMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesMode", "()I", ref global::android.preference.PreferenceManager._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setSharedPreferencesMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesMode", "(I)V", ref global::android.preference.PreferenceManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.content.SharedPreferences getDefaultSharedPreferences(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceManager._m6.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceManager._m6 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "getDefaultSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallStaticObjectMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceManager.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", ref global::android.preference.PreferenceManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void setDefaultValues(android.content.Context arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceManager._m8.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceManager._m8 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;IZ)V");
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void setDefaultValues(android.content.Context arg0, java.lang.String arg1, int arg2, int arg3, bool arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceManager._m9.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceManager._m9 = @__env.GetStaticMethodIDNoThrow(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;Ljava/lang/String;IIZ)V");
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		}
		internal static void InitJNI()
		{
		}
	}
}
