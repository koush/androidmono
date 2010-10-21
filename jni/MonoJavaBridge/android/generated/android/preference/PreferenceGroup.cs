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
		internal static global::MonoJavaBridge.MethodId _removeAll10365;
		public virtual void removeAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._removeAll10365);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removeAll10365);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled10366;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._setEnabled10366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setEnabled10366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState10367;
		protected virtual void dispatchSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._dispatchSaveInstanceState10367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchSaveInstanceState10367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState10368;
		protected virtual void dispatchRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState10368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._dispatchRestoreInstanceState10368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToActivity10369;
		protected override void onAttachedToActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._onAttachedToActivity10369);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onAttachedToActivity10369);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareForRemoval10370;
		protected override void onPrepareForRemoval() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._onPrepareForRemoval10370);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareForRemoval10370);
		}
		internal static global::MonoJavaBridge.MethodId _findPreference10371;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup._findPreference10371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._findPreference10371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _isOnSameScreenAsChildren10372;
		protected virtual bool isOnSameScreenAsChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren10372);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOnSameScreenAsChildren10372);
		}
		internal static global::MonoJavaBridge.MethodId _setOrderingAsAdded10373;
		public virtual void setOrderingAsAdded(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._setOrderingAsAdded10373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._setOrderingAsAdded10373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOrderingAsAdded10374;
		public virtual bool isOrderingAsAdded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._isOrderingAsAdded10374);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._isOrderingAsAdded10374);
		}
		internal static global::MonoJavaBridge.MethodId _addItemFromInflater10375;
		public virtual void addItemFromInflater(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup._addItemFromInflater10375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addItemFromInflater10375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceCount10376;
		public virtual int getPreferenceCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.PreferenceGroup._getPreferenceCount10376);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreferenceCount10376);
		}
		internal static global::MonoJavaBridge.MethodId _getPreference10377;
		public virtual global::android.preference.Preference getPreference(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup._getPreference10377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._getPreference10377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		internal static global::MonoJavaBridge.MethodId _addPreference10378;
		public virtual bool addPreference(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._addPreference10378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._addPreference10378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreference10379;
		public virtual bool removePreference(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._removePreference10379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._removePreference10379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareAddPreference10380;
		protected virtual bool onPrepareAddPreference(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup._onPrepareAddPreference10380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._onPrepareAddPreference10380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceGroup10381;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup10381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceGroup10382;
		public PreferenceGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceGroup.staticClass, global::android.preference.PreferenceGroup._PreferenceGroup10382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceGroup"));
			global::android.preference.PreferenceGroup._removeAll10365 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "removeAll", "()V");
			global::android.preference.PreferenceGroup._setEnabled10366 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "setEnabled", "(Z)V");
			global::android.preference.PreferenceGroup._dispatchSaveInstanceState10367 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceGroup._dispatchRestoreInstanceState10368 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceGroup._onAttachedToActivity10369 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.PreferenceGroup._onPrepareForRemoval10370 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.PreferenceGroup._findPreference10371 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;");
			global::android.preference.PreferenceGroup._isOnSameScreenAsChildren10372 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "isOnSameScreenAsChildren", "()Z");
			global::android.preference.PreferenceGroup._setOrderingAsAdded10373 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "setOrderingAsAdded", "(Z)V");
			global::android.preference.PreferenceGroup._isOrderingAsAdded10374 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "isOrderingAsAdded", "()Z");
			global::android.preference.PreferenceGroup._addItemFromInflater10375 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "addItemFromInflater", "(Landroid/preference/Preference;)V");
			global::android.preference.PreferenceGroup._getPreferenceCount10376 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "getPreferenceCount", "()I");
			global::android.preference.PreferenceGroup._getPreference10377 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "getPreference", "(I)Landroid/preference/Preference;");
			global::android.preference.PreferenceGroup._addPreference10378 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "addPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._removePreference10379 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "removePreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._onPrepareAddPreference10380 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceGroup._PreferenceGroup10381 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.PreferenceGroup._PreferenceGroup10382 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
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
