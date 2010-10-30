namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Preference : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Preference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected BaseSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public BaseSavedState(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.preference.Preference.BaseSavedState._m0.native == global::System.IntPtr.Zero)
					global::android.preference.Preference.BaseSavedState._m0 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public BaseSavedState(android.os.Parcelable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.preference.Preference.BaseSavedState._m1.native == global::System.IntPtr.Zero)
					global::android.preference.Preference.BaseSavedState._m1 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR4052;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.preference.Preference.BaseSavedState.staticClass, _CREATOR4052)) as android.os.Parcelable_Creator;
				}
			}
			static BaseSavedState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$BaseSavedState"));
				global::android.preference.Preference.BaseSavedState._CREATOR4052 = @__env.GetStaticFieldIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
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
			internal OnPreferenceChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.OnPreferenceChangeListener_.staticClass, "onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z", ref global::android.preference.Preference.OnPreferenceChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnPreferenceChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnPreferenceChangeListenerDelegate(android.preference.Preference arg0, java.lang.Object arg1);

		internal partial class OnPreferenceChangeListenerDelegateWrapper : java.lang.Object, OnPreferenceChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnPreferenceChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnPreferenceChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper.staticClass, global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnPreferenceChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference_OnPreferenceChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
			internal OnPreferenceClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.preference.Preference.OnPreferenceClickListener.onPreferenceClick(android.preference.Preference arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.OnPreferenceClickListener_.staticClass, "onPreferenceClick", "(Landroid/preference/Preference;)Z", ref global::android.preference.Preference.OnPreferenceClickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnPreferenceClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceClickListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnPreferenceClickListenerDelegate(android.preference.Preference arg0);

		internal partial class OnPreferenceClickListenerDelegateWrapper : java.lang.Object, OnPreferenceClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnPreferenceClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnPreferenceClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.OnPreferenceClickListenerDelegateWrapper.staticClass, global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnPreferenceClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference_OnPreferenceClickListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.preference.Preference.staticClass, "toString", "()Ljava/lang/String;", ref global::android.preference.Preference._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.Preference.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::android.preference.Preference._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int compareTo(android.preference.Preference arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.Preference.staticClass, "compareTo", "(Landroid/preference/Preference;)I", ref global::android.preference.Preference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.preference.Preference.staticClass, "getKey", "()Ljava/lang/String;", ref global::android.preference.Preference._m3) as java.lang.String;
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.Preference.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.preference.Preference._m4) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setKey", "(Ljava/lang/String;)V", ref global::android.preference.Preference._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void onClick()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onClick", "()V", ref global::android.preference.Preference._m6);
		}
		public new global::android.content.SharedPreferences SharedPreferences
		{
			get
			{
				return getSharedPreferences();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.content.SharedPreferences getSharedPreferences()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences>(this, global::android.preference.Preference.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;", ref global::android.preference.Preference._m7) as android.content.SharedPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "isEnabled", "()Z", ref global::android.preference.Preference._m8);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setEnabled", "(Z)V", ref global::android.preference.Preference._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.content.Intent getIntent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.Preference.staticClass, "getIntent", "()Landroid/content/Intent;", ref global::android.preference.Preference._m10) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setIntent", "(Landroid/content/Intent;)V", ref global::android.preference.Preference._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.preference.Preference._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.preference.Preference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.preference.Preference._m13) as android.os.Parcelable;
		}
		public new bool Persistent
		{
			set
			{
				setPersistent(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setPersistent(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setPersistent", "(Z)V", ref global::android.preference.Preference._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "isPersistent", "()Z", ref global::android.preference.Preference._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setTitle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setTitle", "(I)V", ref global::android.preference.Preference._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V", ref global::android.preference.Preference._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.CharSequence getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.Preference.staticClass, "getTitle", "()Ljava/lang/CharSequence;", ref global::android.preference.Preference._m18) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual global::android.view.View onCreateView(android.view.ViewGroup arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.Preference.staticClass, "onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.preference.Preference._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void saveHierarchyState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "saveHierarchyState", "(Landroid/os/Bundle;)V", ref global::android.preference.Preference._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void restoreHierarchyState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V", ref global::android.preference.Preference._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getOrder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.Preference.staticClass, "getOrder", "()I", ref global::android.preference.Preference._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::android.view.View getView(android.view.View arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.Preference.staticClass, "getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.preference.Preference._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isSelectable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "isSelectable", "()Z", ref global::android.preference.Preference._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setOrder(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setOrder", "(I)V", ref global::android.preference.Preference._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual void notifyChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "notifyChanged", "()V", ref global::android.preference.Preference._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected virtual void onBindView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onBindView", "(Landroid/view/View;)V", ref global::android.preference.Preference._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool shouldDisableDependents()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "shouldDisableDependents", "()Z", ref global::android.preference.Preference._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected virtual global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.Preference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", ref global::android.preference.Preference._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V", ref global::android.preference.Preference._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setLayoutResource", "(I)V", ref global::android.preference.Preference._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual int getLayoutResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.Preference.staticClass, "getLayoutResource", "()I", ref global::android.preference.Preference._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setWidgetLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setWidgetLayoutResource", "(I)V", ref global::android.preference.Preference._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual int getWidgetLayoutResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.Preference.staticClass, "getWidgetLayoutResource", "()I", ref global::android.preference.Preference._m34);
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
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.lang.CharSequence getSummary()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.Preference.staticClass, "getSummary", "()Ljava/lang/CharSequence;", ref global::android.preference.Preference._m35) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setSummary(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setSummary", "(I)V", ref global::android.preference.Preference._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setSummary(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setSummary", "(Ljava/lang/CharSequence;)V", ref global::android.preference.Preference._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void setSelectable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setSelectable", "(Z)V", ref global::android.preference.Preference._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void setShouldDisableView(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setShouldDisableView", "(Z)V", ref global::android.preference.Preference._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual bool getShouldDisableView()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "getShouldDisableView", "()Z", ref global::android.preference.Preference._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual bool hasKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "hasKey", "()Z", ref global::android.preference.Preference._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		protected virtual bool shouldPersist()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "shouldPersist", "()Z", ref global::android.preference.Preference._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		protected virtual bool callChangeListener(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "callChangeListener", "(Ljava/lang/Object;)Z", ref global::android.preference.Preference._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V", ref global::android.preference.Preference._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnPreferenceChangeListener(global::android.preference.Preference.OnPreferenceChangeListenerDelegate arg0)
		{
			setOnPreferenceChangeListener((global::android.preference.Preference.OnPreferenceChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual global::android.preference.Preference.OnPreferenceChangeListener getOnPreferenceChangeListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.preference.Preference.OnPreferenceChangeListener>(this, global::android.preference.Preference.staticClass, "getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;", ref global::android.preference.Preference._m45) as android.preference.Preference.OnPreferenceChangeListener;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual void setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V", ref global::android.preference.Preference._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnPreferenceClickListener(global::android.preference.Preference.OnPreferenceClickListenerDelegate arg0)
		{
			setOnPreferenceClickListener((global::android.preference.Preference.OnPreferenceClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual global::android.preference.Preference.OnPreferenceClickListener getOnPreferenceClickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.preference.Preference.OnPreferenceClickListener>(this, global::android.preference.Preference.staticClass, "getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;", ref global::android.preference.Preference._m47) as android.preference.Preference.OnPreferenceClickListener;
		}
		public new global::android.content.SharedPreferences_Editor Editor
		{
			get
			{
				return getEditor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual global::android.content.SharedPreferences_Editor getEditor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.preference.Preference.staticClass, "getEditor", "()Landroid/content/SharedPreferences$Editor;", ref global::android.preference.Preference._m48) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual bool shouldCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "shouldCommit", "()Z", ref global::android.preference.Preference._m49);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		protected virtual void notifyHierarchyChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "notifyHierarchyChanged", "()V", ref global::android.preference.Preference._m50);
		}
		public new global::android.preference.PreferenceManager PreferenceManager
		{
			get
			{
				return getPreferenceManager();
			}
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual global::android.preference.PreferenceManager getPreferenceManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.Preference.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;", ref global::android.preference.Preference._m51) as android.preference.PreferenceManager;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		protected virtual void onAttachedToHierarchy(android.preference.PreferenceManager arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V", ref global::android.preference.Preference._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		protected virtual void onAttachedToActivity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onAttachedToActivity", "()V", ref global::android.preference.Preference._m53);
		}
		private static global::MonoJavaBridge.MethodId _m54;
		protected virtual global::android.preference.Preference findPreferenceInHierarchy(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.Preference.staticClass, "findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;", ref global::android.preference.Preference._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.preference.Preference;
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual void notifyDependencyChange(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "notifyDependencyChange", "(Z)V", ref global::android.preference.Preference._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void onDependencyChanged(android.preference.Preference arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onDependencyChanged", "(Landroid/preference/Preference;Z)V", ref global::android.preference.Preference._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void setDependency(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setDependency", "(Ljava/lang/String;)V", ref global::android.preference.Preference._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual global::java.lang.String getDependency()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.preference.Preference.staticClass, "getDependency", "()Ljava/lang/String;", ref global::android.preference.Preference._m58) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m59;
		protected virtual void onPrepareForRemoval()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "onPrepareForRemoval", "()V", ref global::android.preference.Preference._m59);
		}
		public new global::java.lang.Object DefaultValue
		{
			set
			{
				setDefaultValue(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void setDefaultValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.Preference.staticClass, "setDefaultValue", "(Ljava/lang/Object;)V", ref global::android.preference.Preference._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		protected virtual bool persistString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "persistString", "(Ljava/lang/String;)Z", ref global::android.preference.Preference._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		protected virtual global::java.lang.String getPersistedString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.preference.Preference.staticClass, "getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.preference.Preference._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m63;
		protected virtual bool persistInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "persistInt", "(I)Z", ref global::android.preference.Preference._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		protected virtual int getPersistedInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.Preference.staticClass, "getPersistedInt", "(I)I", ref global::android.preference.Preference._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		protected virtual bool persistFloat(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "persistFloat", "(F)Z", ref global::android.preference.Preference._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		protected virtual float getPersistedFloat(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.preference.Preference.staticClass, "getPersistedFloat", "(F)F", ref global::android.preference.Preference._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		protected virtual bool persistLong(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "persistLong", "(J)Z", ref global::android.preference.Preference._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		protected virtual long getPersistedLong(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.preference.Preference.staticClass, "getPersistedLong", "(J)J", ref global::android.preference.Preference._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		protected virtual bool persistBoolean(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "persistBoolean", "(Z)Z", ref global::android.preference.Preference._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		protected virtual bool getPersistedBoolean(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.Preference.staticClass, "getPersistedBoolean", "(Z)Z", ref global::android.preference.Preference._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.Preference._m71.native == global::System.IntPtr.Zero)
				global::android.preference.Preference._m71 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public Preference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.Preference._m72.native == global::System.IntPtr.Zero)
				global::android.preference.Preference._m72 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.Preference._m73.native == global::System.IntPtr.Zero)
				global::android.preference.Preference._m73 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int DEFAULT_ORDER
		{
			get
			{
				return 2147483647;
			}
		}
		static Preference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.Preference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
