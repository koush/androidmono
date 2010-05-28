namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PreferenceManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PreferenceManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.preference.PreferenceManager(@__env); 
			} 
		} 
		protected PreferenceManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnActivityDestroyListener 
		{ 
			void onActivityDestroy(); 
		} 

		public partial class OnActivityDestroyListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnActivityDestroyListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnActivityDestroyListener : java.lang.Object, OnActivityDestroyListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnActivityDestroyListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceManager.__OnActivityDestroyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.preference.PreferenceManager.__OnActivityDestroyListener(@__env); 
				} 
			} 
			internal __OnActivityDestroyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onActivityDestroy6093; 
			 void android.preference.PreferenceManager.OnActivityDestroyListener.onActivityDestroy() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.preference.PreferenceManager.__OnActivityDestroyListener)) 
					@__env.CallVoidMethod(this, global::android.preference.PreferenceManager.__OnActivityDestroyListener._onActivityDestroy6093); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceManager.__OnActivityDestroyListener.staticClass, global::android.preference.PreferenceManager.__OnActivityDestroyListener._onActivityDestroy6093); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.preference.PreferenceManager.__OnActivityDestroyListener.staticClass = @__class; 
				global::android.preference.PreferenceManager.__OnActivityDestroyListener._onActivityDestroy6093 = @__env.GetMethodID(global::android.preference.PreferenceManager.__OnActivityDestroyListener.staticClass, "android.preference.PreferenceManager.OnActivityDestroyListener.onActivityDestroy", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnActivityResultListener 
		{ 
			bool onActivityResult(int arg0, int arg1, android.content.Intent arg2); 
		} 

		public partial class OnActivityResultListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnActivityResultListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnActivityResultListener : java.lang.Object, OnActivityResultListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnActivityResultListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceManager.__OnActivityResultListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.preference.PreferenceManager.__OnActivityResultListener(@__env); 
				} 
			} 
			internal __OnActivityResultListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onActivityResult6094; 
			 bool android.preference.PreferenceManager.OnActivityResultListener.onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.preference.PreferenceManager.__OnActivityResultListener)) 
					return @__env.CallBooleanMethod(this, global::android.preference.PreferenceManager.__OnActivityResultListener._onActivityResult6094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceManager.__OnActivityResultListener.staticClass, global::android.preference.PreferenceManager.__OnActivityResultListener._onActivityResult6094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.preference.PreferenceManager.__OnActivityResultListener.staticClass = @__class; 
				global::android.preference.PreferenceManager.__OnActivityResultListener._onActivityResult6094 = @__env.GetMethodID(global::android.preference.PreferenceManager.__OnActivityResultListener.staticClass, "android.preference.PreferenceManager.OnActivityResultListener.onActivityResult", "(IILandroid/content/Intent;)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnActivityStopListener 
		{ 
			void onActivityStop(); 
		} 

		public partial class OnActivityStopListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnActivityStopListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnActivityStopListener : java.lang.Object, OnActivityStopListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnActivityStopListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceManager.__OnActivityStopListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.preference.PreferenceManager.__OnActivityStopListener(@__env); 
				} 
			} 
			internal __OnActivityStopListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onActivityStop6095; 
			 void android.preference.PreferenceManager.OnActivityStopListener.onActivityStop() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.preference.PreferenceManager.__OnActivityStopListener)) 
					@__env.CallVoidMethod(this, global::android.preference.PreferenceManager.__OnActivityStopListener._onActivityStop6095); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceManager.__OnActivityStopListener.staticClass, global::android.preference.PreferenceManager.__OnActivityStopListener._onActivityStop6095); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.preference.PreferenceManager.__OnActivityStopListener.staticClass = @__class; 
				global::android.preference.PreferenceManager.__OnActivityStopListener._onActivityStop6095 = @__env.GetMethodID(global::android.preference.PreferenceManager.__OnActivityStopListener.staticClass, "android.preference.PreferenceManager.OnActivityStopListener.onActivityStop", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences6096; 
		public virtual global::android.content.SharedPreferences getSharedPreferences() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceManager._getSharedPreferences6096)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferences6096)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createPreferenceScreen6097; 
		public virtual global::android.preference.PreferenceScreen createPreferenceScreen(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceManager._createPreferenceScreen6097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.PreferenceScreen>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._createPreferenceScreen6097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferencesName6098; 
		public virtual global::java.lang.String getSharedPreferencesName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceManager._getSharedPreferencesName6098)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferencesName6098)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSharedPreferencesName6099; 
		public virtual void setSharedPreferencesName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceManager._setSharedPreferencesName6099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setSharedPreferencesName6099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferencesMode6100; 
		public virtual int getSharedPreferencesMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return @__env.CallIntMethod(this, global::android.preference.PreferenceManager._getSharedPreferencesMode6100); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getSharedPreferencesMode6100); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSharedPreferencesMode6101; 
		public virtual void setSharedPreferencesMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				@__env.CallVoidMethod(this, global::android.preference.PreferenceManager._setSharedPreferencesMode6101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setSharedPreferencesMode6101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultSharedPreferences6102; 
		public static global::android.content.SharedPreferences getDefaultSharedPreferences(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallStaticObjectMethodPtr(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._getDefaultSharedPreferences6102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPreference6103; 
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceManager._findPreference6103, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.preference.Preference>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._findPreference6103, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultValues6104; 
		public static void setDefaultValues(android.content.Context arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setDefaultValues6104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultValues6105; 
		public static void setDefaultValues(android.content.Context arg0, java.lang.String arg1, int arg2, int arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.preference.PreferenceManager.staticClass, global::android.preference.PreferenceManager._setDefaultValues6105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		public static global::java.lang.String METADATA_KEY_PREFERENCES
		{ 
			get 
			{ 
				return "android.preference"; 
			} 
		} 
		public static global::java.lang.String KEY_HAS_SET_DEFAULT_VALUES
		{ 
			get 
			{ 
				return "_has_set_default_values"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceManager.staticClass = @__class; 
			global::android.preference.PreferenceManager._getSharedPreferences6096 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "getSharedPreferences", "()Landroid/content/SharedPreferences;"); 
			global::android.preference.PreferenceManager._createPreferenceScreen6097 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "createPreferenceScreen", "(Landroid/content/Context;)Landroid/preference/PreferenceScreen;"); 
			global::android.preference.PreferenceManager._getSharedPreferencesName6098 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesName", "()Ljava/lang/String;"); 
			global::android.preference.PreferenceManager._setSharedPreferencesName6099 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesName", "(Ljava/lang/String;)V"); 
			global::android.preference.PreferenceManager._getSharedPreferencesMode6100 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "getSharedPreferencesMode", "()I"); 
			global::android.preference.PreferenceManager._setSharedPreferencesMode6101 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "setSharedPreferencesMode", "(I)V"); 
			global::android.preference.PreferenceManager._getDefaultSharedPreferences6102 = @__env.GetStaticMethodID(global::android.preference.PreferenceManager.staticClass, "getDefaultSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;"); 
			global::android.preference.PreferenceManager._findPreference6103 = @__env.GetMethodID(global::android.preference.PreferenceManager.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;"); 
			global::android.preference.PreferenceManager._setDefaultValues6104 = @__env.GetStaticMethodID(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;IZ)V"); 
			global::android.preference.PreferenceManager._setDefaultValues6105 = @__env.GetStaticMethodID(global::android.preference.PreferenceManager.staticClass, "setDefaultValues", "(Landroid/content/Context;Ljava/lang/String;IIZ)V"); 
		} 
	} 
} 
