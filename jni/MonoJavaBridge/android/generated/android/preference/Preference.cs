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
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState6554;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState6554, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState6555;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, global::android.preference.Preference.BaseSavedState._BaseSavedState6555, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR6556;
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
				global::android.preference.Preference.BaseSavedState._BaseSavedState6554 = @__env.GetMethodID(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.preference.Preference.BaseSavedState._BaseSavedState6555 = @__env.GetMethodID(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onPreferenceChange6557;
			 bool android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.preference.Preference.__OnPreferenceChangeListener._onPreferenceChange6557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.__OnPreferenceChangeListener.staticClass, global::android.preference.Preference.__OnPreferenceChangeListener._onPreferenceChange6557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.preference.Preference.__OnPreferenceChangeListener.staticClass = @__class;
				global::android.preference.Preference.__OnPreferenceChangeListener._onPreferenceChange6557 = @__env.GetMethodID(global::android.preference.Preference.__OnPreferenceChangeListener.staticClass, "android.preference.Preference.OnPreferenceChangeListener.onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z");
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
			internal static global::net.sf.jni4net.jni.MethodId _onPreferenceClick6558;
			 bool android.preference.Preference.OnPreferenceClickListener.onPreferenceClick(android.preference.Preference arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.preference.Preference.__OnPreferenceClickListener._onPreferenceClick6558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.__OnPreferenceClickListener.staticClass, global::android.preference.Preference.__OnPreferenceClickListener._onPreferenceClick6558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.preference.Preference.__OnPreferenceClickListener.staticClass = @__class;
				global::android.preference.Preference.__OnPreferenceClickListener._onPreferenceClick6558 = @__env.GetMethodID(global::android.preference.Preference.__OnPreferenceClickListener.staticClass, "android.preference.Preference.OnPreferenceClickListener.onPreferenceClick", "(Landroid/preference/Preference;)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6559;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._toString6559));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._toString6559));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo6560;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._compareTo6560, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo6560, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo6561;
		public virtual int compareTo(android.preference.Preference arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._compareTo6561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._compareTo6561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKey6562;
		public virtual global::java.lang.String getKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getKey6562));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getKey6562));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext6563;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getContext6563));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getContext6563));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKey6564;
		public virtual void setKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setKey6564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setKey6564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick6565;
		protected virtual void onClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onClick6565);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onClick6565);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences6566;
		public virtual global::android.content.SharedPreferences getSharedPreferences() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getSharedPreferences6566));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSharedPreferences6566));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled6567;
		public virtual bool isEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._isEnabled6567);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._isEnabled6567);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled6568;
		public virtual void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setEnabled6568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setEnabled6568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntent6569;
		public virtual global::android.content.Intent getIntent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getIntent6569));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getIntent6569));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntent6570;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setIntent6570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setIntent6570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState6571;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onRestoreInstanceState6571, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onRestoreInstanceState6571, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState6572;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._onSaveInstanceState6572));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSaveInstanceState6572));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPersistent6573;
		public virtual void setPersistent(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setPersistent6573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setPersistent6573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPersistent6574;
		public virtual bool isPersistent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._isPersistent6574);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._isPersistent6574);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle6575;
		public virtual void setTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setTitle6575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle6575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle6576;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setTitle6576, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setTitle6576, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle6577;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getTitle6577));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getTitle6577));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView6578;
		protected virtual global::android.view.View onCreateView(android.view.ViewGroup arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._onCreateView6578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onCreateView6578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState6579;
		public virtual void saveHierarchyState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._saveHierarchyState6579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._saveHierarchyState6579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState6580;
		public virtual void restoreHierarchyState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._restoreHierarchyState6580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._restoreHierarchyState6580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrder6581;
		public virtual int getOrder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getOrder6581);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOrder6581);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView6582;
		public virtual global::android.view.View getView(android.view.View arg0, android.view.ViewGroup arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getView6582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getView6582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSelectable6583;
		public virtual bool isSelectable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._isSelectable6583);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._isSelectable6583);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrder6584;
		public virtual void setOrder(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setOrder6584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOrder6584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyChanged6585;
		protected virtual void notifyChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._notifyChanged6585);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyChanged6585);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBindView6586;
		protected virtual void onBindView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onBindView6586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onBindView6586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents6587;
		public virtual bool shouldDisableDependents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._shouldDisableDependents6587);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldDisableDependents6587);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue6588;
		protected virtual global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._onGetDefaultValue6588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onGetDefaultValue6588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue6589;
		protected virtual void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onSetInitialValue6589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onSetInitialValue6589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutResource6590;
		public virtual void setLayoutResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setLayoutResource6590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setLayoutResource6590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutResource6591;
		public virtual int getLayoutResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getLayoutResource6591);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getLayoutResource6591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWidgetLayoutResource6592;
		public virtual void setWidgetLayoutResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setWidgetLayoutResource6592, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setWidgetLayoutResource6592, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidgetLayoutResource6593;
		public virtual int getWidgetLayoutResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getWidgetLayoutResource6593);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getWidgetLayoutResource6593);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSummary6594;
		public virtual global::java.lang.CharSequence getSummary() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getSummary6594));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getSummary6594));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummary6595;
		public virtual void setSummary(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setSummary6595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary6595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSummary6596;
		public virtual void setSummary(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setSummary6596, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSummary6596, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setSummary(string arg0)
		{
			setSummary((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectable6597;
		public virtual void setSelectable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setSelectable6597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setSelectable6597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShouldDisableView6598;
		public virtual void setShouldDisableView(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setShouldDisableView6598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setShouldDisableView6598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShouldDisableView6599;
		public virtual bool getShouldDisableView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._getShouldDisableView6599);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getShouldDisableView6599);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasKey6600;
		public virtual bool hasKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._hasKey6600);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._hasKey6600);
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldPersist6601;
		protected virtual bool shouldPersist() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._shouldPersist6601);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldPersist6601);
		}
		internal static global::net.sf.jni4net.jni.MethodId _callChangeListener6602;
		protected virtual bool callChangeListener(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._callChangeListener6602, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._callChangeListener6602, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreferenceChangeListener6603;
		public virtual void setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setOnPreferenceChangeListener6603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceChangeListener6603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnPreferenceChangeListener6604;
		public virtual global::android.preference.Preference.OnPreferenceChangeListener getOnPreferenceChangeListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceChangeListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getOnPreferenceChangeListener6604));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceChangeListener6604));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreferenceClickListener6605;
		public virtual void setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setOnPreferenceClickListener6605, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setOnPreferenceClickListener6605, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnPreferenceClickListener6606;
		public virtual global::android.preference.Preference.OnPreferenceClickListener getOnPreferenceClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getOnPreferenceClickListener6606));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getOnPreferenceClickListener6606));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEditor6607;
		public virtual global::android.content.SharedPreferences_Editor getEditor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getEditor6607));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getEditor6607));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldCommit6608;
		public virtual bool shouldCommit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._shouldCommit6608);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._shouldCommit6608);
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyHierarchyChanged6609;
		protected virtual void notifyHierarchyChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._notifyHierarchyChanged6609);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyHierarchyChanged6609);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceManager6610;
		public virtual global::android.preference.PreferenceManager getPreferenceManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getPreferenceManager6610));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPreferenceManager6610));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToHierarchy6611;
		protected virtual void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onAttachedToHierarchy6611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToHierarchy6611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToActivity6612;
		protected virtual void onAttachedToActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onAttachedToActivity6612);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onAttachedToActivity6612);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findPreferenceInHierarchy6613;
		protected virtual global::android.preference.Preference findPreferenceInHierarchy(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._findPreferenceInHierarchy6613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._findPreferenceInHierarchy6613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyDependencyChange6614;
		public virtual void notifyDependencyChange(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._notifyDependencyChange6614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._notifyDependencyChange6614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDependencyChanged6615;
		public virtual void onDependencyChanged(android.preference.Preference arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onDependencyChanged6615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onDependencyChanged6615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDependency6616;
		public virtual void setDependency(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setDependency6616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDependency6616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDependency6617;
		public virtual global::java.lang.String getDependency() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getDependency6617));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getDependency6617));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareForRemoval6618;
		protected virtual void onPrepareForRemoval() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._onPrepareForRemoval6618);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._onPrepareForRemoval6618);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultValue6619;
		public virtual void setDefaultValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.Preference._setDefaultValue6619, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._setDefaultValue6619, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistString6620;
		protected virtual bool persistString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistString6620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistString6620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedString6621;
		protected virtual global::java.lang.String getPersistedString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.Preference._getPersistedString6621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedString6621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistInt6622;
		protected virtual bool persistInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistInt6622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistInt6622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedInt6623;
		protected virtual int getPersistedInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.Preference._getPersistedInt6623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedInt6623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistFloat6624;
		protected virtual bool persistFloat(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistFloat6624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistFloat6624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedFloat6625;
		protected virtual float getPersistedFloat(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.preference.Preference._getPersistedFloat6625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedFloat6625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistLong6626;
		protected virtual bool persistLong(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistLong6626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistLong6626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedLong6627;
		protected virtual long getPersistedLong(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.preference.Preference._getPersistedLong6627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedLong6627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _persistBoolean6628;
		protected virtual bool persistBoolean(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._persistBoolean6628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._persistBoolean6628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedBoolean6629;
		protected virtual bool getPersistedBoolean(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.preference.Preference._getPersistedBoolean6629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.Preference.staticClass, global::android.preference.Preference._getPersistedBoolean6629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Preference6630;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6630, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Preference6631;
		public Preference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6631, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Preference6632;
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.Preference.staticClass, global::android.preference.Preference._Preference6632, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
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
			global::android.preference.Preference._toString6559 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "toString", "()Ljava/lang/String;");
			global::android.preference.Preference._compareTo6560 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.preference.Preference._compareTo6561 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "compareTo", "(Landroid/preference/Preference;)I");
			global::android.preference.Preference._getKey6562 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.preference.Preference._getContext6563 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.preference.Preference._setKey6564 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setKey", "(Ljava/lang/String;)V");
			global::android.preference.Preference._onClick6565 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onClick", "()V");
			global::android.preference.Preference._getSharedPreferences6566 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;");
			global::android.preference.Preference._isEnabled6567 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isEnabled", "()Z");
			global::android.preference.Preference._setEnabled6568 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setEnabled", "(Z)V");
			global::android.preference.Preference._getIntent6569 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.preference.Preference._setIntent6570 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.preference.Preference._onRestoreInstanceState6571 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.Preference._onSaveInstanceState6572 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.Preference._setPersistent6573 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setPersistent", "(Z)V");
			global::android.preference.Preference._isPersistent6574 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isPersistent", "()Z");
			global::android.preference.Preference._setTitle6575 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setTitle", "(I)V");
			global::android.preference.Preference._setTitle6576 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._getTitle6577 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._onCreateView6578 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._saveHierarchyState6579 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "saveHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._restoreHierarchyState6580 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.preference.Preference._getOrder6581 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOrder", "()I");
			global::android.preference.Preference._getView6582 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.preference.Preference._isSelectable6583 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isSelectable", "()Z");
			global::android.preference.Preference._setOrder6584 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOrder", "(I)V");
			global::android.preference.Preference._notifyChanged6585 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyChanged", "()V");
			global::android.preference.Preference._onBindView6586 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onBindView", "(Landroid/view/View;)V");
			global::android.preference.Preference._shouldDisableDependents6587 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldDisableDependents", "()Z");
			global::android.preference.Preference._onGetDefaultValue6588 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.Preference._onSetInitialValue6589 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.Preference._setLayoutResource6590 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setLayoutResource", "(I)V");
			global::android.preference.Preference._getLayoutResource6591 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getLayoutResource", "()I");
			global::android.preference.Preference._setWidgetLayoutResource6592 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setWidgetLayoutResource", "(I)V");
			global::android.preference.Preference._getWidgetLayoutResource6593 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getWidgetLayoutResource", "()I");
			global::android.preference.Preference._getSummary6594 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getSummary", "()Ljava/lang/CharSequence;");
			global::android.preference.Preference._setSummary6595 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSummary", "(I)V");
			global::android.preference.Preference._setSummary6596 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSummary", "(Ljava/lang/CharSequence;)V");
			global::android.preference.Preference._setSelectable6597 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSelectable", "(Z)V");
			global::android.preference.Preference._setShouldDisableView6598 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setShouldDisableView", "(Z)V");
			global::android.preference.Preference._getShouldDisableView6599 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getShouldDisableView", "()Z");
			global::android.preference.Preference._hasKey6600 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "hasKey", "()Z");
			global::android.preference.Preference._shouldPersist6601 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldPersist", "()Z");
			global::android.preference.Preference._callChangeListener6602 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "callChangeListener", "(Ljava/lang/Object;)Z");
			global::android.preference.Preference._setOnPreferenceChangeListener6603 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V");
			global::android.preference.Preference._getOnPreferenceChangeListener6604 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;");
			global::android.preference.Preference._setOnPreferenceClickListener6605 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V");
			global::android.preference.Preference._getOnPreferenceClickListener6606 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;");
			global::android.preference.Preference._getEditor6607 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getEditor", "()Landroid/content/SharedPreferences$Editor;");
			global::android.preference.Preference._shouldCommit6608 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldCommit", "()Z");
			global::android.preference.Preference._notifyHierarchyChanged6609 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyHierarchyChanged", "()V");
			global::android.preference.Preference._getPreferenceManager6610 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;");
			global::android.preference.Preference._onAttachedToHierarchy6611 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V");
			global::android.preference.Preference._onAttachedToActivity6612 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onAttachedToActivity", "()V");
			global::android.preference.Preference._findPreferenceInHierarchy6613 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;");
			global::android.preference.Preference._notifyDependencyChange6614 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyDependencyChange", "(Z)V");
			global::android.preference.Preference._onDependencyChanged6615 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onDependencyChanged", "(Landroid/preference/Preference;Z)V");
			global::android.preference.Preference._setDependency6616 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setDependency", "(Ljava/lang/String;)V");
			global::android.preference.Preference._getDependency6617 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getDependency", "()Ljava/lang/String;");
			global::android.preference.Preference._onPrepareForRemoval6618 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onPrepareForRemoval", "()V");
			global::android.preference.Preference._setDefaultValue6619 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setDefaultValue", "(Ljava/lang/Object;)V");
			global::android.preference.Preference._persistString6620 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistString", "(Ljava/lang/String;)Z");
			global::android.preference.Preference._getPersistedString6621 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.preference.Preference._persistInt6622 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistInt", "(I)Z");
			global::android.preference.Preference._getPersistedInt6623 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedInt", "(I)I");
			global::android.preference.Preference._persistFloat6624 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistFloat", "(F)Z");
			global::android.preference.Preference._getPersistedFloat6625 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedFloat", "(F)F");
			global::android.preference.Preference._persistLong6626 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistLong", "(J)Z");
			global::android.preference.Preference._getPersistedLong6627 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedLong", "(J)J");
			global::android.preference.Preference._persistBoolean6628 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistBoolean", "(Z)Z");
			global::android.preference.Preference._getPersistedBoolean6629 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedBoolean", "(Z)Z");
			global::android.preference.Preference._Preference6630 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.Preference._Preference6631 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.Preference._Preference6632 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
