namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.PreferenceGroup_))]
	public abstract partial class PreferenceGroup : android.preference.Preference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PreferenceGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void removeAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "removeAll", "()V", ref global::android.preference.PreferenceGroup._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "setEnabled", "(Z)V", ref global::android.preference.PreferenceGroup._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void dispatchSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.preference.PreferenceGroup._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void dispatchRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.preference.PreferenceGroup._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onAttachedToActivity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "onAttachedToActivity", "()V", ref global::android.preference.PreferenceGroup._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onPrepareForRemoval()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "onPrepareForRemoval", "()V", ref global::android.preference.PreferenceGroup._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceGroup.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", ref global::android.preference.PreferenceGroup._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual bool isOnSameScreenAsChildren()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "isOnSameScreenAsChildren", "()Z", ref global::android.preference.PreferenceGroup._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setOrderingAsAdded(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "setOrderingAsAdded", "(Z)V", ref global::android.preference.PreferenceGroup._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isOrderingAsAdded()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "isOrderingAsAdded", "()Z", ref global::android.preference.PreferenceGroup._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void addItemFromInflater(android.preference.Preference arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceGroup.staticClass, "addItemFromInflater", "(Landroid/preference/Preference;)V", ref global::android.preference.PreferenceGroup._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getPreferenceCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.PreferenceGroup.staticClass, "getPreferenceCount", "()I", ref global::android.preference.PreferenceGroup._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.preference.Preference getPreference(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceGroup.staticClass, "getPreference", "(I)Landroid/preference/Preference;", ref global::android.preference.PreferenceGroup._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.Preference;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool addPreference(android.preference.Preference arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "addPreference", "(Landroid/preference/Preference;)Z", ref global::android.preference.PreferenceGroup._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool removePreference(android.preference.Preference arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "removePreference", "(Landroid/preference/Preference;)Z", ref global::android.preference.PreferenceGroup._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual bool onPrepareAddPreference(android.preference.Preference arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceGroup.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z", ref global::android.preference.PreferenceGroup._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceGroup._m16.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceGroup._m16 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.PreferenceGroup._m17.native == global::System.IntPtr.Zero)
				global::android.preference.PreferenceGroup._m17 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PreferenceGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceGroup"));
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
	}
}
