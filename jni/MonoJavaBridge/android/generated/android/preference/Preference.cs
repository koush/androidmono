namespace android.preference
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Preference : java.lang.Object, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static Preference()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.Preference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.preference.Preference(@__env);
			}
		}
		protected Preference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::java.lang.Class staticClass;
			static BaseSavedState()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.Preference.BaseSavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.preference.Preference.BaseSavedState(@__env);
				}
			}
			protected BaseSavedState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState5975;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState5975, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState5976;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState5976, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR5977;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.preference.Preference.BaseSavedState.staticClass = @__class;
				global::android.preference.Preference.BaseSavedState._BaseSavedState5975 = @__env.GetMethodID(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.preference.Preference.BaseSavedState._BaseSavedState5976 = @__env.GetMethodID(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnPreferenceChangeListener 
		{
			bool onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1);
		}

		public partial class OnPreferenceChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnPreferenceChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnPreferenceChangeListener : java.lang.Object, OnPreferenceChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnPreferenceChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.Preference.__OnPreferenceChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.preference.Preference.__OnPreferenceChangeListener(@__env);
				}
			}
			internal __OnPreferenceChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPreferenceChange5978;
			 bool android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.preference.Preference.__OnPreferenceChangeListener._onPreferenceChange5978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.__OnPreferenceChangeListener.staticClass, global::android.preference.Preference.__OnPreferenceChangeListener._onPreferenceChange5978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.preference.Preference.__OnPreferenceChangeListener.staticClass = @__class;
				global::android.preference.Preference.__OnPreferenceChangeListener._onPreferenceChange5978 = @__env.GetMethodID(global::android.preference.Preference.__OnPreferenceChangeListener.staticClass, "android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnPreferenceClickListener 
		{
			bool onPreferenceClick(android.preference.Preference arg0);
		}

		public partial class OnPreferenceClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnPreferenceClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnPreferenceClickListener : java.lang.Object, OnPreferenceClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnPreferenceClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.Preference.__OnPreferenceClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.preference.Preference.__OnPreferenceClickListener(@__env);
				}
			}
			internal __OnPreferenceClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPreferenceClick5979;
			 bool android.preference.Preference.OnPreferenceClickListener.onPreferenceClick(android.preference.Preference arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.preference.Preference.__OnPreferenceClickListener._onPreferenceClick5979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.__OnPreferenceClickListener.staticClass, global::android.preference.Preference.__OnPreferenceClickListener._onPreferenceClick5979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.preference.Preference.__OnPreferenceClickListener.staticClass = @__class;
				global::android.preference.Preference.__OnPreferenceClickListener._onPreferenceClick5979 = @__env.GetMethodID(global::android.preference.Preference.__OnPreferenceClickListener.staticClass, "android.preference.Preference.OnPreferenceClickListener.onPreferenceClick", "(Landroid/preference/Preference;)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString5980;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._toString5980));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._toString5980));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo5981;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._compareTo5981, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo5981, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo5982;
		public virtual int compareTo(android.preference.Preference arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._compareTo5982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo5982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKey5983;
		public virtual global::java.lang.String getKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getKey5983));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getKey5983));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext5984;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getContext5984));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getContext5984));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKey5985;
		public virtual void setKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setKey5985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setKey5985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick5986;
		protected virtual void onClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onClick5986);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onClick5986);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences5987;
		public virtual global::android.content.SharedPreferences getSharedPreferences() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getSharedPreferences5987));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSharedPreferences5987));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled5988;
		public virtual bool isEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._isEnabled5988);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._isEnabled5988);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled5989;
		public virtual void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setEnabled5989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setEnabled5989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntent5990;
		public virtual global::android.content.Intent getIntent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getIntent5990));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getIntent5990));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntent5991;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setIntent5991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setIntent5991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5992;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onRestoreInstanceState5992, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onRestoreInstanceState5992, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5993;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._onSaveInstanceState5993));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSaveInstanceState5993));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPersistent5994;
		public virtual void setPersistent(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setPersistent5994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setPersistent5994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPersistent5995;
		public virtual bool isPersistent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._isPersistent5995);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._isPersistent5995);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle5996;
		public virtual void setTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setTitle5996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle5996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle5997;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setTitle5997, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle5997, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle5998;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getTitle5998));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getTitle5998));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView5999;
		protected virtual global::android.view.View onCreateView(android.view.ViewGroup arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._onCreateView5999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onCreateView5999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState6000;
		public virtual void saveHierarchyState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._saveHierarchyState6000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._saveHierarchyState6000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState6001;
		public virtual void restoreHierarchyState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._restoreHierarchyState6001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._restoreHierarchyState6001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrder6002;
		public virtual int getOrder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getOrder6002);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOrder6002);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView6003;
		public virtual global::android.view.View getView(android.view.View arg0, android.view.ViewGroup arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getView6003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getView6003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSelectable6004;
		public virtual bool isSelectable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._isSelectable6004);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._isSelectable6004);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrder6005;
		public virtual void setOrder(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setOrder6005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOrder6005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyChanged6006;
		protected virtual void notifyChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._notifyChanged6006);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyChanged6006);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBindView6007;
		protected virtual void onBindView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onBindView6007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onBindView6007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents6008;
		public virtual bool shouldDisableDependents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._shouldDisableDependents6008);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldDisableDependents6008);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue6009;
		protected virtual global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._onGetDefaultValue6009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onGetDefaultValue6009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue6010;
		protected virtual void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onSetInitialValue6010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSetInitialValue6010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutResource6011;
		public virtual void setLayoutResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setLayoutResource6011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setLayoutResource6011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutResource6012;
		public virtual int getLayoutResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getLayoutResource6012);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getLayoutResource6012);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWidgetLayoutResource6013;
		public virtual void setWidgetLayoutResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setWidgetLayoutResource6013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setWidgetLayoutResource6013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidgetLayoutResource6014;
		public virtual int getWidgetLayoutResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getWidgetLayoutResource6014);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getWidgetLayoutResource6014);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSummary6015;
		public virtual global::java.lang.CharSequence getSummary() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getSummary6015));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSummary6015));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummary6016;
		public virtual void setSummary(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setSummary6016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary6016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummary6017;
		public virtual void setSummary(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setSummary6017, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary6017, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setSummary(string arg0)
		{
			setSummary((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectable6018;
		public virtual void setSelectable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setSelectable6018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSelectable6018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShouldDisableView6019;
		public virtual void setShouldDisableView(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setShouldDisableView6019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setShouldDisableView6019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShouldDisableView6020;
		public virtual bool getShouldDisableView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._getShouldDisableView6020);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getShouldDisableView6020);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasKey6021;
		public virtual bool hasKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._hasKey6021);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._hasKey6021);
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldPersist6022;
		protected virtual bool shouldPersist() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._shouldPersist6022);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldPersist6022);
		}
		internal static global::net.sf.jni4net.jni.MethodId _callChangeListener6023;
		protected virtual bool callChangeListener(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._callChangeListener6023, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._callChangeListener6023, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreferenceChangeListener6024;
		public virtual void setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setOnPreferenceChangeListener6024, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceChangeListener6024, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnPreferenceChangeListener6025;
		public virtual global::android.preference.Preference.OnPreferenceChangeListener getOnPreferenceChangeListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceChangeListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getOnPreferenceChangeListener6025));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceChangeListener6025));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreferenceClickListener6026;
		public virtual void setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setOnPreferenceClickListener6026, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceClickListener6026, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnPreferenceClickListener6027;
		public virtual global::android.preference.Preference.OnPreferenceClickListener getOnPreferenceClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getOnPreferenceClickListener6027));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceClickListener6027));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEditor6028;
		public virtual global::android.content.SharedPreferences_Editor getEditor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getEditor6028));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getEditor6028));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldCommit6029;
		public virtual bool shouldCommit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._shouldCommit6029);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldCommit6029);
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyHierarchyChanged6030;
		protected virtual void notifyHierarchyChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._notifyHierarchyChanged6030);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyHierarchyChanged6030);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceManager6031;
		public virtual global::android.preference.PreferenceManager getPreferenceManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getPreferenceManager6031));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPreferenceManager6031));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToHierarchy6032;
		protected virtual void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onAttachedToHierarchy6032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToHierarchy6032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToActivity6033;
		protected virtual void onAttachedToActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onAttachedToActivity6033);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToActivity6033);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findPreferenceInHierarchy6034;
		protected virtual global::android.preference.Preference findPreferenceInHierarchy(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._findPreferenceInHierarchy6034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._findPreferenceInHierarchy6034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyDependencyChange6035;
		public virtual void notifyDependencyChange(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._notifyDependencyChange6035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyDependencyChange6035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDependencyChanged6036;
		public virtual void onDependencyChanged(android.preference.Preference arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onDependencyChanged6036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onDependencyChanged6036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDependency6037;
		public virtual void setDependency(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setDependency6037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDependency6037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDependency6038;
		public virtual global::java.lang.String getDependency() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getDependency6038));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getDependency6038));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareForRemoval6039;
		protected virtual void onPrepareForRemoval() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onPrepareForRemoval6039);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onPrepareForRemoval6039);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultValue6040;
		public virtual void setDefaultValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setDefaultValue6040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDefaultValue6040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistString6041;
		protected virtual bool persistString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistString6041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistString6041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedString6042;
		protected virtual global::java.lang.String getPersistedString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getPersistedString6042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedString6042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistInt6043;
		protected virtual bool persistInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistInt6043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistInt6043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedInt6044;
		protected virtual int getPersistedInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getPersistedInt6044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedInt6044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistFloat6045;
		protected virtual bool persistFloat(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistFloat6045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistFloat6045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedFloat6046;
		protected virtual float getPersistedFloat(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.preference.Preference._getPersistedFloat6046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedFloat6046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistLong6047;
		protected virtual bool persistLong(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistLong6047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistLong6047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedLong6048;
		protected virtual long getPersistedLong(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.preference.Preference._getPersistedLong6048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedLong6048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistBoolean6049;
		protected virtual bool persistBoolean(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistBoolean6049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistBoolean6049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedBoolean6050;
		protected virtual bool getPersistedBoolean(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._getPersistedBoolean6050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedBoolean6050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Preference6051;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6051, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Preference6052;
		public Preference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6052, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Preference6053;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6053, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		public static int DEFAULT_ORDER
		{
			get
			{
				return 2147483647;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.preference.Preference.staticClass = @__class;
			global::android.preference.Preference._toString5980 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "toString", "()Ljava/lang/String;");
			global::android.preference.Preference._compareTo5981 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.preference.Preference._compareTo5982 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "compareTo", "(Landroid/preference/Preference;)I");
			global::android.preference.Preference._getKey5983 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.preference.Preference._getContext5984 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.preference.Preference._setKey5985 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setKey", "(Ljava/lang/String;)V");
			global::android.preference.Preference._onClick5986 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onClick", "()V");
			global::android.preference.Preference._getSharedPreferences5987 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;");
			global::android.preference.Preference._isEnabled5988 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isEnabled", "()Z");
			global::android.preference.Preference._setEnabled5989 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setEnabled", "(Z)V");
			global::android.preference.Preference._getIntent5990 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.preference.Preference._setIntent5991 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.preference.Preference._onRestoreInstanceState5992 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.Preference._onSaveInstanceState5993 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.Preference._setPersistent5994 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setPersistent", "(Z)V");
			global::android.preference.Preference._isPersistent5995 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isPersistent", "()Z");
			global::android.preference.Preference._setTitle5996 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setTitle", "(I)V");
			global::android.preference.Preference._setTitle5997 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._getTitle5998 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._onCreateView5999 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._saveHierarchyState6000 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "saveHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._restoreHierarchyState6001 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._getOrder6002 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOrder", "()I");
			global::android.preference.Preference._getView6003 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._isSelectable6004 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isSelectable", "()Z");
			global::android.preference.Preference._setOrder6005 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOrder", "(I)V");
			global::android.preference.Preference._notifyChanged6006 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyChanged", "()V");
			global::android.preference.Preference._onBindView6007 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.Preference._shouldDisableDependents6008 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.Preference._onGetDefaultValue6009 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.Preference._onSetInitialValue6010 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.Preference._setLayoutResource6011 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setLayoutResource", "(I)V");
			global::android.preference.Preference._getLayoutResource6012 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getLayoutResource", "()I");
			global::android.preference.Preference._setWidgetLayoutResource6013 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setWidgetLayoutResource", "(I)V");
			global::android.preference.Preference._getWidgetLayoutResource6014 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getWidgetLayoutResource", "()I");
			global::android.preference.Preference._getSummary6015 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getSummary", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._setSummary6016 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSummary", "(I)V");
			global::android.preference.Preference._setSummary6017 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSummary", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._setSelectable6018 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSelectable", "(Z)V");
			global::android.preference.Preference._setShouldDisableView6019 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setShouldDisableView", "(Z)V");
			global::android.preference.Preference._getShouldDisableView6020 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getShouldDisableView", "()Z");
			global::android.preference.Preference._hasKey6021 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "hasKey", "()Z");
			global::android.preference.Preference._shouldPersist6022 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldPersist", "()Z");
			global::android.preference.Preference._callChangeListener6023 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "callChangeListener", "(Ljava/lang/Object;)Z");
			global::android.preference.Preference._setOnPreferenceChangeListener6024 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V");
			global::android.preference.Preference._getOnPreferenceChangeListener6025 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;");
			global::android.preference.Preference._setOnPreferenceClickListener6026 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V");
			global::android.preference.Preference._getOnPreferenceClickListener6027 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;");
			global::android.preference.Preference._getEditor6028 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getEditor", "()Landroid/content/SharedPreferences$Editor;");
			global::android.preference.Preference._shouldCommit6029 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldCommit", "()Z");
			global::android.preference.Preference._notifyHierarchyChanged6030 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyHierarchyChanged", "()V");
			global::android.preference.Preference._getPreferenceManager6031 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;");
			global::android.preference.Preference._onAttachedToHierarchy6032 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V");
			global::android.preference.Preference._onAttachedToActivity6033 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.Preference._findPreferenceInHierarchy6034 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;");
			global::android.preference.Preference._notifyDependencyChange6035 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyDependencyChange", "(Z)V");
			global::android.preference.Preference._onDependencyChanged6036 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onDependencyChanged", "(Landroid/preference/Preference;Z)V");
			global::android.preference.Preference._setDependency6037 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setDependency", "(Ljava/lang/String;)V");
			global::android.preference.Preference._getDependency6038 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getDependency", "()Ljava/lang/String;");
			global::android.preference.Preference._onPrepareForRemoval6039 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.Preference._setDefaultValue6040 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setDefaultValue", "(Ljava/lang/Object;)V");
			global::android.preference.Preference._persistString6041 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistString", "(Ljava/lang/String;)Z");
			global::android.preference.Preference._getPersistedString6042 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.preference.Preference._persistInt6043 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistInt", "(I)Z");
			global::android.preference.Preference._getPersistedInt6044 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedInt", "(I)I");
			global::android.preference.Preference._persistFloat6045 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistFloat", "(F)Z");
			global::android.preference.Preference._getPersistedFloat6046 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedFloat", "(F)F");
			global::android.preference.Preference._persistLong6047 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistLong", "(J)Z");
			global::android.preference.Preference._getPersistedLong6048 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedLong", "(J)J");
			global::android.preference.Preference._persistBoolean6049 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistBoolean", "(Z)Z");
			global::android.preference.Preference._getPersistedBoolean6050 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedBoolean", "(Z)Z");
			global::android.preference.Preference._Preference6051 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.Preference._Preference6052 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.Preference._Preference6053 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
