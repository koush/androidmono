namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.PreferenceActivity_))]
	public abstract partial class PreferenceActivity : android.app.ListActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PreferenceActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.preference.PreferenceActivity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onDestroy", "()V", ref global::android.preference.PreferenceActivity._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.preference.PreferenceActivity._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onNewIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V", ref global::android.preference.PreferenceActivity._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.preference.PreferenceActivity._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onStop", "()V", ref global::android.preference.PreferenceActivity._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onContentChanged", "()V", ref global::android.preference.PreferenceActivity._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onActivityResult(int arg0, int arg1, android.content.Intent arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V", ref global::android.preference.PreferenceActivity._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.preference.PreferenceManager getPreferenceManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceActivity.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;", ref global::android.preference.PreferenceActivity._m8) as android.preference.PreferenceManager;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceActivity.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", ref global::android.preference.PreferenceActivity._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setPreferenceScreen(android.preference.PreferenceScreen arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", ref global::android.preference.PreferenceActivity._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.preference.PreferenceScreen getPreferenceScreen()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.preference.PreferenceScreen>(this, global::android.preference.PreferenceActivity.staticClass, "getPreferenceScreen", "()Landroid/preference/PreferenceScreen;", ref global::android.preference.PreferenceActivity._m11) as android.preference.PreferenceScreen;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void addPreferencesFromIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromIntent", "(Landroid/content/Intent;)V", ref global::android.preference.PreferenceActivity._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void addPreferencesFromResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromResource", "(I)V", ref global::android.preference.PreferenceActivity._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool onPreferenceTreeClick(android.preference.PreferenceScreen arg0, android.preference.Preference arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceActivity.staticClass, "onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z", ref global::android.preference.PreferenceActivity._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public PreferenceActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceActivity._m15.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceActivity._m15 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._m15);
			Init(@__env, handle);
		}
		static PreferenceActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceActivity"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceActivity))]
	internal sealed partial class PreferenceActivity_ : android.preference.PreferenceActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreferenceActivity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static PreferenceActivity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceActivity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceActivity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
