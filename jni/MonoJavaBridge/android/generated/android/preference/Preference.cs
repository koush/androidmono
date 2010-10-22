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
			internal static global::MonoJavaBridge.MethodId _BaseSavedState10264;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState10264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState10265;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState10265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR10266;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.preference.Preference.BaseSavedState.staticClass, _CREATOR10266)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$BaseSavedState"));
				global::android.preference.Preference.BaseSavedState._BaseSavedState10264 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.preference.Preference.BaseSavedState._BaseSavedState10265 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
				global::android.preference.Preference.BaseSavedState._CREATOR10266 = @__env.GetStaticFieldIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.Preference.OnPreferenceChangeListener_))]
		public partial interface OnPreferenceChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.Preference.OnPreferenceChangeListener))]
		public sealed partial class OnPreferenceChangeListener_ : java.lang.Object, OnPreferenceChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreferenceChangeListener_()
			{
				InitJNI();
			}
			internal OnPreferenceChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPreferenceChange10267;
			 bool android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange10267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceChangeListener_.staticClass, global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange10267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceChangeListener"));
				global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange10267 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceChangeListener_.staticClass, "onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.Preference.OnPreferenceClickListener_))]
		public partial interface OnPreferenceClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onPreferenceClick(android.preference.Preference arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.Preference.OnPreferenceClickListener))]
		public sealed partial class OnPreferenceClickListener_ : java.lang.Object, OnPreferenceClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreferenceClickListener_()
			{
				InitJNI();
			}
			internal OnPreferenceClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPreferenceClick10268;
			 bool android.preference.Preference.OnPreferenceClickListener.onPreferenceClick(android.preference.Preference arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick10268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceClickListener_.staticClass, global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick10268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceClickListener"));
				global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick10268 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceClickListener_.staticClass, "onPreferenceClick", "(Landroid/preference/Preference;)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString10269;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._toString10269)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._toString10269)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo10270;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._compareTo10270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo10270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo10271;
		public virtual int compareTo(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._compareTo10271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo10271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getKey10272;
		public virtual global::java.lang.String getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getKey10272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getKey10272)) as java.lang.String;
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext10273;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getContext10273)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getContext10273)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setKey10274;
		public virtual void setKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setKey10274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setKey10274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onClick10275;
		protected virtual void onClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onClick10275);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onClick10275);
		}
		public new global::android.content.SharedPreferences SharedPreferences
		{
			get
			{
				return getSharedPreferences();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences10276;
		public virtual global::android.content.SharedPreferences getSharedPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getSharedPreferences10276)) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSharedPreferences10276)) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled10277;
		public virtual bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isEnabled10277);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isEnabled10277);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled10278;
		public virtual void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setEnabled10278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setEnabled10278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getIntent10279;
		public virtual global::android.content.Intent getIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getIntent10279)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getIntent10279)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setIntent10280;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setIntent10280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setIntent10280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10281;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onRestoreInstanceState10281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onRestoreInstanceState10281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10282;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onSaveInstanceState10282)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSaveInstanceState10282)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setPersistent10283;
		public virtual void setPersistent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setPersistent10283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setPersistent10283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent10284;
		public virtual bool isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isPersistent10284);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isPersistent10284);
		}
		internal static global::MonoJavaBridge.MethodId _setTitle10285;
		public virtual void setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setTitle10285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle10285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle10286;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setTitle10286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle10286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTitle10287;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getTitle10287)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getTitle10287)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView10288;
		protected virtual global::android.view.View onCreateView(android.view.ViewGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onCreateView10288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onCreateView10288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState10289;
		public virtual void saveHierarchyState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._saveHierarchyState10289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._saveHierarchyState10289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState10290;
		public virtual void restoreHierarchyState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._restoreHierarchyState10290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._restoreHierarchyState10290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrder10291;
		public virtual int getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getOrder10291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOrder10291);
		}
		internal static global::MonoJavaBridge.MethodId _getView10292;
		public virtual global::android.view.View getView(android.view.View arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getView10292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getView10292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isSelectable10293;
		public virtual bool isSelectable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isSelectable10293);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isSelectable10293);
		}
		internal static global::MonoJavaBridge.MethodId _setOrder10294;
		public virtual void setOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOrder10294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOrder10294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyChanged10295;
		protected virtual void notifyChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyChanged10295);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyChanged10295);
		}
		internal static global::MonoJavaBridge.MethodId _onBindView10296;
		protected virtual void onBindView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onBindView10296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onBindView10296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents10297;
		public virtual bool shouldDisableDependents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldDisableDependents10297);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldDisableDependents10297);
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10298;
		protected virtual global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onGetDefaultValue10298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onGetDefaultValue10298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10299;
		protected virtual void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onSetInitialValue10299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSetInitialValue10299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutResource10300;
		public virtual void setLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setLayoutResource10300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setLayoutResource10300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLayoutResource10301;
		public virtual int getLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getLayoutResource10301);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getLayoutResource10301);
		}
		internal static global::MonoJavaBridge.MethodId _setWidgetLayoutResource10302;
		public virtual void setWidgetLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setWidgetLayoutResource10302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setWidgetLayoutResource10302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getWidgetLayoutResource10303;
		public virtual int getWidgetLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getWidgetLayoutResource10303);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getWidgetLayoutResource10303);
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
		internal static global::MonoJavaBridge.MethodId _getSummary10304;
		public virtual global::java.lang.CharSequence getSummary() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getSummary10304)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSummary10304)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setSummary10305;
		public virtual void setSummary(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSummary10305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary10305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSummary10306;
		public virtual void setSummary(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSummary10306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary10306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setSummary(string arg0)
		{
			setSummary((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectable10307;
		public virtual void setSelectable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSelectable10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSelectable10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShouldDisableView10308;
		public virtual void setShouldDisableView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setShouldDisableView10308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setShouldDisableView10308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getShouldDisableView10309;
		public virtual bool getShouldDisableView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._getShouldDisableView10309);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getShouldDisableView10309);
		}
		internal static global::MonoJavaBridge.MethodId _hasKey10310;
		public virtual bool hasKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._hasKey10310);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._hasKey10310);
		}
		internal static global::MonoJavaBridge.MethodId _shouldPersist10311;
		protected virtual bool shouldPersist() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldPersist10311);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldPersist10311);
		}
		internal static global::MonoJavaBridge.MethodId _callChangeListener10312;
		protected virtual bool callChangeListener(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._callChangeListener10312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._callChangeListener10312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreferenceChangeListener10313;
		public virtual void setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOnPreferenceChangeListener10313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceChangeListener10313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnPreferenceChangeListener10314;
		public virtual global::android.preference.Preference.OnPreferenceChangeListener getOnPreferenceChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getOnPreferenceChangeListener10314)) as android.preference.Preference.OnPreferenceChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceChangeListener10314)) as android.preference.Preference.OnPreferenceChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreferenceClickListener10315;
		public virtual void setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOnPreferenceClickListener10315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceClickListener10315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnPreferenceClickListener10316;
		public virtual global::android.preference.Preference.OnPreferenceClickListener getOnPreferenceClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getOnPreferenceClickListener10316)) as android.preference.Preference.OnPreferenceClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceClickListener10316)) as android.preference.Preference.OnPreferenceClickListener;
		}
		public new global::android.content.SharedPreferences_Editor Editor
		{
			get
			{
				return getEditor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditor10317;
		public virtual global::android.content.SharedPreferences_Editor getEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getEditor10317)) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getEditor10317)) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _shouldCommit10318;
		public virtual bool shouldCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldCommit10318);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldCommit10318);
		}
		internal static global::MonoJavaBridge.MethodId _notifyHierarchyChanged10319;
		protected virtual void notifyHierarchyChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyHierarchyChanged10319);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyHierarchyChanged10319);
		}
		public new global::android.preference.PreferenceManager PreferenceManager
		{
			get
			{
				return getPreferenceManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceManager10320;
		public virtual global::android.preference.PreferenceManager getPreferenceManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getPreferenceManager10320)) as android.preference.PreferenceManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPreferenceManager10320)) as android.preference.PreferenceManager;
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToHierarchy10321;
		protected virtual void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onAttachedToHierarchy10321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToHierarchy10321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToActivity10322;
		protected virtual void onAttachedToActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onAttachedToActivity10322);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToActivity10322);
		}
		internal static global::MonoJavaBridge.MethodId _findPreferenceInHierarchy10323;
		protected virtual global::android.preference.Preference findPreferenceInHierarchy(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._findPreferenceInHierarchy10323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._findPreferenceInHierarchy10323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDependencyChange10324;
		public virtual void notifyDependencyChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyDependencyChange10324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyDependencyChange10324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDependencyChanged10325;
		public virtual void onDependencyChanged(android.preference.Preference arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onDependencyChanged10325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onDependencyChanged10325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDependency10326;
		public virtual void setDependency(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setDependency10326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDependency10326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDependency10327;
		public virtual global::java.lang.String getDependency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getDependency10327)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getDependency10327)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareForRemoval10328;
		protected virtual void onPrepareForRemoval() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onPrepareForRemoval10328);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onPrepareForRemoval10328);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultValue10329;
		public virtual void setDefaultValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setDefaultValue10329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDefaultValue10329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistString10330;
		protected virtual bool persistString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistString10330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistString10330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedString10331;
		protected virtual global::java.lang.String getPersistedString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getPersistedString10331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedString10331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _persistInt10332;
		protected virtual bool persistInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistInt10332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistInt10332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedInt10333;
		protected virtual int getPersistedInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getPersistedInt10333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedInt10333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistFloat10334;
		protected virtual bool persistFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistFloat10334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistFloat10334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedFloat10335;
		protected virtual float getPersistedFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.preference.Preference._getPersistedFloat10335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedFloat10335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistLong10336;
		protected virtual bool persistLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistLong10336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistLong10336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedLong10337;
		protected virtual long getPersistedLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.preference.Preference._getPersistedLong10337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedLong10337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistBoolean10338;
		protected virtual bool persistBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistBoolean10338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistBoolean10338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedBoolean10339;
		protected virtual bool getPersistedBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._getPersistedBoolean10339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedBoolean10339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Preference10340;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference10340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Preference10341;
		public Preference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference10341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Preference10342;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference10342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::android.preference.Preference._toString10269 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "toString", "()Ljava/lang/String;");
			global::android.preference.Preference._compareTo10270 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.preference.Preference._compareTo10271 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "compareTo", "(Landroid/preference/Preference;)I");
			global::android.preference.Preference._getKey10272 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.preference.Preference._getContext10273 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.preference.Preference._setKey10274 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setKey", "(Ljava/lang/String;)V");
			global::android.preference.Preference._onClick10275 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onClick", "()V");
			global::android.preference.Preference._getSharedPreferences10276 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;");
			global::android.preference.Preference._isEnabled10277 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isEnabled", "()Z");
			global::android.preference.Preference._setEnabled10278 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setEnabled", "(Z)V");
			global::android.preference.Preference._getIntent10279 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.preference.Preference._setIntent10280 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.preference.Preference._onRestoreInstanceState10281 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.Preference._onSaveInstanceState10282 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.Preference._setPersistent10283 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setPersistent", "(Z)V");
			global::android.preference.Preference._isPersistent10284 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isPersistent", "()Z");
			global::android.preference.Preference._setTitle10285 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setTitle", "(I)V");
			global::android.preference.Preference._setTitle10286 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._getTitle10287 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._onCreateView10288 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._saveHierarchyState10289 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "saveHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._restoreHierarchyState10290 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._getOrder10291 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOrder", "()I");
			global::android.preference.Preference._getView10292 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._isSelectable10293 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isSelectable", "()Z");
			global::android.preference.Preference._setOrder10294 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOrder", "(I)V");
			global::android.preference.Preference._notifyChanged10295 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyChanged", "()V");
			global::android.preference.Preference._onBindView10296 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.Preference._shouldDisableDependents10297 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.Preference._onGetDefaultValue10298 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.Preference._onSetInitialValue10299 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.Preference._setLayoutResource10300 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setLayoutResource", "(I)V");
			global::android.preference.Preference._getLayoutResource10301 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getLayoutResource", "()I");
			global::android.preference.Preference._setWidgetLayoutResource10302 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setWidgetLayoutResource", "(I)V");
			global::android.preference.Preference._getWidgetLayoutResource10303 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getWidgetLayoutResource", "()I");
			global::android.preference.Preference._getSummary10304 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getSummary", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._setSummary10305 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSummary", "(I)V");
			global::android.preference.Preference._setSummary10306 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSummary", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._setSelectable10307 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSelectable", "(Z)V");
			global::android.preference.Preference._setShouldDisableView10308 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setShouldDisableView", "(Z)V");
			global::android.preference.Preference._getShouldDisableView10309 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getShouldDisableView", "()Z");
			global::android.preference.Preference._hasKey10310 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "hasKey", "()Z");
			global::android.preference.Preference._shouldPersist10311 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldPersist", "()Z");
			global::android.preference.Preference._callChangeListener10312 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "callChangeListener", "(Ljava/lang/Object;)Z");
			global::android.preference.Preference._setOnPreferenceChangeListener10313 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V");
			global::android.preference.Preference._getOnPreferenceChangeListener10314 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;");
			global::android.preference.Preference._setOnPreferenceClickListener10315 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V");
			global::android.preference.Preference._getOnPreferenceClickListener10316 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;");
			global::android.preference.Preference._getEditor10317 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getEditor", "()Landroid/content/SharedPreferences$Editor;");
			global::android.preference.Preference._shouldCommit10318 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldCommit", "()Z");
			global::android.preference.Preference._notifyHierarchyChanged10319 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyHierarchyChanged", "()V");
			global::android.preference.Preference._getPreferenceManager10320 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;");
			global::android.preference.Preference._onAttachedToHierarchy10321 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V");
			global::android.preference.Preference._onAttachedToActivity10322 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.Preference._findPreferenceInHierarchy10323 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;");
			global::android.preference.Preference._notifyDependencyChange10324 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyDependencyChange", "(Z)V");
			global::android.preference.Preference._onDependencyChanged10325 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onDependencyChanged", "(Landroid/preference/Preference;Z)V");
			global::android.preference.Preference._setDependency10326 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setDependency", "(Ljava/lang/String;)V");
			global::android.preference.Preference._getDependency10327 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getDependency", "()Ljava/lang/String;");
			global::android.preference.Preference._onPrepareForRemoval10328 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.Preference._setDefaultValue10329 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setDefaultValue", "(Ljava/lang/Object;)V");
			global::android.preference.Preference._persistString10330 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistString", "(Ljava/lang/String;)Z");
			global::android.preference.Preference._getPersistedString10331 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.preference.Preference._persistInt10332 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistInt", "(I)Z");
			global::android.preference.Preference._getPersistedInt10333 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedInt", "(I)I");
			global::android.preference.Preference._persistFloat10334 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistFloat", "(F)Z");
			global::android.preference.Preference._getPersistedFloat10335 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedFloat", "(F)F");
			global::android.preference.Preference._persistLong10336 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistLong", "(J)Z");
			global::android.preference.Preference._getPersistedLong10337 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedLong", "(J)J");
			global::android.preference.Preference._persistBoolean10338 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistBoolean", "(Z)Z");
			global::android.preference.Preference._getPersistedBoolean10339 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedBoolean", "(Z)Z");
			global::android.preference.Preference._Preference10340 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.Preference._Preference10341 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.Preference._Preference10342 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
