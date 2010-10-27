namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Preference : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Preference()
		{
			InitJNI();
		}
		protected Preference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BaseSavedState()
			{
				InitJNI();
			}
			protected BaseSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState10311;
			public BaseSavedState(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState10311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState10312;
			public BaseSavedState(android.os.Parcelable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState10312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR10313;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.preference.Preference.BaseSavedState.staticClass, _CREATOR10313)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$BaseSavedState"));
				global::android.preference.Preference.BaseSavedState._BaseSavedState10311 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.preference.Preference.BaseSavedState._BaseSavedState10312 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
				global::android.preference.Preference.BaseSavedState._CREATOR10313 = @__env.GetStaticFieldIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.Preference.OnPreferenceChangeListener_))]
		public partial interface OnPreferenceChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.Preference.OnPreferenceChangeListener))]
		internal sealed partial class OnPreferenceChangeListener_ : java.lang.Object, OnPreferenceChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreferenceChangeListener_()
			{
				InitJNI();
			}
			internal OnPreferenceChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPreferenceChange10314;
			bool android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange10314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceChangeListener_.staticClass, global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange10314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceChangeListener"));
				global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange10314 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceChangeListener_.staticClass, "onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z");
			}
		}

		public delegate bool OnPreferenceChangeListenerDelegate(android.preference.Preference arg0, java.lang.Object arg1);

		internal partial class OnPreferenceChangeListenerDelegateWrapper : java.lang.Object, OnPreferenceChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreferenceChangeListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnPreferenceChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnPreferenceChangeListenerDelegateWrapper10315;
			public OnPreferenceChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper.staticClass, global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper._OnPreferenceChangeListenerDelegateWrapper10315);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference_OnPreferenceChangeListenerDelegateWrapper"));
				global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper._OnPreferenceChangeListenerDelegateWrapper10315 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnPreferenceChangeListenerDelegateWrapper
		{
			private OnPreferenceChangeListenerDelegate myDelegate;
			public bool onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1)
			{
				return myDelegate(arg0, arg1);
			}
			public static implicit operator OnPreferenceChangeListenerDelegateWrapper(OnPreferenceChangeListenerDelegate d)
			{
				global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper ret = new global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.Preference.OnPreferenceClickListener_))]
		public partial interface OnPreferenceClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onPreferenceClick(android.preference.Preference arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.Preference.OnPreferenceClickListener))]
		internal sealed partial class OnPreferenceClickListener_ : java.lang.Object, OnPreferenceClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreferenceClickListener_()
			{
				InitJNI();
			}
			internal OnPreferenceClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPreferenceClick10316;
			bool android.preference.Preference.OnPreferenceClickListener.onPreferenceClick(android.preference.Preference arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick10316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceClickListener_.staticClass, global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick10316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceClickListener"));
				global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick10316 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceClickListener_.staticClass, "onPreferenceClick", "(Landroid/preference/Preference;)Z");
			}
		}

		public delegate bool OnPreferenceClickListenerDelegate(android.preference.Preference arg0);

		internal partial class OnPreferenceClickListenerDelegateWrapper : java.lang.Object, OnPreferenceClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreferenceClickListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnPreferenceClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnPreferenceClickListenerDelegateWrapper10317;
			public OnPreferenceClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.OnPreferenceClickListenerDelegateWrapper.staticClass, global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper._OnPreferenceClickListenerDelegateWrapper10317);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference_OnPreferenceClickListenerDelegateWrapper"));
				global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper._OnPreferenceClickListenerDelegateWrapper10317 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnPreferenceClickListenerDelegateWrapper
		{
			private OnPreferenceClickListenerDelegate myDelegate;
			public bool onPreferenceClick(android.preference.Preference arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator OnPreferenceClickListenerDelegateWrapper(OnPreferenceClickListenerDelegate d)
			{
				global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper ret = new global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString10318;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._toString10318)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._toString10318)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo10319;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._compareTo10319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo10319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo10320;
		public virtual int compareTo(android.preference.Preference arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._compareTo10320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo10320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
			set
			{
				setKey(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKey10321;
		public virtual global::java.lang.String getKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getKey10321)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getKey10321)) as java.lang.String;
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext10322;
		public virtual global::android.content.Context getContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getContext10322)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getContext10322)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setKey10323;
		public virtual void setKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setKey10323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setKey10323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onClick10324;
		protected virtual void onClick()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onClick10324);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onClick10324);
		}
		public new global::android.content.SharedPreferences SharedPreferences
		{
			get
			{
				return getSharedPreferences();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences10325;
		public virtual global::android.content.SharedPreferences getSharedPreferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getSharedPreferences10325)) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSharedPreferences10325)) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled10326;
		public virtual bool isEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isEnabled10326);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isEnabled10326);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled10327;
		public virtual void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setEnabled10327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setEnabled10327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Intent Intent
		{
			get
			{
				return getIntent();
			}
			set
			{
				setIntent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntent10328;
		public virtual global::android.content.Intent getIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getIntent10328)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getIntent10328)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setIntent10329;
		public virtual void setIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setIntent10329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setIntent10329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10330;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onRestoreInstanceState10330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onRestoreInstanceState10330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10331;
		protected virtual global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onSaveInstanceState10331)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSaveInstanceState10331)) as android.os.Parcelable;
		}
		public new bool Persistent
		{
			set
			{
				setPersistent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPersistent10332;
		public virtual void setPersistent(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setPersistent10332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setPersistent10332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent10333;
		public virtual bool isPersistent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isPersistent10333);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isPersistent10333);
		}
		internal static global::MonoJavaBridge.MethodId _setTitle10334;
		public virtual void setTitle(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setTitle10334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle10334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle10335;
		public virtual void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setTitle10335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle10335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string Title
		{
			get
			{
				return getTitle().toString();
			}
			set
			{
				setTitle((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle10336;
		public virtual global::java.lang.CharSequence getTitle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getTitle10336)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getTitle10336)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView10337;
		protected virtual global::android.view.View onCreateView(android.view.ViewGroup arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onCreateView10337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onCreateView10337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState10338;
		public virtual void saveHierarchyState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._saveHierarchyState10338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._saveHierarchyState10338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState10339;
		public virtual void restoreHierarchyState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._restoreHierarchyState10339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._restoreHierarchyState10339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Order
		{
			get
			{
				return getOrder();
			}
			set
			{
				setOrder(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOrder10340;
		public virtual int getOrder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getOrder10340);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOrder10340);
		}
		internal static global::MonoJavaBridge.MethodId _getView10341;
		public virtual global::android.view.View getView(android.view.View arg0, android.view.ViewGroup arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getView10341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getView10341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isSelectable10342;
		public virtual bool isSelectable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isSelectable10342);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isSelectable10342);
		}
		internal static global::MonoJavaBridge.MethodId _setOrder10343;
		public virtual void setOrder(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOrder10343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOrder10343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyChanged10344;
		protected virtual void notifyChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyChanged10344);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyChanged10344);
		}
		internal static global::MonoJavaBridge.MethodId _onBindView10345;
		protected virtual void onBindView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onBindView10345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onBindView10345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents10346;
		public virtual bool shouldDisableDependents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldDisableDependents10346);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldDisableDependents10346);
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10347;
		protected virtual global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onGetDefaultValue10347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onGetDefaultValue10347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10348;
		protected virtual void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onSetInitialValue10348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSetInitialValue10348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutResource10349;
		public virtual void setLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setLayoutResource10349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setLayoutResource10349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int LayoutResource
		{
			get
			{
				return getLayoutResource();
			}
			set
			{
				setLayoutResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutResource10350;
		public virtual int getLayoutResource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getLayoutResource10350);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getLayoutResource10350);
		}
		internal static global::MonoJavaBridge.MethodId _setWidgetLayoutResource10351;
		public virtual void setWidgetLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setWidgetLayoutResource10351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setWidgetLayoutResource10351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WidgetLayoutResource
		{
			get
			{
				return getWidgetLayoutResource();
			}
			set
			{
				setWidgetLayoutResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidgetLayoutResource10352;
		public virtual int getWidgetLayoutResource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getWidgetLayoutResource10352);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getWidgetLayoutResource10352);
		}
		public new string Summary
		{
			get
			{
				return getSummary().toString();
			}
			set
			{
				setSummary((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSummary10353;
		public virtual global::java.lang.CharSequence getSummary()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getSummary10353)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSummary10353)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setSummary10354;
		public virtual void setSummary(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSummary10354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary10354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSummary10355;
		public virtual void setSummary(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSummary10355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary10355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setSummary(string arg0)
		{
			setSummary((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new bool Selectable
		{
			set
			{
				setSelectable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelectable10356;
		public virtual void setSelectable(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSelectable10356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSelectable10356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShouldDisableView10357;
		public virtual void setShouldDisableView(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setShouldDisableView10357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setShouldDisableView10357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ShouldDisableView
		{
			get
			{
				return getShouldDisableView();
			}
			set
			{
				setShouldDisableView(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShouldDisableView10358;
		public virtual bool getShouldDisableView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._getShouldDisableView10358);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getShouldDisableView10358);
		}
		internal static global::MonoJavaBridge.MethodId _hasKey10359;
		public virtual bool hasKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._hasKey10359);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._hasKey10359);
		}
		internal static global::MonoJavaBridge.MethodId _shouldPersist10360;
		protected virtual bool shouldPersist()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldPersist10360);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldPersist10360);
		}
		internal static global::MonoJavaBridge.MethodId _callChangeListener10361;
		protected virtual bool callChangeListener(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._callChangeListener10361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._callChangeListener10361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreferenceChangeListener10362;
		public virtual void setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOnPreferenceChangeListener10362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceChangeListener10362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnPreferenceChangeListener(global::android.preference.Preference.OnPreferenceChangeListenerDelegate arg0)
		{
			setOnPreferenceChangeListener((global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getOnPreferenceChangeListener10363;
		public virtual global::android.preference.Preference.OnPreferenceChangeListener getOnPreferenceChangeListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getOnPreferenceChangeListener10363)) as android.preference.Preference.OnPreferenceChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceChangeListener10363)) as android.preference.Preference.OnPreferenceChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreferenceClickListener10364;
		public virtual void setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOnPreferenceClickListener10364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceClickListener10364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnPreferenceClickListener(global::android.preference.Preference.OnPreferenceClickListenerDelegate arg0)
		{
			setOnPreferenceClickListener((global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getOnPreferenceClickListener10365;
		public virtual global::android.preference.Preference.OnPreferenceClickListener getOnPreferenceClickListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getOnPreferenceClickListener10365)) as android.preference.Preference.OnPreferenceClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceClickListener10365)) as android.preference.Preference.OnPreferenceClickListener;
		}
		public new global::android.content.SharedPreferences_Editor Editor
		{
			get
			{
				return getEditor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditor10366;
		public virtual global::android.content.SharedPreferences_Editor getEditor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getEditor10366)) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getEditor10366)) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _shouldCommit10367;
		public virtual bool shouldCommit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldCommit10367);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldCommit10367);
		}
		internal static global::MonoJavaBridge.MethodId _notifyHierarchyChanged10368;
		protected virtual void notifyHierarchyChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyHierarchyChanged10368);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyHierarchyChanged10368);
		}
		public new global::android.preference.PreferenceManager PreferenceManager
		{
			get
			{
				return getPreferenceManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceManager10369;
		public virtual global::android.preference.PreferenceManager getPreferenceManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getPreferenceManager10369)) as android.preference.PreferenceManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPreferenceManager10369)) as android.preference.PreferenceManager;
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToHierarchy10370;
		protected virtual void onAttachedToHierarchy(android.preference.PreferenceManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onAttachedToHierarchy10370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToHierarchy10370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToActivity10371;
		protected virtual void onAttachedToActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onAttachedToActivity10371);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToActivity10371);
		}
		internal static global::MonoJavaBridge.MethodId _findPreferenceInHierarchy10372;
		protected virtual global::android.preference.Preference findPreferenceInHierarchy(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._findPreferenceInHierarchy10372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._findPreferenceInHierarchy10372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDependencyChange10373;
		public virtual void notifyDependencyChange(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyDependencyChange10373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyDependencyChange10373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDependencyChanged10374;
		public virtual void onDependencyChanged(android.preference.Preference arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onDependencyChanged10374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onDependencyChanged10374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDependency10375;
		public virtual void setDependency(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setDependency10375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDependency10375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Dependency
		{
			get
			{
				return getDependency();
			}
			set
			{
				setDependency(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDependency10376;
		public virtual global::java.lang.String getDependency()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getDependency10376)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getDependency10376)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareForRemoval10377;
		protected virtual void onPrepareForRemoval()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onPrepareForRemoval10377);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onPrepareForRemoval10377);
		}
		public new global::java.lang.Object DefaultValue
		{
			set
			{
				setDefaultValue(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultValue10378;
		public virtual void setDefaultValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setDefaultValue10378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDefaultValue10378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistString10379;
		protected virtual bool persistString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistString10379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistString10379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedString10380;
		protected virtual global::java.lang.String getPersistedString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getPersistedString10380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedString10380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _persistInt10381;
		protected virtual bool persistInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistInt10381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistInt10381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedInt10382;
		protected virtual int getPersistedInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getPersistedInt10382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedInt10382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistFloat10383;
		protected virtual bool persistFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistFloat10383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistFloat10383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedFloat10384;
		protected virtual float getPersistedFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.preference.Preference._getPersistedFloat10384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedFloat10384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistLong10385;
		protected virtual bool persistLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistLong10385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistLong10385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedLong10386;
		protected virtual long getPersistedLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.preference.Preference._getPersistedLong10386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedLong10386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistBoolean10387;
		protected virtual bool persistBoolean(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistBoolean10387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistBoolean10387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedBoolean10388;
		protected virtual bool getPersistedBoolean(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._getPersistedBoolean10388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedBoolean10388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Preference10389;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference10389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Preference10390;
		public Preference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference10390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Preference10391;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference10391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int DEFAULT_ORDER
		{
			get
			{
				return 2147483647;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.Preference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference"));
			global::android.preference.Preference._toString10318 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "toString", "()Ljava/lang/String;");
			global::android.preference.Preference._compareTo10319 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.preference.Preference._compareTo10320 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "compareTo", "(Landroid/preference/Preference;)I");
			global::android.preference.Preference._getKey10321 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.preference.Preference._getContext10322 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.preference.Preference._setKey10323 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setKey", "(Ljava/lang/String;)V");
			global::android.preference.Preference._onClick10324 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onClick", "()V");
			global::android.preference.Preference._getSharedPreferences10325 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;");
			global::android.preference.Preference._isEnabled10326 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isEnabled", "()Z");
			global::android.preference.Preference._setEnabled10327 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setEnabled", "(Z)V");
			global::android.preference.Preference._getIntent10328 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.preference.Preference._setIntent10329 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.preference.Preference._onRestoreInstanceState10330 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.Preference._onSaveInstanceState10331 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.Preference._setPersistent10332 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setPersistent", "(Z)V");
			global::android.preference.Preference._isPersistent10333 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isPersistent", "()Z");
			global::android.preference.Preference._setTitle10334 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setTitle", "(I)V");
			global::android.preference.Preference._setTitle10335 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._getTitle10336 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._onCreateView10337 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._saveHierarchyState10338 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "saveHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._restoreHierarchyState10339 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._getOrder10340 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOrder", "()I");
			global::android.preference.Preference._getView10341 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._isSelectable10342 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isSelectable", "()Z");
			global::android.preference.Preference._setOrder10343 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOrder", "(I)V");
			global::android.preference.Preference._notifyChanged10344 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyChanged", "()V");
			global::android.preference.Preference._onBindView10345 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.Preference._shouldDisableDependents10346 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.Preference._onGetDefaultValue10347 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.Preference._onSetInitialValue10348 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.Preference._setLayoutResource10349 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setLayoutResource", "(I)V");
			global::android.preference.Preference._getLayoutResource10350 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getLayoutResource", "()I");
			global::android.preference.Preference._setWidgetLayoutResource10351 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setWidgetLayoutResource", "(I)V");
			global::android.preference.Preference._getWidgetLayoutResource10352 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getWidgetLayoutResource", "()I");
			global::android.preference.Preference._getSummary10353 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getSummary", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._setSummary10354 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSummary", "(I)V");
			global::android.preference.Preference._setSummary10355 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSummary", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._setSelectable10356 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSelectable", "(Z)V");
			global::android.preference.Preference._setShouldDisableView10357 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setShouldDisableView", "(Z)V");
			global::android.preference.Preference._getShouldDisableView10358 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getShouldDisableView", "()Z");
			global::android.preference.Preference._hasKey10359 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "hasKey", "()Z");
			global::android.preference.Preference._shouldPersist10360 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldPersist", "()Z");
			global::android.preference.Preference._callChangeListener10361 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "callChangeListener", "(Ljava/lang/Object;)Z");
			global::android.preference.Preference._setOnPreferenceChangeListener10362 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V");
			global::android.preference.Preference._getOnPreferenceChangeListener10363 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;");
			global::android.preference.Preference._setOnPreferenceClickListener10364 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V");
			global::android.preference.Preference._getOnPreferenceClickListener10365 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;");
			global::android.preference.Preference._getEditor10366 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getEditor", "()Landroid/content/SharedPreferences$Editor;");
			global::android.preference.Preference._shouldCommit10367 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldCommit", "()Z");
			global::android.preference.Preference._notifyHierarchyChanged10368 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyHierarchyChanged", "()V");
			global::android.preference.Preference._getPreferenceManager10369 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;");
			global::android.preference.Preference._onAttachedToHierarchy10370 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V");
			global::android.preference.Preference._onAttachedToActivity10371 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.Preference._findPreferenceInHierarchy10372 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;");
			global::android.preference.Preference._notifyDependencyChange10373 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyDependencyChange", "(Z)V");
			global::android.preference.Preference._onDependencyChanged10374 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onDependencyChanged", "(Landroid/preference/Preference;Z)V");
			global::android.preference.Preference._setDependency10375 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setDependency", "(Ljava/lang/String;)V");
			global::android.preference.Preference._getDependency10376 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getDependency", "()Ljava/lang/String;");
			global::android.preference.Preference._onPrepareForRemoval10377 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.Preference._setDefaultValue10378 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setDefaultValue", "(Ljava/lang/Object;)V");
			global::android.preference.Preference._persistString10379 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistString", "(Ljava/lang/String;)Z");
			global::android.preference.Preference._getPersistedString10380 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.preference.Preference._persistInt10381 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistInt", "(I)Z");
			global::android.preference.Preference._getPersistedInt10382 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedInt", "(I)I");
			global::android.preference.Preference._persistFloat10383 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistFloat", "(F)Z");
			global::android.preference.Preference._getPersistedFloat10384 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedFloat", "(F)F");
			global::android.preference.Preference._persistLong10385 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistLong", "(J)Z");
			global::android.preference.Preference._getPersistedLong10386 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedLong", "(J)J");
			global::android.preference.Preference._persistBoolean10387 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistBoolean", "(Z)Z");
			global::android.preference.Preference._getPersistedBoolean10388 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedBoolean", "(Z)Z");
			global::android.preference.Preference._Preference10389 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.Preference._Preference10390 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.Preference._Preference10391 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
