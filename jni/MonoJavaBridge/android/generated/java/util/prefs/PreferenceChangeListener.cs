namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.prefs.PreferenceChangeListener_))]
	public partial interface PreferenceChangeListener : EventListener
	{
		void preferenceChange(java.util.prefs.PreferenceChangeEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.PreferenceChangeListener))]
	public sealed partial class PreferenceChangeListener_ : java.lang.Object, PreferenceChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreferenceChangeListener_()
		{
			InitJNI();
		}
		internal PreferenceChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _preferenceChange28067;
		 void java.util.prefs.PreferenceChangeListener.preferenceChange(java.util.prefs.PreferenceChangeEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.PreferenceChangeListener_._preferenceChange28067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.PreferenceChangeListener_.staticClass, global::java.util.prefs.PreferenceChangeListener_._preferenceChange28067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.PreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/PreferenceChangeListener"));
			global::java.util.prefs.PreferenceChangeListener_._preferenceChange28067 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferenceChangeListener_.staticClass, "preferenceChange", "(Ljava/util/prefs/PreferenceChangeEvent;)V");
		}
	}
}
