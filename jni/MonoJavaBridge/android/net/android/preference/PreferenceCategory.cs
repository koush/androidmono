namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PreferenceCategory : android.preference.PreferenceGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PreferenceCategory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceCategory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.preference.PreferenceCategory(@__env); 
			} 
		} 
		protected PreferenceCategory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled6070; 
		public override bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceCategory)) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceCategory._isEnabled6070); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._isEnabled6070); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareAddPreference6071; 
		protected override bool onPrepareAddPreference(android.preference.Preference arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceCategory)) 
				return @__env.CallBooleanMethod(this, global::android.preference.PreferenceCategory._onPrepareAddPreference6071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._onPrepareAddPreference6071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceCategory6072; 
		public PreferenceCategory(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory6072, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceCategory6073; 
		public PreferenceCategory(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory6073, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PreferenceCategory6074; 
		public PreferenceCategory(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory6074, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceCategory.staticClass = @__class; 
			global::android.preference.PreferenceCategory._isEnabled6070 = @__env.GetMethodID(global::android.preference.PreferenceCategory.staticClass, "isEnabled", "()Z"); 
			global::android.preference.PreferenceCategory._onPrepareAddPreference6071 = @__env.GetMethodID(global::android.preference.PreferenceCategory.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z"); 
			global::android.preference.PreferenceCategory._PreferenceCategory6072 = @__env.GetMethodID(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.preference.PreferenceCategory._PreferenceCategory6073 = @__env.GetMethodID(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.PreferenceCategory._PreferenceCategory6074 = @__env.GetMethodID(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
