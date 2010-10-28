namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PreferenceCategory : android.preference.PreferenceGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PreferenceCategory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled10409;
		public override bool isEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory._isEnabled10409);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._isEnabled10409);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareAddPreference10410;
		protected override bool onPrepareAddPreference(android.preference.Preference arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory._onPrepareAddPreference10410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._onPrepareAddPreference10410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceCategory10411;
		public PreferenceCategory(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory10411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceCategory10412;
		public PreferenceCategory(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory10412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceCategory10413;
		public PreferenceCategory(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory10413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PreferenceCategory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceCategory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceCategory"));
			global::android.preference.PreferenceCategory._isEnabled10409 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "isEnabled", "()Z");
			global::android.preference.PreferenceCategory._onPrepareAddPreference10410 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceCategory._PreferenceCategory10411 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.PreferenceCategory._PreferenceCategory10412 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.PreferenceCategory._PreferenceCategory10413 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
