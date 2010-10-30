namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.prefs.PreferenceChangeListener_))]
	public partial interface PreferenceChangeListener : EventListener
	{
		void preferenceChange(java.util.prefs.PreferenceChangeEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.PreferenceChangeListener))]
	internal sealed partial class PreferenceChangeListener_ : java.lang.Object, PreferenceChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreferenceChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _preferenceChange28186;
		void java.util.prefs.PreferenceChangeListener.preferenceChange(java.util.prefs.PreferenceChangeEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.PreferenceChangeListener_._preferenceChange28186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static PreferenceChangeListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.PreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/PreferenceChangeListener"));
			global::java.util.prefs.PreferenceChangeListener_._preferenceChange28186 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferenceChangeListener_.staticClass, "preferenceChange", "(Ljava/util/prefs/PreferenceChangeEvent;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
