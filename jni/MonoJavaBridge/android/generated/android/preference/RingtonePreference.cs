namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RingtonePreference : android.preference.Preference, android.preference.PreferenceManager.OnActivityResultListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RingtonePreference()
		{
			InitJNI();
		}
		protected RingtonePreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick10403;
		protected override void onClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onClick10403);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onClick10403);
		}
		internal static global::MonoJavaBridge.MethodId _onActivityResult10404;
		public virtual bool onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference._onActivityResult10404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onActivityResult10404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10405;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference._onGetDefaultValue10405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onGetDefaultValue10405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10406;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onSetInitialValue10406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onSetInitialValue10406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToHierarchy10407;
		protected override void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onAttachedToHierarchy10407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onAttachedToHierarchy10407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRingtoneType10408;
		public virtual int getRingtoneType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.RingtonePreference._getRingtoneType10408);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getRingtoneType10408);
		}
		internal static global::MonoJavaBridge.MethodId _setRingtoneType10409;
		public virtual void setRingtoneType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._setRingtoneType10409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setRingtoneType10409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getShowDefault10410;
		public virtual bool getShowDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference._getShowDefault10410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getShowDefault10410);
		}
		internal static global::MonoJavaBridge.MethodId _setShowDefault10411;
		public virtual void setShowDefault(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._setShowDefault10411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setShowDefault10411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getShowSilent10412;
		public virtual bool getShowSilent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference._getShowSilent10412);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getShowSilent10412);
		}
		internal static global::MonoJavaBridge.MethodId _setShowSilent10413;
		public virtual void setShowSilent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._setShowSilent10413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setShowSilent10413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareRingtonePickerIntent10414;
		protected virtual void onPrepareRingtonePickerIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent10414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent10414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveRingtone10415;
		protected virtual void onSaveRingtone(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onSaveRingtone10415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onSaveRingtone10415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreRingtone10416;
		protected virtual global::android.net.Uri onRestoreRingtone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference._onRestoreRingtone10416)) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onRestoreRingtone10416)) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference10417;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference10417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference10418;
		public RingtonePreference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference10418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference10419;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference10419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.RingtonePreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/RingtonePreference"));
			global::android.preference.RingtonePreference._onClick10403 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onClick", "()V");
			global::android.preference.RingtonePreference._onActivityResult10404 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z");
			global::android.preference.RingtonePreference._onGetDefaultValue10405 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.RingtonePreference._onSetInitialValue10406 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.RingtonePreference._onAttachedToHierarchy10407 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V");
			global::android.preference.RingtonePreference._getRingtoneType10408 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "getRingtoneType", "()I");
			global::android.preference.RingtonePreference._setRingtoneType10409 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "setRingtoneType", "(I)V");
			global::android.preference.RingtonePreference._getShowDefault10410 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "getShowDefault", "()Z");
			global::android.preference.RingtonePreference._setShowDefault10411 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "setShowDefault", "(Z)V");
			global::android.preference.RingtonePreference._getShowSilent10412 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "getShowSilent", "()Z");
			global::android.preference.RingtonePreference._setShowSilent10413 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "setShowSilent", "(Z)V");
			global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent10414 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V");
			global::android.preference.RingtonePreference._onSaveRingtone10415 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onSaveRingtone", "(Landroid/net/Uri;)V");
			global::android.preference.RingtonePreference._onRestoreRingtone10416 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onRestoreRingtone", "()Landroid/net/Uri;");
			global::android.preference.RingtonePreference._RingtonePreference10417 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.RingtonePreference._RingtonePreference10418 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.RingtonePreference._RingtonePreference10419 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
