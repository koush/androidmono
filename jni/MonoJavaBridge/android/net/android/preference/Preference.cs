namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Preference : java.lang.Object, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Preference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.Preference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.Preference.BaseSavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState5701; 
			public BaseSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, _BaseSavedState5701, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState5702; 
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.preference.Preference.BaseSavedState.staticClass, _BaseSavedState5702, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR5703; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.preference.Preference.BaseSavedState.staticClass = @__class; 
				global::android.preference.Preference.BaseSavedState._BaseSavedState5701 = @__env.GetMethodID(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
				global::android.preference.Preference.BaseSavedState._BaseSavedState5702 = @__env.GetMethodID(global::android.preference.Preference.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnPreferenceChangeListener 
		{ 
			bool onPreferenceChange(android.preference.Preference arg0, java.lang.Object arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnPreferenceClickListener 
		{ 
			bool onPreferenceClick(android.preference.Preference arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo5704; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallIntMethod(this, _compareTo5704, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.Preference.staticClass, _compareTo5704, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo5705; 
		public virtual int compareTo(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallIntMethod(this, _compareTo5705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.Preference.staticClass, _compareTo5705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString5706; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString5706)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _toString5706)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKey5707; 
		public virtual java.lang.String getKey() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getKey5707)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getKey5707)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext5708; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext5708)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getContext5708)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKey5709; 
		public virtual void setKey(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setKey5709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setKey5709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick5710; 
		protected virtual void onClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onClick5710); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onClick5710); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences5711; 
		public virtual android.content.SharedPreferences getSharedPreferences() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, _getSharedPreferences5711)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getSharedPreferences5711)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled5712; 
		public virtual bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _isEnabled5712); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _isEnabled5712); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled5713; 
		public virtual void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setEnabled5713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setEnabled5713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntent5714; 
		public virtual android.content.Intent getIntent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _getIntent5714)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getIntent5714)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntent5715; 
		public virtual void setIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setIntent5715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setIntent5715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5716; 
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState5716, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onRestoreInstanceState5716, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5717; 
		protected virtual android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState5717)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _onSaveInstanceState5717)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPersistent5718; 
		public virtual void setPersistent(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setPersistent5718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setPersistent5718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPersistent5719; 
		public virtual bool isPersistent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _isPersistent5719); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _isPersistent5719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle5720; 
		public virtual void setTitle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setTitle5720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setTitle5720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle5721; 
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setTitle5721, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setTitle5721, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle5722; 
		public virtual java.lang.CharSequence getTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTitle5722)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getTitle5722)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView5723; 
		protected virtual android.view.View onCreateView(android.view.ViewGroup arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateView5723, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _onCreateView5723, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState5724; 
		public virtual void saveHierarchyState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _saveHierarchyState5724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _saveHierarchyState5724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState5725; 
		public virtual void restoreHierarchyState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _restoreHierarchyState5725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _restoreHierarchyState5725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrder5726; 
		public virtual int getOrder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallIntMethod(this, _getOrder5726); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.Preference.staticClass, _getOrder5726); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView5727; 
		public virtual android.view.View getView(android.view.View arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView5727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getView5727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSelectable5728; 
		public virtual bool isSelectable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _isSelectable5728); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _isSelectable5728); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrder5729; 
		public virtual void setOrder(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setOrder5729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setOrder5729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyChanged5730; 
		protected virtual void notifyChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _notifyChanged5730); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _notifyChanged5730); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindView5731; 
		protected virtual void onBindView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onBindView5731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onBindView5731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents5732; 
		public virtual bool shouldDisableDependents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _shouldDisableDependents5732); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _shouldDisableDependents5732); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue5733; 
		protected virtual java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _onGetDefaultValue5733, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _onGetDefaultValue5733, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue5734; 
		protected virtual void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onSetInitialValue5734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onSetInitialValue5734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutResource5735; 
		public virtual void setLayoutResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setLayoutResource5735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setLayoutResource5735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutResource5736; 
		public virtual int getLayoutResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallIntMethod(this, _getLayoutResource5736); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.Preference.staticClass, _getLayoutResource5736); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWidgetLayoutResource5737; 
		public virtual void setWidgetLayoutResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setWidgetLayoutResource5737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setWidgetLayoutResource5737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidgetLayoutResource5738; 
		public virtual int getWidgetLayoutResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallIntMethod(this, _getWidgetLayoutResource5738); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.Preference.staticClass, _getWidgetLayoutResource5738); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSummary5739; 
		public virtual java.lang.CharSequence getSummary() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getSummary5739)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getSummary5739)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSummary5740; 
		public virtual void setSummary(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setSummary5740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setSummary5740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSummary5741; 
		public virtual void setSummary(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setSummary5741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setSummary5741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectable5742; 
		public virtual void setSelectable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setSelectable5742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setSelectable5742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShouldDisableView5743; 
		public virtual void setShouldDisableView(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setShouldDisableView5743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setShouldDisableView5743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShouldDisableView5744; 
		public virtual bool getShouldDisableView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _getShouldDisableView5744); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _getShouldDisableView5744); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasKey5745; 
		public virtual bool hasKey() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _hasKey5745); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _hasKey5745); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldPersist5746; 
		protected virtual bool shouldPersist() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _shouldPersist5746); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _shouldPersist5746); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callChangeListener5747; 
		protected virtual bool callChangeListener(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _callChangeListener5747, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _callChangeListener5747, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreferenceChangeListener5748; 
		public virtual void setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setOnPreferenceChangeListener5748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setOnPreferenceChangeListener5748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnPreferenceChangeListener5749; 
		public virtual android.preference.Preference.OnPreferenceChangeListener getOnPreferenceChangeListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceChangeListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnPreferenceChangeListener5749)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getOnPreferenceChangeListener5749)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreferenceClickListener5750; 
		public virtual void setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setOnPreferenceClickListener5750, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setOnPreferenceClickListener5750, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnPreferenceClickListener5751; 
		public virtual android.preference.Preference.OnPreferenceClickListener getOnPreferenceClickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceClickListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnPreferenceClickListener5751)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.preference.Preference.OnPreferenceClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getOnPreferenceClickListener5751)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEditor5752; 
		public virtual android.content.SharedPreferences_Editor getEditor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _getEditor5752)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getEditor5752)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldCommit5753; 
		public virtual bool shouldCommit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _shouldCommit5753); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _shouldCommit5753); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyHierarchyChanged5754; 
		protected virtual void notifyHierarchyChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _notifyHierarchyChanged5754); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _notifyHierarchyChanged5754); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferenceManager5755; 
		public virtual android.preference.PreferenceManager getPreferenceManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallObjectMethodPtr(this, _getPreferenceManager5755)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getPreferenceManager5755)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToHierarchy5756; 
		protected virtual void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onAttachedToHierarchy5756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onAttachedToHierarchy5756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToActivity5757; 
		protected virtual void onAttachedToActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onAttachedToActivity5757); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onAttachedToActivity5757); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPreferenceInHierarchy5758; 
		protected virtual android.preference.Preference findPreferenceInHierarchy(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, _findPreferenceInHierarchy5758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _findPreferenceInHierarchy5758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDependencyChange5759; 
		public virtual void notifyDependencyChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _notifyDependencyChange5759, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _notifyDependencyChange5759, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDependencyChanged5760; 
		public virtual void onDependencyChanged(android.preference.Preference arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onDependencyChanged5760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onDependencyChanged5760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDependency5761; 
		public virtual void setDependency(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setDependency5761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setDependency5761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDependency5762; 
		public virtual java.lang.String getDependency() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDependency5762)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getDependency5762)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareForRemoval5763; 
		protected virtual void onPrepareForRemoval() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _onPrepareForRemoval5763); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _onPrepareForRemoval5763); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultValue5764; 
		public virtual void setDefaultValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				@__env.CallVoidMethod(this, _setDefaultValue5764, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.Preference.staticClass, _setDefaultValue5764, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _persistString5765; 
		protected virtual bool persistString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _persistString5765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _persistString5765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedString5766; 
		protected virtual java.lang.String getPersistedString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPersistedString5766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.Preference.staticClass, _getPersistedString5766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _persistInt5767; 
		protected virtual bool persistInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _persistInt5767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _persistInt5767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedInt5768; 
		protected virtual int getPersistedInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallIntMethod(this, _getPersistedInt5768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.Preference.staticClass, _getPersistedInt5768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _persistFloat5769; 
		protected virtual bool persistFloat(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _persistFloat5769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _persistFloat5769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedFloat5770; 
		protected virtual float getPersistedFloat(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallFloatMethod(this, _getPersistedFloat5770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.preference.Preference.staticClass, _getPersistedFloat5770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _persistLong5771; 
		protected virtual bool persistLong(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _persistLong5771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _persistLong5771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedLong5772; 
		protected virtual long getPersistedLong(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallLongMethod(this, _getPersistedLong5772, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.preference.Preference.staticClass, _getPersistedLong5772, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _persistBoolean5773; 
		protected virtual bool persistBoolean(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _persistBoolean5773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _persistBoolean5773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPersistedBoolean5774; 
		protected virtual bool getPersistedBoolean(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.Preference)) 
				return @__env.CallBooleanMethod(this, _getPersistedBoolean5774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.preference.Preference.staticClass, _getPersistedBoolean5774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Preference5775; 
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.Preference.staticClass, _Preference5775, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Preference5776; 
		public Preference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.Preference.staticClass, _Preference5776, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Preference5777; 
		public Preference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.Preference.staticClass, _Preference5777, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
			global::android.preference.Preference._compareTo5704 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::android.preference.Preference._compareTo5705 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "compareTo", "(Landroid/preference/Preference;)I"); 
			global::android.preference.Preference._toString5706 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.preference.Preference._getKey5707 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getKey", "()Ljava/lang/String;"); 
			global::android.preference.Preference._getContext5708 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.preference.Preference._setKey5709 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setKey", "(Ljava/lang/String;)V"); 
			global::android.preference.Preference._onClick5710 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onClick", "()V"); 
			global::android.preference.Preference._getSharedPreferences5711 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;"); 
			global::android.preference.Preference._isEnabled5712 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isEnabled", "()Z"); 
			global::android.preference.Preference._setEnabled5713 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setEnabled", "(Z)V"); 
			global::android.preference.Preference._getIntent5714 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getIntent", "()Landroid/content/Intent;"); 
			global::android.preference.Preference._setIntent5715 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setIntent", "(Landroid/content/Intent;)V"); 
			global::android.preference.Preference._onRestoreInstanceState5716 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.preference.Preference._onSaveInstanceState5717 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.preference.Preference._setPersistent5718 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setPersistent", "(Z)V"); 
			global::android.preference.Preference._isPersistent5719 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isPersistent", "()Z"); 
			global::android.preference.Preference._setTitle5720 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setTitle", "(I)V"); 
			global::android.preference.Preference._setTitle5721 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.Preference._getTitle5722 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getTitle", "()Ljava/lang/CharSequence;"); 
			global::android.preference.Preference._onCreateView5723 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.preference.Preference._saveHierarchyState5724 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "saveHierarchyState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.Preference._restoreHierarchyState5725 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V"); 
			global::android.preference.Preference._getOrder5726 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOrder", "()I"); 
			global::android.preference.Preference._getView5727 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.preference.Preference._isSelectable5728 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "isSelectable", "()Z"); 
			global::android.preference.Preference._setOrder5729 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOrder", "(I)V"); 
			global::android.preference.Preference._notifyChanged5730 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyChanged", "()V"); 
			global::android.preference.Preference._onBindView5731 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onBindView", "(Landroid/view/View;)V"); 
			global::android.preference.Preference._shouldDisableDependents5732 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldDisableDependents", "()Z"); 
			global::android.preference.Preference._onGetDefaultValue5733 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;"); 
			global::android.preference.Preference._onSetInitialValue5734 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V"); 
			global::android.preference.Preference._setLayoutResource5735 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setLayoutResource", "(I)V"); 
			global::android.preference.Preference._getLayoutResource5736 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getLayoutResource", "()I"); 
			global::android.preference.Preference._setWidgetLayoutResource5737 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setWidgetLayoutResource", "(I)V"); 
			global::android.preference.Preference._getWidgetLayoutResource5738 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getWidgetLayoutResource", "()I"); 
			global::android.preference.Preference._getSummary5739 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getSummary", "()Ljava/lang/CharSequence;"); 
			global::android.preference.Preference._setSummary5740 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSummary", "(I)V"); 
			global::android.preference.Preference._setSummary5741 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSummary", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.Preference._setSelectable5742 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setSelectable", "(Z)V"); 
			global::android.preference.Preference._setShouldDisableView5743 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setShouldDisableView", "(Z)V"); 
			global::android.preference.Preference._getShouldDisableView5744 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getShouldDisableView", "()Z"); 
			global::android.preference.Preference._hasKey5745 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "hasKey", "()Z"); 
			global::android.preference.Preference._shouldPersist5746 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldPersist", "()Z"); 
			global::android.preference.Preference._callChangeListener5747 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "callChangeListener", "(Ljava/lang/Object;)Z"); 
			global::android.preference.Preference._setOnPreferenceChangeListener5748 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V"); 
			global::android.preference.Preference._getOnPreferenceChangeListener5749 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;"); 
			global::android.preference.Preference._setOnPreferenceClickListener5750 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V"); 
			global::android.preference.Preference._getOnPreferenceClickListener5751 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;"); 
			global::android.preference.Preference._getEditor5752 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getEditor", "()Landroid/content/SharedPreferences$Editor;"); 
			global::android.preference.Preference._shouldCommit5753 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "shouldCommit", "()Z"); 
			global::android.preference.Preference._notifyHierarchyChanged5754 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyHierarchyChanged", "()V"); 
			global::android.preference.Preference._getPreferenceManager5755 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;"); 
			global::android.preference.Preference._onAttachedToHierarchy5756 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V"); 
			global::android.preference.Preference._onAttachedToActivity5757 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onAttachedToActivity", "()V"); 
			global::android.preference.Preference._findPreferenceInHierarchy5758 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;"); 
			global::android.preference.Preference._notifyDependencyChange5759 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "notifyDependencyChange", "(Z)V"); 
			global::android.preference.Preference._onDependencyChanged5760 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onDependencyChanged", "(Landroid/preference/Preference;Z)V"); 
			global::android.preference.Preference._setDependency5761 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setDependency", "(Ljava/lang/String;)V"); 
			global::android.preference.Preference._getDependency5762 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getDependency", "()Ljava/lang/String;"); 
			global::android.preference.Preference._onPrepareForRemoval5763 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "onPrepareForRemoval", "()V"); 
			global::android.preference.Preference._setDefaultValue5764 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "setDefaultValue", "(Ljava/lang/Object;)V"); 
			global::android.preference.Preference._persistString5765 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistString", "(Ljava/lang/String;)Z"); 
			global::android.preference.Preference._getPersistedString5766 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.preference.Preference._persistInt5767 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistInt", "(I)Z"); 
			global::android.preference.Preference._getPersistedInt5768 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedInt", "(I)I"); 
			global::android.preference.Preference._persistFloat5769 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistFloat", "(F)Z"); 
			global::android.preference.Preference._getPersistedFloat5770 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedFloat", "(F)F"); 
			global::android.preference.Preference._persistLong5771 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistLong", "(J)Z"); 
			global::android.preference.Preference._getPersistedLong5772 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedLong", "(J)J"); 
			global::android.preference.Preference._persistBoolean5773 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "persistBoolean", "(Z)Z"); 
			global::android.preference.Preference._getPersistedBoolean5774 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "getPersistedBoolean", "(Z)Z"); 
			global::android.preference.Preference._Preference5775 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.Preference._Preference5776 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.preference.Preference._Preference5777 = @__env.GetMethodID(global::android.preference.Preference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
