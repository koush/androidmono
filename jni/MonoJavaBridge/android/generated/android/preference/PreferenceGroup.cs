namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.PreferenceGroup_))]
	public abstract partial class PreferenceGroup : android.preference.Preference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreferenceGroup()
		{
			InitJNI();
		}
		protected PreferenceGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _removeAll6930;
		public virtual void removeAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._removeAll6930);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removeAll6930);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled6931;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._setEnabled6931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setEnabled6931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState6932;
		protected virtual void dispatchSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._dispatchSaveInstanceState6932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchSaveInstanceState6932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState6933;
		protected virtual void dispatchRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToActivity6934;
		protected override void onAttachedToActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._onAttachedToActivity6934);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onAttachedToActivity6934);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareForRemoval6935;
		protected override void onPrepareForRemoval() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._onPrepareForRemoval6935);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareForRemoval6935);
		}
		internal static global::MonoJavaBridge.MethodId _findPreference6936;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup._findPreference6936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._findPreference6936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _isOnSameScreenAsChildren6937;
		protected virtual bool isOnSameScreenAsChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6937);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6937);
		}
		internal static global::MonoJavaBridge.MethodId _setOrderingAsAdded6938;
		public virtual void setOrderingAsAdded(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._setOrderingAsAdded6938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setOrderingAsAdded6938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOrderingAsAdded6939;
		public virtual bool isOrderingAsAdded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._isOrderingAsAdded6939);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOrderingAsAdded6939);
		}
		internal static global::MonoJavaBridge.MethodId _addItemFromInflater6940;
		public virtual void addItemFromInflater(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._addItemFromInflater6940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addItemFromInflater6940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceCount6941;
		public virtual int getPreferenceCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.PreferenceGroup._getPreferenceCount6941);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreferenceCount6941);
		}
		internal static global::MonoJavaBridge.MethodId _getPreference6942;
		public virtual global::android.preference.Preference getPreference(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup._getPreference6942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreference6942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		internal static global::MonoJavaBridge.MethodId _addPreference6943;
		public virtual bool addPreference(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._addPreference6943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addPreference6943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreference6944;
		public virtual bool removePreference(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._removePreference6944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removePreference6944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareAddPreference6945;
		protected virtual bool onPrepareAddPreference(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._onPrepareAddPreference6945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareAddPreference6945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceGroup6946;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup6946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceGroup6947;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup6947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceGroup"));
			global::android.preference.PreferenceGroup._removeAll6930 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "removeAll", "()V");
			global::android.preference.PreferenceGroup._setEnabled6931 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "setEnabled", "(Z)V");
			global::android.preference.PreferenceGroup._dispatchSaveInstanceState6932 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceGroup._dispatchRestoreInstanceState6933 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceGroup._onAttachedToActivity6934 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.PreferenceGroup._onPrepareForRemoval6935 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.PreferenceGroup._findPreference6936 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;");
			global::android.preference.PreferenceGroup._isOnSameScreenAsChildren6937 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "isOnSameScreenAsChildren", "()Z");
			global::android.preference.PreferenceGroup._setOrderingAsAdded6938 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "setOrderingAsAdded", "(Z)V");
			global::android.preference.PreferenceGroup._isOrderingAsAdded6939 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "isOrderingAsAdded", "()Z");
			global::android.preference.PreferenceGroup._addItemFromInflater6940 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "addItemFromInflater", "(Landroid/preference/Preference;)V");
			global::android.preference.PreferenceGroup._getPreferenceCount6941 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "getPreferenceCount", "()I");
			global::android.preference.PreferenceGroup._getPreference6942 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "getPreference", "(I)Landroid/preference/Preference;");
			global::android.preference.PreferenceGroup._addPreference6943 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "addPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._removePreference6944 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "removePreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._onPrepareAddPreference6945 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._PreferenceGroup6946 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.PreferenceGroup._PreferenceGroup6947 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceGroup))]
	public sealed partial class PreferenceGroup_ : android.preference.PreferenceGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreferenceGroup_()
		{
			InitJNI();
		}
		internal PreferenceGroup_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceGroup_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceGroup"));
		}
	}
}
