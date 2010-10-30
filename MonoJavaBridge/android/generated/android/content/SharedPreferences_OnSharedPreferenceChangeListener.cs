namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_))]
	public partial interface SharedPreferences_OnSharedPreferenceChangeListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onSharedPreferenceChanged(android.content.SharedPreferences arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SharedPreferences_OnSharedPreferenceChangeListener))]
	internal sealed partial class SharedPreferences_OnSharedPreferenceChangeListener_ : java.lang.Object, SharedPreferences_OnSharedPreferenceChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SharedPreferences_OnSharedPreferenceChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onSharedPreferenceChanged3520;
		void android.content.SharedPreferences_OnSharedPreferenceChangeListener.onSharedPreferenceChanged(android.content.SharedPreferences arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_._onSharedPreferenceChanged3520.native == global::System.IntPtr.Zero)
				global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_._onSharedPreferenceChanged3520 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_.staticClass, "onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_._onSharedPreferenceChanged3520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SharedPreferences_OnSharedPreferenceChangeListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences$OnSharedPreferenceChangeListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void SharedPreferences_OnSharedPreferenceChangeListenerDelegate(android.content.SharedPreferences arg0, java.lang.String arg1);

	internal partial class SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper : java.lang.Object, SharedPreferences_OnSharedPreferenceChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper3521;
		public SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper._SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper3521.native == global::System.IntPtr.Zero)
				global::android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper._SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper3521 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper.staticClass, global::android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper._SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper3521);
			Init(@__env, handle);
		}
		static SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper
	{
		private SharedPreferences_OnSharedPreferenceChangeListenerDelegate myDelegate;
		public void onSharedPreferenceChanged(android.content.SharedPreferences arg0, java.lang.String arg1)
		{
			myDelegate(arg0, arg1);
		}
		public static implicit operator SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper(SharedPreferences_OnSharedPreferenceChangeListenerDelegate d)
		{
			global::android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper ret = new global::android.content.SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
