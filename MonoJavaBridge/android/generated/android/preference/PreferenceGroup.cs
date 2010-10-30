namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.PreferenceGroup_))]
	public abstract partial class PreferenceGroup : android.preference.Preference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PreferenceGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _removeAll10414;
		public virtual void removeAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "removeAll", "()V", ref global::android.preference.PreferenceGroup._removeAll10414);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled10415;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "setEnabled", "(Z)V", ref global::android.preference.PreferenceGroup._setEnabled10415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState10416;
		protected virtual void dispatchSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.preference.PreferenceGroup._dispatchSaveInstanceState10416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState10417;
		protected virtual void dispatchRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.preference.PreferenceGroup._dispatchRestoreInstanceState10417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToActivity10418;
		protected override void onAttachedToActivity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "onAttachedToActivity", "()V", ref global::android.preference.PreferenceGroup._onAttachedToActivity10418);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareForRemoval10419;
		protected override void onPrepareForRemoval()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "onPrepareForRemoval", "()V", ref global::android.preference.PreferenceGroup._onPrepareForRemoval10419);
		}
		internal static global::MonoJavaBridge.MethodId _findPreference10420;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceGroup.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", ref global::android.preference.PreferenceGroup._findPreference10420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _isOnSameScreenAsChildren10421;
		protected virtual bool isOnSameScreenAsChildren()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "isOnSameScreenAsChildren", "()Z", ref global::android.preference.PreferenceGroup._isOnSameScreenAsChildren10421);
		}
		internal static global::MonoJavaBridge.MethodId _setOrderingAsAdded10422;
		public virtual void setOrderingAsAdded(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "setOrderingAsAdded", "(Z)V", ref global::android.preference.PreferenceGroup._setOrderingAsAdded10422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOrderingAsAdded10423;
		public virtual bool isOrderingAsAdded()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "isOrderingAsAdded", "()Z", ref global::android.preference.PreferenceGroup._isOrderingAsAdded10423);
		}
		internal static global::MonoJavaBridge.MethodId _addItemFromInflater10424;
		public virtual void addItemFromInflater(android.preference.Preference arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "addItemFromInflater", "(Landroid/preference/Preference;)V", ref global::android.preference.PreferenceGroup._addItemFromInflater10424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceCount10425;
		public virtual int getPreferenceCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.PreferenceGroup.staticClass, "getPreferenceCount", "()I", ref global::android.preference.PreferenceGroup._getPreferenceCount10425);
		}
		internal static global::MonoJavaBridge.MethodId _getPreference10426;
		public virtual global::android.preference.Preference getPreference(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceGroup.staticClass, "getPreference", "(I)Landroid/preference/Preference;", ref global::android.preference.PreferenceGroup._getPreference10426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.Preference;
		}
		internal static global::MonoJavaBridge.MethodId _addPreference10427;
		public virtual bool addPreference(android.preference.Preference arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "addPreference", "(Landroid/preference/Preference;)Z", ref global::android.preference.PreferenceGroup._addPreference10427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreference10428;
		public virtual bool removePreference(android.preference.Preference arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "removePreference", "(Landroid/preference/Preference;)Z", ref global::android.preference.PreferenceGroup._removePreference10428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareAddPreference10429;
		protected virtual bool onPrepareAddPreference(android.preference.Preference arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z", ref global::android.preference.PreferenceGroup._onPrepareAddPreference10429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceGroup10430;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceGroup._PreferenceGroup10430.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceGroup._PreferenceGroup10430 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup10430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceGroup10431;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceGroup._PreferenceGroup10431.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceGroup._PreferenceGroup10431 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup10431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PreferenceGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceGroup"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceGroup))]
	internal sealed partial class PreferenceGroup_ : android.preference.PreferenceGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreferenceGroup_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static PreferenceGroup_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceGroup_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceGroup"));
		}
		internal static void InitJNI()
		{
		}
	}
}
