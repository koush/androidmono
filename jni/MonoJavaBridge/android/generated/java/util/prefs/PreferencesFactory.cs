namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.prefs.PreferencesFactory_))]
	public interface PreferencesFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.prefs.Preferences userRoot();
		global::java.util.prefs.Preferences systemRoot();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.PreferencesFactory))]
	public sealed partial class PreferencesFactory_ : java.lang.Object, PreferencesFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreferencesFactory_()
		{
			InitJNI();
		}
		internal PreferencesFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _userRoot22279;
		 global::java.util.prefs.Preferences java.util.prefs.PreferencesFactory.userRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.PreferencesFactory_._userRoot22279)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.PreferencesFactory_.staticClass, global::java.util.prefs.PreferencesFactory_._userRoot22279)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemRoot22280;
		 global::java.util.prefs.Preferences java.util.prefs.PreferencesFactory.systemRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.PreferencesFactory_._systemRoot22280)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.PreferencesFactory_.staticClass, global::java.util.prefs.PreferencesFactory_._systemRoot22280)) as java.util.prefs.Preferences;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.PreferencesFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/PreferencesFactory"));
			global::java.util.prefs.PreferencesFactory_._userRoot22279 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferencesFactory_.staticClass, "userRoot", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.PreferencesFactory_._systemRoot22280 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferencesFactory_.staticClass, "systemRoot", "()Ljava/util/prefs/Preferences;");
		}
	}
}
