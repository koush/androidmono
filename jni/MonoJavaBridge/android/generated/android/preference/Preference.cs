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
			internal static global::MonoJavaBridge.MethodId _BaseSavedState6830;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState6830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState6831;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState6831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR6832;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$BaseSavedState"));
				global::android.preference.Preference.BaseSavedState._BaseSavedState6830 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.preference.Preference.BaseSavedState._BaseSavedState6831 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.Preference.OnPreferenceChangeListener_))]
		public interface OnPreferenceChangeListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onPreferenceChange6833;
			 bool android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange6833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceChangeListener_.staticClass, global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange6833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceChangeListener"));
				global::android.preference.Preference.OnPreferenceChangeListener_._onPreferenceChange6833 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceChangeListener_.staticClass, "onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.preference.Preference.OnPreferenceClickListener_))]
		public interface OnPreferenceClickListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onPreferenceClick6834;
			 bool android.preference.Preference.OnPreferenceClickListener.onPreferenceClick(android.preference.Preference arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick6834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.OnPreferenceClickListener_.staticClass, global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick6834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.preference.Preference.OnPreferenceClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/Preference$OnPreferenceClickListener"));
				global::android.preference.Preference.OnPreferenceClickListener_._onPreferenceClick6834 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.OnPreferenceClickListener_.staticClass, "onPreferenceClick", "(Landroid/preference/Preference;)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString6835;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._toString6835)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._toString6835)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo6836;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._compareTo6836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo6836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo6837;
		public virtual int compareTo(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._compareTo6837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo6837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKey6838;
		public virtual global::java.lang.String getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getKey6838)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getKey6838)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContext6839;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getContext6839)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getContext6839)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setKey6840;
		public virtual void setKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setKey6840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setKey6840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onClick6841;
		protected virtual void onClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onClick6841);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onClick6841);
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences6842;
		public virtual global::android.content.SharedPreferences getSharedPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getSharedPreferences6842)) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSharedPreferences6842)) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled6843;
		public virtual bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isEnabled6843);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isEnabled6843);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled6844;
		public virtual void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setEnabled6844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setEnabled6844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIntent6845;
		public virtual global::android.content.Intent getIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getIntent6845)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getIntent6845)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setIntent6846;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setIntent6846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setIntent6846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState6847;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onRestoreInstanceState6847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onRestoreInstanceState6847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState6848;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onSaveInstanceState6848)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSaveInstanceState6848)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setPersistent6849;
		public virtual void setPersistent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setPersistent6849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setPersistent6849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent6850;
		public virtual bool isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isPersistent6850);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isPersistent6850);
		}
		internal static global::MonoJavaBridge.MethodId _setTitle6851;
		public virtual void setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setTitle6851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle6851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle6852;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setTitle6852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle6852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getTitle6853;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getTitle6853)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getTitle6853)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView6854;
		protected virtual global::android.view.View onCreateView(android.view.ViewGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onCreateView6854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onCreateView6854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState6855;
		public virtual void saveHierarchyState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._saveHierarchyState6855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._saveHierarchyState6855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState6856;
		public virtual void restoreHierarchyState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._restoreHierarchyState6856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._restoreHierarchyState6856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrder6857;
		public virtual int getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getOrder6857);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOrder6857);
		}
		internal static global::MonoJavaBridge.MethodId _getView6858;
		public virtual global::android.view.View getView(android.view.View arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getView6858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getView6858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isSelectable6859;
		public virtual bool isSelectable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._isSelectable6859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._isSelectable6859);
		}
		internal static global::MonoJavaBridge.MethodId _setOrder6860;
		public virtual void setOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOrder6860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOrder6860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyChanged6861;
		protected virtual void notifyChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyChanged6861);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyChanged6861);
		}
		internal static global::MonoJavaBridge.MethodId _onBindView6862;
		protected virtual void onBindView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onBindView6862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onBindView6862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shouldDisableDependents6863;
		public virtual bool shouldDisableDependents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldDisableDependents6863);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldDisableDependents6863);
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue6864;
		protected virtual global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._onGetDefaultValue6864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onGetDefaultValue6864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue6865;
		protected virtual void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onSetInitialValue6865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSetInitialValue6865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutResource6866;
		public virtual void setLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setLayoutResource6866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setLayoutResource6866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutResource6867;
		public virtual int getLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getLayoutResource6867);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getLayoutResource6867);
		}
		internal static global::MonoJavaBridge.MethodId _setWidgetLayoutResource6868;
		public virtual void setWidgetLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setWidgetLayoutResource6868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setWidgetLayoutResource6868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWidgetLayoutResource6869;
		public virtual int getWidgetLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getWidgetLayoutResource6869);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getWidgetLayoutResource6869);
		}
		internal static global::MonoJavaBridge.MethodId _getSummary6870;
		public virtual global::java.lang.CharSequence getSummary() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getSummary6870)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSummary6870)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setSummary6871;
		public virtual void setSummary(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSummary6871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary6871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSummary6872;
		public virtual void setSummary(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSummary6872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary6872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setSummary(string arg0)
		{
			setSummary((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectable6873;
		public virtual void setSelectable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setSelectable6873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSelectable6873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShouldDisableView6874;
		public virtual void setShouldDisableView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setShouldDisableView6874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setShouldDisableView6874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShouldDisableView6875;
		public virtual bool getShouldDisableView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._getShouldDisableView6875);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getShouldDisableView6875);
		}
		internal static global::MonoJavaBridge.MethodId _hasKey6876;
		public virtual bool hasKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._hasKey6876);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._hasKey6876);
		}
		internal static global::MonoJavaBridge.MethodId _shouldPersist6877;
		protected virtual bool shouldPersist() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldPersist6877);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldPersist6877);
		}
		internal static global::MonoJavaBridge.MethodId _callChangeListener6878;
		protected virtual bool callChangeListener(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._callChangeListener6878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._callChangeListener6878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreferenceChangeListener6879;
		public virtual void setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOnPreferenceChangeListener6879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceChangeListener6879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnPreferenceChangeListener6880;
		public virtual global::android.preference.Preference.OnPreferenceChangeListener getOnPreferenceChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getOnPreferenceChangeListener6880)) as android.preference.Preference.OnPreferenceChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceChangeListener6880)) as android.preference.Preference.OnPreferenceChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreferenceClickListener6881;
		public virtual void setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setOnPreferenceClickListener6881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceClickListener6881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnPreferenceClickListener6882;
		public virtual global::android.preference.Preference.OnPreferenceClickListener getOnPreferenceClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getOnPreferenceClickListener6882)) as android.preference.Preference.OnPreferenceClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.preference.Preference.OnPreferenceClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceClickListener6882)) as android.preference.Preference.OnPreferenceClickListener;
		}
		internal static global::MonoJavaBridge.MethodId _getEditor6883;
		public virtual global::android.content.SharedPreferences_Editor getEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getEditor6883)) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getEditor6883)) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _shouldCommit6884;
		public virtual bool shouldCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._shouldCommit6884);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldCommit6884);
		}
		internal static global::MonoJavaBridge.MethodId _notifyHierarchyChanged6885;
		protected virtual void notifyHierarchyChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyHierarchyChanged6885);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyHierarchyChanged6885);
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceManager6886;
		public virtual global::android.preference.PreferenceManager getPreferenceManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getPreferenceManager6886)) as android.preference.PreferenceManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPreferenceManager6886)) as android.preference.PreferenceManager;
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToHierarchy6887;
		protected virtual void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onAttachedToHierarchy6887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToHierarchy6887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToActivity6888;
		protected virtual void onAttachedToActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onAttachedToActivity6888);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToActivity6888);
		}
		internal static global::MonoJavaBridge.MethodId _findPreferenceInHierarchy6889;
		protected virtual global::android.preference.Preference findPreferenceInHierarchy(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._findPreferenceInHierarchy6889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._findPreferenceInHierarchy6889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDependencyChange6890;
		public virtual void notifyDependencyChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._notifyDependencyChange6890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyDependencyChange6890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDependencyChanged6891;
		public virtual void onDependencyChanged(android.preference.Preference arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onDependencyChanged6891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onDependencyChanged6891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDependency6892;
		public virtual void setDependency(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setDependency6892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDependency6892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDependency6893;
		public virtual global::java.lang.String getDependency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getDependency6893)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getDependency6893)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareForRemoval6894;
		protected virtual void onPrepareForRemoval() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._onPrepareForRemoval6894);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._onPrepareForRemoval6894);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultValue6895;
		public virtual void setDefaultValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.Preference._setDefaultValue6895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDefaultValue6895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistString6896;
		protected virtual bool persistString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistString6896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistString6896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedString6897;
		protected virtual global::java.lang.String getPersistedString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.Preference._getPersistedString6897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedString6897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _persistInt6898;
		protected virtual bool persistInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistInt6898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistInt6898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedInt6899;
		protected virtual int getPersistedInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.Preference._getPersistedInt6899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedInt6899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistFloat6900;
		protected virtual bool persistFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistFloat6900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistFloat6900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedFloat6901;
		protected virtual float getPersistedFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.preference.Preference._getPersistedFloat6901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedFloat6901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistLong6902;
		protected virtual bool persistLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistLong6902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistLong6902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedLong6903;
		protected virtual long getPersistedLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.preference.Preference._getPersistedLong6903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedLong6903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _persistBoolean6904;
		protected virtual bool persistBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._persistBoolean6904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistBoolean6904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistedBoolean6905;
		protected virtual bool getPersistedBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.Preference._getPersistedBoolean6905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedBoolean6905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Preference6906;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Preference6907;
		public Preference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Preference6908;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::android.preference.Preference._toString6835 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "toString", "()Ljava/lang/String;");
			global::android.preference.Preference._compareTo6836 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.preference.Preference._compareTo6837 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "compareTo", "(Landroid/preference/Preference;)I");
			global::android.preference.Preference._getKey6838 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.preference.Preference._getContext6839 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.preference.Preference._setKey6840 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setKey", "(Ljava/lang/String;)V");
			global::android.preference.Preference._onClick6841 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onClick", "()V");
			global::android.preference.Preference._getSharedPreferences6842 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;");
			global::android.preference.Preference._isEnabled6843 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isEnabled", "()Z");
			global::android.preference.Preference._setEnabled6844 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setEnabled", "(Z)V");
			global::android.preference.Preference._getIntent6845 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.preference.Preference._setIntent6846 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.preference.Preference._onRestoreInstanceState6847 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.Preference._onSaveInstanceState6848 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.Preference._setPersistent6849 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setPersistent", "(Z)V");
			global::android.preference.Preference._isPersistent6850 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isPersistent", "()Z");
			global::android.preference.Preference._setTitle6851 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setTitle", "(I)V");
			global::android.preference.Preference._setTitle6852 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._getTitle6853 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._onCreateView6854 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._saveHierarchyState6855 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "saveHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._restoreHierarchyState6856 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._getOrder6857 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOrder", "()I");
			global::android.preference.Preference._getView6858 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._isSelectable6859 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "isSelectable", "()Z");
			global::android.preference.Preference._setOrder6860 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOrder", "(I)V");
			global::android.preference.Preference._notifyChanged6861 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyChanged", "()V");
			global::android.preference.Preference._onBindView6862 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.Preference._shouldDisableDependents6863 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.Preference._onGetDefaultValue6864 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.Preference._onSetInitialValue6865 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.Preference._setLayoutResource6866 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setLayoutResource", "(I)V");
			global::android.preference.Preference._getLayoutResource6867 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getLayoutResource", "()I");
			global::android.preference.Preference._setWidgetLayoutResource6868 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setWidgetLayoutResource", "(I)V");
			global::android.preference.Preference._getWidgetLayoutResource6869 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getWidgetLayoutResource", "()I");
			global::android.preference.Preference._getSummary6870 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getSummary", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._setSummary6871 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSummary", "(I)V");
			global::android.preference.Preference._setSummary6872 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSummary", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._setSelectable6873 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setSelectable", "(Z)V");
			global::android.preference.Preference._setShouldDisableView6874 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setShouldDisableView", "(Z)V");
			global::android.preference.Preference._getShouldDisableView6875 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getShouldDisableView", "()Z");
			global::android.preference.Preference._hasKey6876 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "hasKey", "()Z");
			global::android.preference.Preference._shouldPersist6877 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldPersist", "()Z");
			global::android.preference.Preference._callChangeListener6878 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "callChangeListener", "(Ljava/lang/Object;)Z");
			global::android.preference.Preference._setOnPreferenceChangeListener6879 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V");
			global::android.preference.Preference._getOnPreferenceChangeListener6880 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;");
			global::android.preference.Preference._setOnPreferenceClickListener6881 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V");
			global::android.preference.Preference._getOnPreferenceClickListener6882 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;");
			global::android.preference.Preference._getEditor6883 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getEditor", "()Landroid/content/SharedPreferences$Editor;");
			global::android.preference.Preference._shouldCommit6884 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "shouldCommit", "()Z");
			global::android.preference.Preference._notifyHierarchyChanged6885 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyHierarchyChanged", "()V");
			global::android.preference.Preference._getPreferenceManager6886 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;");
			global::android.preference.Preference._onAttachedToHierarchy6887 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V");
			global::android.preference.Preference._onAttachedToActivity6888 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.Preference._findPreferenceInHierarchy6889 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;");
			global::android.preference.Preference._notifyDependencyChange6890 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "notifyDependencyChange", "(Z)V");
			global::android.preference.Preference._onDependencyChanged6891 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onDependencyChanged", "(Landroid/preference/Preference;Z)V");
			global::android.preference.Preference._setDependency6892 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setDependency", "(Ljava/lang/String;)V");
			global::android.preference.Preference._getDependency6893 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getDependency", "()Ljava/lang/String;");
			global::android.preference.Preference._onPrepareForRemoval6894 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.Preference._setDefaultValue6895 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "setDefaultValue", "(Ljava/lang/Object;)V");
			global::android.preference.Preference._persistString6896 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistString", "(Ljava/lang/String;)Z");
			global::android.preference.Preference._getPersistedString6897 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.preference.Preference._persistInt6898 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistInt", "(I)Z");
			global::android.preference.Preference._getPersistedInt6899 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedInt", "(I)I");
			global::android.preference.Preference._persistFloat6900 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistFloat", "(F)Z");
			global::android.preference.Preference._getPersistedFloat6901 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedFloat", "(F)F");
			global::android.preference.Preference._persistLong6902 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistLong", "(J)Z");
			global::android.preference.Preference._getPersistedLong6903 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedLong", "(J)J");
			global::android.preference.Preference._persistBoolean6904 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "persistBoolean", "(Z)Z");
			global::android.preference.Preference._getPersistedBoolean6905 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "getPersistedBoolean", "(Z)Z");
			global::android.preference.Preference._Preference6906 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.Preference._Preference6907 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.Preference._Preference6908 = @__env.GetMethodIDNoThrow(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
