namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_))]
	public partial interface SharedPreferences_OnSharedPreferenceChangeListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onSharedPreferenceChanged(android.content.SharedPreferences arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SharedPreferences_OnSharedPreferenceChangeListener))]
	public sealed partial class SharedPreferences_OnSharedPreferenceChangeListener_ : java.lang.Object, SharedPreferences_OnSharedPreferenceChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SharedPreferences_OnSharedPreferenceChangeListener_()
		{
			InitJNI();
		}
		internal SharedPreferences_OnSharedPreferenceChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onSharedPreferenceChanged3505;
		 void android.content.SharedPreferences_OnSharedPreferenceChangeListener.onSharedPreferenceChanged(android.content.SharedPreferences arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_._onSharedPreferenceChanged3505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_.staticClass, global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_._onSharedPreferenceChanged3505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences_OnSharedPreferenceChangeListener"));
			global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_._onSharedPreferenceChanged3505 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_OnSharedPreferenceChangeListener_.staticClass, "onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V");
		}
	}
}
