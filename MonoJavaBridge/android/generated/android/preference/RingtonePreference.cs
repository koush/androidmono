namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RingtonePreference : android.preference.Preference, android.preference.PreferenceManager.OnActivityResultListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RingtonePreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick10455;
		protected override void onClick()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onClick", "()V", ref global::android.preference.RingtonePreference._onClick10455);
		}
		internal static global::MonoJavaBridge.MethodId _onActivityResult10456;
		public virtual bool onActivityResult(int arg0, int arg1, android.content.Intent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z", ref global::android.preference.RingtonePreference._onActivityResult10456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10457;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.RingtonePreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", ref global::android.preference.RingtonePreference._onGetDefaultValue10457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10458;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V", ref global::android.preference.RingtonePreference._onSetInitialValue10458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToHierarchy10459;
		protected override void onAttachedToHierarchy(android.preference.PreferenceManager arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V", ref global::android.preference.RingtonePreference._onAttachedToHierarchy10459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RingtoneType
		{
			get
			{
				return getRingtoneType();
			}
			set
			{
				setRingtoneType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRingtoneType10460;
		public virtual int getRingtoneType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.RingtonePreference.staticClass, "getRingtoneType", "()I", ref global::android.preference.RingtonePreference._getRingtoneType10460);
		}
		internal static global::MonoJavaBridge.MethodId _setRingtoneType10461;
		public virtual void setRingtoneType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "setRingtoneType", "(I)V", ref global::android.preference.RingtonePreference._setRingtoneType10461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ShowDefault
		{
			get
			{
				return getShowDefault();
			}
			set
			{
				setShowDefault(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShowDefault10462;
		public virtual bool getShowDefault()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, "getShowDefault", "()Z", ref global::android.preference.RingtonePreference._getShowDefault10462);
		}
		internal static global::MonoJavaBridge.MethodId _setShowDefault10463;
		public virtual void setShowDefault(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "setShowDefault", "(Z)V", ref global::android.preference.RingtonePreference._setShowDefault10463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ShowSilent
		{
			get
			{
				return getShowSilent();
			}
			set
			{
				setShowSilent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShowSilent10464;
		public virtual bool getShowSilent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, "getShowSilent", "()Z", ref global::android.preference.RingtonePreference._getShowSilent10464);
		}
		internal static global::MonoJavaBridge.MethodId _setShowSilent10465;
		public virtual void setShowSilent(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "setShowSilent", "(Z)V", ref global::android.preference.RingtonePreference._setShowSilent10465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareRingtonePickerIntent10466;
		protected virtual void onPrepareRingtonePickerIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V", ref global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent10466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveRingtone10467;
		protected virtual void onSaveRingtone(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onSaveRingtone", "(Landroid/net/Uri;)V", ref global::android.preference.RingtonePreference._onSaveRingtone10467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreRingtone10468;
		protected virtual global::android.net.Uri onRestoreRingtone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.RingtonePreference.staticClass, "onRestoreRingtone", "()Landroid/net/Uri;", ref global::android.preference.RingtonePreference._onRestoreRingtone10468) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference10469;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.RingtonePreference._RingtonePreference10469.native == global::System.IntPtr.Zero)
				global::android.preference.RingtonePreference._RingtonePreference10469 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference10469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference10470;
		public RingtonePreference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.RingtonePreference._RingtonePreference10470.native == global::System.IntPtr.Zero)
				global::android.preference.RingtonePreference._RingtonePreference10470 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference10470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference10471;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.RingtonePreference._RingtonePreference10471.native == global::System.IntPtr.Zero)
				global::android.preference.RingtonePreference._RingtonePreference10471 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference10471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RingtonePreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.RingtonePreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/RingtonePreference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
