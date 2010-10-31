namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RingtonePreference : android.preference.Preference, android.preference.PreferenceManager.OnActivityResultListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RingtonePreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onClick()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onClick", "()V", ref global::android.preference.RingtonePreference._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool onActivityResult(int arg0, int arg1, android.content.Intent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z", ref global::android.preference.RingtonePreference._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.RingtonePreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", ref global::android.preference.RingtonePreference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V", ref global::android.preference.RingtonePreference._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onAttachedToHierarchy(android.preference.PreferenceManager arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V", ref global::android.preference.RingtonePreference._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getRingtoneType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.RingtonePreference.staticClass, "getRingtoneType", "()I", ref global::android.preference.RingtonePreference._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setRingtoneType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "setRingtoneType", "(I)V", ref global::android.preference.RingtonePreference._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool getShowDefault()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, "getShowDefault", "()Z", ref global::android.preference.RingtonePreference._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setShowDefault(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "setShowDefault", "(Z)V", ref global::android.preference.RingtonePreference._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool getShowSilent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.RingtonePreference.staticClass, "getShowSilent", "()Z", ref global::android.preference.RingtonePreference._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setShowSilent(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "setShowSilent", "(Z)V", ref global::android.preference.RingtonePreference._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void onPrepareRingtonePickerIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V", ref global::android.preference.RingtonePreference._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void onSaveRingtone(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.RingtonePreference.staticClass, "onSaveRingtone", "(Landroid/net/Uri;)V", ref global::android.preference.RingtonePreference._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual global::android.net.Uri onRestoreRingtone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.RingtonePreference.staticClass, "onRestoreRingtone", "()Landroid/net/Uri;", ref global::android.preference.RingtonePreference._m13) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.RingtonePreference._m14.native == global::System.IntPtr.Zero)
				global::android.preference.RingtonePreference._m14 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public RingtonePreference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.RingtonePreference._m15.native == global::System.IntPtr.Zero)
				global::android.preference.RingtonePreference._m15 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.RingtonePreference._m16.native == global::System.IntPtr.Zero)
				global::android.preference.RingtonePreference._m16 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RingtonePreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.RingtonePreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/RingtonePreference"));
		}
	}
}
